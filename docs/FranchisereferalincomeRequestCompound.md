# eZmaxApi.Model.FranchisereferalincomeRequestCompound
A Franchisereferalincome Object and children to create a complete structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjAddress** | [**AddressRequest**](AddressRequest.md) |  | [optional] 
**AObjContact** | [**List&lt;ContactRequestCompound&gt;**](ContactRequestCompound.md) |  | 
**FkiFranchisebrokerID** | **int** | The unique ID of the Franchisebroker | 
**FkiFranchisereferalincomeprogramID** | **int** | The unique ID of the Franchisereferalincomeprogram | 
**FkiPeriodID** | **int** | The unique ID of the Period | 
**DFranchisereferalincomeLoan** | **string** | The loan amount | 
**DFranchisereferalincomeFranchiseamount** | **string** | The amount that will be given to the franchise | 
**DFranchisereferalincomeFranchisoramount** | **string** | The amount that will be kept by the franchisor | 
**DFranchisereferalincomeAgentamount** | **string** | The amount that will be given to the agent | 
**DtFranchisereferalincomeDisbursed** | **string** | The date the amounts were disbursed | 
**TFranchisereferalincomeComment** | **string** | A comment about the transaction | 
**FkiFranchiseofficeID** | **int** | The unique ID of the Franchisereoffice | 
**SFranchisereferalincomeRemoteid** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

