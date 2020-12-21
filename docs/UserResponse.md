# eZmaxinc/eZmax-SDK-csharp-netcore.Model.UserResponse
A User Object
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pkiUserID** | **int** | The unique ID of the User | 
**fkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**eUserType** | [**FieldEUserType**](FieldEUserType.md) |  | 
**sUserFirstname** | **string** | The First name of the user | 
**sUserLastname** | **string** | The Last name of the user | 
**sUserLoginname** | **string** | The Login name of the User. | 
**fkiUserIDCreated** | **int** | The id of the User that created the object. | 
**fkiUserIDModified** | **int** | The id of the User that made the last modification on the object. | 
**fkiApikeyIDCreated** | **int** | The id of the API Key that created the object. | [optional] 
**fkiApikeyIDModified** | **int** | The id of the API Key that made the last modification on the object. | [optional] 
**dtCreatedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 
**dtModifiedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

