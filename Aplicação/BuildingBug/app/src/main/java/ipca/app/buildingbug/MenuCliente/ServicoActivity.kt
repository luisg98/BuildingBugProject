package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.EditText
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import ipca.app.buildingbug.databinding.ActivityServicoBinding
import okhttp3.Call
import okhttp3.Callback
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody.Companion.toRequestBody
import okhttp3.Response
import java.io.IOException
import java.util.concurrent.TimeUnit

class ServicoActivity : AppCompatActivity() {

    private lateinit var binding: ActivityServicoBinding

    companion object {
        private const val API_KEY = "d68fe64649b74abc93522bb7972e5854"
        private const val API_URL = "https://buildingbugapiapi.azure-api.net/api/v1.0/Servico/new"
        private const val PREFS_NAME = "MyPrefs"
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityServicoBinding.inflate(layoutInflater)
        setContentView(binding.root)
        val temFatorEditText = findViewById<EditText>(R.id.fatorEditText)

        val temFator = intent.getBooleanExtra("TEMFATOR", false)
        var fator: Int = -1

        if (temFator) {
            temFatorEditText.visibility = View.VISIBLE
        } else {
            temFatorEditText.visibility = View.GONE
            fator = 0
        }

        binding.adicionarServicoButton.setOnClickListener {
            val morada = binding.moradaEditText.text.toString().trim()

            val cpText = binding.cpEditText.text.toString().trim()
            val cp = cpText.toIntOrNull()

            if (cpText.length != 7 || !cpText.all { it.isDigit() }) {
                Toast.makeText(this, "Código Postal deve ser um número de 9 dígitos", Toast.LENGTH_LONG).show()
                return@setOnClickListener
            }

            if (cp == null) {
                Toast.makeText(this, "Código Postal inválido", Toast.LENGTH_LONG).show()
                return@setOnClickListener
            }

            if (temFatorEditText.visibility == View.VISIBLE) {
                fator = binding.fatorEditText.text.toString().toIntOrNull() ?: -1
            }

            val sharedPref = this.getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE)
            val userId = sharedPref.getInt("Id", -1)
            val token = sharedPref.getString("Token", "")
            val tipo = intent.getIntExtra("IDTIPO", -1)

            if (tipo == -1) {
                Toast.makeText(this, "Tipo de serviço não especificado", Toast.LENGTH_LONG).show()
                return@setOnClickListener
            }

            performNovoServico(morada, cp, fator, userId, tipo, token!!, onSuccess = {
                val intent = Intent(this, ClientMenuActivity::class.java)
                startActivity(intent)
                finish()
            }, onError = { error ->
                Toast.makeText(this@ServicoActivity, error, Toast.LENGTH_SHORT).show()
            })
        }
    }

    private fun performNovoServico(morada: String, codigoPostal: Int, fator: Int, id: Int, tipo: Int, token:String,
                                   onSuccess: () -> Unit, onError: (String) -> Unit) {

        val okHttpClient = OkHttpClient.Builder()
            .readTimeout(30, TimeUnit.SECONDS)
            .writeTimeout(30, TimeUnit.SECONDS)
            .build()

        val mediaType = "application/json".toMediaTypeOrNull()
        val gson = Gson()
        val jsonBody = """
            {
                "morada": "$morada",
                "fator": "$fator",
                "clienteId": $id,
                "codigoPostalCP": "$codigoPostal",
                "tipoId": $tipo
            }
        """.trimIndent()

        val body = jsonBody.toRequestBody(mediaType)

        val request = Request.Builder()
            .url(API_URL)
            .post(body)
            .addHeader("Content-Type", "application/json")
            .addHeader("Ocp-Apim-Subscription-Key", API_KEY)
            .addHeader("Authorization", "Bearer $token")
            .build()

        okHttpClient.newCall(request).enqueue(object : Callback {
            override fun onResponse(call: Call, response: Response) {
                runOnUiThread {
                    if (response.isSuccessful) {
                        response.body?.string()?.let { responseBodyStr ->
                            val NovoServicoResponse = gson.fromJson(responseBodyStr, NovoServicoResponse::class.java)
                            Toast.makeText(this@ServicoActivity, "Serviço adicionado com sucesso!", Toast.LENGTH_SHORT).show()
                            onSuccess()
                        } ?: onError("Empty response")
                    } else {
                        onError("Erro com o código: ${response.code}")
                    }
                    response.close()
                }
            }

            override fun onFailure(call: Call, e: IOException) {
                runOnUiThread {
                    onError("Network error: ${e.localizedMessage}")
                }
            }
        })
    }

    data class NovoServicoResponse(val id: Int)
}
