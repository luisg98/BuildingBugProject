# PaisApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionPaisAllGet**](PaisApi.md#apiVversionPaisAllGet) | **GET** /api/v{version}/Pais/all | 
[**apiVversionPaisDeleteIdLastUpdateDelete**](PaisApi.md#apiVversionPaisDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Pais/delete/{id}/{lastUpdate} | 
[**apiVversionPaisIdGet**](PaisApi.md#apiVversionPaisIdGet) | **GET** /api/v{version}/Pais/{id} | 
[**apiVversionPaisNewPost**](PaisApi.md#apiVversionPaisNewPost) | **POST** /api/v{version}/Pais/new | 
[**apiVversionPaisUpdatePut**](PaisApi.md#apiVversionPaisUpdatePut) | **PUT** /api/v{version}/Pais/update | 

<a name="apiVversionPaisAllGet"></a>
# **apiVversionPaisAllGet**
> apiVversionPaisAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = PaisApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionPaisAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling PaisApi#apiVversionPaisAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PaisApi#apiVversionPaisAllGet")
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

<a name="apiVversionPaisDeleteIdLastUpdateDelete"></a>
# **apiVversionPaisDeleteIdLastUpdateDelete**
> apiVversionPaisDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = PaisApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionPaisDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling PaisApi#apiVversionPaisDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PaisApi#apiVversionPaisDeleteIdLastUpdateDelete")
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

<a name="apiVversionPaisIdGet"></a>
# **apiVversionPaisIdGet**
> apiVversionPaisIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = PaisApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionPaisIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling PaisApi#apiVversionPaisIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PaisApi#apiVversionPaisIdGet")
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

<a name="apiVversionPaisNewPost"></a>
# **apiVversionPaisNewPost**
> apiVversionPaisNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = PaisApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreatePaisRequestContract =  // CreatePaisRequestContract | 
try {
    apiInstance.apiVversionPaisNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling PaisApi#apiVversionPaisNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PaisApi#apiVversionPaisNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreatePaisRequestContract**](CreatePaisRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionPaisUpdatePut"></a>
# **apiVversionPaisUpdatePut**
> apiVversionPaisUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = PaisApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdatePaisRequestContract =  // UpdatePaisRequestContract | 
try {
    apiInstance.apiVversionPaisUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling PaisApi#apiVversionPaisUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PaisApi#apiVversionPaisUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdatePaisRequestContract**](UpdatePaisRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

