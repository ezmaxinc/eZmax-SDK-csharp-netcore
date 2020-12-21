/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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
    /// A Contact Object
    /// </summary>
    [DataContract(Name = "contact-Request")]
    public partial class ContactRequest : IEquatable<ContactRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequest" /> class.
        /// </summary>
        /// <param name="fkiContacttitleID">The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)| (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sContactFirstname">The First name of the contact (required).</param>
        /// <param name="sContactLastname">The Last name of the contact (required).</param>
        /// <param name="sContactCompany">The Company name of the contact (required).</param>
        /// <param name="dtContactBirthdate">The Birth Date of the contact.</param>
        public ContactRequest(int fkiContacttitleID = default(int), int fkiLanguageID = default(int), string sContactFirstname = default(string), string sContactLastname = default(string), string sContactCompany = default(string), string dtContactBirthdate = default(string))
        {
            this.fkiContacttitleID = fkiContacttitleID;
            this.fkiLanguageID = fkiLanguageID;
            // to ensure "sContactFirstname" is required (not null)
            this.sContactFirstname = sContactFirstname ?? throw new ArgumentNullException("sContactFirstname is a required property for ContactRequest and cannot be null");
            // to ensure "sContactLastname" is required (not null)
            this.sContactLastname = sContactLastname ?? throw new ArgumentNullException("sContactLastname is a required property for ContactRequest and cannot be null");
            // to ensure "sContactCompany" is required (not null)
            this.sContactCompany = sContactCompany ?? throw new ArgumentNullException("sContactCompany is a required property for ContactRequest and cannot be null");
            this.dtContactBirthdate = dtContactBirthdate;
        }

        /// <summary>
        /// The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)|
        /// </summary>
        /// <value>The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)|</value>
        [DataMember(Name = "fkiContacttitleID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiContacttitleID { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// The First name of the contact
        /// </summary>
        /// <value>The First name of the contact</value>
        [DataMember(Name = "sContactFirstname", IsRequired = true, EmitDefaultValue = false)]
        public string sContactFirstname { get; set; }

        /// <summary>
        /// The Last name of the contact
        /// </summary>
        /// <value>The Last name of the contact</value>
        [DataMember(Name = "sContactLastname", IsRequired = true, EmitDefaultValue = false)]
        public string sContactLastname { get; set; }

        /// <summary>
        /// The Company name of the contact
        /// </summary>
        /// <value>The Company name of the contact</value>
        [DataMember(Name = "sContactCompany", IsRequired = true, EmitDefaultValue = false)]
        public string sContactCompany { get; set; }

        /// <summary>
        /// The Birth Date of the contact
        /// </summary>
        /// <value>The Birth Date of the contact</value>
        [DataMember(Name = "dtContactBirthdate", EmitDefaultValue = false)]
        public string dtContactBirthdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRequest {\n");
            sb.Append("  fkiContacttitleID: ").Append(fkiContacttitleID).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sContactFirstname: ").Append(sContactFirstname).Append("\n");
            sb.Append("  sContactLastname: ").Append(sContactLastname).Append("\n");
            sb.Append("  sContactCompany: ").Append(sContactCompany).Append("\n");
            sb.Append("  dtContactBirthdate: ").Append(dtContactBirthdate).Append("\n");
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
            return this.Equals(input as ContactRequest);
        }

        /// <summary>
        /// Returns true if ContactRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiContacttitleID == input.fkiContacttitleID ||
                    this.fkiContacttitleID.Equals(input.fkiContacttitleID)
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    this.fkiLanguageID.Equals(input.fkiLanguageID)
                ) && 
                (
                    this.sContactFirstname == input.sContactFirstname ||
                    (this.sContactFirstname != null &&
                    this.sContactFirstname.Equals(input.sContactFirstname))
                ) && 
                (
                    this.sContactLastname == input.sContactLastname ||
                    (this.sContactLastname != null &&
                    this.sContactLastname.Equals(input.sContactLastname))
                ) && 
                (
                    this.sContactCompany == input.sContactCompany ||
                    (this.sContactCompany != null &&
                    this.sContactCompany.Equals(input.sContactCompany))
                ) && 
                (
                    this.dtContactBirthdate == input.dtContactBirthdate ||
                    (this.dtContactBirthdate != null &&
                    this.dtContactBirthdate.Equals(input.dtContactBirthdate))
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
                hashCode = hashCode * 59 + this.fkiContacttitleID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sContactFirstname != null)
                    hashCode = hashCode * 59 + this.sContactFirstname.GetHashCode();
                if (this.sContactLastname != null)
                    hashCode = hashCode * 59 + this.sContactLastname.GetHashCode();
                if (this.sContactCompany != null)
                    hashCode = hashCode * 59 + this.sContactCompany.GetHashCode();
                if (this.dtContactBirthdate != null)
                    hashCode = hashCode * 59 + this.dtContactBirthdate.GetHashCode();
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
