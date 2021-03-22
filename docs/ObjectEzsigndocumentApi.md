# eZmaxApi.Api.ObjectEzsigndocumentApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsigndocumentApplyEzsigntemplateV1**](ObjectEzsigndocumentApi.md#ezsigndocumentapplyezsigntemplatev1) | **POST** /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyezsigntemplate | Apply an Ezsign Template to the Ezsigndocument.
[**EzsigndocumentCreateObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentcreateobjectv1) | **POST** /1/object/ezsigndocument | Create a new Ezsigndocument
[**EzsigndocumentDeleteObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentdeleteobjectv1) | **DELETE** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Delete an existing Ezsigndocument
[**EzsigndocumentGetChildrenV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetchildrenv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getChildren | Retrieve an existing Ezsigndocument&#39;s children IDs
[**EzsigndocumentGetDownloadUrlV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetdownloadurlv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getDownloadUrl/{eDocumentType} | Retrieve a URL to download documents.
[**EzsigndocumentGetObjectV1**](ObjectEzsigndocumentApi.md#ezsigndocumentgetobjectv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument


<a name="ezsigndocumentapplyezsigntemplatev1"></a>
# **EzsigndocumentApplyEzsigntemplateV1**
> EzsigndocumentApplyEzsigntemplateV1Response EzsigndocumentApplyEzsigntemplateV1 (int pkiEzsigndocumentID, EzsigndocumentApplyEzsigntemplateV1Request ezsigndocumentApplyEzsigntemplateV1Request)

Apply an Ezsign Template to the Ezsigndocument.

This endpoint applies a predefined template to the ezsign document. This allows to automatically apply all the form and signature fields on a document in a single step.  The document must not already have fields otherwise an error will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentApplyEzsigntemplateV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | The unique ID of the Ezsigndocument
            var ezsigndocumentApplyEzsigntemplateV1Request = new EzsigndocumentApplyEzsigntemplateV1Request(); // EzsigndocumentApplyEzsigntemplateV1Request | 

            try
            {
                // Apply an Ezsign Template to the Ezsigndocument.
                EzsigndocumentApplyEzsigntemplateV1Response result = apiInstance.EzsigndocumentApplyEzsigntemplateV1(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentApplyEzsigntemplateV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsigndocumentID** | **int**| The unique ID of the Ezsigndocument | 
 **ezsigndocumentApplyEzsigntemplateV1Request** | [**EzsigndocumentApplyEzsigntemplateV1Request**](EzsigndocumentApplyEzsigntemplateV1Request.md)|  | 

### Return type

[**EzsigndocumentApplyEzsigntemplateV1Response**](EzsigndocumentApplyEzsigntemplateV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ezsigndocumentcreateobjectv1"></a>
# **EzsigndocumentCreateObjectV1**
> EzsigndocumentCreateObjectV1Response EzsigndocumentCreateObjectV1 (List<EzsigndocumentCreateObjectV1Request> ezsigndocumentCreateObjectV1Request)

Create a new Ezsigndocument

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var ezsigndocumentCreateObjectV1Request = new List<EzsigndocumentCreateObjectV1Request>(); // List<EzsigndocumentCreateObjectV1Request> | 

            try
            {
                // Create a new Ezsigndocument
                EzsigndocumentCreateObjectV1Response result = apiInstance.EzsigndocumentCreateObjectV1(ezsigndocumentCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentCreateObjectV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ezsigndocumentCreateObjectV1Request** | [**List&lt;EzsigndocumentCreateObjectV1Request&gt;**](EzsigndocumentCreateObjectV1Request.md)|  | 

### Return type

[**EzsigndocumentCreateObjectV1Response**](EzsigndocumentCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ezsigndocumentdeleteobjectv1"></a>
# **EzsigndocumentDeleteObjectV1**
> EzsigndocumentDeleteObjectV1Response EzsigndocumentDeleteObjectV1 (int pkiEzsigndocumentID)

Delete an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | The unique ID of the Ezsigndocument

            try
            {
                // Delete an existing Ezsigndocument
                EzsigndocumentDeleteObjectV1Response result = apiInstance.EzsigndocumentDeleteObjectV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentDeleteObjectV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsigndocumentID** | **int**| The unique ID of the Ezsigndocument | 

### Return type

[**EzsigndocumentDeleteObjectV1Response**](EzsigndocumentDeleteObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ezsigndocumentgetchildrenv1"></a>
# **EzsigndocumentGetChildrenV1**
> void EzsigndocumentGetChildrenV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument's children IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetChildrenV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | The unique ID of the Ezsigndocument

            try
            {
                // Retrieve an existing Ezsigndocument's children IDs
                apiInstance.EzsigndocumentGetChildrenV1(pkiEzsigndocumentID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetChildrenV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsigndocumentID** | **int**| The unique ID of the Ezsigndocument | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | The element you are trying to work on does not exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ezsigndocumentgetdownloadurlv1"></a>
# **EzsigndocumentGetDownloadUrlV1**
> EzsigndocumentGetDownloadUrlV1Response EzsigndocumentGetDownloadUrlV1 (int pkiEzsigndocumentID, string eDocumentType)

Retrieve a URL to download documents.

This endpoint returns URLs to different files that can be downloaded during the signing process.  These links will expire after 5 minutes so the download of the file should be made soon after retrieving the link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetDownloadUrlV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | The unique ID of the Ezsigndocument
            var eDocumentType = eDocumentType_example;  // string | The type of document to retrieve.  1. **Initial** Is the initial document before any signature were applied. 2. **Signed** Is the final document once all signatures were applied. 3. **Proofdocument** Is the evidence report. 4. **Proof** Is the complete evidence archive including all of the above and more. 

            try
            {
                // Retrieve a URL to download documents.
                EzsigndocumentGetDownloadUrlV1Response result = apiInstance.EzsigndocumentGetDownloadUrlV1(pkiEzsigndocumentID, eDocumentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetDownloadUrlV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsigndocumentID** | **int**| The unique ID of the Ezsigndocument | 
 **eDocumentType** | **string**| The type of document to retrieve.  1. **Initial** Is the initial document before any signature were applied. 2. **Signed** Is the final document once all signatures were applied. 3. **Proofdocument** Is the evidence report. 4. **Proof** Is the complete evidence archive including all of the above and more.  | 

### Return type

[**EzsigndocumentGetDownloadUrlV1Response**](EzsigndocumentGetDownloadUrlV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ezsigndocumentgetobjectv1"></a>
# **EzsigndocumentGetObjectV1**
> EzsigndocumentGetObjectV1Response EzsigndocumentGetObjectV1 (int pkiEzsigndocumentID)

Retrieve an existing Ezsigndocument

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsigndocumentGetObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsigndocumentApi(config);
            var pkiEzsigndocumentID = 56;  // int | The unique ID of the Ezsigndocument

            try
            {
                // Retrieve an existing Ezsigndocument
                EzsigndocumentGetObjectV1Response result = apiInstance.EzsigndocumentGetObjectV1(pkiEzsigndocumentID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectEzsigndocumentApi.EzsigndocumentGetObjectV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsigndocumentID** | **int**| The unique ID of the Ezsigndocument | 

### Return type

[**EzsigndocumentGetObjectV1Response**](EzsigndocumentGetObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

