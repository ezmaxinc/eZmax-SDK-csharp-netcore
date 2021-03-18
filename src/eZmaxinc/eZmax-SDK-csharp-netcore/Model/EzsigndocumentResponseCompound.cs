/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.37
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp-netcore.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Model
{
    /// <summary>
    /// An Ezsigndocument Object and children to create a complete structure
    /// </summary>
    [DataContract(Name = "ezsigndocument-ResponseCompound")]
    public partial class EzsigndocumentResponseCompound : IEquatable<EzsigndocumentResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentResponseCompound" /> class.
        /// </summary>
        /// <param name="fkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsigndocumentDuedate">The maximum date and time at which the document can be signed. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEzsigndocumentName">The name of the document that will be presented to Ezsignfoldersignerassociations (required).</param>
        /// <param name="pkiEzsigndocumentID">The unique ID of the Ezsigntemplate (required).</param>
        /// <param name="eEzsigndocumentStep">eEzsigndocumentStep (required).</param>
        /// <param name="dtEzsigndocumentFirstsend">The date and time when the Ezsigndocument was first sent. (required).</param>
        /// <param name="dtEzsigndocumentLastsend">The date and time when the Ezsigndocument was sent the last time. (required).</param>
        /// <param name="iEzsigndocumentOrder">The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder. (required).</param>
        /// <param name="iEzsigndocumentPagetotal">The number of pages in the Ezsigndocument. (required).</param>
        /// <param name="iEzsigndocumentSignaturesigned">The number of signatures that were signed in the document. (required).</param>
        /// <param name="iEzsigndocumentSignaturetotal">The number of total signatures that were requested in the Ezsigndocument. (required).</param>
        /// <param name="sEzsigndocumentMD5initial">MD5 Hash of the initial PDF Document before signatures were applied to it. (required).</param>
        /// <param name="sEzsigndocumentMD5signed">MD5 Hash of the final PDF Document after all signatures were applied to it. (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public EzsigndocumentResponseCompound(int fkiEzsignfolderID = default(int), string dtEzsigndocumentDuedate = default(string), int fkiLanguageID = default(int), string sEzsigndocumentName = default(string), int pkiEzsigndocumentID = default(int), FieldEEzsigndocumentStep eEzsigndocumentStep = default(FieldEEzsigndocumentStep), string dtEzsigndocumentFirstsend = default(string), string dtEzsigndocumentLastsend = default(string), int iEzsigndocumentOrder = default(int), int iEzsigndocumentPagetotal = default(int), int iEzsigndocumentSignaturesigned = default(int), int iEzsigndocumentSignaturetotal = default(int), string sEzsigndocumentMD5initial = default(string), string sEzsigndocumentMD5signed = default(string), CommonAudit objAudit = default(CommonAudit))
        {
            this.fkiEzsignfolderID = fkiEzsignfolderID;
            // to ensure "dtEzsigndocumentDuedate" is required (not null)
            this.dtEzsigndocumentDuedate = dtEzsigndocumentDuedate ?? throw new ArgumentNullException("dtEzsigndocumentDuedate is a required property for EzsigndocumentResponseCompound and cannot be null");
            this.fkiLanguageID = fkiLanguageID;
            // to ensure "sEzsigndocumentName" is required (not null)
            this.sEzsigndocumentName = sEzsigndocumentName ?? throw new ArgumentNullException("sEzsigndocumentName is a required property for EzsigndocumentResponseCompound and cannot be null");
            this.pkiEzsigndocumentID = pkiEzsigndocumentID;
            // to ensure "eEzsigndocumentStep" is required (not null)
            this.eEzsigndocumentStep = eEzsigndocumentStep ?? throw new ArgumentNullException("eEzsigndocumentStep is a required property for EzsigndocumentResponseCompound and cannot be null");
            // to ensure "dtEzsigndocumentFirstsend" is required (not null)
            this.dtEzsigndocumentFirstsend = dtEzsigndocumentFirstsend ?? throw new ArgumentNullException("dtEzsigndocumentFirstsend is a required property for EzsigndocumentResponseCompound and cannot be null");
            // to ensure "dtEzsigndocumentLastsend" is required (not null)
            this.dtEzsigndocumentLastsend = dtEzsigndocumentLastsend ?? throw new ArgumentNullException("dtEzsigndocumentLastsend is a required property for EzsigndocumentResponseCompound and cannot be null");
            this.iEzsigndocumentOrder = iEzsigndocumentOrder;
            this.iEzsigndocumentPagetotal = iEzsigndocumentPagetotal;
            this.iEzsigndocumentSignaturesigned = iEzsigndocumentSignaturesigned;
            this.iEzsigndocumentSignaturetotal = iEzsigndocumentSignaturetotal;
            // to ensure "sEzsigndocumentMD5initial" is required (not null)
            this.sEzsigndocumentMD5initial = sEzsigndocumentMD5initial ?? throw new ArgumentNullException("sEzsigndocumentMD5initial is a required property for EzsigndocumentResponseCompound and cannot be null");
            // to ensure "sEzsigndocumentMD5signed" is required (not null)
            this.sEzsigndocumentMD5signed = sEzsigndocumentMD5signed ?? throw new ArgumentNullException("sEzsigndocumentMD5signed is a required property for EzsigndocumentResponseCompound and cannot be null");
            // to ensure "objAudit" is required (not null)
            this.objAudit = objAudit ?? throw new ArgumentNullException("objAudit is a required property for EzsigndocumentResponseCompound and cannot be null");
        }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name = "fkiEzsignfolderID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiEzsignfolderID { get; set; }

        /// <summary>
        /// The maximum date and time at which the document can be signed.
        /// </summary>
        /// <value>The maximum date and time at which the document can be signed.</value>
        [DataMember(Name = "dtEzsigndocumentDuedate", IsRequired = true, EmitDefaultValue = false)]
        public string dtEzsigndocumentDuedate { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// The name of the document that will be presented to Ezsignfoldersignerassociations
        /// </summary>
        /// <value>The name of the document that will be presented to Ezsignfoldersignerassociations</value>
        [DataMember(Name = "sEzsigndocumentName", IsRequired = true, EmitDefaultValue = false)]
        public string sEzsigndocumentName { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name = "pkiEzsigndocumentID", IsRequired = true, EmitDefaultValue = false)]
        public int pkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Gets or Sets eEzsigndocumentStep
        /// </summary>
        [DataMember(Name = "eEzsigndocumentStep", IsRequired = true, EmitDefaultValue = false)]
        public FieldEEzsigndocumentStep eEzsigndocumentStep { get; set; }

        /// <summary>
        /// The date and time when the Ezsigndocument was first sent.
        /// </summary>
        /// <value>The date and time when the Ezsigndocument was first sent.</value>
        [DataMember(Name = "dtEzsigndocumentFirstsend", IsRequired = true, EmitDefaultValue = false)]
        public string dtEzsigndocumentFirstsend { get; set; }

        /// <summary>
        /// The date and time when the Ezsigndocument was sent the last time.
        /// </summary>
        /// <value>The date and time when the Ezsigndocument was sent the last time.</value>
        [DataMember(Name = "dtEzsigndocumentLastsend", IsRequired = true, EmitDefaultValue = false)]
        public string dtEzsigndocumentLastsend { get; set; }

        /// <summary>
        /// The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder.
        /// </summary>
        /// <value>The order in which the Ezsigndocument will be presented to the signatory in the Ezsignfolder.</value>
        [DataMember(Name = "iEzsigndocumentOrder", IsRequired = true, EmitDefaultValue = false)]
        public int iEzsigndocumentOrder { get; set; }

        /// <summary>
        /// The number of pages in the Ezsigndocument.
        /// </summary>
        /// <value>The number of pages in the Ezsigndocument.</value>
        [DataMember(Name = "iEzsigndocumentPagetotal", IsRequired = true, EmitDefaultValue = false)]
        public int iEzsigndocumentPagetotal { get; set; }

        /// <summary>
        /// The number of signatures that were signed in the document.
        /// </summary>
        /// <value>The number of signatures that were signed in the document.</value>
        [DataMember(Name = "iEzsigndocumentSignaturesigned", IsRequired = true, EmitDefaultValue = false)]
        public int iEzsigndocumentSignaturesigned { get; set; }

        /// <summary>
        /// The number of total signatures that were requested in the Ezsigndocument.
        /// </summary>
        /// <value>The number of total signatures that were requested in the Ezsigndocument.</value>
        [DataMember(Name = "iEzsigndocumentSignaturetotal", IsRequired = true, EmitDefaultValue = false)]
        public int iEzsigndocumentSignaturetotal { get; set; }

        /// <summary>
        /// MD5 Hash of the initial PDF Document before signatures were applied to it.
        /// </summary>
        /// <value>MD5 Hash of the initial PDF Document before signatures were applied to it.</value>
        [DataMember(Name = "sEzsigndocumentMD5initial", IsRequired = true, EmitDefaultValue = false)]
        public string sEzsigndocumentMD5initial { get; set; }

        /// <summary>
        /// MD5 Hash of the final PDF Document after all signatures were applied to it.
        /// </summary>
        /// <value>MD5 Hash of the final PDF Document after all signatures were applied to it.</value>
        [DataMember(Name = "sEzsigndocumentMD5signed", IsRequired = true, EmitDefaultValue = false)]
        public string sEzsigndocumentMD5signed { get; set; }

        /// <summary>
        /// Gets or Sets objAudit
        /// </summary>
        [DataMember(Name = "objAudit", IsRequired = true, EmitDefaultValue = false)]
        public CommonAudit objAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentResponseCompound {\n");
            sb.Append("  fkiEzsignfolderID: ").Append(fkiEzsignfolderID).Append("\n");
            sb.Append("  dtEzsigndocumentDuedate: ").Append(dtEzsigndocumentDuedate).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sEzsigndocumentName: ").Append(sEzsigndocumentName).Append("\n");
            sb.Append("  pkiEzsigndocumentID: ").Append(pkiEzsigndocumentID).Append("\n");
            sb.Append("  eEzsigndocumentStep: ").Append(eEzsigndocumentStep).Append("\n");
            sb.Append("  dtEzsigndocumentFirstsend: ").Append(dtEzsigndocumentFirstsend).Append("\n");
            sb.Append("  dtEzsigndocumentLastsend: ").Append(dtEzsigndocumentLastsend).Append("\n");
            sb.Append("  iEzsigndocumentOrder: ").Append(iEzsigndocumentOrder).Append("\n");
            sb.Append("  iEzsigndocumentPagetotal: ").Append(iEzsigndocumentPagetotal).Append("\n");
            sb.Append("  iEzsigndocumentSignaturesigned: ").Append(iEzsigndocumentSignaturesigned).Append("\n");
            sb.Append("  iEzsigndocumentSignaturetotal: ").Append(iEzsigndocumentSignaturetotal).Append("\n");
            sb.Append("  sEzsigndocumentMD5initial: ").Append(sEzsigndocumentMD5initial).Append("\n");
            sb.Append("  sEzsigndocumentMD5signed: ").Append(sEzsigndocumentMD5signed).Append("\n");
            sb.Append("  objAudit: ").Append(objAudit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsigndocumentResponseCompound);
        }

        /// <summary>
        /// Returns true if EzsigndocumentResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentResponseCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiEzsignfolderID == input.fkiEzsignfolderID ||
                    this.fkiEzsignfolderID.Equals(input.fkiEzsignfolderID)
                ) && 
                (
                    this.dtEzsigndocumentDuedate == input.dtEzsigndocumentDuedate ||
                    (this.dtEzsigndocumentDuedate != null &&
                    this.dtEzsigndocumentDuedate.Equals(input.dtEzsigndocumentDuedate))
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    this.fkiLanguageID.Equals(input.fkiLanguageID)
                ) && 
                (
                    this.sEzsigndocumentName == input.sEzsigndocumentName ||
                    (this.sEzsigndocumentName != null &&
                    this.sEzsigndocumentName.Equals(input.sEzsigndocumentName))
                ) && 
                (
                    this.pkiEzsigndocumentID == input.pkiEzsigndocumentID ||
                    this.pkiEzsigndocumentID.Equals(input.pkiEzsigndocumentID)
                ) && 
                (
                    this.eEzsigndocumentStep == input.eEzsigndocumentStep ||
                    (this.eEzsigndocumentStep != null &&
                    this.eEzsigndocumentStep.Equals(input.eEzsigndocumentStep))
                ) && 
                (
                    this.dtEzsigndocumentFirstsend == input.dtEzsigndocumentFirstsend ||
                    (this.dtEzsigndocumentFirstsend != null &&
                    this.dtEzsigndocumentFirstsend.Equals(input.dtEzsigndocumentFirstsend))
                ) && 
                (
                    this.dtEzsigndocumentLastsend == input.dtEzsigndocumentLastsend ||
                    (this.dtEzsigndocumentLastsend != null &&
                    this.dtEzsigndocumentLastsend.Equals(input.dtEzsigndocumentLastsend))
                ) && 
                (
                    this.iEzsigndocumentOrder == input.iEzsigndocumentOrder ||
                    this.iEzsigndocumentOrder.Equals(input.iEzsigndocumentOrder)
                ) && 
                (
                    this.iEzsigndocumentPagetotal == input.iEzsigndocumentPagetotal ||
                    this.iEzsigndocumentPagetotal.Equals(input.iEzsigndocumentPagetotal)
                ) && 
                (
                    this.iEzsigndocumentSignaturesigned == input.iEzsigndocumentSignaturesigned ||
                    this.iEzsigndocumentSignaturesigned.Equals(input.iEzsigndocumentSignaturesigned)
                ) && 
                (
                    this.iEzsigndocumentSignaturetotal == input.iEzsigndocumentSignaturetotal ||
                    this.iEzsigndocumentSignaturetotal.Equals(input.iEzsigndocumentSignaturetotal)
                ) && 
                (
                    this.sEzsigndocumentMD5initial == input.sEzsigndocumentMD5initial ||
                    (this.sEzsigndocumentMD5initial != null &&
                    this.sEzsigndocumentMD5initial.Equals(input.sEzsigndocumentMD5initial))
                ) && 
                (
                    this.sEzsigndocumentMD5signed == input.sEzsigndocumentMD5signed ||
                    (this.sEzsigndocumentMD5signed != null &&
                    this.sEzsigndocumentMD5signed.Equals(input.sEzsigndocumentMD5signed))
                ) && 
                (
                    this.objAudit == input.objAudit ||
                    (this.objAudit != null &&
                    this.objAudit.Equals(input.objAudit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.fkiEzsignfolderID.GetHashCode();
                if (this.dtEzsigndocumentDuedate != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentDuedate.GetHashCode();
                hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sEzsigndocumentName != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentName.GetHashCode();
                hashCode = hashCode * 59 + this.pkiEzsigndocumentID.GetHashCode();
                if (this.eEzsigndocumentStep != null)
                    hashCode = hashCode * 59 + this.eEzsigndocumentStep.GetHashCode();
                if (this.dtEzsigndocumentFirstsend != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentFirstsend.GetHashCode();
                if (this.dtEzsigndocumentLastsend != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentLastsend.GetHashCode();
                hashCode = hashCode * 59 + this.iEzsigndocumentOrder.GetHashCode();
                hashCode = hashCode * 59 + this.iEzsigndocumentPagetotal.GetHashCode();
                hashCode = hashCode * 59 + this.iEzsigndocumentSignaturesigned.GetHashCode();
                hashCode = hashCode * 59 + this.iEzsigndocumentSignaturetotal.GetHashCode();
                if (this.sEzsigndocumentMD5initial != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentMD5initial.GetHashCode();
                if (this.sEzsigndocumentMD5signed != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentMD5signed.GetHashCode();
                if (this.objAudit != null)
                    hashCode = hashCode * 59 + this.objAudit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // fkiLanguageID (int) maximum
            if(this.fkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value less than or equal to 2.", new [] { "fkiLanguageID" });
            }

            // fkiLanguageID (int) minimum
            if(this.fkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value greater than or equal to 1.", new [] { "fkiLanguageID" });
            }

            yield break;
        }
    }

}
