# eZmaxinc/eZmax-SDK-csharp-netcore.Api.GlobalCustomerApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GlobalCustomerGetEndpointV1**](GlobalCustomerApi.md#globalcustomergetendpointv1) | **GET** /1/customer/{pksCustomerCode}/endpoint | Get customer endpoint


<a name="globalcustomergetendpointv1"></a>
# **GlobalCustomerGetEndpointV1**
> GlobalCustomerGetEndpointV1Response GlobalCustomerGetEndpointV1 (string pksCustomerCode, string sInfrastructureproductCode = null)

Get customer endpoint

Retrieve the customer's specific server endpoint where to send requests. This will help locate the proper region (ie: sInfrastructureregionCode) and the proper environment (ie: sInfrastructureenvironmenttypeDescription) where the customer's data is stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class GlobalCustomerGetEndpointV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GlobalCustomerApi(config);
            var pksCustomerCode = pksCustomerCode_example;  // string | The customer code assigned to your account
            var sInfrastructureproductCode = sInfrastructureproductCode_example;  // string | The infrastructure product Code  If undefined, \"appcluster01\" is assumed (optional) 

            try
            {
                // Get customer endpoint
                GlobalCustomerGetEndpointV1Response result = apiInstance.GlobalCustomerGetEndpointV1(pksCustomerCode, sInfrastructureproductCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalCustomerApi.GlobalCustomerGetEndpointV1: " + e.Message );
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
 **pksCustomerCode** | **string**| The customer code assigned to your account | 
 **sInfrastructureproductCode** | **string**| The infrastructure product Code  If undefined, \&quot;appcluster01\&quot; is assumed | [optional] 

### Return type

[**GlobalCustomerGetEndpointV1Response**](GlobalCustomerGetEndpointV1Response.md)

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

