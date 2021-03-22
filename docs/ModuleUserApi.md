# eZmaxApi.Api.ModuleUserApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserCreateEzsignuserV1**](ModuleUserApi.md#usercreateezsignuserv1) | **POST** /1/module/user/createezsignuser | Create a new User of type Ezsignuser


<a name="usercreateezsignuserv1"></a>
# **UserCreateEzsignuserV1**
> UserCreateEzsignuserV1Response UserCreateEzsignuserV1 (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request)

Create a new User of type Ezsignuser

The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class UserCreateEzsignuserV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleUserApi(config);
            var userCreateEzsignuserV1Request = new List<UserCreateEzsignuserV1Request>(); // List<UserCreateEzsignuserV1Request> | 

            try
            {
                // Create a new User of type Ezsignuser
                UserCreateEzsignuserV1Response result = apiInstance.UserCreateEzsignuserV1(userCreateEzsignuserV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleUserApi.UserCreateEzsignuserV1: " + e.Message );
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
 **userCreateEzsignuserV1Request** | [**List&lt;UserCreateEzsignuserV1Request&gt;**](UserCreateEzsignuserV1Request.md)|  | 

### Return type

[**UserCreateEzsignuserV1Response**](UserCreateEzsignuserV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

