package ipca.app.buildingbug

import android.content.Intent
import android.os.Bundle
import android.util.Patterns
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.bumptech.glide.Glide
import com.google.gson.Gson
import ipca.app.buildingbug.databinding.ActivityRegistoBinding
import jp.wasabeef.glide.transformations.BlurTransformation
import okhttp3.Call
import okhttp3.Callback
import okhttp3.MediaType.Companion.toMediaTypeOrNull
import okhttp3.OkHttpClient
import okhttp3.Request
import okhttp3.RequestBody.Companion.toRequestBody
import okhttp3.Response
import java.io.IOException
import java.util.concurrent.TimeUnit

class RegistoActivity : AppCompatActivity() {

    private lateinit var binding: ActivityRegistoBinding

    private val apiKey = "d68fe64649b74abc93522bb7972e5854"
    private val apiVersion = "1.0"

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityRegistoBinding.inflate(layoutInflater)
        setContentView(binding.root)

        // Configure the background image with blur effect
        Glide.with(this)
            .load(R.drawable.image1)
            .transform(BlurTransformation(25, 3))
            .into(binding.backgroundImageView)

        // Set up the registration button click listener
        binding.registrationButton.setOnClickListener {
            val nome = binding.nomeEditText.text.toString().trim()
            val apelido = binding.apelidoEditText.text.toString().trim()
            val email = binding.emailEditText.text.toString().trim()
            val senha = binding.senhaEditText.text.toString().trim()
            val contactoString = binding.contactoEditText.text.toString().trim()


            binding.registrationButton.isEnabled = false

            if (nome.isNotEmpty() && apelido.isNotEmpty() && email.isNotEmpty() && senha.isNotEmpty() && contactoString.isNotEmpty()) {
                // Verifica se o email é válido
                if (!Patterns.EMAIL_ADDRESS.matcher(email).matches()) {
                    Toast.makeText(this, "Insira um endereço de e-mail válido", Toast.LENGTH_SHORT)
                        .show()
                    binding.registrationButton.isEnabled = true
                    return@setOnClickListener
                }

                // Verifica se o contato tem 9 dígitos e começa com 9
                if (!contactoString.matches(Regex("9\\d{8}"))) {
                    Toast.makeText(
                        this,
                        "O número de contato deve ter 9 dígitos e começar com 9",
                        Toast.LENGTH_SHORT
                    ).show()
                    binding.registrationButton.isEnabled = true
                    return@setOnClickListener
                }

                // Verifica se a senha tem pelo menos 8 dígitos
                if (senha.length < 8) {
                    Toast.makeText(
                        this,
                        "A senha deve ter pelo menos 8 dígitos",
                        Toast.LENGTH_SHORT
                    ).show()
                    binding.registrationButton.isEnabled = true
                    return@setOnClickListener
                }

                // Tenta converter o contato para inteiro
                try {
                    val contacto = contactoString.toInt()
                    performRegistration(nome, apelido, email, senha, contacto, onSuccess = {
                        val intent = Intent(this, LoginActivity::class.java)
                        startActivity(intent)
                        finish()
                    }, onError = { error ->
                        // Show error message
                        Toast.makeText(this@RegistoActivity, error, Toast.LENGTH_SHORT).show()
                    })
                } catch (e: NumberFormatException) {
                    Toast.makeText(this, "Número de contato inválido", Toast.LENGTH_SHORT).show()
                    binding.registrationButton.isEnabled = true
                }
            } else {
                Toast.makeText(this, "Preencha todos os campos", Toast.LENGTH_SHORT).show()
                binding.registrationButton.isEnabled = true
            }
        }
    }


    private fun performRegistration(nome: String, apelido: String, email: String, senha: String, contacto: Int,
                                    onSuccess: () -> Unit, onError: (String) -> Unit) {

        val okHttpClient = OkHttpClient.Builder()
            .readTimeout(30, TimeUnit.SECONDS)
            .writeTimeout(30, TimeUnit.SECONDS)
            .build()

        val mediaType = "application/json".toMediaTypeOrNull()
        val gson = Gson()
        val jsonBody = """
    {
        "nome": "$nome",
        "apelido": "$apelido",
        "email": "$email",
        "senha": "$senha",
        "contacto": $contacto
    }
""".trimIndent()

        val body = jsonBody.toRequestBody(mediaType)

        val requestUrl = if (binding.contaProSwitch.isChecked) {
            "https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Profissional/new"
        } else {
            "https://buildingbugapiapi.azure-api.net/api/v$apiVersion/Cliente/new"
        }

        val request = Request.Builder()
            .url(requestUrl)
            .post(body)
            .addHeader("Content-Type", "application/json")
            .addHeader("Ocp-Apim-Subscription-Key", apiKey)
            .build()


        binding.registrationButton.isEnabled = false

        okHttpClient.newCall(request).enqueue(object : Callback {
            override fun onResponse(call: Call, response: Response) {
                runOnUiThread {
                    binding.registrationButton.isEnabled = true
                    if (response.isSuccessful) {
                        response.body?.string()?.let { responseBodyStr ->
                            val registrationResponse = gson.fromJson(responseBodyStr, RegistrationResponse::class.java)
                            Toast.makeText(this@RegistoActivity, "Registo bem-sucedido!", Toast.LENGTH_SHORT).show()
                            onSuccess()
                        } ?: onError("Resposta vazia")
                    } else {
                        onError("Falha no registo com código: ${response.code}")
                    }
                    response.close()
                }
            }

            override fun onFailure(call: Call, e: IOException) {
                runOnUiThread {
                    binding.registrationButton.isEnabled = true
                    onError("Erro de rede: ${e.localizedMessage}")
                }
            }
        })
    }


    data class RegistrationResponse(val id: Int)
}