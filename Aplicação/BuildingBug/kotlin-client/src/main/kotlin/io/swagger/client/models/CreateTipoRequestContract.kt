/**
 * BuildingBugAPI
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
package io.swagger.client.models


/**
 * 
 * @param descricao 
 * @param preco 
 * @param fator 
 * @param categoria 
 */
data class CreateTipoRequestContract (

    val descricao: kotlin.String? = null,
    val preco: kotlin.Int? = null,
    val fator: kotlin.Boolean? = null,
    val categoria: kotlin.String? = null
) {
}