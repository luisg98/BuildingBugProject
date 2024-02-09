# TipoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionTipoAllGet**](TipoApi.md#apiVversionTipoAllGet) | **GET** /api/v{version}/Tipo/all | 
[**apiVversionTipoDeleteIdLastUpdateDelete**](TipoApi.md#apiVversionTipoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Tipo/delete/{id}/{lastUpdate} | 
[**apiVversionTipoIdGet**](TipoApi.md#apiVversionTipoIdGet) | **GET** /api/v{version}/Tipo/{id} | 
[**apiVversionTipoNewPost**](TipoApi.md#apiVversionTipoNewPost) | **POST** /api/v{version}/Tipo/new | 
[**apiVversionTipoUpdatePut**](TipoApi.md#apiVversionTipoUpdatePut) | **PUT** /api/v{version}/Tipo/update | 

<a name="apiVversionTipoAllGet"></a>
# **apiVversionTipoAllGet**
> apiVversionTipoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionTipoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling TipoApi#apiVversionTipoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoApi#apiVversionTipoAllGet")
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

<a name="apiVversionTipoDeleteIdLastUpdateDelete"></a>
# **apiVversionTipoDeleteIdLastUpdateDelete**
> apiVversionTipoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionTipoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling TipoApi#apiVversionTipoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoApi#apiVversionTipoDeleteIdLastUpdateDelete")
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

<a name="apiVversionTipoIdGet"></a>
# **apiVversionTipoIdGet**
> apiVversionTipoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionTipoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling TipoApi#apiVversionTipoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoApi#apiVversionTipoIdGet")
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

<a name="apiVversionTipoNewPost"></a>
# **apiVversionTipoNewPost**
> apiVversionTipoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateTipoRequestContract =  // CreateTipoRequestContract | 
try {
    apiInstance.apiVversionTipoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling TipoApi#apiVversionTipoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoApi#apiVversionTipoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateTipoRequestContract**](CreateTipoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionTipoUpdatePut"></a>
# **apiVversionTipoUpdatePut**
> apiVversionTipoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = TipoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateTipoRequestContract =  // UpdateTipoRequestContract | 
try {
    apiInstance.apiVversionTipoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling TipoApi#apiVversionTipoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TipoApi#apiVversionTipoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateTipoRequestContract**](UpdateTipoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

