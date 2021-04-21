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
    /// An Ezsignfolder Object
    /// </summary>
    [DataContract(Name = "ezsignfolder-Request")]
    public partial class EzsignfolderRequest : IEquatable<EzsignfolderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderRequest" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here. (required).</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="tEzsignfolderNote">Somes extra notes about the eZsign Folder (required).</param>
        /// <param name="eEzsignfolderSendreminderfrequency">eEzsignfolderSendreminderfrequency (required).</param>
        public EzsignfolderRequest(int fkiEzsignfoldertypeID = default(int), int fkiEzsigntsarequirementID = default(int), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency = default(FieldEEzsignfolderSendreminderfrequency))
        {
            this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            this.FkiEzsigntsarequirementID = fkiEzsigntsarequirementID;
            // to ensure "sEzsignfolderDescription" is required (not null)
            this.SEzsignfolderDescription = sEzsignfolderDescription ?? throw new ArgumentNullException("sEzsignfolderDescription is a required property for EzsignfolderRequest and cannot be null");
            // to ensure "tEzsignfolderNote" is required (not null)
            this.TEzsignfolderNote = tEzsignfolderNote ?? throw new ArgumentNullException("tEzsignfolderNote is a required property for EzsignfolderRequest and cannot be null");
            // to ensure "eEzsignfolderSendreminderfrequency" is required (not null)
            this.EEzsignfolderSendreminderfrequency = eEzsignfolderSendreminderfrequency ?? throw new ArgumentNullException("eEzsignfolderSendreminderfrequency is a required property for EzsignfolderRequest and cannot be null");
        }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.</value>
        [DataMember(Name = "fkiEzsignfoldertypeID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|
        /// </summary>
        /// <value>The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|</value>
        [DataMember(Name = "fkiEzsigntsarequirementID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiEzsigntsarequirementID { get; set; }

        /// <summary>
        /// The description of the Ezsign Folder
        /// </summary>
        /// <value>The description of the Ezsign Folder</value>
        [DataMember(Name = "sEzsignfolderDescription", IsRequired = true, EmitDefaultValue = false)]
        public string SEzsignfolderDescription { get; set; }

        /// <summary>
        /// Somes extra notes about the eZsign Folder
        /// </summary>
        /// <value>Somes extra notes about the eZsign Folder</value>
        [DataMember(Name = "tEzsignfolderNote", IsRequired = true, EmitDefaultValue = false)]
        public string TEzsignfolderNote { get; set; }

        /// <summary>
        /// Gets or Sets EEzsignfolderSendreminderfrequency
        /// </summary>
        [DataMember(Name = "eEzsignfolderSendreminderfrequency", IsRequired = true, EmitDefaultValue = false)]
        public FieldEEzsignfolderSendreminderfrequency EEzsignfolderSendreminderfrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderRequest {\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  FkiEzsigntsarequirementID: ").Append(FkiEzsigntsarequirementID).Append("\n");
            sb.Append("  SEzsignfolderDescription: ").Append(SEzsignfolderDescription).Append("\n");
            sb.Append("  TEzsignfolderNote: ").Append(TEzsignfolderNote).Append("\n");
            sb.Append("  EEzsignfolderSendreminderfrequency: ").Append(EEzsignfolderSendreminderfrequency).Append("\n");
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
            return this.Equals(input as EzsignfolderRequest);
        }

        /// <summary>
        /// Returns true if EzsignfolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsignfoldertypeID == input.FkiEzsignfoldertypeID ||
                    this.FkiEzsignfoldertypeID.Equals(input.FkiEzsignfoldertypeID)
                ) && 
                (
                    this.FkiEzsigntsarequirementID == input.FkiEzsigntsarequirementID ||
                    this.FkiEzsigntsarequirementID.Equals(input.FkiEzsigntsarequirementID)
                ) && 
                (
                    this.SEzsignfolderDescription == input.SEzsignfolderDescription ||
                    (this.SEzsignfolderDescription != null &&
                    this.SEzsignfolderDescription.Equals(input.SEzsignfolderDescription))
                ) && 
                (
                    this.TEzsignfolderNote == input.TEzsignfolderNote ||
                    (this.TEzsignfolderNote != null &&
                    this.TEzsignfolderNote.Equals(input.TEzsignfolderNote))
                ) && 
                (
                    this.EEzsignfolderSendreminderfrequency == input.EEzsignfolderSendreminderfrequency ||
                    (this.EEzsignfolderSendreminderfrequency != null &&
                    this.EEzsignfolderSendreminderfrequency.Equals(input.EEzsignfolderSendreminderfrequency))
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
                hashCode = hashCode * 59 + this.FkiEzsignfoldertypeID.GetHashCode();
                hashCode = hashCode * 59 + this.FkiEzsigntsarequirementID.GetHashCode();
                if (this.SEzsignfolderDescription != null)
                    hashCode = hashCode * 59 + this.SEzsignfolderDescription.GetHashCode();
                if (this.TEzsignfolderNote != null)
                    hashCode = hashCode * 59 + this.TEzsignfolderNote.GetHashCode();
                if (this.EEzsignfolderSendreminderfrequency != null)
                    hashCode = hashCode * 59 + this.EEzsignfolderSendreminderfrequency.GetHashCode();
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
            // FkiEzsigntsarequirementID (int) maximum
            if(this.FkiEzsigntsarequirementID > (int)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntsarequirementID, must be a value less than or equal to 3.", new [] { "FkiEzsigntsarequirementID" });
            }

            // FkiEzsigntsarequirementID (int) minimum
            if(this.FkiEzsigntsarequirementID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntsarequirementID, must be a value greater than or equal to 1.", new [] { "FkiEzsigntsarequirementID" });
            }

            // SEzsignfolderDescription (string) maxLength
            if(this.SEzsignfolderDescription != null && this.SEzsignfolderDescription.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignfolderDescription, length must be less than 75.", new [] { "SEzsignfolderDescription" });
            }

            // SEzsignfolderDescription (string) minLength
            if(this.SEzsignfolderDescription != null && this.SEzsignfolderDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SEzsignfolderDescription, length must be greater than 1.", new [] { "SEzsignfolderDescription" });
            }

            yield break;
        }
    }

}
