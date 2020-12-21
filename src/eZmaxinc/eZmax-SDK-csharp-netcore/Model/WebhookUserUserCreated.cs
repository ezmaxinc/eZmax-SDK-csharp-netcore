/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.21
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
    [DataContract(Name = "Webhook-User-UserCreated")]
    public partial class WebhookUserUserCreated : IEquatable<WebhookUserUserCreated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUserUserCreated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookUserUserCreated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUserUserCreated" /> class.
        /// </summary>
        /// <param name="objUser">objUser (required).</param>
        /// <param name="objWebhook">objWebhook (required).</param>
        /// <param name="aObjAttempt">An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt. (required).</param>
        public WebhookUserUserCreated(UserResponse objUser = default(UserResponse), WebhookResponse objWebhook = default(WebhookResponse), List<AttemptResponse> aObjAttempt = default(List<AttemptResponse>))
        {
            // to ensure "objUser" is required (not null)
            this.objUser = objUser ?? throw new ArgumentNullException("objUser is a required property for WebhookUserUserCreated and cannot be null");
            // to ensure "objWebhook" is required (not null)
            this.objWebhook = objWebhook ?? throw new ArgumentNullException("objWebhook is a required property for WebhookUserUserCreated and cannot be null");
            // to ensure "aObjAttempt" is required (not null)
            this.a_objAttempt = aObjAttempt ?? throw new ArgumentNullException("aObjAttempt is a required property for WebhookUserUserCreated and cannot be null");
        }

        /// <summary>
        /// Gets or Sets objUser
        /// </summary>
        [DataMember(Name = "objUser", IsRequired = true, EmitDefaultValue = false)]
        public UserResponse objUser { get; set; }

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
            sb.Append("class WebhookUserUserCreated {\n");
            sb.Append("  objUser: ").Append(objUser).Append("\n");
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
            return this.Equals(input as WebhookUserUserCreated);
        }

        /// <summary>
        /// Returns true if WebhookUserUserCreated instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUserUserCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUserUserCreated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objUser == input.objUser ||
                    (this.objUser != null &&
                    this.objUser.Equals(input.objUser))
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
                if (this.objUser != null)
                    hashCode = hashCode * 59 + this.objUser.GetHashCode();
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