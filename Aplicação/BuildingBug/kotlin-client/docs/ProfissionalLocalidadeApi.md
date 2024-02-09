# ProfissionalLocalidadeApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionProfissionalLocalidadeAllGet**](ProfissionalLocalidadeApi.md#apiVversionProfissionalLocalidadeAllGet) | **GET** /api/v{version}/ProfissionalLocalidade/all | 
[**apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete**](ProfissionalLocalidadeApi.md#apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/ProfissionalLocalidade/delete/{id}/{lastUpdate} | 
[**apiVversionProfissionalLocalidadeIdGet**](ProfissionalLocalidadeApi.md#apiVversionProfissionalLocalidadeIdGet) | **GET** /api/v{version}/ProfissionalLocalidade/{id} | 
[**apiVversionProfissionalLocalidadeNewPost**](ProfissionalLocalidadeApi.md#apiVversionProfissionalLocalidadeNewPost) | **POST** /api/v{version}/ProfissionalLocalidade/new | 
[**apiVversionProfissionalLocalidadeUpdatePut**](ProfissionalLocalidadeApi.md#apiVversionProfissionalLocalidadeUpdatePut) | **PUT** /api/v{version}/ProfissionalLocalidade/update | 

<a name="apiVversionProfissionalLocalidadeAllGet"></a>
# **apiVversionProfissionalLocalidadeAllGet**
> apiVversionProfissionalLocalidadeAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalLocalidadeApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionProfissionalLocalidadeAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeAllGet")
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

<a name="apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete"></a>
# **apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete**
> apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalLocalidadeApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete")
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

<a name="apiVversionProfissionalLocalidadeIdGet"></a>
# **apiVversionProfissionalLocalidadeIdGet**
> apiVversionProfissionalLocalidadeIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalLocalidadeApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionProfissionalLocalidadeIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeIdGet")
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

<a name="apiVversionProfissionalLocalidadeNewPost"></a>
# **apiVversionProfissionalLocalidadeNewPost**
> apiVversionProfissionalLocalidadeNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalLocalidadeApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateProfissionalLocalidadeRequestContract =  // CreateProfissionalLocalidadeRequestContract | 
try {
    apiInstance.apiVversionProfissionalLocalidadeNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateProfissionalLocalidadeRequestContract**](CreateProfissionalLocalidadeRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionProfissionalLocalidadeUpdatePut"></a>
# **apiVversionProfissionalLocalidadeUpdatePut**
> apiVversionProfissionalLocalidadeUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ProfissionalLocalidadeApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateProfissionalLocalidadeRequestContract =  // UpdateProfissionalLocalidadeRequestContract | 
try {
    apiInstance.apiVversionProfissionalLocalidadeUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ProfissionalLocalidadeApi#apiVversionProfissionalLocalidadeUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateProfissionalLocalidadeRequestContract**](UpdateProfissionalLocalidadeRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

