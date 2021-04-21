/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.41
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
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// Request for the /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyezsigntemplate API Request
    /// </summary>
    [DataContract(Name = "ezsigndocument-applyEzsigntemplate-v1-Request")]
    public partial class EzsigndocumentApplyEzsigntemplateV1Request : IEquatable<EzsigndocumentApplyEzsigntemplateV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentApplyEzsigntemplateV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateV1Request" /> class.
        /// </summary>
        /// <param name="fkiEzsigntemplateID">The unique ID of the Ezsigndocument (required).</param>
        /// <param name="aSEzsigntemplatesigner">aSEzsigntemplatesigner (required).</param>
        /// <param name="aPkiEzsignfoldersignerassociationID">aPkiEzsignfoldersignerassociationID (required).</param>
        public EzsigndocumentApplyEzsigntemplateV1Request(int fkiEzsigntemplateID = default(int), List<string> aSEzsigntemplatesigner = default(List<string>), List<int> aPkiEzsignfoldersignerassociationID = default(List<int>))
        {
            this.FkiEzsigntemplateID = fkiEzsigntemplateID;
            // to ensure "aSEzsigntemplatesigner" is required (not null)
            this.ASEzsigntemplatesigner = aSEzsigntemplatesigner ?? throw new ArgumentNullException("aSEzsigntemplatesigner is a required property for EzsigndocumentApplyEzsigntemplateV1Request and cannot be null");
            // to ensure "aPkiEzsignfoldersignerassociationID" is required (not null)
            this.APkiEzsignfoldersignerassociationID = aPkiEzsignfoldersignerassociationID ?? throw new ArgumentNullException("aPkiEzsignfoldersignerassociationID is a required property for EzsigndocumentApplyEzsigntemplateV1Request and cannot be null");
        }

        /// <summary>
        /// The unique ID of the Ezsigndocument
        /// </summary>
        /// <value>The unique ID of the Ezsigndocument</value>
        [DataMember(Name = "fkiEzsigntemplateID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiEzsigntemplateID { get; set; }

        /// <summary>
        /// Gets or Sets ASEzsigntemplatesigner
        /// </summary>
        [DataMember(Name = "a_sEzsigntemplatesigner", IsRequired = true, EmitDefaultValue = false)]
        public List<string> ASEzsigntemplatesigner { get; set; }

        /// <summary>
        /// Gets or Sets APkiEzsignfoldersignerassociationID
        /// </summary>
        [DataMember(Name = "a_pkiEzsignfoldersignerassociationID", IsRequired = true, EmitDefaultValue = false)]
        public List<int> APkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentApplyEzsigntemplateV1Request {\n");
            sb.Append("  FkiEzsigntemplateID: ").Append(FkiEzsigntemplateID).Append("\n");
            sb.Append("  ASEzsigntemplatesigner: ").Append(ASEzsigntemplatesigner).Append("\n");
            sb.Append("  APkiEzsignfoldersignerassociationID: ").Append(APkiEzsignfoldersignerassociationID).Append("\n");
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
            return this.Equals(input as EzsigndocumentApplyEzsigntemplateV1Request);
        }

        /// <summary>
        /// Returns true if EzsigndocumentApplyEzsigntemplateV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentApplyEzsigntemplateV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentApplyEzsigntemplateV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsigntemplateID == input.FkiEzsigntemplateID ||
                    this.FkiEzsigntemplateID.Equals(input.FkiEzsigntemplateID)
                ) && 
                (
                    this.ASEzsigntemplatesigner == input.ASEzsigntemplatesigner ||
                    this.ASEzsigntemplatesigner != null &&
                    input.ASEzsigntemplatesigner != null &&
                    this.ASEzsigntemplatesigner.SequenceEqual(input.ASEzsigntemplatesigner)
                ) && 
                (
                    this.APkiEzsignfoldersignerassociationID == input.APkiEzsignfoldersignerassociationID ||
                    this.APkiEzsignfoldersignerassociationID != null &&
                    input.APkiEzsignfoldersignerassociationID != null &&
                    this.APkiEzsignfoldersignerassociationID.SequenceEqual(input.APkiEzsignfoldersignerassociationID)
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
                hashCode = hashCode * 59 + this.FkiEzsigntemplateID.GetHashCode();
                if (this.ASEzsigntemplatesigner != null)
                    hashCode = hashCode * 59 + this.ASEzsigntemplatesigner.GetHashCode();
                if (this.APkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.APkiEzsignfoldersignerassociationID.GetHashCode();
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
            yield break;
        }
    }

}
