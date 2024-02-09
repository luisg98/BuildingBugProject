# SimulacaoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionSimulacaoAllGet**](SimulacaoApi.md#apiVversionSimulacaoAllGet) | **GET** /api/v{version}/Simulacao/all | 
[**apiVversionSimulacaoDeleteIdLastUpdateDelete**](SimulacaoApi.md#apiVversionSimulacaoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Simulacao/delete/{id}/{lastUpdate} | 
[**apiVversionSimulacaoIdGet**](SimulacaoApi.md#apiVversionSimulacaoIdGet) | **GET** /api/v{version}/Simulacao/{id} | 
[**apiVversionSimulacaoNewPost**](SimulacaoApi.md#apiVversionSimulacaoNewPost) | **POST** /api/v{version}/Simulacao/new | 
[**apiVversionSimulacaoUpdatePut**](SimulacaoApi.md#apiVversionSimulacaoUpdatePut) | **PUT** /api/v{version}/Simulacao/update | 

<a name="apiVversionSimulacaoAllGet"></a>
# **apiVversionSimulacaoAllGet**
> apiVversionSimulacaoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = SimulacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionSimulacaoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling SimulacaoApi#apiVversionSimulacaoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SimulacaoApi#apiVversionSimulacaoAllGet")
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

<a name="apiVversionSimulacaoDeleteIdLastUpdateDelete"></a>
# **apiVversionSimulacaoDeleteIdLastUpdateDelete**
> apiVversionSimulacaoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = SimulacaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionSimulacaoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling SimulacaoApi#apiVversionSimulacaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SimulacaoApi#apiVversionSimulacaoDeleteIdLastUpdateDelete")
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

<a name="apiVversionSimulacaoIdGet"></a>
# **apiVversionSimulacaoIdGet**
> apiVversionSimulacaoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = SimulacaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionSimulacaoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling SimulacaoApi#apiVversionSimulacaoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SimulacaoApi#apiVversionSimulacaoIdGet")
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

<a name="apiVversionSimulacaoNewPost"></a>
# **apiVversionSimulacaoNewPost**
> apiVversionSimulacaoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = SimulacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateSimulacaoRequestContract =  // CreateSimulacaoRequestContract | 
try {
    apiInstance.apiVversionSimulacaoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling SimulacaoApi#apiVversionSimulacaoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SimulacaoApi#apiVversionSimulacaoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateSimulacaoRequestContract**](CreateSimulacaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionSimulacaoUpdatePut"></a>
# **apiVversionSimulacaoUpdatePut**
> apiVversionSimulacaoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = SimulacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateSimulacaoRequestContract =  // UpdateSimulacaoRequestContract | 
try {
    apiInstance.apiVversionSimulacaoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling SimulacaoApi#apiVversionSimulacaoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SimulacaoApi#apiVversionSimulacaoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateSimulacaoRequestContract**](UpdateSimulacaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

