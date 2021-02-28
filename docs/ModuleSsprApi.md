# eZmaxinc/eZmax-SDK-csharp-netcore.Api.ModuleSsprApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SsprResetPasswordRequestV1**](ModuleSsprApi.md#ssprresetpasswordrequestv1) | **POST** /1/module/sspr/resetPasswordRequest/ | Reset Password Request
[**SsprResetPasswordV1**](ModuleSsprApi.md#ssprresetpasswordv1) | **POST** /1/module/sspr/resetPassword | Reset Password
[**SsprSendUsernamesV1**](ModuleSsprApi.md#ssprsendusernamesv1) | **POST** /1/module/sspr/sendUsernames | Send username(s)
[**SsprUnlockAccountRequestV1**](ModuleSsprApi.md#ssprunlockaccountrequestv1) | **POST** /1/module/sspr/unlockAccountRequest | Unlock Account Request
[**SsprUnlockAccountV1**](ModuleSsprApi.md#ssprunlockaccountv1) | **POST** /1/module/sspr/unlockAccount | Unlock Account


<a name="ssprresetpasswordrequestv1"></a>
# **SsprResetPasswordRequestV1**
> void SsprResetPasswordRequestV1 (SsprResetPasswordRequestV1Request ssprResetPasswordRequestV1Request)

Reset Password Request

This endpoint sends an email with a link to reset the user's password.  sEmailAddress must be set if eUserTypeSSPR = EzsignUser  sUserLoginname must be set if eUserTypeSSPR = Native

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class SsprResetPasswordRequestV1Example
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
            var ssprResetPasswordRequestV1Request = new SsprResetPasswordRequestV1Request(); // SsprResetPasswordRequestV1Request | 

            try
            {
                // Reset Password Request
                apiInstance.SsprResetPasswordRequestV1(ssprResetPasswordRequestV1Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleSsprApi.SsprResetPasswordRequestV1: " + e.Message );
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
 **ssprResetPasswordRequestV1Request** | [**SsprResetPasswordRequestV1Request**](SsprResetPasswordRequestV1Request.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was accepted.  Do not misinterpret as \&quot;the account exists\&quot;. It only means an email will be sent if (and only if) an account exists. |  -  |
| **403** | You are not allowed to call this function |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssprresetpasswordv1"></a>
# **SsprResetPasswordV1**
> void SsprResetPasswordV1 (SsprResetPasswordV1Request ssprResetPasswordV1Request)

Reset Password

This endpoint resets the user's password.  sEmailAddress must be set if eUserTypeSSPR = EzsignUser  sUserLoginname must be set if eUserTypeSSPR = Native

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class SsprResetPasswordV1Example
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
            var ssprResetPasswordV1Request = new SsprResetPasswordV1Request(); // SsprResetPasswordV1Request | 

            try
            {
                // Reset Password
                apiInstance.SsprResetPasswordV1(ssprResetPasswordV1Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleSsprApi.SsprResetPasswordV1: " + e.Message );
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
 **ssprResetPasswordV1Request** | [**SsprResetPasswordV1Request**](SsprResetPasswordV1Request.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The password was reset Successfully |  -  |
| **403** | You are not allowed to call this function |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssprsendusernamesv1"></a>
# **SsprSendUsernamesV1**
> void SsprSendUsernamesV1 (SsprSendUsernamesV1Request ssprSendUsernamesV1Request)

Send username(s)

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
    public class SsprSendUsernamesV1Example
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
            var ssprSendUsernamesV1Request = new SsprSendUsernamesV1Request(); // SsprSendUsernamesV1Request | 

            try
            {
                // Send username(s)
                apiInstance.SsprSendUsernamesV1(ssprSendUsernamesV1Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleSsprApi.SsprSendUsernamesV1: " + e.Message );
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
 **ssprSendUsernamesV1Request** | [**SsprSendUsernamesV1Request**](SsprSendUsernamesV1Request.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was accepted.  Do not misinterpret as \&quot;the email address has an account attached to it\&quot;. It only means an email will be sent if (and only if) an account exists for that email address. |  -  |
| **403** | You are not allowed to call this function |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssprunlockaccountrequestv1"></a>
# **SsprUnlockAccountRequestV1**
> void SsprUnlockAccountRequestV1 (SsprUnlockAccountRequestV1Request ssprUnlockAccountRequestV1Request)

Unlock Account Request

This endpoint sends an email with a link to unlock the user account.  sEmailAddress must be set if eUserTypeSSPR = EzsignUser  sUserLoginname must be set if eUserTypeSSPR = Native

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class SsprUnlockAccountRequestV1Example
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
            var ssprUnlockAccountRequestV1Request = new SsprUnlockAccountRequestV1Request(); // SsprUnlockAccountRequestV1Request | 

            try
            {
                // Unlock Account Request
                apiInstance.SsprUnlockAccountRequestV1(ssprUnlockAccountRequestV1Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleSsprApi.SsprUnlockAccountRequestV1: " + e.Message );
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
 **ssprUnlockAccountRequestV1Request** | [**SsprUnlockAccountRequestV1Request**](SsprUnlockAccountRequestV1Request.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The request was accepted.  Do not misinterpret as \&quot;the account exists\&quot;. It only means an email will be sent if (and only if) an account exists. |  -  |
| **403** | You are not allowed to call this function |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssprunlockaccountv1"></a>
# **SsprUnlockAccountV1**
> void SsprUnlockAccountV1 (SsprUnlockAccountV1Request ssprUnlockAccountV1Request)

Unlock Account

This endpoint unlocks the user account.  sEmailAddress must be set if eUserTypeSSPR = EzsignUser  sUserLoginname must be set if eUserTypeSSPR = Native

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp-netcore.Api;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace Example
{
    public class SsprUnlockAccountV1Example
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
            var ssprUnlockAccountV1Request = new SsprUnlockAccountV1Request(); // SsprUnlockAccountV1Request | 

            try
            {
                // Unlock Account
                apiInstance.SsprUnlockAccountV1(ssprUnlockAccountV1Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleSsprApi.SsprUnlockAccountV1: " + e.Message );
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
 **ssprUnlockAccountV1Request** | [**SsprUnlockAccountV1Request**](SsprUnlockAccountV1Request.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The account was unlocked Successfully |  -  |
| **403** | You are not allowed to call this function |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

