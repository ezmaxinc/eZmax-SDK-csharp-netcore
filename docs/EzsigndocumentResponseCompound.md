# eZmaxApi.Model.EzsigndocumentResponseCompound
An Ezsigndocument Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiEzsignfolderID** | **int** | The unique ID of the Ezsignfolder | 
**DtEzsigndocumentDuedate** | **string** | The maximum date and time at which the document can be signed. | 
**FkiLanguageID** | **int** | The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| | 
**SEzsigndocumentName** | **string** | The name of the document that will be presented to Ezsignfoldersignerassociations | 
**PkiEzsigndocumentID** | **int** | The unique ID of the Ezsigntemplate | 
**EEzsigndocumentStep** | [**FieldEEzsigndocumentStep**](FieldEEzsigndocumentStep.md) |  | 
**DtEzsigndocumentFirstsend** | **string** | The date and time when the Ezsigndocument was first sent. | 
**DtEzsigndocumentLastsend** | **string** | The date and time when the Ezsigndocument was sent the last time. | 
**IEzsigndocumentOrder** | **int** | The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder. | 
**IEzsigndocumentPagetotal** | **int** | The number of pages in the Ezsigndocument. | 
**IEzsigndocumentSignaturesigned** | **int** | The number of signatures that were signed in the document. | 
**IEzsigndocumentSignaturetotal** | **int** | The number of total signatures that were requested in the Ezsigndocument. | 
**SEzsigndocumentMD5initial** | **string** | MD5 Hash of the initial PDF Document before signatures were applied to it. | 
**SEzsigndocumentMD5signed** | **string** | MD5 Hash of the final PDF Document after all signatures were applied to it. | 
**ObjAudit** | [**CommonAudit**](CommonAudit.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

