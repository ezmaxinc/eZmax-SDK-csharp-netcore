/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.40
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
            this.FkiContacttitleID = fkiContacttitleID;
            this.FkiLanguageID = fkiLanguageID;
            // to ensure "sContactFirstname" is required (not null)
            this.SContactFirstname = sContactFirstname ?? throw new ArgumentNullException("sContactFirstname is a required property for ContactRequest and cannot be null");
            // to ensure "sContactLastname" is required (not null)
            this.SContactLastname = sContactLastname ?? throw new ArgumentNullException("sContactLastname is a required property for ContactRequest and cannot be null");
            // to ensure "sContactCompany" is required (not null)
            this.SContactCompany = sContactCompany ?? throw new ArgumentNullException("sContactCompany is a required property for ContactRequest and cannot be null");
            this.DtContactBirthdate = dtContactBirthdate;
        }

        /// <summary>
        /// The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)|
        /// </summary>
        /// <value>The unique ID of the Contacttitle.  Valid values:  |Value|Description| |-|-| |1|Ms.| |2|Mr.| |4|(Blank)| |5|Me (For Notaries)|</value>
        [DataMember(Name = "fkiContacttitleID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiContacttitleID { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// The First name of the contact
        /// </summary>
        /// <value>The First name of the contact</value>
        [DataMember(Name = "sContactFirstname", IsRequired = true, EmitDefaultValue = false)]
        public string SContactFirstname { get; set; }

        /// <summary>
        /// The Last name of the contact
        /// </summary>
        /// <value>The Last name of the contact</value>
        [DataMember(Name = "sContactLastname", IsRequired = true, EmitDefaultValue = false)]
        public string SContactLastname { get; set; }

        /// <summary>
        /// The Company name of the contact
        /// </summary>
        /// <value>The Company name of the contact</value>
        [DataMember(Name = "sContactCompany", IsRequired = true, EmitDefaultValue = false)]
        public string SContactCompany { get; set; }

        /// <summary>
        /// The Birth Date of the contact
        /// </summary>
        /// <value>The Birth Date of the contact</value>
        [DataMember(Name = "dtContactBirthdate", EmitDefaultValue = false)]
        public string DtContactBirthdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRequest {\n");
            sb.Append("  FkiContacttitleID: ").Append(FkiContacttitleID).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SContactFirstname: ").Append(SContactFirstname).Append("\n");
            sb.Append("  SContactLastname: ").Append(SContactLastname).Append("\n");
            sb.Append("  SContactCompany: ").Append(SContactCompany).Append("\n");
            sb.Append("  DtContactBirthdate: ").Append(DtContactBirthdate).Append("\n");
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
                    this.FkiContacttitleID == input.FkiContacttitleID ||
                    this.FkiContacttitleID.Equals(input.FkiContacttitleID)
                ) && 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    this.FkiLanguageID.Equals(input.FkiLanguageID)
                ) && 
                (
                    this.SContactFirstname == input.SContactFirstname ||
                    (this.SContactFirstname != null &&
                    this.SContactFirstname.Equals(input.SContactFirstname))
                ) && 
                (
                    this.SContactLastname == input.SContactLastname ||
                    (this.SContactLastname != null &&
                    this.SContactLastname.Equals(input.SContactLastname))
                ) && 
                (
                    this.SContactCompany == input.SContactCompany ||
                    (this.SContactCompany != null &&
                    this.SContactCompany.Equals(input.SContactCompany))
                ) && 
                (
                    this.DtContactBirthdate == input.DtContactBirthdate ||
                    (this.DtContactBirthdate != null &&
                    this.DtContactBirthdate.Equals(input.DtContactBirthdate))
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
                hashCode = hashCode * 59 + this.FkiContacttitleID.GetHashCode();
                hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.SContactFirstname != null)
                    hashCode = hashCode * 59 + this.SContactFirstname.GetHashCode();
                if (this.SContactLastname != null)
                    hashCode = hashCode * 59 + this.SContactLastname.GetHashCode();
                if (this.SContactCompany != null)
                    hashCode = hashCode * 59 + this.SContactCompany.GetHashCode();
                if (this.DtContactBirthdate != null)
                    hashCode = hashCode * 59 + this.DtContactBirthdate.GetHashCode();
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
            // FkiLanguageID (int) maximum
            if(this.FkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value less than or equal to 2.", new [] { "FkiLanguageID" });
            }

            // FkiLanguageID (int) minimum
            if(this.FkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value greater than or equal to 1.", new [] { "FkiLanguageID" });
            }

            yield break;
        }
    }

}
