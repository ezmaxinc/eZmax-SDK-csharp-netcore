/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.
 *
 * The version of the OpenAPI document: 1.0.30
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
    /// An Ezsignfolder Object and children to create a complete structure
    /// </summary>
    [DataContract(Name = "ezsignfolder-RequestCompound")]
    public partial class EzsignfolderRequestCompound : IEquatable<EzsignfolderRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderRequestCompound" /> class.
        /// </summary>
        /// <param name="aEzsignfoldersignerassociation">An array of signers that will be invited to sign the Ezsigndocuments (required).</param>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here. (required).</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="tEzsignfolderNote">Somes extra notes about the eZsign Folder (required).</param>
        /// <param name="eEzsignfolderSendreminderfrequency">eEzsignfolderSendreminderfrequency (required).</param>
        public EzsignfolderRequestCompound(List<EzsignfoldersignerassociationRequest> aEzsignfoldersignerassociation = default(List<EzsignfoldersignerassociationRequest>), int fkiEzsignfoldertypeID = default(int), int fkiEzsigntsarequirementID = default(int), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency = default(FieldEEzsignfolderSendreminderfrequency))
        {
            // to ensure "aEzsignfoldersignerassociation" is required (not null)
            this.a_Ezsignfoldersignerassociation = aEzsignfoldersignerassociation ?? throw new ArgumentNullException("aEzsignfoldersignerassociation is a required property for EzsignfolderRequestCompound and cannot be null");
            this.fkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            this.fkiEzsigntsarequirementID = fkiEzsigntsarequirementID;
            // to ensure "sEzsignfolderDescription" is required (not null)
            this.sEzsignfolderDescription = sEzsignfolderDescription ?? throw new ArgumentNullException("sEzsignfolderDescription is a required property for EzsignfolderRequestCompound and cannot be null");
            // to ensure "tEzsignfolderNote" is required (not null)
            this.tEzsignfolderNote = tEzsignfolderNote ?? throw new ArgumentNullException("tEzsignfolderNote is a required property for EzsignfolderRequestCompound and cannot be null");
            // to ensure "eEzsignfolderSendreminderfrequency" is required (not null)
            this.eEzsignfolderSendreminderfrequency = eEzsignfolderSendreminderfrequency ?? throw new ArgumentNullException("eEzsignfolderSendreminderfrequency is a required property for EzsignfolderRequestCompound and cannot be null");
        }

        /// <summary>
        /// An array of signers that will be invited to sign the Ezsigndocuments
        /// </summary>
        /// <value>An array of signers that will be invited to sign the Ezsigndocuments</value>
        [DataMember(Name = "a_Ezsignfoldersignerassociation", IsRequired = true, EmitDefaultValue = false)]
        public List<EzsignfoldersignerassociationRequest> a_Ezsignfoldersignerassociation { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.</value>
        [DataMember(Name = "fkiEzsignfoldertypeID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|
        /// </summary>
        /// <value>The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|</value>
        [DataMember(Name = "fkiEzsigntsarequirementID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiEzsigntsarequirementID { get; set; }

        /// <summary>
        /// The description of the Ezsign Folder
        /// </summary>
        /// <value>The description of the Ezsign Folder</value>
        [DataMember(Name = "sEzsignfolderDescription", IsRequired = true, EmitDefaultValue = false)]
        public string sEzsignfolderDescription { get; set; }

        /// <summary>
        /// Somes extra notes about the eZsign Folder
        /// </summary>
        /// <value>Somes extra notes about the eZsign Folder</value>
        [DataMember(Name = "tEzsignfolderNote", IsRequired = true, EmitDefaultValue = false)]
        public string tEzsignfolderNote { get; set; }

        /// <summary>
        /// Gets or Sets eEzsignfolderSendreminderfrequency
        /// </summary>
        [DataMember(Name = "eEzsignfolderSendreminderfrequency", IsRequired = true, EmitDefaultValue = false)]
        public FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderRequestCompound {\n");
            sb.Append("  a_Ezsignfoldersignerassociation: ").Append(a_Ezsignfoldersignerassociation).Append("\n");
            sb.Append("  fkiEzsignfoldertypeID: ").Append(fkiEzsignfoldertypeID).Append("\n");
            sb.Append("  fkiEzsigntsarequirementID: ").Append(fkiEzsigntsarequirementID).Append("\n");
            sb.Append("  sEzsignfolderDescription: ").Append(sEzsignfolderDescription).Append("\n");
            sb.Append("  tEzsignfolderNote: ").Append(tEzsignfolderNote).Append("\n");
            sb.Append("  eEzsignfolderSendreminderfrequency: ").Append(eEzsignfolderSendreminderfrequency).Append("\n");
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
            return this.Equals(input as EzsignfolderRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsignfolderRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_Ezsignfoldersignerassociation == input.a_Ezsignfoldersignerassociation ||
                    this.a_Ezsignfoldersignerassociation != null &&
                    input.a_Ezsignfoldersignerassociation != null &&
                    this.a_Ezsignfoldersignerassociation.SequenceEqual(input.a_Ezsignfoldersignerassociation)
                ) && 
                (
                    this.fkiEzsignfoldertypeID == input.fkiEzsignfoldertypeID ||
                    this.fkiEzsignfoldertypeID.Equals(input.fkiEzsignfoldertypeID)
                ) && 
                (
                    this.fkiEzsigntsarequirementID == input.fkiEzsigntsarequirementID ||
                    this.fkiEzsigntsarequirementID.Equals(input.fkiEzsigntsarequirementID)
                ) && 
                (
                    this.sEzsignfolderDescription == input.sEzsignfolderDescription ||
                    (this.sEzsignfolderDescription != null &&
                    this.sEzsignfolderDescription.Equals(input.sEzsignfolderDescription))
                ) && 
                (
                    this.tEzsignfolderNote == input.tEzsignfolderNote ||
                    (this.tEzsignfolderNote != null &&
                    this.tEzsignfolderNote.Equals(input.tEzsignfolderNote))
                ) && 
                (
                    this.eEzsignfolderSendreminderfrequency == input.eEzsignfolderSendreminderfrequency ||
                    (this.eEzsignfolderSendreminderfrequency != null &&
                    this.eEzsignfolderSendreminderfrequency.Equals(input.eEzsignfolderSendreminderfrequency))
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
                if (this.a_Ezsignfoldersignerassociation != null)
                    hashCode = hashCode * 59 + this.a_Ezsignfoldersignerassociation.GetHashCode();
                hashCode = hashCode * 59 + this.fkiEzsignfoldertypeID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiEzsigntsarequirementID.GetHashCode();
                if (this.sEzsignfolderDescription != null)
                    hashCode = hashCode * 59 + this.sEzsignfolderDescription.GetHashCode();
                if (this.tEzsignfolderNote != null)
                    hashCode = hashCode * 59 + this.tEzsignfolderNote.GetHashCode();
                if (this.eEzsignfolderSendreminderfrequency != null)
                    hashCode = hashCode * 59 + this.eEzsignfolderSendreminderfrequency.GetHashCode();
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
            // fkiEzsigntsarequirementID (int) maximum
            if(this.fkiEzsigntsarequirementID > (int)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsigntsarequirementID, must be a value less than or equal to 3.", new [] { "fkiEzsigntsarequirementID" });
            }

            // fkiEzsigntsarequirementID (int) minimum
            if(this.fkiEzsigntsarequirementID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsigntsarequirementID, must be a value greater than or equal to 1.", new [] { "fkiEzsigntsarequirementID" });
            }

            // sEzsignfolderDescription (string) maxLength
            if(this.sEzsignfolderDescription != null && this.sEzsignfolderDescription.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for sEzsignfolderDescription, length must be less than 75.", new [] { "sEzsignfolderDescription" });
            }

            // sEzsignfolderDescription (string) minLength
            if(this.sEzsignfolderDescription != null && this.sEzsignfolderDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for sEzsignfolderDescription, length must be greater than 1.", new [] { "sEzsignfolderDescription" });
            }

            yield break;
        }
    }

}
