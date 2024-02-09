package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import ipca.app.buildingbug.MenuCliente.VerServicosClienteActivity
import ipca.app.buildingbug.databinding.ActivityClientMenuBinding

class ClientMenuActivity : AppCompatActivity() {

    private lateinit var binding: ActivityClientMenuBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityClientMenuBinding.inflate(layoutInflater)
        setContentView(binding.root)

        setupCardClickListeners()

        binding.perfilClienteButton.setOnClickListener {
            startActivity(Intent(this, PerfilClienteActivity::class.java))

        }

        binding.verServicosClienteButton.setOnClickListener {
            startActivity(Intent(this, VerServicosClienteActivity::class.java))

        }

        binding.logoutClienteButton.setOnClickListener {
            val sharedPref = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
            with(sharedPref.edit()) {
                putString("Email", "")
                putString("Senha", "")
                putInt("Id", 0)
                putString("Token", "")
                apply()
            }
            startActivity(Intent(this, LoginActivity::class.java))
            finish()

        }


    }

    private fun setupCardClickListeners() {
        val categories = listOf("Eletricidade", "Canalização", "Limpeza", "Decoração", "Jardinagem", "Pintura")
        val cards = listOf(binding.CardView1, binding.CardView2, binding.CardView3, binding.CardView4, binding.CardView5, binding.CardView6)

        cards.zip(categories).forEach { (card, category) ->
            card.setOnClickListener {
                val intent = Intent(this, TipoActivity::class.java).apply {
                    putExtra("CATEGORIA", category)
                }
                startActivity(intent)
            }
        }
    }



}
