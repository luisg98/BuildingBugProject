# LocalidadeApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionLocalidadeAllGet**](LocalidadeApi.md#apiVversionLocalidadeAllGet) | **GET** /api/v{version}/Localidade/all | 
[**apiVversionLocalidadeDeleteIdLastUpdateDelete**](LocalidadeApi.md#apiVversionLocalidadeDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Localidade/delete/{id}/{lastUpdate} | 
[**apiVversionLocalidadeIdGet**](LocalidadeApi.md#apiVversionLocalidadeIdGet) | **GET** /api/v{version}/Localidade/{id} | 
[**apiVversionLocalidadeNewPost**](LocalidadeApi.md#apiVversionLocalidadeNewPost) | **POST** /api/v{version}/Localidade/new | 
[**apiVversionLocalidadeUpdatePut**](LocalidadeApi.md#apiVversionLocalidadeUpdatePut) | **PUT** /api/v{version}/Localidade/update | 

<a name="apiVversionLocalidadeAllGet"></a>
# **apiVversionLocalidadeAllGet**
> apiVversionLocalidadeAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = LocalidadeApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionLocalidadeAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling LocalidadeApi#apiVversionLocalidadeAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocalidadeApi#apiVversionLocalidadeAllGet")
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

<a name="apiVversionLocalidadeDeleteIdLastUpdateDelete"></a>
# **apiVversionLocalidadeDeleteIdLastUpdateDelete**
> apiVversionLocalidadeDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = LocalidadeApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionLocalidadeDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling LocalidadeApi#apiVversionLocalidadeDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocalidadeApi#apiVversionLocalidadeDeleteIdLastUpdateDelete")
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

<a name="apiVversionLocalidadeIdGet"></a>
# **apiVversionLocalidadeIdGet**
> apiVversionLocalidadeIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = LocalidadeApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionLocalidadeIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling LocalidadeApi#apiVversionLocalidadeIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocalidadeApi#apiVversionLocalidadeIdGet")
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

<a name="apiVversionLocalidadeNewPost"></a>
# **apiVversionLocalidadeNewPost**
> apiVversionLocalidadeNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = LocalidadeApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateLocalidadeRequestContract =  // CreateLocalidadeRequestContract | 
try {
    apiInstance.apiVversionLocalidadeNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling LocalidadeApi#apiVversionLocalidadeNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocalidadeApi#apiVversionLocalidadeNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateLocalidadeRequestContract**](CreateLocalidadeRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionLocalidadeUpdatePut"></a>
# **apiVversionLocalidadeUpdatePut**
> apiVversionLocalidadeUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = LocalidadeApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateLocalidadeRequestContract =  // UpdateLocalidadeRequestContract | 
try {
    apiInstance.apiVversionLocalidadeUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling LocalidadeApi#apiVversionLocalidadeUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling LocalidadeApi#apiVversionLocalidadeUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateLocalidadeRequestContract**](UpdateLocalidadeRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

