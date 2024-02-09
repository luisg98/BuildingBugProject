# RelatorioDeslocacaoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionRelatorioDeslocacaoAllGet**](RelatorioDeslocacaoApi.md#apiVversionRelatorioDeslocacaoAllGet) | **GET** /api/v{version}/RelatorioDeslocacao/all | 
[**apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete**](RelatorioDeslocacaoApi.md#apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/RelatorioDeslocacao/delete/{id}/{lastUpdate} | 
[**apiVversionRelatorioDeslocacaoIdGet**](RelatorioDeslocacaoApi.md#apiVversionRelatorioDeslocacaoIdGet) | **GET** /api/v{version}/RelatorioDeslocacao/{id} | 
[**apiVversionRelatorioDeslocacaoNewPost**](RelatorioDeslocacaoApi.md#apiVversionRelatorioDeslocacaoNewPost) | **POST** /api/v{version}/RelatorioDeslocacao/new | 
[**apiVversionRelatorioDeslocacaoUpdatePut**](RelatorioDeslocacaoApi.md#apiVversionRelatorioDeslocacaoUpdatePut) | **PUT** /api/v{version}/RelatorioDeslocacao/update | 

<a name="apiVversionRelatorioDeslocacaoAllGet"></a>
# **apiVversionRelatorioDeslocacaoAllGet**
> apiVversionRelatorioDeslocacaoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = RelatorioDeslocacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionRelatorioDeslocacaoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoAllGet")
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

<a name="apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete"></a>
# **apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete**
> apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = RelatorioDeslocacaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.Int**|  |
 **lastUpdate** | **java.time.LocalDateTime**|  |
 **version** | **kotlin.String**|  |

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiVversionRelatorioDeslocacaoIdGet"></a>
# **apiVversionRelatorioDeslocacaoIdGet**
> apiVversionRelatorioDeslocacaoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = RelatorioDeslocacaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionRelatorioDeslocacaoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoIdGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.Int**|  |
 **version** | **kotlin.String**|  |

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiVversionRelatorioDeslocacaoNewPost"></a>
# **apiVversionRelatorioDeslocacaoNewPost**
> apiVversionRelatorioDeslocacaoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = RelatorioDeslocacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateRelatorioDeslocacaoRequestContract =  // CreateRelatorioDeslocacaoRequestContract | 
try {
    apiInstance.apiVversionRelatorioDeslocacaoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateRelatorioDeslocacaoRequestContract**](CreateRelatorioDeslocacaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionRelatorioDeslocacaoUpdatePut"></a>
# **apiVversionRelatorioDeslocacaoUpdatePut**
> apiVversionRelatorioDeslocacaoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = RelatorioDeslocacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateRelatorioDeslocacaoRequestContract =  // UpdateRelatorioDeslocacaoRequestContract | 
try {
    apiInstance.apiVversionRelatorioDeslocacaoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RelatorioDeslocacaoApi#apiVversionRelatorioDeslocacaoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateRelatorioDeslocacaoRequestContract**](UpdateRelatorioDeslocacaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

