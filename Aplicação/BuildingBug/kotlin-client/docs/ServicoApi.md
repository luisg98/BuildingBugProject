# ServicoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionServicoAllGet**](ServicoApi.md#apiVversionServicoAllGet) | **GET** /api/v{version}/Servico/all | 
[**apiVversionServicoDeleteIdLastUpdateDelete**](ServicoApi.md#apiVversionServicoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Servico/delete/{id}/{lastUpdate} | 
[**apiVversionServicoIdGet**](ServicoApi.md#apiVversionServicoIdGet) | **GET** /api/v{version}/Servico/{id} | 
[**apiVversionServicoNewPost**](ServicoApi.md#apiVversionServicoNewPost) | **POST** /api/v{version}/Servico/new | 
[**apiVversionServicoUpdatePut**](ServicoApi.md#apiVversionServicoUpdatePut) | **PUT** /api/v{version}/Servico/update | 

<a name="apiVversionServicoAllGet"></a>
# **apiVversionServicoAllGet**
> apiVversionServicoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ServicoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionServicoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling ServicoApi#apiVversionServicoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServicoApi#apiVversionServicoAllGet")
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

<a name="apiVversionServicoDeleteIdLastUpdateDelete"></a>
# **apiVversionServicoDeleteIdLastUpdateDelete**
> apiVversionServicoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ServicoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionServicoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling ServicoApi#apiVversionServicoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServicoApi#apiVversionServicoDeleteIdLastUpdateDelete")
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

<a name="apiVversionServicoIdGet"></a>
# **apiVversionServicoIdGet**
> apiVversionServicoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ServicoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionServicoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling ServicoApi#apiVversionServicoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServicoApi#apiVversionServicoIdGet")
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

<a name="apiVversionServicoNewPost"></a>
# **apiVversionServicoNewPost**
> apiVversionServicoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ServicoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateServicoRequestContract =  // CreateServicoRequestContract | 
try {
    apiInstance.apiVversionServicoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling ServicoApi#apiVversionServicoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServicoApi#apiVversionServicoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateServicoRequestContract**](CreateServicoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionServicoUpdatePut"></a>
# **apiVversionServicoUpdatePut**
> apiVversionServicoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ServicoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateServicoRequestContract =  // UpdateServicoRequestContract | 
try {
    apiInstance.apiVversionServicoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling ServicoApi#apiVversionServicoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ServicoApi#apiVversionServicoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateServicoRequestContract**](UpdateServicoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

