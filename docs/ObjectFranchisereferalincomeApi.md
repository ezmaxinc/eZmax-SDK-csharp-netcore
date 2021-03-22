# eZmaxApi.Api.ObjectFranchisereferalincomeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FranchisereferalincomeCreateObjectV1**](ObjectFranchisereferalincomeApi.md#franchisereferalincomecreateobjectv1) | **POST** /1/object/franchisereferalincome | Create a new Franchisereferalincome


<a name="franchisereferalincomecreateobjectv1"></a>
# **FranchisereferalincomeCreateObjectV1**
> FranchisereferalincomeCreateObjectV1Response FranchisereferalincomeCreateObjectV1 (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request)

Create a new Franchisereferalincome

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
    public class FranchisereferalincomeCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectFranchisereferalincomeApi(config);
            var franchisereferalincomeCreateObjectV1Request = new List<FranchisereferalincomeCreateObjectV1Request>(); // List<FranchisereferalincomeCreateObjectV1Request> | 

            try
            {
                // Create a new Franchisereferalincome
                FranchisereferalincomeCreateObjectV1Response result = apiInstance.FranchisereferalincomeCreateObjectV1(franchisereferalincomeCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ObjectFranchisereferalincomeApi.FranchisereferalincomeCreateObjectV1: " + e.Message );
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
 **franchisereferalincomeCreateObjectV1Request** | [**List&lt;FranchisereferalincomeCreateObjectV1Request&gt;**](FranchisereferalincomeCreateObjectV1Request.md)|  | 

### Return type

[**FranchisereferalincomeCreateObjectV1Response**](FranchisereferalincomeCreateObjectV1Response.md)

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

