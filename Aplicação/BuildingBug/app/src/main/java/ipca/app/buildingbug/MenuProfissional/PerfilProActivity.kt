package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.gson.Gson
import com.google.gson.JsonParseException
import io.swagger.client.models.Profissional
import ipca.app.buildingbug.databinding.ActivityPerfilProBinding
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

class PerfilProActivity : AppCompatActivity() {

    private lateinit var binding: ActivityPerfilProBinding

    private val apiKey = "d68fe64649b74abc93522bb7972e5854"
    private val apiVersion = "1.0"

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityPerfilProBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val sharedPreferences = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
        val token = sharedPreferences.getString("Token", null)
        val id = sharedPreferences.getInt("Id", 0)

        if (token != null && id != 0) {
            getPro(id, token)
        } else {
            Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
            startActivity(Intent(this, LoginActivity::class.java))
        }

        binding.alterarButton.setOnClickListener{
            if (token != null && id != 0) {
                val nome = binding.nomeEditText.text.toString().trim()
                val apelido = binding.apelidoEditText.text.toString().trim()
                val contacto = binding.contactoEditText.text.toString().trim()
                alterarPro(id, token, nome, apelido, contacto)
            } else {
                Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
                startActivity(Intent(this, LoginActivity::class.java))
            }
        }
        binding.alterarSenhaButton.setOnClickListener{

        }
        binding.apagarContaButton.setOnClickListener{
            if (token != null && id != 0) {
                apagarPro(id, token)
                startActivity(Intent(this, LoginActivity::class.java))
                finish()
            } else {
                Toast.makeText(this, "Sessão Expirada- Faça Login Novamente", Toast.LENGTH_LONG).show()
                startActivity(Intent(this, LoginActivity::class.java))
            }
        }

    }

    private fun getPro(id: Int, token: String) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val client = OkHttpClient()
                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Profissional/$id")
                    .get()
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = client.newCall(request).execute()
                val responseBodyString = response.body?.string()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful && responseBodyString != null) {
                        val perfilProsResponse: Profissional =
                            Gson().fromJson(responseBodyString, Profissional::class.java)
                        binding.nomeEditText.setText(perfilProsResponse.nome)
                        binding.apelidoEditText.setText(perfilProsResponse.apelido)
                        binding.contactoEditText.setText(perfilProsResponse.contacto.toString())
                        binding.emailEditText.setText(perfilProsResponse.email)
                    } else {
                        val errorBody = responseBodyString ?: "Unknown error"
                        Toast.makeText(
                            this@PerfilProActivity,
                            "Failed to get Profissional: $errorBody",
                            Toast.LENGTH_SHORT
                        ).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilProActivity,
                        "Network error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilProActivity,
                        "JSON parsing error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilProActivity,
                        "Unknown error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }

    private fun apagarPro(id: Int, token: String) {
        CoroutineScope(Dispatchers.IO).launch {
            var response: Response? = null
            try {
                val client = OkHttpClient()
                val request = Request.Builder()
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Profissional/delete/$id")
                    .delete()
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = client.newCall(request).execute()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful) {
                        // Handle successful response
                        Toast.makeText(this@PerfilProActivity, "Profissional apagado com sucesso.", Toast.LENGTH_SHORT).show()
                    } else {
                        // Handle error response
                        val errorBody = response.body?.string() ?: "Unknown error"
                        Toast.makeText(this@PerfilProActivity, "Erro ao apagar profissional: $errorBody", Toast.LENGTH_SHORT).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@PerfilProActivity, "Erro de rede: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@PerfilProActivity, "Erro de análise JSON: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@PerfilProActivity, "Erro desconhecido: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } finally {
                response?.body?.close()
            }
        }
    }

    private fun alterarPro(id: Int, token: String, nome: String, apelido: String, contacto: String) {
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
                    .url("https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Profissional/update")
                    .put(body)
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .addHeader("Authorization", "Bearer $token")
                    .build()

                response = okHttpClient.newCall(request).execute()
                val responseBodyString = response.body?.string()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful) {
                        Toast.makeText(this@PerfilProActivity, "Dados alterados com sucesso!", Toast.LENGTH_SHORT).show()
                    } else {
                        val errorBody = responseBodyString ?: "Unknown error"
                        Toast.makeText(
                            this@PerfilProActivity,
                            "Falha ao alterar os dados: $errorBody",
                            Toast.LENGTH_SHORT
                        ).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilProActivity,
                        "Network error: ${e.message}",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(
                        this@PerfilProActivity,
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
