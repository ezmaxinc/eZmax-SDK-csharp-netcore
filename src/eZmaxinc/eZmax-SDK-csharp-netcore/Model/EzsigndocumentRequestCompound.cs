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
    [DataContract(Name = "ezsigndocument-RequestCompound")]
    public partial class EzsigndocumentRequestCompound : IEquatable<EzsigndocumentRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Indicates where to look for the document binary content.
        /// </summary>
        /// <value>Indicates where to look for the document binary content.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EEzsigndocumentSourceEnum
        {
            /// <summary>
            /// Enum Base64 for value: Base64
            /// </summary>
            [EnumMember(Value = "Base64")]
            Base64 = 1

        }

        /// <summary>
        /// Indicates where to look for the document binary content.
        /// </summary>
        /// <value>Indicates where to look for the document binary content.</value>
        [DataMember(Name = "eEzsigndocumentSource", IsRequired = true, EmitDefaultValue = false)]
        public EEzsigndocumentSourceEnum eEzsigndocumentSource { get; set; }
        /// <summary>
        /// Indicates the format of the document.
        /// </summary>
        /// <value>Indicates the format of the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EEzsigndocumentFormatEnum
        {
            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 1

        }

        /// <summary>
        /// Indicates the format of the document.
        /// </summary>
        /// <value>Indicates the format of the document.</value>
        [DataMember(Name = "eEzsigndocumentFormat", IsRequired = true, EmitDefaultValue = false)]
        public EEzsigndocumentFormatEnum eEzsigndocumentFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentRequestCompound" /> class.
        /// </summary>
        /// <param name="eEzsigndocumentSource">Indicates where to look for the document binary content. (required).</param>
        /// <param name="eEzsigndocumentFormat">Indicates the format of the document. (required).</param>
        /// <param name="sEzsigndocumentBase64">The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64..</param>
        /// <param name="fkiEzsignfolderID">A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation. (required).</param>
        /// <param name="dtEzsigndocumentDuedate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEzsigndocumentName">The name of the document that will be presented to Ezsignfoldersignerassociations (required).</param>
        public EzsigndocumentRequestCompound(EEzsigndocumentSourceEnum eEzsigndocumentSource = default(EEzsigndocumentSourceEnum), EEzsigndocumentFormatEnum eEzsigndocumentFormat = default(EEzsigndocumentFormatEnum), byte[] sEzsigndocumentBase64 = default(byte[]), int fkiEzsignfolderID = default(int), string dtEzsigndocumentDuedate = default(string), int fkiLanguageID = default(int), string sEzsigndocumentName = default(string))
        {
            this.eEzsigndocumentSource = eEzsigndocumentSource;
            this.eEzsigndocumentFormat = eEzsigndocumentFormat;
            this.fkiEzsignfolderID = fkiEzsignfolderID;
            // to ensure "dtEzsigndocumentDuedate" is required (not null)
            this.dtEzsigndocumentDuedate = dtEzsigndocumentDuedate ?? throw new ArgumentNullException("dtEzsigndocumentDuedate is a required property for EzsigndocumentRequestCompound and cannot be null");
            this.fkiLanguageID = fkiLanguageID;
            // to ensure "sEzsigndocumentName" is required (not null)
            this.sEzsigndocumentName = sEzsigndocumentName ?? throw new ArgumentNullException("sEzsigndocumentName is a required property for EzsigndocumentRequestCompound and cannot be null");
            this.sEzsigndocumentBase64 = sEzsigndocumentBase64;
        }

        /// <summary>
        /// The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64.
        /// </summary>
        /// <value>The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64.</value>
        [DataMember(Name = "sEzsigndocumentBase64", EmitDefaultValue = false)]
        public byte[] sEzsigndocumentBase64 { get; set; }

        /// <summary>
        /// A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.</value>
        [DataMember(Name = "fkiEzsignfolderID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiEzsignfolderID { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentRequestCompound {\n");
            sb.Append("  eEzsigndocumentSource: ").Append(eEzsigndocumentSource).Append("\n");
            sb.Append("  eEzsigndocumentFormat: ").Append(eEzsigndocumentFormat).Append("\n");
            sb.Append("  sEzsigndocumentBase64: ").Append(sEzsigndocumentBase64).Append("\n");
            sb.Append("  fkiEzsignfolderID: ").Append(fkiEzsignfolderID).Append("\n");
            sb.Append("  dtEzsigndocumentDuedate: ").Append(dtEzsigndocumentDuedate).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sEzsigndocumentName: ").Append(sEzsigndocumentName).Append("\n");
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
            return this.Equals(input as EzsigndocumentRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsigndocumentRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.eEzsigndocumentSource == input.eEzsigndocumentSource ||
                    this.eEzsigndocumentSource.Equals(input.eEzsigndocumentSource)
                ) && 
                (
                    this.eEzsigndocumentFormat == input.eEzsigndocumentFormat ||
                    this.eEzsigndocumentFormat.Equals(input.eEzsigndocumentFormat)
                ) && 
                (
                    this.sEzsigndocumentBase64 == input.sEzsigndocumentBase64 ||
                    (this.sEzsigndocumentBase64 != null &&
                    this.sEzsigndocumentBase64.Equals(input.sEzsigndocumentBase64))
                ) && 
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
                hashCode = hashCode * 59 + this.eEzsigndocumentSource.GetHashCode();
                hashCode = hashCode * 59 + this.eEzsigndocumentFormat.GetHashCode();
                if (this.sEzsigndocumentBase64 != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentBase64.GetHashCode();
                hashCode = hashCode * 59 + this.fkiEzsignfolderID.GetHashCode();
                if (this.dtEzsigndocumentDuedate != null)
                    hashCode = hashCode * 59 + this.dtEzsigndocumentDuedate.GetHashCode();
                hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sEzsigndocumentName != null)
                    hashCode = hashCode * 59 + this.sEzsigndocumentName.GetHashCode();
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
            // fkiEzsignfolderID (int) minimum
            if(this.fkiEzsignfolderID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsignfolderID, must be a value greater than or equal to 1.", new [] { "fkiEzsignfolderID" });
            }

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
