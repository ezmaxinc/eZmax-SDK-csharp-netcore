/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.31
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
    /// Payload for the /1/module/user/createEzsignuser API Request
    /// </summary>
    [DataContract(Name = "user-createEzsignuser-v1-Response-mPayload")]
    public partial class UserCreateEzsignuserV1ResponseMPayload : IEquatable<UserCreateEzsignuserV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateEzsignuserV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCreateEzsignuserV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateEzsignuserV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aSEmailAddressSuccess">An array of email addresses that succeeded. (required).</param>
        /// <param name="aSEmailAddressFailure">An array of email addresses that failed. (required).</param>
        public UserCreateEzsignuserV1ResponseMPayload(List<string> aSEmailAddressSuccess = default(List<string>), List<string> aSEmailAddressFailure = default(List<string>))
        {
            // to ensure "aSEmailAddressSuccess" is required (not null)
            this.a_sEmailAddressSuccess = aSEmailAddressSuccess ?? throw new ArgumentNullException("aSEmailAddressSuccess is a required property for UserCreateEzsignuserV1ResponseMPayload and cannot be null");
            // to ensure "aSEmailAddressFailure" is required (not null)
            this.a_sEmailAddressFailure = aSEmailAddressFailure ?? throw new ArgumentNullException("aSEmailAddressFailure is a required property for UserCreateEzsignuserV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// An array of email addresses that succeeded.
        /// </summary>
        /// <value>An array of email addresses that succeeded.</value>
        [DataMember(Name = "a_sEmailAddressSuccess", IsRequired = true, EmitDefaultValue = false)]
        public List<string> a_sEmailAddressSuccess { get; set; }

        /// <summary>
        /// An array of email addresses that failed.
        /// </summary>
        /// <value>An array of email addresses that failed.</value>
        [DataMember(Name = "a_sEmailAddressFailure", IsRequired = true, EmitDefaultValue = false)]
        public List<string> a_sEmailAddressFailure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreateEzsignuserV1ResponseMPayload {\n");
            sb.Append("  a_sEmailAddressSuccess: ").Append(a_sEmailAddressSuccess).Append("\n");
            sb.Append("  a_sEmailAddressFailure: ").Append(a_sEmailAddressFailure).Append("\n");
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
            return this.Equals(input as UserCreateEzsignuserV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if UserCreateEzsignuserV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCreateEzsignuserV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreateEzsignuserV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_sEmailAddressSuccess == input.a_sEmailAddressSuccess ||
                    this.a_sEmailAddressSuccess != null &&
                    input.a_sEmailAddressSuccess != null &&
                    this.a_sEmailAddressSuccess.SequenceEqual(input.a_sEmailAddressSuccess)
                ) && 
                (
                    this.a_sEmailAddressFailure == input.a_sEmailAddressFailure ||
                    this.a_sEmailAddressFailure != null &&
                    input.a_sEmailAddressFailure != null &&
                    this.a_sEmailAddressFailure.SequenceEqual(input.a_sEmailAddressFailure)
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
                if (this.a_sEmailAddressSuccess != null)
                    hashCode = hashCode * 59 + this.a_sEmailAddressSuccess.GetHashCode();
                if (this.a_sEmailAddressFailure != null)
                    hashCode = hashCode * 59 + this.a_sEmailAddressFailure.GetHashCode();
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
