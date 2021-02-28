# eZmaxinc/eZmax-SDK-csharp-netcore.Model.SsprUnlockAccountRequestV1Request
Request for the /1/module/sspr/unlockAccountRequest API Request
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pksCustomerCode** | **string** | The customer code assigned to your account | 
**fkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**eUserTypeSSPR** | [**FieldEUserTypeSSPR**](FieldEUserTypeSSPR.md) |  | 
**sEmailAddress** | **string** | The email address. | [optional] 
**sUserLoginname** | **string** | The Login name of the User. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
