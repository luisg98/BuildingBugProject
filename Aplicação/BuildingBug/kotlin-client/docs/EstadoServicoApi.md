# EstadoServicoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionEstadoServicoAllGet**](EstadoServicoApi.md#apiVversionEstadoServicoAllGet) | **GET** /api/v{version}/EstadoServico/all | 
[**apiVversionEstadoServicoDeleteIdLastUpdateDelete**](EstadoServicoApi.md#apiVversionEstadoServicoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/EstadoServico/delete/{id}/{lastUpdate} | 
[**apiVversionEstadoServicoIdGet**](EstadoServicoApi.md#apiVversionEstadoServicoIdGet) | **GET** /api/v{version}/EstadoServico/{id} | 
[**apiVversionEstadoServicoNewPost**](EstadoServicoApi.md#apiVversionEstadoServicoNewPost) | **POST** /api/v{version}/EstadoServico/new | 
[**apiVversionEstadoServicoUpdatePut**](EstadoServicoApi.md#apiVversionEstadoServicoUpdatePut) | **PUT** /api/v{version}/EstadoServico/update | 

<a name="apiVversionEstadoServicoAllGet"></a>
# **apiVversionEstadoServicoAllGet**
> apiVversionEstadoServicoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = EstadoServicoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionEstadoServicoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling EstadoServicoApi#apiVversionEstadoServicoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EstadoServicoApi#apiVversionEstadoServicoAllGet")
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

<a name="apiVversionEstadoServicoDeleteIdLastUpdateDelete"></a>
# **apiVversionEstadoServicoDeleteIdLastUpdateDelete**
> apiVversionEstadoServicoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = EstadoServicoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionEstadoServicoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling EstadoServicoApi#apiVversionEstadoServicoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EstadoServicoApi#apiVversionEstadoServicoDeleteIdLastUpdateDelete")
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

<a name="apiVversionEstadoServicoIdGet"></a>
# **apiVversionEstadoServicoIdGet**
> apiVversionEstadoServicoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = EstadoServicoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionEstadoServicoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling EstadoServicoApi#apiVversionEstadoServicoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EstadoServicoApi#apiVversionEstadoServicoIdGet")
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

<a name="apiVversionEstadoServicoNewPost"></a>
# **apiVversionEstadoServicoNewPost**
> apiVversionEstadoServicoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = EstadoServicoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateEstadoServicoRequestContract =  // CreateEstadoServicoRequestContract | 
try {
    apiInstance.apiVversionEstadoServicoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling EstadoServicoApi#apiVversionEstadoServicoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EstadoServicoApi#apiVversionEstadoServicoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateEstadoServicoRequestContract**](CreateEstadoServicoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionEstadoServicoUpdatePut"></a>
# **apiVversionEstadoServicoUpdatePut**
> apiVversionEstadoServicoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = EstadoServicoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateEstadoServicoRequestContract =  // UpdateEstadoServicoRequestContract | 
try {
    apiInstance.apiVversionEstadoServicoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling EstadoServicoApi#apiVversionEstadoServicoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EstadoServicoApi#apiVversionEstadoServicoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateEstadoServicoRequestContract**](UpdateEstadoServicoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

