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
    /// This is the base Webhook object
    /// </summary>
    [DataContract(Name = "Webhook-Ezsign-FolderCompleted")]
    public partial class WebhookEzsignFolderCompleted : IEquatable<WebhookEzsignFolderCompleted>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEzsignFolderCompleted" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEzsignFolderCompleted() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEzsignFolderCompleted" /> class.
        /// </summary>
        /// <param name="objEzsignfolder">objEzsignfolder (required).</param>
        /// <param name="objWebhook">objWebhook (required).</param>
        /// <param name="aObjAttempt">An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt. (required).</param>
        public WebhookEzsignFolderCompleted(EzsignfolderResponse objEzsignfolder = default(EzsignfolderResponse), WebhookResponse objWebhook = default(WebhookResponse), List<AttemptResponse> aObjAttempt = default(List<AttemptResponse>))
        {
            // to ensure "objEzsignfolder" is required (not null)
            this.objEzsignfolder = objEzsignfolder ?? throw new ArgumentNullException("objEzsignfolder is a required property for WebhookEzsignFolderCompleted and cannot be null");
            // to ensure "objWebhook" is required (not null)
            this.objWebhook = objWebhook ?? throw new ArgumentNullException("objWebhook is a required property for WebhookEzsignFolderCompleted and cannot be null");
            // to ensure "aObjAttempt" is required (not null)
            this.a_objAttempt = aObjAttempt ?? throw new ArgumentNullException("aObjAttempt is a required property for WebhookEzsignFolderCompleted and cannot be null");
        }

        /// <summary>
        /// Gets or Sets objEzsignfolder
        /// </summary>
        [DataMember(Name = "objEzsignfolder", IsRequired = true, EmitDefaultValue = false)]
        public EzsignfolderResponse objEzsignfolder { get; set; }

        /// <summary>
        /// Gets or Sets objWebhook
        /// </summary>
        [DataMember(Name = "objWebhook", IsRequired = true, EmitDefaultValue = false)]
        public WebhookResponse objWebhook { get; set; }

        /// <summary>
        /// An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt.
        /// </summary>
        /// <value>An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt.</value>
        [DataMember(Name = "a_objAttempt", IsRequired = true, EmitDefaultValue = false)]
        public List<AttemptResponse> a_objAttempt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEzsignFolderCompleted {\n");
            sb.Append("  objEzsignfolder: ").Append(objEzsignfolder).Append("\n");
            sb.Append("  objWebhook: ").Append(objWebhook).Append("\n");
            sb.Append("  a_objAttempt: ").Append(a_objAttempt).Append("\n");
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
            return this.Equals(input as WebhookEzsignFolderCompleted);
        }

        /// <summary>
        /// Returns true if WebhookEzsignFolderCompleted instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEzsignFolderCompleted to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEzsignFolderCompleted input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objEzsignfolder == input.objEzsignfolder ||
                    (this.objEzsignfolder != null &&
                    this.objEzsignfolder.Equals(input.objEzsignfolder))
                ) && 
                (
                    this.objWebhook == input.objWebhook ||
                    (this.objWebhook != null &&
                    this.objWebhook.Equals(input.objWebhook))
                ) && 
                (
                    this.a_objAttempt == input.a_objAttempt ||
                    this.a_objAttempt != null &&
                    input.a_objAttempt != null &&
                    this.a_objAttempt.SequenceEqual(input.a_objAttempt)
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
                if (this.objEzsignfolder != null)
                    hashCode = hashCode * 59 + this.objEzsignfolder.GetHashCode();
                if (this.objWebhook != null)
                    hashCode = hashCode * 59 + this.objWebhook.GetHashCode();
                if (this.a_objAttempt != null)
                    hashCode = hashCode * 59 + this.a_objAttempt.GetHashCode();
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
