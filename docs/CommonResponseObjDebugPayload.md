# eZmaxApi.Model.CommonResponseObjDebugPayload
This is a debug object containing debugging information on the actual function

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IVersionMin** | **int** | The minimum version of the function that can be called | 
**IVersionMax** | **int** | The maximum version of the function that can be called | 
**ARequiredPermissions** | **List&lt;int&gt;** | An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

