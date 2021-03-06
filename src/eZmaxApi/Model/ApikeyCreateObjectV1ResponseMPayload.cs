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
    /// Payload for the /1/object/apikey/createObject API Request
    /// </summary>
    [DataContract(Name = "apikey-createObject-v1-Response-mPayload")]
    public partial class ApikeyCreateObjectV1ResponseMPayload : IEquatable<ApikeyCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApikeyCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aObjApikey">aObjApikey (required).</param>
        public ApikeyCreateObjectV1ResponseMPayload(List<ApikeyResponse> aObjApikey = default(List<ApikeyResponse>))
        {
            // to ensure "aObjApikey" is required (not null)
            this.AObjApikey = aObjApikey ?? throw new ArgumentNullException("aObjApikey is a required property for ApikeyCreateObjectV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// Gets or Sets AObjApikey
        /// </summary>
        [DataMember(Name = "a_objApikey", IsRequired = true, EmitDefaultValue = false)]
        public List<ApikeyResponse> AObjApikey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApikeyCreateObjectV1ResponseMPayload {\n");
            sb.Append("  AObjApikey: ").Append(AObjApikey).Append("\n");
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
            return this.Equals(input as ApikeyCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if ApikeyCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AObjApikey == input.AObjApikey ||
                    this.AObjApikey != null &&
                    input.AObjApikey != null &&
                    this.AObjApikey.SequenceEqual(input.AObjApikey)
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
                if (this.AObjApikey != null)
                    hashCode = hashCode * 59 + this.AObjApikey.GetHashCode();
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
