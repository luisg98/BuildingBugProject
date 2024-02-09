package ipca.app.buildingbug.MenuCliente

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.BaseAdapter
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.GsonBuilder
import com.google.gson.JsonDeserializer
import com.google.gson.JsonParseException
import com.google.gson.reflect.TypeToken
import io.swagger.client.models.ServicoDTO
import ipca.app.buildingbug.LoginActivity
import ipca.app.buildingbug.R
import ipca.app.buildingbug.databinding.ActivityVerServicosClienteBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.Response
import java.io.IOException
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter


class VerServicosClienteActivity : AppCompatActivity() {

    private lateinit var binding: ActivityVerServicosClienteBinding
    private lateinit var servicoClienteAdapter: VerServicosClienteAdapter
    private var servicosCliente: List<ServicoDTO> = arrayListOf()
    private val apiKey = "d68fe64649b74abc93522bb7972e5854"
    private val apiVersion = "1.0"

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityVerServicosClienteBinding.inflate(layoutInflater)
        setContentView(binding.root)



        servicoClienteAdapter = VerServicosClienteAdapter(this)
        binding.servicosClienteListView.adapter = servicoClienteAdapter
        val sharedPreferences = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
        val token = sharedPreferences.getString("Token", null)
        val id = sharedPreferences.getInt("Id", 0)
        if (token != null) {
            getServicosCliente(token, id)
        } else {
            Toast.makeText(this, "Sessão Expirada - Faça Login Novamente", Toast.LENGTH_LONG).show()
            startActivity(Intent(this, LoginActivity::class.java))
            finish()
        }
    }

    private fun getServicosCliente(token: String, id:Int) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val client = OkHttpClient()
                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Servico/all/Cliente/$id")
                    .get()
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = client.newCall(request).execute()
                val responseBodyString = response.body?.string()


                withContext(Dispatchers.Main) {
                    if (response.isSuccessful && responseBodyString != null) {
                        val gson = GsonBuilder().registerTypeAdapter(LocalDateTime::class.java, JsonDeserializer { json, _, _ ->
                            LocalDateTime.parse(json.asJsonPrimitive.asString, DateTimeFormatter.ISO_LOCAL_DATE_TIME)
                        }).create()

                        val listServicosType = object : TypeToken<List<ServicoDTO>>() {}.type
                        val servicosResponse: List<ServicoDTO> = gson.fromJson(responseBodyString, listServicosType)
                        servicosCliente = servicosResponse
                        servicoClienteAdapter.notifyDataSetChanged()
                    } else {
                        val errorBody = responseBodyString ?: "Unknown error"
                        Toast.makeText(this@VerServicosClienteActivity, "Failed to get services: $errorBody", Toast.LENGTH_SHORT).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@VerServicosClienteActivity, "Network error: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@VerServicosClienteActivity, "JSON parsing error: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@VerServicosClienteActivity, "Unknown error: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }

    inner class VerServicosClienteAdapter(private val context: Context) : BaseAdapter() {
        override fun getCount(): Int = servicosCliente.size

        override fun getItem(position: Int): Any = servicosCliente[position]

        override fun getItemId(position: Int): Long = servicosCliente[position].id.toLong()

        override fun getView(position: Int, convertView: View?, parent: ViewGroup?): View {
            val rootView = convertView ?: LayoutInflater.from(context).inflate(R.layout.row_servico, parent, false)
            val textViewMorada: TextView = rootView.findViewById(R.id.textViewMorada)
            val textViewCusto: TextView = rootView.findViewById(R.id.textViewCusto)
            val textViewClientId: TextView = rootView.findViewById(R.id.textViewClienteId)
            val textViewTipoId: TextView = rootView.findViewById(R.id.textViewTipoId)

            val servico = getItem(position) as ServicoDTO
            textViewMorada.text = "Morada: ${servico.morada}"
            textViewClientId.text = "Cliente: ${servico.nome_cliente}"
            textViewCusto.text = "Custo: ${servico.custo}€"
            textViewTipoId.text = "Tipo: ${servico.tipo}"

            val buttonIr: Button = rootView.findViewById(R.id.irButton)
            buttonIr.setOnClickListener {
                val intent = Intent(context, VerServicosClienteDetailActivity::class.java)
                intent.putExtra("id", servico.id)
                intent.putExtra("custo", servico.custo)
                intent.putExtra("cliente", servico.nome_cliente)
                intent.putExtra("morada", servico.morada)
                intent.putExtra("dataInicio", servico.dataInicio)
                intent.putExtra("avaliacao", servico.avaliacao)
                intent.putExtra("codigoPostalCP", servico.codigoPostalCP)
                intent.putExtra("dataFim", servico.dataFim)
                intent.putExtra("estadoServico", servico.estadoServico)
                intent.putExtra("fator", servico.fator)
                intent.putExtra("profissional", servico.nome_profissional)
                intent.putExtra("tipo", servico.tipo)
                context.startActivity(intent)
            }

            return rootView
        }
    }
}
