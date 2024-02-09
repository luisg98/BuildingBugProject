package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.bumptech.glide.Glide
import com.google.gson.Gson
import com.google.gson.JsonParseException
import io.swagger.client.models.LoginResponse
import ipca.app.buildingbug.databinding.ActivityLoginBinding
import jp.wasabeef.glide.transformations.BlurTransformation
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody.Companion.toRequestBody
import java.io.IOException

class LoginActivity : AppCompatActivity() {

    private lateinit var binding: ActivityLoginBinding
    private val apiKey = "d68fe64649b74abc93522bb7972e5854"
    private val apiVersion = "1.0"

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val sharedPref = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
        val email = sharedPref.getString("Email", "")
        val senha = sharedPref.getString("Senha", "")
        val tipoUtilizador = sharedPref.getString("userTipo", "")
        if (email.isNullOrEmpty() || senha.isNullOrEmpty()) {
        } else {
            when (tipoUtilizador) {
                "cliente" -> performLogin(email, senha, false)
                "profissional" -> performLogin(email, senha, true)
                else -> {
                }
            }
        }

        Glide.with(this)
            .load(R.drawable.image1)
            .transform(BlurTransformation(25, 3))
            .into(binding.backgroundImageView)

        binding.loginButton.setOnClickListener {
            val email = binding.emailEditText.text.toString().trim()
            val password = binding.passwordEditText.text.toString().trim()
            if (email.isNotEmpty() && password.isNotEmpty()) {
                if(binding.contaProSwitch.isChecked) {
                    performLogin(email, password, true)
                }
                else{
                    performLogin(email, password, false)
                }
            } else {
                Toast.makeText(this, "Please enter email and password.", Toast.LENGTH_SHORT).show()
            }
        }

        binding.signUpTextView.setOnClickListener {
            startActivity(Intent(this, RegistoActivity::class.java))
        }
    }

    private fun performLogin(email: String, password: String, isPro: Boolean) {
        CoroutineScope(Dispatchers.IO).launch {
            try {
                val client = OkHttpClient()
                val mediaType = "application/json".toMediaTypeOrNull()
                val jsonBody = "{\"email\":\"$email\",\"password\":\"$password\"}"
                val body = jsonBody.toRequestBody(mediaType)

                val requestUrl: String
                if (isPro == true) {
                    requestUrl = "https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Profissional/login"
                    val sharedPref = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
                    with(sharedPref.edit()) {
                        putString("userTipo", "profissional")
                        apply()
                    }
                } else {
                    requestUrl= "https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Cliente/login"
                    val sharedPref = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
                    with(sharedPref.edit()) {
                        putString("userTipo", "cliente")
                        apply()
                    }
                }

                val request = Request.Builder()
                    .url(requestUrl)
                    .post(body)
                    .addHeader("Content-Type", "application/json")
                    .addHeader("Ocp-Apim-Subscription-Key", apiKey)
                    .build()

                val response = client.newCall(request).execute()

                val responseBodyString = response.body?.string()

                withContext(Dispatchers.Main) {
                    if (response.isSuccessful && responseBodyString != null) {
                        val loginResponse = Gson().fromJson(responseBodyString, LoginResponse::class.java)
                        val sharedPref = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
                        with(sharedPref.edit()) {
                            putString("Email", email)
                            putString("Senha", password)
                            putInt("Id", loginResponse.id)
                            putString("Token", loginResponse.token)
                            putBoolean("Switch", binding.contaProSwitch.isChecked)
                            apply()
                        }
                        val intent = if (isPro == true) {
                            Intent(this@LoginActivity, ProMenuActivity::class.java)
                        } else {
                            Intent(this@LoginActivity, ClientMenuActivity::class.java)
                        }
                        startActivity(intent)
                        finish()
                    } else {
                        val errorBody = if (responseBodyString.isNullOrEmpty()) "Unknown error" else responseBodyString
                        Toast.makeText(this@LoginActivity, "Login failed: $errorBody", Toast.LENGTH_SHORT).show()
                    }
                }
            } catch (e: IOException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@LoginActivity, "Network error: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: JsonParseException) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@LoginActivity, "JSON parsing error: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            } catch (e: Exception) {
                withContext(Dispatchers.Main) {
                    Toast.makeText(this@LoginActivity, "Unknown error: ${e.message}", Toast.LENGTH_SHORT).show()
                }
            }
        }

    }



}
