# eZmaxApi.Api.ModuleAuthenticateApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticateAuthenticateV2**](ModuleAuthenticateApi.md#authenticateauthenticatev2) | **POST** /2/module/authenticate/authenticate/ezsignuser/{eSessionType} | Authenticate a user


<a name="authenticateauthenticatev2"></a>
# **AuthenticateAuthenticateV2**
> AuthenticateAuthenticateV2Response AuthenticateAuthenticateV2 (string eSessionType, AuthenticateAuthenticateV2Request authenticateAuthenticateV2Request)

Authenticate a user

This endpoint authenticates a user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class AuthenticateAuthenticateV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleAuthenticateApi(config);
            var eSessionType = eSessionType_example;  // string | 
            var authenticateAuthenticateV2Request = new AuthenticateAuthenticateV2Request(); // AuthenticateAuthenticateV2Request | 

            try
            {
                // Authenticate a user
                AuthenticateAuthenticateV2Response result = apiInstance.AuthenticateAuthenticateV2(eSessionType, authenticateAuthenticateV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleAuthenticateApi.AuthenticateAuthenticateV2: " + e.Message );
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
 **eSessionType** | **string**|  | 
 **authenticateAuthenticateV2Request** | [**AuthenticateAuthenticateV2Request**](AuthenticateAuthenticateV2Request.md)|  | 

### Return type

[**AuthenticateAuthenticateV2Response**](AuthenticateAuthenticateV2Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

