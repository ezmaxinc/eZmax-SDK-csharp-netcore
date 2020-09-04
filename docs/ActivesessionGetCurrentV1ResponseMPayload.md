# eZmaxinc/eZmax-SDK-csharp-netcore.Model.ActivesessionGetCurrentV1ResponseMPayload
Payload for the /1/object/activesession/getCurrent API Request
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**sCustomerCode** | **string** | The customer code specific to the client in which the API request is being made | 
**eActivesessionSessiontype** | **string** | The type of session used for the API request call | 
**fkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**sCompanyNameX** | **string** | The name of the active Company in the current language | 
**sDepartmentNameX** | **string** | The name of the active Department in the current language | 
**a_RegisteredModules** | **List&lt;string&gt;** | An Array of Registered modules.  These are the modules that are Licensed to be used by the User or the API Key. | 
**a_Permissions** | **List&lt;int&gt;** | An array of permissions granted to the user or api key | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

