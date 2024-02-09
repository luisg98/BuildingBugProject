package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import com.google.gson.JsonParseException
import io.swagger.client.models.Cliente
import ipca.app.buildingbug.databinding.ActivityPerfilClienteBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody.Companion.toRequestBody
import okhttp3.Response
import org.json.JSONObject
import java.io.IOException
import java.util.concurrent.TimeUnit

class PerfilClienteActivity : AppCompatActivity() {

    private lateinit var binding: ActivityPerfilClienteBinding

    private val apiKey = "d68fe64649b74abc93522bb7972e5854"
    private val apiVersion = "1.0"

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityPerfilClienteBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val sharedPreferences = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
        val token = sharedPreferences.getString("Token", null)
        val id = sharedPreferences.getInt("Id", 0)

        if (token != null && id != 0) {
            getCliente(id, token)
        } else {
            Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
            startActivity(Intent(this, LoginActivity::class.java))
        }

        binding.alterarButton.setOnClickListener{
            if (token != null && id != 0) {
                val nome = binding.nomeEditText.text.toString().trim()
                val apelido = binding.apelidoEditText.text.toString().trim()
                val contacto = binding.contactoEditText.text.toString().trim()
                alterarCliente(id, token, nome, apelido, contacto)
            } else {
                Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
                startActivity(Intent(this, LoginActivity::class.java))
            }
        }
        binding.alterarSenhaButton.setOnClickListener{

        }
        binding.apagarContaButton.setOnClickListener{
            if (token != null && id != 0) {
                apagarCliente(id, token)
                startActivity(Intent(this, LoginActivity::class.java))
                finish()
            } else {
                Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
                startActivity(Intent(this, LoginActivity::class.java))
            }
        }


    }

    private fun getCliente(id: Int, token: String) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val client = OkHttpClient()
                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Cliente/$id")
                    .get()
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()


                response = client.newCall(request).execute()
                val responseBodyString = response.body?.string()


                withContext(Dispatchers.Main) {
                    if (response.isSuccessful && responseBodyString != null) {
                        val perfilClienteResponse: Cliente =
                            Gson().fromJson(responseBodyString, Cliente::class.java)
                        binding.nomeEditText.setText(perfilClienteResponse.nome)
                        binding.apelidoEditText.setText(perfilClienteResponse.apelido)
                        binding.contactoEditText.setText(perfilClienteResponse.contacto.toString())
                        binding.emailEditText.setText(perfilClienteResponse.email)
                    } else {
                        val errorBody = responseBodyString ?: "Unknown error"
                        Toast.makeText(
                            this@PerfilClienteActivity,
                            "Failed to get Profissional: $errorBody",
                            Toast.LENGTH_SHORT
                        ).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilClienteActivity,
                        "Network error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilClienteActivity,
                        "JSON parsing error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilClienteActivity,
                        "Unknown error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }
    private fun apagarCliente(id: Int, token: String) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val client = OkHttpClient()
                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Cliente/delete/$id")
                    .delete()
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = client.newCall(request).execute()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful) {
                        // Handle successful response
                        Toast.makeText(this@PerfilClienteActivity, "Cliente apagado com sucesso.", Toast.LENGTH_SHORT).show()
                    } else {
                        // Handle error response
                        val errorBody = response.body?.string() ?: "Unknown error"
                        Toast.makeText(this@PerfilClienteActivity, "Erro ao apagar cliente: $errorBody", Toast.LENGTH_SHORT).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@PerfilClienteActivity, "Erro de rede: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@PerfilClienteActivity, "Erro de análise JSON: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@PerfilClienteActivity, "Erro desconhecido: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }
    private fun alterarCliente(id: Int, token: String, nome: String, apelido: String, contacto: String) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val okHttpClient = OkHttpClient.Builder()
                    .readTimeout(30, TimeUnit.SECONDS)
                    .writeTimeout(30, TimeUnit.SECONDS)
                    .build()

                val mediaType = "application/json".toMediaTypeOrNull()
                val jsonBody = JSONObject().apply {
                    put("id", id)
                    put("nome", nome)
                    put("apelido", apelido)
                    put("contacto", contacto)
                }.toString()

                val body = jsonBody.toRequestBody(mediaType)

                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Cliente/update")
                    .put(body)
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = okHttpClient.newCall(request).execute()
                val responseBodyString = response.body?.string()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful) {
                        Toast.makeText(this@PerfilClienteActivity, "Dados alterados com sucesso!", Toast.LENGTH_SHORT).show()
                    } else {
                        val errorBody = responseBodyString ?: "Unknown error"
                        Toast.makeText(
                            this@PerfilClienteActivity,
                            "Falha a alterar os dados: $errorBody",
                            Toast.LENGTH_SHORT
                        ).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilClienteActivity,
                        "Network error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilClienteActivity,
                        "Unknown error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }
}
