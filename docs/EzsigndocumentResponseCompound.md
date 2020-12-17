# eZmaxinc/eZmax-SDK-csharp-netcore.Model.EzsigndocumentResponseCompound
An Ezsigndocument Object and children to create a complete structure
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**fkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**dtEzsigndocumentDuedate** | **string** | The maximum date and time at which the document can be signed. | 
**fkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**sEzsigndocumentFilename** | **string** | The actual file name that will be used when downloading or attaching to an email. | 
**sEzsigndocumentName** | **string** | The name of the document that will be presented to Ezsignfoldersignerassociations | 
**pkiEzsigndocumentID** | **int** | The unique ID of the Ezsigntemplate | 
**eEzsigndocumentStep** | [**FieldEEzsigndocumentStep**](FieldEEzsigndocumentStep.md) |  | 
**dtEzsigndocumentFirstsend** | **string** | The date and time when the Ezsigndocument was first sent. | 
**dtEzsigndocumentLastsend** | **string** | The date and time when the Ezsigndocument was sent the last time. | 
**iEzsigndocumentOrder** | **int** | The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder. | 
**iEzsigndocumentPagetotal** | **int** | The number of pages in the Ezsigndocument. | 
**iEzsigndocumentSignaturesigned** | **int** | The number of signatures that were signed in the document. | 
**iEzsigndocumentSignaturetotal** | **int** | The number of total signatures that were requested in the Ezsigndocument. | 
**sEzsigndocumentMD5initial** | **string** | MD5 Hash of the initial PDF Document before signatures were applied to it. | 
**sEzsigndocumentMD5signed** | **string** | MD5 Hash of the final PDF Document after all signatures were applied to it. | 
**fkiUserIDCreated** | **int** | The id of the User that created the object. | 
**fkiUserIDModified** | **int** | The id of the User that made the last modification on the object. | 
**fkiApikeyIDCreated** | **int** | The id of the API Key that created the object. | [optional] 
**fkiApikeyIDModified** | **int** | The id of the API Key that made the last modification on the object. | [optional] 
**dtCreatedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 
**dtModifiedDate** | **string** | Represent a Date Time. The timezone is the one configured in the User&#39;s profile. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

