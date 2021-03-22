# eZmaxApi.Model.ContactinformationsRequestCompound
A Contactinformations Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AObjAddress** | [**List&lt;AddressRequest&gt;**](AddressRequest.md) |  | 
**AObjPhone** | [**List&lt;PhoneRequest&gt;**](PhoneRequest.md) |  | 
**AObjEmail** | [**List&lt;EmailRequest&gt;**](EmailRequest.md) |  | 
**AObjWebsite** | [**List&lt;WebsiteRequest&gt;**](WebsiteRequest.md) |  | 
**IAddressDefault** | **int** | The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**IPhoneDefault** | **int** | The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**IEmailDefault** | **int** | The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty. | 
**IWebsiteDefault** | **int** | The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

