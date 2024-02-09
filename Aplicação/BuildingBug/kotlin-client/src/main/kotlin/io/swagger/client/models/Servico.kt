package io.swagger.client.models

import java.time.LocalDateTime


data class Servico (

    var id: Int,
    var morada: String,
    var dataInicio: LocalDateTime,
    var dataFim: LocalDateTime,
    var avaliacao: Int,
    var custo: Int,
    var fator: Int,
    var inactive: Boolean,
    var clienteId: Int,
    var estadoServicoId: Int,
    var codigoPostalCP: Int,
    var profissionalId: Int?,
    var tipoId: Int
)

