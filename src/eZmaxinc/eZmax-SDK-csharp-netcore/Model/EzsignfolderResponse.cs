/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.12
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp-netcore.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Model
{
    /// <summary>
    /// An Ezsignfolder Object
    /// </summary>
    [DataContract(Name = "ezsignfolder-Response")]
    public partial class EzsignfolderResponse : IEquatable<EzsignfolderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponse" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here. (required).</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="tEzsignfolderNote">Somes extra notes about the eZsign Folder (required).</param>
        /// <param name="eEzsignfolderSendreminderfrequency">eEzsignfolderSendreminderfrequency (required).</param>
        /// <param name="pkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsignfolderSentdate">The date and time at which the Ezsign folder was sent the last time. (required).</param>
        /// <param name="eEzsignfolderStep">eEzsignfolderStep (required).</param>
        /// <param name="dtEzsignfolderClose">The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely. (required).</param>
        /// <param name="fkiUserIDCreated">The id of the User that created the object. (required).</param>
        /// <param name="fkiUserIDModified">The id of the User that made the last modification on the object. (required).</param>
        /// <param name="fkiApikeyIDCreated">The id of the API Key that created the object..</param>
        /// <param name="fkiApikeyIDModified">The id of the API Key that made the last modification on the object..</param>
        /// <param name="dtCreatedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="dtModifiedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        public EzsignfolderResponse(int fkiEzsignfoldertypeID = default(int), int fkiEzsigntsarequirementID = default(int), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency = default(FieldEEzsignfolderSendreminderfrequency), int pkiEzsignfolderID = default(int), string dtEzsignfolderSentdate = default(string), FieldEEzsignfolderStep eEzsignfolderStep = default(FieldEEzsignfolderStep), string dtEzsignfolderClose = default(string), int fkiUserIDCreated = default(int), int fkiUserIDModified = default(int), int fkiApikeyIDCreated = default(int), int fkiApikeyIDModified = default(int), string dtCreatedDate = default(string), string dtModifiedDate = default(string))
        {
            this.fkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            this.fkiEzsigntsarequirementID = fkiEzsigntsarequirementID;
            // to ensure "sEzsignfolderDescription" is required (not null)
            this.sEzsignfolderDescription = sEzsignfolderDescription ?? throw new ArgumentNullException("sEzsignfolderDescription is a required property for EzsignfolderResponse and cannot be null");
            // to ensure "tEzsignfolderNote" is required (not null)
            this.tEzsignfolderNote = tEzsignfolderNote ?? throw new ArgumentNullException("tEzsignfolderNote is a required property for EzsignfolderResponse and cannot be null");
            // to ensure "eEzsignfolderSendreminderfrequency" is required (not null)
            this.eEzsignfolderSendreminderfrequency = eEzsignfolderSendreminderfrequency ?? throw new ArgumentNullException("eEzsignfolderSendreminderfrequency is a required property for EzsignfolderResponse and cannot be null");
            this.pkiEzsignfolderID = pkiEzsignfolderID;
            // to ensure "dtEzsignfolderSentdate" is required (not null)
            this.dtEzsignfolderSentdate = dtEzsignfolderSentdate ?? throw new ArgumentNullException("dtEzsignfolderSentdate is a required property for EzsignfolderResponse and cannot be null");
            // to ensure "eEzsignfolderStep" is required (not null)
            this.eEzsignfolderStep = eEzsignfolderStep ?? throw new ArgumentNullException("eEzsignfolderStep is a required property for EzsignfolderResponse and cannot be null");
            // to ensure "dtEzsignfolderClose" is required (not null)
            this.dtEzsignfolderClose = dtEzsignfolderClose ?? throw new ArgumentNullException("dtEzsignfolderClose is a required property for EzsignfolderResponse and cannot be null");
            this.fkiUserIDCreated = fkiUserIDCreated;
            this.fkiUserIDModified = fkiUserIDModified;
            // to ensure "dtCreatedDate" is required (not null)
            this.dtCreatedDate = dtCreatedDate ?? throw new ArgumentNullException("dtCreatedDate is a required property for EzsignfolderResponse and cannot be null");
            // to ensure "dtModifiedDate" is required (not null)
            this.dtModifiedDate = dtModifiedDate ?? throw new ArgumentNullException("dtModifiedDate is a required property for EzsignfolderResponse and cannot be null");
            this.fkiApikeyIDCreated = fkiApikeyIDCreated;
            this.fkiApikeyIDModified = fkiApikeyIDModified;
        }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.</value>
        [DataMember(Name = "fkiEzsignfoldertypeID", EmitDefaultValue = false)]
        public int fkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|
        /// </summary>
        /// <value>The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|</value>
        [DataMember(Name = "fkiEzsigntsarequirementID", EmitDefaultValue = false)]
        public int fkiEzsigntsarequirementID { get; set; }

        /// <summary>
        /// The description of the Ezsign Folder
        /// </summary>
        /// <value>The description of the Ezsign Folder</value>
        [DataMember(Name = "sEzsignfolderDescription", EmitDefaultValue = false)]
        public string sEzsignfolderDescription { get; set; }

        /// <summary>
        /// Somes extra notes about the eZsign Folder
        /// </summary>
        /// <value>Somes extra notes about the eZsign Folder</value>
        [DataMember(Name = "tEzsignfolderNote", EmitDefaultValue = false)]
        public string tEzsignfolderNote { get; set; }

        /// <summary>
        /// Gets or Sets eEzsignfolderSendreminderfrequency
        /// </summary>
        [DataMember(Name = "eEzsignfolderSendreminderfrequency", EmitDefaultValue = false)]
        public FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name = "pkiEzsignfolderID", EmitDefaultValue = false)]
        public int pkiEzsignfolderID { get; set; }

        /// <summary>
        /// The date and time at which the Ezsign folder was sent the last time.
        /// </summary>
        /// <value>The date and time at which the Ezsign folder was sent the last time.</value>
        [DataMember(Name = "dtEzsignfolderSentdate", EmitDefaultValue = false)]
        public string dtEzsignfolderSentdate { get; set; }

        /// <summary>
        /// Gets or Sets eEzsignfolderStep
        /// </summary>
        [DataMember(Name = "eEzsignfolderStep", EmitDefaultValue = false)]
        public FieldEEzsignfolderStep eEzsignfolderStep { get; set; }

        /// <summary>
        /// The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely.
        /// </summary>
        /// <value>The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely.</value>
        [DataMember(Name = "dtEzsignfolderClose", EmitDefaultValue = false)]
        public string dtEzsignfolderClose { get; set; }

        /// <summary>
        /// The id of the User that created the object.
        /// </summary>
        /// <value>The id of the User that created the object.</value>
        [DataMember(Name = "fkiUserIDCreated", EmitDefaultValue = false)]
        public int fkiUserIDCreated { get; set; }

        /// <summary>
        /// The id of the User that made the last modification on the object.
        /// </summary>
        /// <value>The id of the User that made the last modification on the object.</value>
        [DataMember(Name = "fkiUserIDModified", EmitDefaultValue = false)]
        public int fkiUserIDModified { get; set; }

        /// <summary>
        /// The id of the API Key that created the object.
        /// </summary>
        /// <value>The id of the API Key that created the object.</value>
        [DataMember(Name = "fkiApikeyIDCreated", EmitDefaultValue = false)]
        public int fkiApikeyIDCreated { get; set; }

        /// <summary>
        /// The id of the API Key that made the last modification on the object.
        /// </summary>
        /// <value>The id of the API Key that made the last modification on the object.</value>
        [DataMember(Name = "fkiApikeyIDModified", EmitDefaultValue = false)]
        public int fkiApikeyIDModified { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name = "dtCreatedDate", EmitDefaultValue = false)]
        public string dtCreatedDate { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name = "dtModifiedDate", EmitDefaultValue = false)]
        public string dtModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderResponse {\n");
            sb.Append("  fkiEzsignfoldertypeID: ").Append(fkiEzsignfoldertypeID).Append("\n");
            sb.Append("  fkiEzsigntsarequirementID: ").Append(fkiEzsigntsarequirementID).Append("\n");
            sb.Append("  sEzsignfolderDescription: ").Append(sEzsignfolderDescription).Append("\n");
            sb.Append("  tEzsignfolderNote: ").Append(tEzsignfolderNote).Append("\n");
            sb.Append("  eEzsignfolderSendreminderfrequency: ").Append(eEzsignfolderSendreminderfrequency).Append("\n");
            sb.Append("  pkiEzsignfolderID: ").Append(pkiEzsignfolderID).Append("\n");
            sb.Append("  dtEzsignfolderSentdate: ").Append(dtEzsignfolderSentdate).Append("\n");
            sb.Append("  eEzsignfolderStep: ").Append(eEzsignfolderStep).Append("\n");
            sb.Append("  dtEzsignfolderClose: ").Append(dtEzsignfolderClose).Append("\n");
            sb.Append("  fkiUserIDCreated: ").Append(fkiUserIDCreated).Append("\n");
            sb.Append("  fkiUserIDModified: ").Append(fkiUserIDModified).Append("\n");
            sb.Append("  fkiApikeyIDCreated: ").Append(fkiApikeyIDCreated).Append("\n");
            sb.Append("  fkiApikeyIDModified: ").Append(fkiApikeyIDModified).Append("\n");
            sb.Append("  dtCreatedDate: ").Append(dtCreatedDate).Append("\n");
            sb.Append("  dtModifiedDate: ").Append(dtModifiedDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsignfolderResponse);
        }

        /// <summary>
        /// Returns true if EzsignfolderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderResponse input)
        {
            if (input == null)
                return false;

            return 
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
                ) && 
                (
                    this.pkiEzsignfolderID == input.pkiEzsignfolderID ||
                    this.pkiEzsignfolderID.Equals(input.pkiEzsignfolderID)
                ) && 
                (
                    this.dtEzsignfolderSentdate == input.dtEzsignfolderSentdate ||
                    (this.dtEzsignfolderSentdate != null &&
                    this.dtEzsignfolderSentdate.Equals(input.dtEzsignfolderSentdate))
                ) && 
                (
                    this.eEzsignfolderStep == input.eEzsignfolderStep ||
                    (this.eEzsignfolderStep != null &&
                    this.eEzsignfolderStep.Equals(input.eEzsignfolderStep))
                ) && 
                (
                    this.dtEzsignfolderClose == input.dtEzsignfolderClose ||
                    (this.dtEzsignfolderClose != null &&
                    this.dtEzsignfolderClose.Equals(input.dtEzsignfolderClose))
                ) && 
                (
                    this.fkiUserIDCreated == input.fkiUserIDCreated ||
                    this.fkiUserIDCreated.Equals(input.fkiUserIDCreated)
                ) && 
                (
                    this.fkiUserIDModified == input.fkiUserIDModified ||
                    this.fkiUserIDModified.Equals(input.fkiUserIDModified)
                ) && 
                (
                    this.fkiApikeyIDCreated == input.fkiApikeyIDCreated ||
                    this.fkiApikeyIDCreated.Equals(input.fkiApikeyIDCreated)
                ) && 
                (
                    this.fkiApikeyIDModified == input.fkiApikeyIDModified ||
                    this.fkiApikeyIDModified.Equals(input.fkiApikeyIDModified)
                ) && 
                (
                    this.dtCreatedDate == input.dtCreatedDate ||
                    (this.dtCreatedDate != null &&
                    this.dtCreatedDate.Equals(input.dtCreatedDate))
                ) && 
                (
                    this.dtModifiedDate == input.dtModifiedDate ||
                    (this.dtModifiedDate != null &&
                    this.dtModifiedDate.Equals(input.dtModifiedDate))
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
                hashCode = hashCode * 59 + this.fkiEzsignfoldertypeID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiEzsigntsarequirementID.GetHashCode();
                if (this.sEzsignfolderDescription != null)
                    hashCode = hashCode * 59 + this.sEzsignfolderDescription.GetHashCode();
                if (this.tEzsignfolderNote != null)
                    hashCode = hashCode * 59 + this.tEzsignfolderNote.GetHashCode();
                if (this.eEzsignfolderSendreminderfrequency != null)
                    hashCode = hashCode * 59 + this.eEzsignfolderSendreminderfrequency.GetHashCode();
                hashCode = hashCode * 59 + this.pkiEzsignfolderID.GetHashCode();
                if (this.dtEzsignfolderSentdate != null)
                    hashCode = hashCode * 59 + this.dtEzsignfolderSentdate.GetHashCode();
                if (this.eEzsignfolderStep != null)
                    hashCode = hashCode * 59 + this.eEzsignfolderStep.GetHashCode();
                if (this.dtEzsignfolderClose != null)
                    hashCode = hashCode * 59 + this.dtEzsignfolderClose.GetHashCode();
                hashCode = hashCode * 59 + this.fkiUserIDCreated.GetHashCode();
                hashCode = hashCode * 59 + this.fkiUserIDModified.GetHashCode();
                hashCode = hashCode * 59 + this.fkiApikeyIDCreated.GetHashCode();
                hashCode = hashCode * 59 + this.fkiApikeyIDModified.GetHashCode();
                if (this.dtCreatedDate != null)
                    hashCode = hashCode * 59 + this.dtCreatedDate.GetHashCode();
                if (this.dtModifiedDate != null)
                    hashCode = hashCode * 59 + this.dtModifiedDate.GetHashCode();
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

            yield break;
        }
    }

}
