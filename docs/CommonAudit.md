# eZmaxinc/eZmax-SDK-csharp-netcore.Model.CommonAudit
Gives informations about the user that created the object and the last user to have modified it.  If the object was never modified after creation, both Created and Modified informations will be the same.  Apikey details will only be provided if the changes were made by an API key.  

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**fkiUserIDCreated** | **int** | The unique ID of the User | 
**fkiUserIDModified** | **int** | The unique ID of the User | 
**fkiApikeyIDCreated** | **int** | The unique ID of the Apikey | [optional] 
**fkiApikeyIDModified** | **int** | The unique ID of the Apikey | [optional] 
**dtCreatedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 
**dtModifiedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

