# ArtigoConstrucaoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionArtigoConstrucaoAllGet**](ArtigoConstrucaoApi.md#apiVversionArtigoConstrucaoAllGet) | **GET** /api/v{version}/ArtigoConstrucao/all | 
[**apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete**](ArtigoConstrucaoApi.md#apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/ArtigoConstrucao/delete/{id}/{lastUpdate} | 
[**apiVversionArtigoConstrucaoIdGet**](ArtigoConstrucaoApi.md#apiVversionArtigoConstrucaoIdGet) | **GET** /api/v{version}/ArtigoConstrucao/{id} | 
[**apiVversionArtigoConstrucaoNewPost**](ArtigoConstrucaoApi.md#apiVversionArtigoConstrucaoNewPost) | **POST** /api/v{version}/ArtigoConstrucao/new | 
[**apiVversionArtigoConstrucaoUpdatePut**](ArtigoConstrucaoApi.md#apiVversionArtigoConstrucaoUpdatePut) | **PUT** /api/v{version}/ArtigoConstrucao/update | 

<a name="apiVversionArtigoConstrucaoAllGet"></a>
# **apiVversionArtigoConstrucaoAllGet**
> apiVversionArtigoConstrucaoAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ArtigoConstrucaoApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionArtigoConstrucaoAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoAllGet")
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

<a name="apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete"></a>
# **apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete**
> apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ArtigoConstrucaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete")
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

<a name="apiVversionArtigoConstrucaoIdGet"></a>
# **apiVversionArtigoConstrucaoIdGet**
> apiVversionArtigoConstrucaoIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ArtigoConstrucaoApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionArtigoConstrucaoIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoIdGet")
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

<a name="apiVversionArtigoConstrucaoNewPost"></a>
# **apiVversionArtigoConstrucaoNewPost**
> apiVversionArtigoConstrucaoNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ArtigoConstrucaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateArtigoConstrucaoRequestContract =  // CreateArtigoConstrucaoRequestContract | 
try {
    apiInstance.apiVversionArtigoConstrucaoNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateArtigoConstrucaoRequestContract**](CreateArtigoConstrucaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionArtigoConstrucaoUpdatePut"></a>
# **apiVversionArtigoConstrucaoUpdatePut**
> apiVversionArtigoConstrucaoUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ArtigoConstrucaoApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateArtigoConstrucaoRequestContract =  // UpdateArtigoConstrucaoRequestContract | 
try {
    apiInstance.apiVversionArtigoConstrucaoUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ArtigoConstrucaoApi#apiVversionArtigoConstrucaoUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateArtigoConstrucaoRequestContract**](UpdateArtigoConstrucaoRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

