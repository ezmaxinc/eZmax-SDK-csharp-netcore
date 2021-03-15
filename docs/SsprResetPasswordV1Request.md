# eZmaxinc/eZmax-SDK-csharp-netcore.Model.SsprResetPasswordV1Request
Request for the /1/module/sspr/resetPassword API Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pksCustomerCode** | **string** | The customer code assigned to your account | 
**fkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**eUserTypeSSPR** | [**FieldEUserTypeSSPR**](FieldEUserTypeSSPR.md) |  | 
**sEmailAddress** | **string** | The email address. | [optional] 
**sUserLoginname** | **string** | The Login name of the User. | [optional] 
**binUserSSPRtoken** | **string** | Hex Encoded Secret SSPR token | 
**sPassword** | **string** | A Password.  Must meet complexity requirements | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

