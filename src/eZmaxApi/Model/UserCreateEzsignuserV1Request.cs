/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.39
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
    /// Request for the /1/module/user/createEzsignuser API Request
    /// </summary>
    [DataContract(Name = "user-createEzsignuser-v1-Request")]
    public partial class UserCreateEzsignuserV1Request : IEquatable<UserCreateEzsignuserV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateEzsignuserV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCreateEzsignuserV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateEzsignuserV1Request" /> class.
        /// </summary>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sUserFirstname">The First name of the user (required).</param>
        /// <param name="sUserLastname">The Last name of the user (required).</param>
        /// <param name="sEmailAddress">The email address. (required).</param>
        /// <param name="sPhoneRegion">The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123 (required).</param>
        /// <param name="sPhoneExchange">The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123 (required).</param>
        /// <param name="sPhoneNumber">The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123 (required).</param>
        /// <param name="sPhoneExtension">The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers.</param>
        public UserCreateEzsignuserV1Request(int fkiLanguageID = default(int), string sUserFirstname = default(string), string sUserLastname = default(string), string sEmailAddress = default(string), string sPhoneRegion = default(string), string sPhoneExchange = default(string), string sPhoneNumber = default(string), string sPhoneExtension = default(string))
        {
            this.FkiLanguageID = fkiLanguageID;
            // to ensure "sUserFirstname" is required (not null)
            this.SUserFirstname = sUserFirstname ?? throw new ArgumentNullException("sUserFirstname is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sUserLastname" is required (not null)
            this.SUserLastname = sUserLastname ?? throw new ArgumentNullException("sUserLastname is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sEmailAddress" is required (not null)
            this.SEmailAddress = sEmailAddress ?? throw new ArgumentNullException("sEmailAddress is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sPhoneRegion" is required (not null)
            this.SPhoneRegion = sPhoneRegion ?? throw new ArgumentNullException("sPhoneRegion is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sPhoneExchange" is required (not null)
            this.SPhoneExchange = sPhoneExchange ?? throw new ArgumentNullException("sPhoneExchange is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sPhoneNumber" is required (not null)
            this.SPhoneNumber = sPhoneNumber ?? throw new ArgumentNullException("sPhoneNumber is a required property for UserCreateEzsignuserV1Request and cannot be null");
            this.SPhoneExtension = sPhoneExtension;
        }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// The First name of the user
        /// </summary>
        /// <value>The First name of the user</value>
        [DataMember(Name = "sUserFirstname", IsRequired = true, EmitDefaultValue = false)]
        public string SUserFirstname { get; set; }

        /// <summary>
        /// The Last name of the user
        /// </summary>
        /// <value>The Last name of the user</value>
        [DataMember(Name = "sUserLastname", IsRequired = true, EmitDefaultValue = false)]
        public string SUserLastname { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name = "sEmailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string SEmailAddress { get; set; }

        /// <summary>
        /// The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneRegion", IsRequired = true, EmitDefaultValue = false)]
        public string SPhoneRegion { get; set; }

        /// <summary>
        /// The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneExchange", IsRequired = true, EmitDefaultValue = false)]
        public string SPhoneExchange { get; set; }

        /// <summary>
        /// The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneNumber", IsRequired = true, EmitDefaultValue = false)]
        public string SPhoneNumber { get; set; }

        /// <summary>
        /// The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers
        /// </summary>
        /// <value>The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers</value>
        [DataMember(Name = "sPhoneExtension", EmitDefaultValue = false)]
        public string SPhoneExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreateEzsignuserV1Request {\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SUserFirstname: ").Append(SUserFirstname).Append("\n");
            sb.Append("  SUserLastname: ").Append(SUserLastname).Append("\n");
            sb.Append("  SEmailAddress: ").Append(SEmailAddress).Append("\n");
            sb.Append("  SPhoneRegion: ").Append(SPhoneRegion).Append("\n");
            sb.Append("  SPhoneExchange: ").Append(SPhoneExchange).Append("\n");
            sb.Append("  SPhoneNumber: ").Append(SPhoneNumber).Append("\n");
            sb.Append("  SPhoneExtension: ").Append(SPhoneExtension).Append("\n");
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
            return this.Equals(input as UserCreateEzsignuserV1Request);
        }

        /// <summary>
        /// Returns true if UserCreateEzsignuserV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCreateEzsignuserV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreateEzsignuserV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    this.FkiLanguageID.Equals(input.FkiLanguageID)
                ) && 
                (
                    this.SUserFirstname == input.SUserFirstname ||
                    (this.SUserFirstname != null &&
                    this.SUserFirstname.Equals(input.SUserFirstname))
                ) && 
                (
                    this.SUserLastname == input.SUserLastname ||
                    (this.SUserLastname != null &&
                    this.SUserLastname.Equals(input.SUserLastname))
                ) && 
                (
                    this.SEmailAddress == input.SEmailAddress ||
                    (this.SEmailAddress != null &&
                    this.SEmailAddress.Equals(input.SEmailAddress))
                ) && 
                (
                    this.SPhoneRegion == input.SPhoneRegion ||
                    (this.SPhoneRegion != null &&
                    this.SPhoneRegion.Equals(input.SPhoneRegion))
                ) && 
                (
                    this.SPhoneExchange == input.SPhoneExchange ||
                    (this.SPhoneExchange != null &&
                    this.SPhoneExchange.Equals(input.SPhoneExchange))
                ) && 
                (
                    this.SPhoneNumber == input.SPhoneNumber ||
                    (this.SPhoneNumber != null &&
                    this.SPhoneNumber.Equals(input.SPhoneNumber))
                ) && 
                (
                    this.SPhoneExtension == input.SPhoneExtension ||
                    (this.SPhoneExtension != null &&
                    this.SPhoneExtension.Equals(input.SPhoneExtension))
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
                hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.SUserFirstname != null)
                    hashCode = hashCode * 59 + this.SUserFirstname.GetHashCode();
                if (this.SUserLastname != null)
                    hashCode = hashCode * 59 + this.SUserLastname.GetHashCode();
                if (this.SEmailAddress != null)
                    hashCode = hashCode * 59 + this.SEmailAddress.GetHashCode();
                if (this.SPhoneRegion != null)
                    hashCode = hashCode * 59 + this.SPhoneRegion.GetHashCode();
                if (this.SPhoneExchange != null)
                    hashCode = hashCode * 59 + this.SPhoneExchange.GetHashCode();
                if (this.SPhoneNumber != null)
                    hashCode = hashCode * 59 + this.SPhoneNumber.GetHashCode();
                if (this.SPhoneExtension != null)
                    hashCode = hashCode * 59 + this.SPhoneExtension.GetHashCode();
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