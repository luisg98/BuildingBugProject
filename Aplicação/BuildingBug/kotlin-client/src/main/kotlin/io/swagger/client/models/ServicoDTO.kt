package io.swagger.client.models

import java.time.LocalDateTime


data class ServicoDTO (

    var id: Int,
    var morada: String,
    var dataInicio: LocalDateTime,
    var dataFim: LocalDateTime,
    var avaliacao: Int,
    var custo: Int,
    var fator: Int,
    var nome_cliente: String,
    var estadoServico: String,
    var codigoPostalCP: Int,
    var nome_profissional: String,
    var tipo: String
)

