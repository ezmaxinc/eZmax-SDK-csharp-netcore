/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.28
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
            this.fkiLanguageID = fkiLanguageID;
            // to ensure "sUserFirstname" is required (not null)
            this.sUserFirstname = sUserFirstname ?? throw new ArgumentNullException("sUserFirstname is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sUserLastname" is required (not null)
            this.sUserLastname = sUserLastname ?? throw new ArgumentNullException("sUserLastname is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sEmailAddress" is required (not null)
            this.sEmailAddress = sEmailAddress ?? throw new ArgumentNullException("sEmailAddress is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sPhoneRegion" is required (not null)
            this.sPhoneRegion = sPhoneRegion ?? throw new ArgumentNullException("sPhoneRegion is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sPhoneExchange" is required (not null)
            this.sPhoneExchange = sPhoneExchange ?? throw new ArgumentNullException("sPhoneExchange is a required property for UserCreateEzsignuserV1Request and cannot be null");
            // to ensure "sPhoneNumber" is required (not null)
            this.sPhoneNumber = sPhoneNumber ?? throw new ArgumentNullException("sPhoneNumber is a required property for UserCreateEzsignuserV1Request and cannot be null");
            this.sPhoneExtension = sPhoneExtension;
        }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// The First name of the user
        /// </summary>
        /// <value>The First name of the user</value>
        [DataMember(Name = "sUserFirstname", IsRequired = true, EmitDefaultValue = false)]
        public string sUserFirstname { get; set; }

        /// <summary>
        /// The Last name of the user
        /// </summary>
        /// <value>The Last name of the user</value>
        [DataMember(Name = "sUserLastname", IsRequired = true, EmitDefaultValue = false)]
        public string sUserLastname { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name = "sEmailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string sEmailAddress { get; set; }

        /// <summary>
        /// The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneRegion", IsRequired = true, EmitDefaultValue = false)]
        public string sPhoneRegion { get; set; }

        /// <summary>
        /// The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneExchange", IsRequired = true, EmitDefaultValue = false)]
        public string sPhoneExchange { get; set; }

        /// <summary>
        /// The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneNumber", IsRequired = true, EmitDefaultValue = false)]
        public string sPhoneNumber { get; set; }

        /// <summary>
        /// The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers
        /// </summary>
        /// <value>The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers</value>
        [DataMember(Name = "sPhoneExtension", EmitDefaultValue = false)]
        public string sPhoneExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreateEzsignuserV1Request {\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  sUserFirstname: ").Append(sUserFirstname).Append("\n");
            sb.Append("  sUserLastname: ").Append(sUserLastname).Append("\n");
            sb.Append("  sEmailAddress: ").Append(sEmailAddress).Append("\n");
            sb.Append("  sPhoneRegion: ").Append(sPhoneRegion).Append("\n");
            sb.Append("  sPhoneExchange: ").Append(sPhoneExchange).Append("\n");
            sb.Append("  sPhoneNumber: ").Append(sPhoneNumber).Append("\n");
            sb.Append("  sPhoneExtension: ").Append(sPhoneExtension).Append("\n");
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
                    this.fkiLanguageID == input.fkiLanguageID ||
                    this.fkiLanguageID.Equals(input.fkiLanguageID)
                ) && 
                (
                    this.sUserFirstname == input.sUserFirstname ||
                    (this.sUserFirstname != null &&
                    this.sUserFirstname.Equals(input.sUserFirstname))
                ) && 
                (
                    this.sUserLastname == input.sUserLastname ||
                    (this.sUserLastname != null &&
                    this.sUserLastname.Equals(input.sUserLastname))
                ) && 
                (
                    this.sEmailAddress == input.sEmailAddress ||
                    (this.sEmailAddress != null &&
                    this.sEmailAddress.Equals(input.sEmailAddress))
                ) && 
                (
                    this.sPhoneRegion == input.sPhoneRegion ||
                    (this.sPhoneRegion != null &&
                    this.sPhoneRegion.Equals(input.sPhoneRegion))
                ) && 
                (
                    this.sPhoneExchange == input.sPhoneExchange ||
                    (this.sPhoneExchange != null &&
                    this.sPhoneExchange.Equals(input.sPhoneExchange))
                ) && 
                (
                    this.sPhoneNumber == input.sPhoneNumber ||
                    (this.sPhoneNumber != null &&
                    this.sPhoneNumber.Equals(input.sPhoneNumber))
                ) && 
                (
                    this.sPhoneExtension == input.sPhoneExtension ||
                    (this.sPhoneExtension != null &&
                    this.sPhoneExtension.Equals(input.sPhoneExtension))
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
                hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.sUserFirstname != null)
                    hashCode = hashCode * 59 + this.sUserFirstname.GetHashCode();
                if (this.sUserLastname != null)
                    hashCode = hashCode * 59 + this.sUserLastname.GetHashCode();
                if (this.sEmailAddress != null)
                    hashCode = hashCode * 59 + this.sEmailAddress.GetHashCode();
                if (this.sPhoneRegion != null)
                    hashCode = hashCode * 59 + this.sPhoneRegion.GetHashCode();
                if (this.sPhoneExchange != null)
                    hashCode = hashCode * 59 + this.sPhoneExchange.GetHashCode();
                if (this.sPhoneNumber != null)
                    hashCode = hashCode * 59 + this.sPhoneNumber.GetHashCode();
                if (this.sPhoneExtension != null)
                    hashCode = hashCode * 59 + this.sPhoneExtension.GetHashCode();
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
