package ipca.app.buildingbug.MenuProfissional

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import ipca.app.buildingbug.LoginActivity
import ipca.app.buildingbug.ProMenuActivity
import ipca.app.buildingbug.databinding.ActivityAceitarServicoDetailBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody.Companion.toRequestBody
import okhttp3.Response
import java.util.concurrent.TimeUnit

class AceitarServicoDetailActivity : AppCompatActivity() {
    private lateinit var binding: ActivityAceitarServicoDetailBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityAceitarServicoDetailBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val servicoId = intent.getIntExtra("id", 0)
        val custo = intent.getIntExtra("custo", 0)
        val cliente = intent.getStringExtra("cliente")
        val morada = intent.getStringExtra("morada")
        val dataInicio = intent.getStringExtra("dataInicio")
        val codigoPostalCP = intent.getIntExtra("codigoPostalCP", 0)
        val fator = intent.getIntExtra("fator", 0)
        val inactive = intent.getBooleanExtra("inactive", false)
        val tipo = intent.getStringExtra("tipo")


        binding.tituloTextView.setText(tipo.toString())
        binding.moradaClienteTextView.setText(morada.toString())
        binding.clienteIdTextView2.setText(cliente.toString())
        binding.dataInicioTextView2.setText(dataInicio.toString())
        binding.cpTextView2.setText(codigoPostalCP.toString())
        binding.custoTextView2.setText("$custo€")
        binding.fatorTextView2.setText(fator.toString())


        binding.aceitaButton.setOnClickListener {
            val sharedPreferences = this.getSharedPreferences("MyPrefs", MODE_PRIVATE)
            val token = sharedPreferences.getString("Token", null)
            val profissionalId = sharedPreferences.getInt("Id", 0) // Replace with your actual key
            val servicoId = intent.getIntExtra("id", 0) // Replace with your actual key

            if (token != null && profissionalId != 0 && servicoId != 0) {
                performAceita(profissionalId, servicoId, token)
                startActivity(Intent(this, ProMenuActivity::class.java))
            } else {
                Toast.makeText(this, "Sessão Expirada - Faça Login Novamente", Toast.LENGTH_LONG)
                    .show()
                startActivity(Intent(this, LoginActivity::class.java))
            }
        }


    }

    private fun performAceita(profissionalId: Int, servicoId: Int, token: String) {
        CoroutineScope(Dispatchers.IO).launch {
            val okHttpClient = OkHttpClient.Builder()
                .readTimeout(30, TimeUnit.SECONDS)
                .writeTimeout(30, TimeUnit.SECONDS)
                .build()

            val mediaType = "application/json".toMediaTypeOrNull()
            val jsonBody =
                Gson().toJson(mapOf("profissionalId" to profissionalId, "servicoId" to servicoId))
            val body = jsonBody.toRequestBody(mediaType)

            val requestUrl =
                "https://buildingbugapiapi.azure-api.net/api/v1.0/Servico/aceitar/$profissionalId/$servicoId"
            val apiKey = "d68fe64649b74abc93522bb7972e5854"

            val request = Request.Builder()
                .url(requestUrl)
                .put(body)
                .addHeader("Content-Type", "application/json")
                .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                .addHeader("Authorization", "Bearer $token")
                .build()

            try {
                val response = okHttpClient.newCall(request).execute()
                withContext(Dispatchers.Main) {
                    if (response.isSuccessful) {
                        onSuccess(response)


                    } else {
                        onFailure(Exception("Request failed with status code: ${response.code}"))
                    }
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    onFailure(e)
                }
            }
        }
    }

    private fun onSuccess(response: Response) {
        // Handle the successful response
        Toast.makeText(this, "Operation Successful", Toast.LENGTH_LONG).show()
    }

    private fun onFailure(e: Exception) {
        // Handle the failure
        Toast.makeText(this, "Operation Failed: ${e.message}", Toast.LENGTH_LONG).show()
    }
}
