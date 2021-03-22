# eZmaxApi.Model.CommonAudit
Gives informations about the user that created the object and the last user to have modified it.  If the object was never modified after creation, both Created and Modified informations will be the same.  Apikey details will only be provided if the changes were made by an API key.  

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiUserIDCreated** | **int** | The unique ID of the User | 
**FkiUserIDModified** | **int** | The unique ID of the User | 
**FkiApikeyIDCreated** | **int** | The unique ID of the Apikey | [optional] 
**FkiApikeyIDModified** | **int** | The unique ID of the Apikey | [optional] 
**DtCreatedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 
**DtModifiedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

