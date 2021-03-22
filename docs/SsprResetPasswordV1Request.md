# eZmaxApi.Model.SsprResetPasswordV1Request
Request for the /1/module/sspr/resetPassword API Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PksCustomerCode** | **string** | The customer code assigned to your account | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**EUserTypeSSPR** | [**FieldEUserTypeSSPR**](FieldEUserTypeSSPR.md) |  | 
**SEmailAddress** | **string** | The email address. | [optional] 
**SUserLoginname** | **string** | The Login name of the User. | [optional] 
**BinUserSSPRtoken** | **string** | Hex Encoded Secret SSPR token | 
**SPassword** | **string** | A Password.  Must meet complexity requirements | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

