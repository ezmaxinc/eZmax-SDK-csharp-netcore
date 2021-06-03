/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
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
    /// An Ezsignsignature Object and children to create a complete structure
    /// </summary>
    [DataContract(Name = "ezsignsignature-RequestCompound")]
    public partial class EzsignsignatureRequestCompound : IEquatable<EzsignsignatureRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignatureRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureRequestCompound" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldersignerassociationID">The unique ID of the Ezsignfoldersignerassociation (required).</param>
        /// <param name="iEzsignpagePagenumber">The page number in the document where to apply the signature (required).</param>
        /// <param name="iEzsignsignatureX">The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate. (required).</param>
        /// <param name="iEzsignsignatureY">The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate. (required).</param>
        /// <param name="iEzsignsignatureStep">The step when the Ezsignsigner will be invited to sign. (required).</param>
        /// <param name="eEzsignsignatureType">eEzsignsignatureType (required).</param>
        /// <param name="fkiEzsigndocumentID">The unique ID of the Ezsigntemplate (required).</param>
        public EzsignsignatureRequestCompound(int fkiEzsignfoldersignerassociationID = default(int), int iEzsignpagePagenumber = default(int), int iEzsignsignatureX = default(int), int iEzsignsignatureY = default(int), int iEzsignsignatureStep = default(int), FieldEEzsignsignatureType eEzsignsignatureType = default(FieldEEzsignsignatureType), int fkiEzsigndocumentID = default(int))
        {
            this.FkiEzsignfoldersignerassociationID = fkiEzsignfoldersignerassociationID;
            this.IEzsignpagePagenumber = iEzsignpagePagenumber;
            this.IEzsignsignatureX = iEzsignsignatureX;
            this.IEzsignsignatureY = iEzsignsignatureY;
            this.IEzsignsignatureStep = iEzsignsignatureStep;
            // to ensure "eEzsignsignatureType" is required (not null)
            this.EEzsignsignatureType = eEzsignsignatureType ?? throw new ArgumentNullException("eEzsignsignatureType is a required property for EzsignsignatureRequestCompound and cannot be null");
            this.FkiEzsigndocumentID = fkiEzsigndocumentID;
        }

        /// <summary>
        /// The unique ID of the Ezsignfoldersignerassociation
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldersignerassociation</value>
        [DataMember(Name = "fkiEzsignfoldersignerassociationID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// The page number in the document where to apply the signature
        /// </summary>
        /// <value>The page number in the document where to apply the signature</value>
        [DataMember(Name = "iEzsignpagePagenumber", IsRequired = true, EmitDefaultValue = false)]
        public int IEzsignpagePagenumber { get; set; }

        /// <summary>
        /// The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.
        /// </summary>
        /// <value>The X coordinate (Horizontal) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 2 inches from the left border of the page, you would use \&quot;200\&quot; for the X coordinate.</value>
        [DataMember(Name = "iEzsignsignatureX", IsRequired = true, EmitDefaultValue = false)]
        public int IEzsignsignatureX { get; set; }

        /// <summary>
        /// The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.
        /// </summary>
        /// <value>The Y coordinate (Vertical) where to put the signature block on the page.  Coordinate is calculated at 100dpi (dot per inch). So for example, if you want to put the signature block 3 inches from the top border of the page, you would use \&quot;300\&quot; for the Y coordinate.</value>
        [DataMember(Name = "iEzsignsignatureY", IsRequired = true, EmitDefaultValue = false)]
        public int IEzsignsignatureY { get; set; }

        /// <summary>
        /// The step when the Ezsignsigner will be invited to sign.
        /// </summary>
        /// <value>The step when the Ezsignsigner will be invited to sign.</value>
        [DataMember(Name = "iEzsignsignatureStep", IsRequired = true, EmitDefaultValue = false)]
        public int IEzsignsignatureStep { get; set; }

        /// <summary>
        /// Gets or Sets EEzsignsignatureType
        /// </summary>
        [DataMember(Name = "eEzsignsignatureType", IsRequired = true, EmitDefaultValue = false)]
        public FieldEEzsignsignatureType EEzsignsignatureType { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntemplate
        /// </summary>
        /// <value>The unique ID of the Ezsigntemplate</value>
        [DataMember(Name = "fkiEzsigndocumentID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureRequestCompound {\n");
            sb.Append("  FkiEzsignfoldersignerassociationID: ").Append(FkiEzsignfoldersignerassociationID).Append("\n");
            sb.Append("  IEzsignpagePagenumber: ").Append(IEzsignpagePagenumber).Append("\n");
            sb.Append("  IEzsignsignatureX: ").Append(IEzsignsignatureX).Append("\n");
            sb.Append("  IEzsignsignatureY: ").Append(IEzsignsignatureY).Append("\n");
            sb.Append("  IEzsignsignatureStep: ").Append(IEzsignsignatureStep).Append("\n");
            sb.Append("  EEzsignsignatureType: ").Append(EEzsignsignatureType).Append("\n");
            sb.Append("  FkiEzsigndocumentID: ").Append(FkiEzsigndocumentID).Append("\n");
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
            return this.Equals(input as EzsignsignatureRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsignsignatureRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsignfoldersignerassociationID == input.FkiEzsignfoldersignerassociationID ||
                    this.FkiEzsignfoldersignerassociationID.Equals(input.FkiEzsignfoldersignerassociationID)
                ) && 
                (
                    this.IEzsignpagePagenumber == input.IEzsignpagePagenumber ||
                    this.IEzsignpagePagenumber.Equals(input.IEzsignpagePagenumber)
                ) && 
                (
                    this.IEzsignsignatureX == input.IEzsignsignatureX ||
                    this.IEzsignsignatureX.Equals(input.IEzsignsignatureX)
                ) && 
                (
                    this.IEzsignsignatureY == input.IEzsignsignatureY ||
                    this.IEzsignsignatureY.Equals(input.IEzsignsignatureY)
                ) && 
                (
                    this.IEzsignsignatureStep == input.IEzsignsignatureStep ||
                    this.IEzsignsignatureStep.Equals(input.IEzsignsignatureStep)
                ) && 
                (
                    this.EEzsignsignatureType == input.EEzsignsignatureType ||
                    (this.EEzsignsignatureType != null &&
                    this.EEzsignsignatureType.Equals(input.EEzsignsignatureType))
                ) && 
                (
                    this.FkiEzsigndocumentID == input.FkiEzsigndocumentID ||
                    this.FkiEzsigndocumentID.Equals(input.FkiEzsigndocumentID)
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
                hashCode = hashCode * 59 + this.FkiEzsignfoldersignerassociationID.GetHashCode();
                hashCode = hashCode * 59 + this.IEzsignpagePagenumber.GetHashCode();
                hashCode = hashCode * 59 + this.IEzsignsignatureX.GetHashCode();
                hashCode = hashCode * 59 + this.IEzsignsignatureY.GetHashCode();
                hashCode = hashCode * 59 + this.IEzsignsignatureStep.GetHashCode();
                if (this.EEzsignsignatureType != null)
                    hashCode = hashCode * 59 + this.EEzsignsignatureType.GetHashCode();
                hashCode = hashCode * 59 + this.FkiEzsigndocumentID.GetHashCode();
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
