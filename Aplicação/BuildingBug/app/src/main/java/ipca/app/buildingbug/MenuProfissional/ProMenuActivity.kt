package ipca.app.buildingbug

import android.content.Context
import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import ipca.app.buildingbug.MenuProfissional.ProcurarServicoActivity
import ipca.app.buildingbug.MenuProfissional.VerServicoActivity
import ipca.app.buildingbug.databinding.ActivityProMenuBinding

class ProMenuActivity : AppCompatActivity() {
    private lateinit var binding: ActivityProMenuBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityProMenuBinding.inflate(layoutInflater)
        setContentView(binding.root)


        binding.verServicosButton.setOnClickListener {
            startActivity(Intent(this, VerServicoActivity::class.java))

        }

        binding.procurarServicosButton.setOnClickListener {
            startActivity(Intent(this, ProcurarServicoActivity::class.java))

        }

        binding.logoutButton.setOnClickListener {
            startActivity(Intent(this, LoginActivity::class.java))
            val sharedPref = getSharedPreferences("MyPrefs", Context.MODE_PRIVATE)
            with(sharedPref.edit()) {
                putString("Email", "")
                putString("Senha", "")
                putInt("Id", 0)
                putString("Token", "")
                apply()
            }
            finish()
        }

        binding.perfilButton.setOnClickListener{
            startActivity(Intent(this, PerfilProActivity::class.java))
        }
    }
}