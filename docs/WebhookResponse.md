# eZmaxApi.Model.WebhookResponse
A webhook object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PkiWebhookID** | **int** | The Webhook ID. This value is visible in the admin interface. | 
**EWebhookModule** | **string** | The Module generating the Event. | 
**EWebhookEzsignevent** | **string** | This Ezsign Event. This property will be set only if the Module is \&quot;Ezsign\&quot;. | [optional] 
**PksCustomerCode** | **string** | The customer code assigned to your account | 
**SWebhookUrl** | **string** | The url being called | 
**SWebhookEmailfailed** | **string** | The email that will receive the webhook in case all attempts fail. | 
**EWebhookManagementevent** | **string** | This Management Event. This property will be set only if the Module is \&quot;Management\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

