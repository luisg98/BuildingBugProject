# ListaComprasArtigosConstrucaoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionListaComprasArtigosConstrucaoAllGet**](ListaComprasArtigosConstrucaoApi.md#apiVversionListaComprasArtigosConstrucaoAllGet) | **GET** /api/v{version}/ListaComprasArtigosConstrucao/all | 
[**apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete**](ListaComprasArtigosConstrucaoApi.md#apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/ListaComprasArtigosConstrucao/delete/{id}/{lastUpdate} | 
[**apiVversionListaComprasArtigosConstrucaoIdGet**](ListaComprasArtigosConstrucaoApi.md#apiVversionListaComprasArtigosConstrucaoIdGet) | **GET** /api/v{version}/ListaComprasArtigosConstrucao/{id} | 
[**apiVversionListaComprasArtigosConstrucaoNewPost**](ListaComprasArtigosConstrucaoApi.md#apiVversionListaComprasArtigosConstrucaoNewPost) | **POST** /api/v{version}/ListaComprasArtigosConstrucao/new | 
[**apiVversionListaComprasArtigosConstrucaoUpdatePut**](ListaComprasArtigosConstrucaoApi.md#apiVversionListaComprasArtigosConstrucaoUpdatePut) | **PUT** /api/v{version}/ListaComprasArtigosConstrucao/update | 

<a name="apiVversionListaComprasArtigosConstrucaoAllGet"></a>
# **apiVversionListaComprasArtigosConstrucaoAllGet**
> apiVversionListaComprasArtigosConstrucaoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasArtigosConstrucaoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionListaComprasArtigosConstrucaoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoAllGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete"></a>
# **apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete**
> apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete(id, lastUpdate, version, outroid)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasArtigosConstrucaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
val outroid : kotlin.Int = 56 // kotlin.Int | 
try {
    apiInstance.apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete(id, lastUpdate, version, outroid)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.Int**|  |
 **lastUpdate** | **java.time.LocalDateTime**|  |
 **version** | **kotlin.String**|  |
 **outroid** | **kotlin.Int**|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiVversionListaComprasArtigosConstrucaoIdGet"></a>
# **apiVversionListaComprasArtigosConstrucaoIdGet**
> apiVversionListaComprasArtigosConstrucaoIdGet(id, version, id2)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasArtigosConstrucaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
val id2 : kotlin.Int = 56 // kotlin.Int | 
try {
    apiInstance.apiVversionListaComprasArtigosConstrucaoIdGet(id, version, id2)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoIdGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.Int**|  |
 **version** | **kotlin.String**|  |
 **id2** | **kotlin.Int**|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiVversionListaComprasArtigosConstrucaoNewPost"></a>
# **apiVversionListaComprasArtigosConstrucaoNewPost**
> apiVversionListaComprasArtigosConstrucaoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasArtigosConstrucaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateListaComprasArtigosConstrucaoRequestContract =  // CreateListaComprasArtigosConstrucaoRequestContract | 
try {
    apiInstance.apiVversionListaComprasArtigosConstrucaoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateListaComprasArtigosConstrucaoRequestContract**](CreateListaComprasArtigosConstrucaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionListaComprasArtigosConstrucaoUpdatePut"></a>
# **apiVversionListaComprasArtigosConstrucaoUpdatePut**
> apiVversionListaComprasArtigosConstrucaoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasArtigosConstrucaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateListaComprasArtigosConstrucaoRequestContract =  // UpdateListaComprasArtigosConstrucaoRequestContract | 
try {
    apiInstance.apiVversionListaComprasArtigosConstrucaoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasArtigosConstrucaoApi#apiVversionListaComprasArtigosConstrucaoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateListaComprasArtigosConstrucaoRequestContract**](UpdateListaComprasArtigosConstrucaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

