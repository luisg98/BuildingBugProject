# DeslocacaoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionDeslocacaoAllGet**](DeslocacaoApi.md#apiVversionDeslocacaoAllGet) | **GET** /api/v{version}/Deslocacao/all | 
[**apiVversionDeslocacaoDeleteIdLastUpdateDelete**](DeslocacaoApi.md#apiVversionDeslocacaoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/Deslocacao/delete/{id}/{lastUpdate} | 
[**apiVversionDeslocacaoIdGet**](DeslocacaoApi.md#apiVversionDeslocacaoIdGet) | **GET** /api/v{version}/Deslocacao/{id} | 
[**apiVversionDeslocacaoNewPost**](DeslocacaoApi.md#apiVversionDeslocacaoNewPost) | **POST** /api/v{version}/Deslocacao/new | 
[**apiVversionDeslocacaoUpdatePut**](DeslocacaoApi.md#apiVversionDeslocacaoUpdatePut) | **PUT** /api/v{version}/Deslocacao/update | 

<a name="apiVversionDeslocacaoAllGet"></a>
# **apiVversionDeslocacaoAllGet**
> apiVversionDeslocacaoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = DeslocacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionDeslocacaoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling DeslocacaoApi#apiVversionDeslocacaoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeslocacaoApi#apiVversionDeslocacaoAllGet")
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

<a name="apiVversionDeslocacaoDeleteIdLastUpdateDelete"></a>
# **apiVversionDeslocacaoDeleteIdLastUpdateDelete**
> apiVversionDeslocacaoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = DeslocacaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionDeslocacaoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling DeslocacaoApi#apiVversionDeslocacaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeslocacaoApi#apiVversionDeslocacaoDeleteIdLastUpdateDelete")
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

<a name="apiVversionDeslocacaoIdGet"></a>
# **apiVversionDeslocacaoIdGet**
> apiVversionDeslocacaoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = DeslocacaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionDeslocacaoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling DeslocacaoApi#apiVversionDeslocacaoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeslocacaoApi#apiVversionDeslocacaoIdGet")
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

<a name="apiVversionDeslocacaoNewPost"></a>
# **apiVversionDeslocacaoNewPost**
> apiVversionDeslocacaoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = DeslocacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateDeslocacaoRequestContract =  // CreateDeslocacaoRequestContract | 
try {
    apiInstance.apiVversionDeslocacaoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling DeslocacaoApi#apiVversionDeslocacaoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeslocacaoApi#apiVversionDeslocacaoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateDeslocacaoRequestContract**](CreateDeslocacaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionDeslocacaoUpdatePut"></a>
# **apiVversionDeslocacaoUpdatePut**
> apiVversionDeslocacaoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = DeslocacaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateDeslocacaoRequestContract =  // UpdateDeslocacaoRequestContract | 
try {
    apiInstance.apiVversionDeslocacaoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling DeslocacaoApi#apiVversionDeslocacaoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling DeslocacaoApi#apiVversionDeslocacaoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateDeslocacaoRequestContract**](UpdateDeslocacaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

