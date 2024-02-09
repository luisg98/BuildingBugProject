package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.view.View
import android.view.ViewGroup
import android.widget.BaseAdapter
import android.widget.Button
import android.widget.ListView
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import com.google.gson.JsonParseException
import com.google.gson.reflect.TypeToken
import io.swagger.client.models.Tipo
import ipca.app.buildingbug.databinding.ActivityTipoBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.Response
import java.io.IOException

class TipoActivity : AppCompatActivity() {

    private lateinit var binding: ActivityTipoBinding
    private lateinit var tipoAdapter: TipoAdapter
    private var tipos: List<Tipo> = arrayListOf()
    private val apiKey = "d68fe64649b74abc93522bb7972e5854"
    private val apiVersion = "1.0"

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityTipoBinding.inflate(layoutInflater)
        setContentView(binding.root)

        tipoAdapter = TipoAdapter(this)
        val listViewTipo = findViewById<ListView>(R.id.tipoListView)
        listViewTipo.adapter = tipoAdapter


        val categoria = intent.getStringExtra("CATEGORIA")

        if (categoria != null) {
            val sharedPreferences = this.getSharedPreferences("MyPrefs", MODE_PRIVATE)
            val Token = sharedPreferences.getString("Token", null)
            if(Token != null){
                getTipo(categoria, Token)
            }else {
                Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
                startActivity(Intent(this, LoginActivity::class.java))
            }

        } else {
            Toast.makeText(this, categoria ?: "Categoria not provided", Toast.LENGTH_SHORT).show()
            startActivity(Intent(this, ClientMenuActivity::class.java))
        }
    }

    private fun getTipo(tipo: String, token:String) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val client = OkHttpClient()
                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Tipo/categoria/$tipo")
                    .get()
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = client.newCall(request).execute()
                val responseBodyString = response.body?.string()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful && responseBodyString != null) {
                        val listType = object : TypeToken<List<Tipo>>() {}.type
                        val tiposResponse: List<Tipo> = Gson().fromJson(responseBodyString, listType)
                        tipos = tiposResponse
                        tipoAdapter.notifyDataSetChanged()
                    } else {
                        val errorBody = responseBodyString ?: "Unknown error"
                        Toast.makeText(this@TipoActivity, "Failed to get tipo: $errorBody", Toast.LENGTH_SHORT).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@TipoActivity,
                        "Network error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@TipoActivity,
                        "JSON parsing error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@TipoActivity,
                        "Unknown error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }


    inner class TipoAdapter(private val context: Context) : BaseAdapter() {
        override fun getCount(): Int = tipos.size

        override fun getItem(position: Int): Any = tipos[position]

        override fun getItemId(position: Int): Long = tipos[position].id.toLong()

        override fun getView(position: Int, convertView: View?, parent: ViewGroup?): View {
            val rootView = layoutInflater.inflate(R.layout.row_tipo, parent, false)
            val textViewDescricaoTipo = rootView.findViewById<TextView>(R.id.textViewDescricao)
            val textViewPreco = rootView.findViewById<TextView>(R.id.textViewPreco)

            textViewDescricaoTipo.text = tipos[position].descricao
            textViewPreco.text = tipos[position].preco.toString() + "€"

            val buttonPedir = rootView.findViewById<Button>(R.id.pedirButton)

            buttonPedir.setOnClickListener{
                val intent = Intent(context, ServicoActivity::class.java)
                val tipoId = getItemId(position).toInt()
                val temFator = tipos[position].fator
                intent.putExtra("IDTIPO", tipoId)
                intent.putExtra("TEMFATOR", temFator)
                context.startActivity(intent)
            }

            return rootView
        }
    }
}
