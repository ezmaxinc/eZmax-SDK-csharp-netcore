# eZmaxinc/eZmax-SDK-csharp-netcore.Api.FranchiseofficeApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FranchiseofficeGetAutocompleteV1**](FranchiseofficeApi.md#franchiseofficegetautocompletev1) | **GET** /1/object/franchiseoffice/getAutocomplete/{sSelector} | Retrieve Franchiseoffices and IDs


<a name="franchiseofficegetautocompletev1"></a>
# **FranchiseofficeGetAutocompleteV1**
> CommonGetAutocompleteV1Response FranchiseofficeGetAutocompleteV1 (string sSelector, string sQuery = null)

Retrieve Franchiseoffices and IDs

Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class FranchiseofficeGetAutocompleteV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FranchiseofficeApi(config);
            var sSelector = sSelector_example;  // string | The type of Franchiseoffices to return
            var sQuery = sQuery_example;  // string | Allow to filter on the option value (optional) 

            try
            {
                // Retrieve Franchiseoffices and IDs
                CommonGetAutocompleteV1Response result = apiInstance.FranchiseofficeGetAutocompleteV1(sSelector, sQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FranchiseofficeApi.FranchiseofficeGetAutocompleteV1: " + e.Message );
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
 **sSelector** | **string**| The type of Franchiseoffices to return | 
 **sQuery** | **string**| Allow to filter on the option value | [optional] 

### Return type

[**CommonGetAutocompleteV1Response**](CommonGetAutocompleteV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

