# eZmaxApi.Model.EzsignsignatureRequest
An Ezsignsignature Object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FkiEzsignfoldersignerassociationID** | **int** | The unique ID of the Ezsignfoldersignerassociation | 
**IEzsignpagePagenumber** | **int** | The page number in the document where to apply the signature | 
**IEzsignsignatureX** | **int** | The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. | 
**IEzsignsignatureY** | **int** | The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. | 
**IEzsignsignatureStep** | **int** | The step when the Ezsignsigner will be invited to sign. | 
**EEzsignsignatureType** | [**FieldEEzsignsignatureType**](FieldEEzsignsignatureType.md) |  | 
**FkiEzsigndocumentID** | **int** | The unique ID of the Ezsigntemplate | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

