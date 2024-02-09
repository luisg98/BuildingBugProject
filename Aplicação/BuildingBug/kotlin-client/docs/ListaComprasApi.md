# ListaComprasApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiVversionListaComprasAllGet**](ListaComprasApi.md#apiVversionListaComprasAllGet) | **GET** /api/v{version}/ListaCompras/all | 
[**apiVversionListaComprasDeleteIdLastUpdateDelete**](ListaComprasApi.md#apiVversionListaComprasDeleteIdLastUpdateDelete) | **DELETE** /api/v{version}/ListaCompras/delete/{id}/{lastUpdate} | 
[**apiVversionListaComprasIdGet**](ListaComprasApi.md#apiVversionListaComprasIdGet) | **GET** /api/v{version}/ListaCompras/{id} | 
[**apiVversionListaComprasNewPost**](ListaComprasApi.md#apiVversionListaComprasNewPost) | **POST** /api/v{version}/ListaCompras/new | 
[**apiVversionListaComprasUpdatePut**](ListaComprasApi.md#apiVversionListaComprasUpdatePut) | **PUT** /api/v{version}/ListaCompras/update | 

<a name="apiVversionListaComprasAllGet"></a>
# **apiVversionListaComprasAllGet**
> apiVversionListaComprasAllGet(version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasApi()
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionListaComprasAllGet(version)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasApi#apiVversionListaComprasAllGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasApi#apiVversionListaComprasAllGet")
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

<a name="apiVversionListaComprasDeleteIdLastUpdateDelete"></a>
# **apiVversionListaComprasDeleteIdLastUpdateDelete**
> apiVversionListaComprasDeleteIdLastUpdateDelete(id, lastUpdate, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val lastUpdate : java.time.LocalDateTime = 2013-10-20T19:20:30+01:00 // java.time.LocalDateTime | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionListaComprasDeleteIdLastUpdateDelete(id, lastUpdate, version)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasApi#apiVversionListaComprasDeleteIdLastUpdateDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasApi#apiVversionListaComprasDeleteIdLastUpdateDelete")
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

<a name="apiVversionListaComprasIdGet"></a>
# **apiVversionListaComprasIdGet**
> apiVversionListaComprasIdGet(id, version)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasApi()
val id : kotlin.Int = 56 // kotlin.Int | 
val version : kotlin.String = version_example // kotlin.String | 
try {
    apiInstance.apiVversionListaComprasIdGet(id, version)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasApi#apiVversionListaComprasIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasApi#apiVversionListaComprasIdGet")
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

<a name="apiVversionListaComprasNewPost"></a>
# **apiVversionListaComprasNewPost**
> apiVversionListaComprasNewPost(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : CreateListaComprasRequestContract =  // CreateListaComprasRequestContract | 
try {
    apiInstance.apiVversionListaComprasNewPost(version, body)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasApi#apiVversionListaComprasNewPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasApi#apiVversionListaComprasNewPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**CreateListaComprasRequestContract**](CreateListaComprasRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="apiVversionListaComprasUpdatePut"></a>
# **apiVversionListaComprasUpdatePut**
> apiVversionListaComprasUpdatePut(version, body)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ListaComprasApi()
val version : kotlin.String = version_example // kotlin.String | 
val body : UpdateListaComprasRequestContract =  // UpdateListaComprasRequestContract | 
try {
    apiInstance.apiVversionListaComprasUpdatePut(version, body)
} catch (e: ClientException) {
    println("4xx response calling ListaComprasApi#apiVversionListaComprasUpdatePut")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ListaComprasApi#apiVversionListaComprasUpdatePut")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **kotlin.String**|  |
 **body** | [**UpdateListaComprasRequestContract**](UpdateListaComprasRequestContract.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

