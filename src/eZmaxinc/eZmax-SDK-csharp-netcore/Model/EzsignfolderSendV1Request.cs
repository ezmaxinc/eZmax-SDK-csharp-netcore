/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.18
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
    /// Request for the /1/object/ezsignfolder/{pkiEzsignfolderID}/send API Request
    /// </summary>
    [DataContract(Name = "ezsignfolder-send-v1-Request")]
    public partial class EzsignfolderSendV1Request : IEquatable<EzsignfolderSendV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderSendV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderSendV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderSendV1Request" /> class.
        /// </summary>
        /// <param name="tExtraMessage">A custom text message that will be added to the email sent to signatories inviting them to sign.  You can send an empty string and only the generic message will be sent. (required).</param>
        public EzsignfolderSendV1Request(string tExtraMessage = default(string))
        {
            // to ensure "tExtraMessage" is required (not null)
            this.tExtraMessage = tExtraMessage ?? throw new ArgumentNullException("tExtraMessage is a required property for EzsignfolderSendV1Request and cannot be null");
        }

        /// <summary>
        /// A custom text message that will be added to the email sent to signatories inviting them to sign.  You can send an empty string and only the generic message will be sent.
        /// </summary>
        /// <value>A custom text message that will be added to the email sent to signatories inviting them to sign.  You can send an empty string and only the generic message will be sent.</value>
        [DataMember(Name = "tExtraMessage", IsRequired = true, EmitDefaultValue = false)]
        public string tExtraMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderSendV1Request {\n");
            sb.Append("  tExtraMessage: ").Append(tExtraMessage).Append("\n");
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
            return this.Equals(input as EzsignfolderSendV1Request);
        }

        /// <summary>
        /// Returns true if EzsignfolderSendV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderSendV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderSendV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.tExtraMessage == input.tExtraMessage ||
                    (this.tExtraMessage != null &&
                    this.tExtraMessage.Equals(input.tExtraMessage))
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
                if (this.tExtraMessage != null)
                    hashCode = hashCode * 59 + this.tExtraMessage.GetHashCode();
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
