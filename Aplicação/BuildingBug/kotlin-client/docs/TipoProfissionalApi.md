# TipoProfissionalApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionTipoProfissionalAllGet**](TipoProfissionalApi.md#apiVversionTipoProfissionalAllGet) | **GET** /api/v{version}/TipoProfissional/all | 
[**apiVversionTipoProfissionalDeleteIdLastUpdateDelete**](TipoProfissionalApi.md#apiVversionTipoProfissionalDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/TipoProfissional/delete/{id}/{lastUpdate} | 
[**apiVversionTipoProfissionalIdGet**](TipoProfissionalApi.md#apiVversionTipoProfissionalIdGet) | **GET** /api/v{version}/TipoProfissional/{id} | 
[**apiVversionTipoProfissionalNewPost**](TipoProfissionalApi.md#apiVversionTipoProfissionalNewPost) | **POST** /api/v{version}/TipoProfissional/new | 
[**apiVversionTipoProfissionalUpdatePut**](TipoProfissionalApi.md#apiVversionTipoProfissionalUpdatePut) | **PUT** /api/v{version}/TipoProfissional/update | 

<a name="apiVversionTipoProfissionalAllGet"></a>
# **apiVversionTipoProfissionalAllGet**
> apiVversionTipoProfissionalAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoProfissionalApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionTipoProfissionalAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling TipoProfissionalApi#apiVversionTipoProfissionalAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoProfissionalApi#apiVversionTipoProfissionalAllGet")
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

<a name="apiVversionTipoProfissionalDeleteIdLastUpdateDelete"></a>
# **apiVversionTipoProfissionalDeleteIdLastUpdateDelete**
> apiVversionTipoProfissionalDeleteIdLastUpdateDelete(id, lastUpdate, version, outroid)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoProfissionalApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
val outroid : kotlin.Int = 56 // kotlin.Int | 
try {
    apiInstance.apiVversionTipoProfissionalDeleteIdLastUpdateDelete(id, lastUpdate, version, outroid)
} catch (e: ClientException) {
    println("4xx response calling TipoProfissionalApi#apiVversionTipoProfissionalDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoProfissionalApi#apiVversionTipoProfissionalDeleteIdLastUpdateDelete")
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

<a name="apiVversionTipoProfissionalIdGet"></a>
# **apiVversionTipoProfissionalIdGet**
> apiVversionTipoProfissionalIdGet(id, version, outroid)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoProfissionalApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
val outroid : kotlin.Int = 56 // kotlin.Int | 
try {
    apiInstance.apiVversionTipoProfissionalIdGet(id, version, outroid)
} catch (e: ClientException) {
    println("4xx response calling TipoProfissionalApi#apiVversionTipoProfissionalIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoProfissionalApi#apiVversionTipoProfissionalIdGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.Int**|  |
 **version** | **kotlin.String**|  |
 **outroid** | **kotlin.Int**|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="apiVversionTipoProfissionalNewPost"></a>
# **apiVversionTipoProfissionalNewPost**
> apiVversionTipoProfissionalNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoProfissionalApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateTipoProfissionalRequestContract =  // CreateTipoProfissionalRequestContract | 
try {
    apiInstance.apiVversionTipoProfissionalNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling TipoProfissionalApi#apiVversionTipoProfissionalNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoProfissionalApi#apiVversionTipoProfissionalNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateTipoProfissionalRequestContract**](CreateTipoProfissionalRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionTipoProfissionalUpdatePut"></a>
# **apiVversionTipoProfissionalUpdatePut**
> apiVversionTipoProfissionalUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoProfissionalApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateTipoProfissionalRequestContract =  // UpdateTipoProfissionalRequestContract | 
try {
    apiInstance.apiVversionTipoProfissionalUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling TipoProfissionalApi#apiVversionTipoProfissionalUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoProfissionalApi#apiVversionTipoProfissionalUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateTipoProfissionalRequestContract**](UpdateTipoProfissionalRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

