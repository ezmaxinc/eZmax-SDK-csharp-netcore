# eZmaxinc/eZmax-SDK-csharp-netcore.Api.ModuleSsprApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SsprRemindUsernamesV1**](ModuleSsprApi.md#ssprremindusernamesv1) | **POST** /1/module/sspr/remindUsernames | Remind of forgotten username(s)


<a name="ssprremindusernamesv1"></a>
# **SsprRemindUsernamesV1**
> void SsprRemindUsernamesV1 ()

Remind of forgotten username(s)

This endpoint returns an email with the username(s) matching the email address provided in case of forgotten username

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class SsprRemindUsernamesV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleSsprApi(config);

            try
            {
                // Remind of forgotten username(s)
                apiInstance.SsprRemindUsernamesV1();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleSsprApi.SsprRemindUsernamesV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
| **204** | The request was accepted.  Do not misinterpret as \&quot;the email address has an account attached to it\&quot;. It only means an email will be sent if (and only if) an account exists for that email address. |  -  |
| **403** | You are not allowed to call this function |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

