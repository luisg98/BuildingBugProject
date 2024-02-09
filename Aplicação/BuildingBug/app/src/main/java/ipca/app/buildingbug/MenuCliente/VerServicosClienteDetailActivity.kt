package ipca.app.buildingbug.MenuCliente

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import ipca.app.buildingbug.databinding.ActivityVerServicosClienteDetailBinding
import java.text.SimpleDateFormat
import java.util.Locale

class VerServicosClienteDetailActivity : AppCompatActivity() {

    private lateinit var binding: ActivityVerServicosClienteDetailBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityVerServicosClienteDetailBinding.inflate(layoutInflater)
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
        val format = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
        binding.dataInicioTextView2.setText(dataInicio.toString())
        binding.cpTextView2.text = "${codigoPostalCP.toString().substring(0, 4)}-${codigoPostalCP.toString().substring(4, 7)}"
        binding.custoTextView2.setText("$custo€")
        binding.fatorTextView2.setText(fator.toString())
        if (dataFim.isNullOrEmpty()) {
            binding.dataFimTextView2.setText("a decorrer")
        } else {
            val format = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
            binding.dataFimTextView2.setText(format.format(dataFim))

        }
        binding.proIdTextView2.setText(profissional.toString())
        binding.estadoServicoTextView2.setText(estadoServico.toString())
        binding.moradaClienteTextView.setText(morada.toString())
        binding.tituloTextView.setText(tipo.toString())

    }
}