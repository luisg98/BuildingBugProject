# ProfissionalApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionProfissionalAllGet**](ProfissionalApi.md#apiVversionProfissionalAllGet) | **GET** /api/v{version}/Profissional/all | 
[**apiVversionProfissionalDeleteIdLastUpdateDelete**](ProfissionalApi.md#apiVversionProfissionalDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Profissional/delete/{id}/{lastUpdate} | 
[**apiVversionProfissionalIdGet**](ProfissionalApi.md#apiVversionProfissionalIdGet) | **GET** /api/v{version}/Profissional/{id} | 
[**apiVversionProfissionalNewPost**](ProfissionalApi.md#apiVversionProfissionalNewPost) | **POST** /api/v{version}/Profissional/new | 
[**apiVversionProfissionalUpdatePut**](ProfissionalApi.md#apiVversionProfissionalUpdatePut) | **PUT** /api/v{version}/Profissional/update | 

<a name="apiVversionProfissionalAllGet"></a>
# **apiVversionProfissionalAllGet**
> apiVversionProfissionalAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionProfissionalAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalApi#apiVversionProfissionalAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalApi#apiVversionProfissionalAllGet")
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

<a name="apiVversionProfissionalDeleteIdLastUpdateDelete"></a>
# **apiVversionProfissionalDeleteIdLastUpdateDelete**
> apiVversionProfissionalDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionProfissionalDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalApi#apiVversionProfissionalDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalApi#apiVversionProfissionalDeleteIdLastUpdateDelete")
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

<a name="apiVversionProfissionalIdGet"></a>
# **apiVversionProfissionalIdGet**
> apiVversionProfissionalIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionProfissionalIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalApi#apiVversionProfissionalIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalApi#apiVversionProfissionalIdGet")
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

<a name="apiVversionProfissionalNewPost"></a>
# **apiVversionProfissionalNewPost**
> apiVversionProfissionalNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateProfissionalRequestContract =  // CreateProfissionalRequestContract | 
try {
    apiInstance.apiVversionProfissionalNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalApi#apiVversionProfissionalNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalApi#apiVversionProfissionalNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateProfissionalRequestContract**](CreateProfissionalRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionProfissionalUpdatePut"></a>
# **apiVversionProfissionalUpdatePut**
> apiVversionProfissionalUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateProfissionalRequestContract =  // UpdateProfissionalRequestContract | 
try {
    apiInstance.apiVversionProfissionalUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalApi#apiVversionProfissionalUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalApi#apiVversionProfissionalUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateProfissionalRequestContract**](UpdateProfissionalRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

