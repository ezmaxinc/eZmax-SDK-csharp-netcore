# eZmaxApi.Model.EzsignsignerRequestCompoundContact
A Ezsignsigner->Contact Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SContactFirstname** | **string** | The first name of the Contact | 
**SContactLastname** | **string** | The last name of the Contact | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SEmailAddress** | **string** | The email address of the contact. Must be filled if email authentification was requested | [optional] 
**SPhoneNumber** | **string** | The Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany. | [optional] 
**SPhoneNumberCell** | **string** | The Cell Phone number of the contact. Use format \&quot;5149901516\&quot; for North American Numbers (Without \&quot;1\&quot; for long distance code) you would dial like this: 1-514-990-1516. Use format \&quot;498945233886\&quot; for international numbers (Without \&quot;011\&quot;) you would dial like this: +49 89 452 33 88-6. In this example \&quot;49\&quot; is the country code of Germany. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

