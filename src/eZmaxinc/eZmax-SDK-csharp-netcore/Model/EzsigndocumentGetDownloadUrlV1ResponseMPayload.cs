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
    /// Payload for the /1/object/ezsigndocument/{pkiEzsigndocument}/getDownloadUrl API Request
    /// </summary>
    [DataContract(Name = "ezsigndocument-getDownloadUrl-v1-Response-mPayload")]
    public partial class EzsigndocumentGetDownloadUrlV1ResponseMPayload : IEquatable<EzsigndocumentGetDownloadUrlV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetDownloadUrlV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetDownloadUrlV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetDownloadUrlV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="sDownloadUrl">The Url to the requested document.  Url will expire after 5 minutes. (required).</param>
        public EzsigndocumentGetDownloadUrlV1ResponseMPayload(string sDownloadUrl = default(string))
        {
            // to ensure "sDownloadUrl" is required (not null)
            this.sDownloadUrl = sDownloadUrl ?? throw new ArgumentNullException("sDownloadUrl is a required property for EzsigndocumentGetDownloadUrlV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// The Url to the requested document.  Url will expire after 5 minutes.
        /// </summary>
        /// <value>The Url to the requested document.  Url will expire after 5 minutes.</value>
        [DataMember(Name = "sDownloadUrl", IsRequired = true, EmitDefaultValue = false)]
        public string sDownloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetDownloadUrlV1ResponseMPayload {\n");
            sb.Append("  sDownloadUrl: ").Append(sDownloadUrl).Append("\n");
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
            return this.Equals(input as EzsigndocumentGetDownloadUrlV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigndocumentGetDownloadUrlV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentGetDownloadUrlV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentGetDownloadUrlV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sDownloadUrl == input.sDownloadUrl ||
                    (this.sDownloadUrl != null &&
                    this.sDownloadUrl.Equals(input.sDownloadUrl))
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
                if (this.sDownloadUrl != null)
                    hashCode = hashCode * 59 + this.sDownloadUrl.GetHashCode();
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
