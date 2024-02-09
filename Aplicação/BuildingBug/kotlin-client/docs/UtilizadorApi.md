# UtilizadorApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionUtilizadorAllGet**](UtilizadorApi.md#apiVversionUtilizadorAllGet) | **GET** /api/v{version}/Utilizador/all | 
[**apiVversionUtilizadorDeleteIdLastUpdateDelete**](UtilizadorApi.md#apiVversionUtilizadorDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Utilizador/delete/{id}/{lastUpdate} | 
[**apiVversionUtilizadorIdGet**](UtilizadorApi.md#apiVversionUtilizadorIdGet) | **GET** /api/v{version}/Utilizador/{id} | 
[**apiVversionUtilizadorLoginPost**](UtilizadorApi.md#apiVversionUtilizadorLoginPost) | **POST** /api/v{version}/Utilizador/login | 
[**apiVversionUtilizadorNewPost**](UtilizadorApi.md#apiVversionUtilizadorNewPost) | **POST** /api/v{version}/Utilizador/new | 
[**apiVversionUtilizadorUpdatePut**](UtilizadorApi.md#apiVversionUtilizadorUpdatePut) | **PUT** /api/v{version}/Utilizador/update | 

<a name="apiVversionUtilizadorAllGet"></a>
# **apiVversionUtilizadorAllGet**
> apiVversionUtilizadorAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = UtilizadorApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionUtilizadorAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling UtilizadorApi#apiVversionUtilizadorAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UtilizadorApi#apiVversionUtilizadorAllGet")
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

<a name="apiVversionUtilizadorDeleteIdLastUpdateDelete"></a>
# **apiVversionUtilizadorDeleteIdLastUpdateDelete**
> apiVversionUtilizadorDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = UtilizadorApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionUtilizadorDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling UtilizadorApi#apiVversionUtilizadorDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UtilizadorApi#apiVversionUtilizadorDeleteIdLastUpdateDelete")
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

<a name="apiVversionUtilizadorIdGet"></a>
# **apiVversionUtilizadorIdGet**
> apiVversionUtilizadorIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = UtilizadorApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionUtilizadorIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling UtilizadorApi#apiVversionUtilizadorIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UtilizadorApi#apiVversionUtilizadorIdGet")
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

<a name="apiVversionUtilizadorLoginPost"></a>
# **apiVversionUtilizadorLoginPost**
> apiVversionUtilizadorLoginPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = UtilizadorApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UtilizadorLoginRequestContract =  // UtilizadorLoginRequestContract | 
try {
    apiInstance.apiVversionUtilizadorLoginPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling UtilizadorApi#apiVversionUtilizadorLoginPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UtilizadorApi#apiVversionUtilizadorLoginPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UtilizadorLoginRequestContract**](UtilizadorLoginRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionUtilizadorNewPost"></a>
# **apiVversionUtilizadorNewPost**
> apiVversionUtilizadorNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = UtilizadorApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateUtilizadorRequestContract =  // CreateUtilizadorRequestContract | 
try {
    apiInstance.apiVversionUtilizadorNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling UtilizadorApi#apiVversionUtilizadorNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UtilizadorApi#apiVversionUtilizadorNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateUtilizadorRequestContract**](CreateUtilizadorRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionUtilizadorUpdatePut"></a>
# **apiVversionUtilizadorUpdatePut**
> apiVversionUtilizadorUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = UtilizadorApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateUtilizadorRequestContract =  // UpdateUtilizadorRequestContract | 
try {
    apiInstance.apiVversionUtilizadorUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling UtilizadorApi#apiVversionUtilizadorUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UtilizadorApi#apiVversionUtilizadorUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateUtilizadorRequestContract**](UpdateUtilizadorRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

