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
    /// WebhookEzsignDocumentCompletedAllOf
    /// </summary>
    [DataContract(Name = "Webhook_Ezsign_DocumentCompleted_allOf")]
    public partial class WebhookEzsignDocumentCompletedAllOf : IEquatable<WebhookEzsignDocumentCompletedAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEzsignDocumentCompletedAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEzsignDocumentCompletedAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEzsignDocumentCompletedAllOf" /> class.
        /// </summary>
        /// <param name="objEzsigndocument">objEzsigndocument (required).</param>
        public WebhookEzsignDocumentCompletedAllOf(EzsigndocumentResponse objEzsigndocument = default(EzsigndocumentResponse))
        {
            // to ensure "objEzsigndocument" is required (not null)
            this.ObjEzsigndocument = objEzsigndocument ?? throw new ArgumentNullException("objEzsigndocument is a required property for WebhookEzsignDocumentCompletedAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ObjEzsigndocument
        /// </summary>
        [DataMember(Name = "objEzsigndocument", IsRequired = true, EmitDefaultValue = false)]
        public EzsigndocumentResponse ObjEzsigndocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEzsignDocumentCompletedAllOf {\n");
            sb.Append("  ObjEzsigndocument: ").Append(ObjEzsigndocument).Append("\n");
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
            return this.Equals(input as WebhookEzsignDocumentCompletedAllOf);
        }

        /// <summary>
        /// Returns true if WebhookEzsignDocumentCompletedAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEzsignDocumentCompletedAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEzsignDocumentCompletedAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsigndocument == input.ObjEzsigndocument ||
                    (this.ObjEzsigndocument != null &&
                    this.ObjEzsigndocument.Equals(input.ObjEzsigndocument))
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
                if (this.ObjEzsigndocument != null)
                    hashCode = hashCode * 59 + this.ObjEzsigndocument.GetHashCode();
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
