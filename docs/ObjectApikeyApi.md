# eZmaxinc/eZmax-SDK-csharp-netcore.Api.ObjectApikeyApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApikeyCreateObjectV1**](ObjectApikeyApi.md#apikeycreateobjectv1) | **POST** /1/object/apikey | Create a new Apikey


<a name="apikeycreateobjectv1"></a>
# **ApikeyCreateObjectV1**
> ApikeyCreateObjectV1Response ApikeyCreateObjectV1 (List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request)

Create a new Apikey

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class ApikeyCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectApikeyApi(config);
            var apikeyCreateObjectV1Request = new List<ApikeyCreateObjectV1Request>(); // List<ApikeyCreateObjectV1Request> | 

            try
            {
                // Create a new Apikey
                ApikeyCreateObjectV1Response result = apiInstance.ApikeyCreateObjectV1(apikeyCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectApikeyApi.ApikeyCreateObjectV1: " + e.Message );
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
 **apikeyCreateObjectV1Request** | [**List&lt;ApikeyCreateObjectV1Request&gt;**](ApikeyCreateObjectV1Request.md)|  | 

### Return type

[**ApikeyCreateObjectV1Response**](ApikeyCreateObjectV1Response.md)

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

