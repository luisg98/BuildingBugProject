package ipca.app.buildingbug.MenuProfissional

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import ipca.app.buildingbug.databinding.ActivityVerServicosProDetailBinding

class VerServicosProDetailActivity : AppCompatActivity() {

    private lateinit var binding: ActivityVerServicosProDetailBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityVerServicosProDetailBinding.inflate(layoutInflater)
        setContentView(binding.root)


        val servicoId = intent.getIntExtra("id", 0)
        val custo = intent.getIntExtra("custo", 0)
        val cliente = intent.getStringExtra("cliente")
        val morada = intent.getStringExtra("morada")
        val dataInicio = intent.getStringExtra("dataInicio")
        val avaliacao = intent.getIntExtra("avaliacao", 0)
        val codigoPostalCP = intent.getIntExtra("codigoPostalCP", 0)
        val dataFim = intent.getStringExtra("dataFim")
        val estadoServico = intent.getStringExtra("estadoServico")
        val fator = intent.getIntExtra("fator", 0)
        val inactive = intent.getBooleanExtra("inactive", false)
        val profissional = intent.getStringExtra("profissional")
        val tipo = intent.getStringExtra("tipo")

        binding.clienteIdTextView2.setText(cliente.toString())
        binding.dataInicioTextView2.setText(dataInicio.toString())
        binding.cpTextView2.text = "${codigoPostalCP.toString().substring(0, 4)}-${codigoPostalCP.toString().substring(4, 7)}"
        binding.custoTextView2.setText("$custo€")
        binding.fatorTextView2.setText(fator.toString())
        if (dataFim.isNullOrEmpty()) {
            binding.dataFimTextView2.setText("a decorrer")
        } else {
            binding.dataFimTextView2.setText(dataFim.toString())
        }
        binding.proIdTextView2.setText(profissional.toString())
        binding.estadoServicoTextView2.setText(estadoServico.toString())
        binding.moradaClienteTextView.setText(morada.toString())
        binding.tituloTextView.setText(tipo.toString())


        binding.aceitaButton.setOnClickListener{
            startActivity(Intent(this, MarcarDeslocacaoActivity::class.java))
        }

    }
}