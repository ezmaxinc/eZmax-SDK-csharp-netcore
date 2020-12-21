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
    /// Response for the /1/object/activesession/getCurrent API Request
    /// </summary>
    [DataContract(Name = "activesession-getCurrent-v1-Response")]
    public partial class ActivesessionGetCurrentV1Response : IEquatable<ActivesessionGetCurrentV1Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivesessionGetCurrentV1Response" /> class.
        /// </summary>
        /// <param name="mPayload">mPayload (required).</param>
        /// <param name="objDebugPayload">objDebugPayload.</param>
        /// <param name="objDebug">objDebug.</param>
        public ActivesessionGetCurrentV1Response(ActivesessionGetCurrentV1ResponseMPayload mPayload = default(ActivesessionGetCurrentV1ResponseMPayload), CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug))
        {
            // to ensure "mPayload" is required (not null)
            this.mPayload = mPayload ?? throw new ArgumentNullException("mPayload is a required property for ActivesessionGetCurrentV1Response and cannot be null");
            this.objDebugPayload = objDebugPayload;
            this.objDebug = objDebug;
        }

        /// <summary>
        /// Gets or Sets mPayload
        /// </summary>
        [DataMember(Name = "mPayload", IsRequired = true, EmitDefaultValue = false)]
        public ActivesessionGetCurrentV1ResponseMPayload mPayload { get; set; }

        /// <summary>
        /// Gets or Sets objDebugPayload
        /// </summary>
        [DataMember(Name = "objDebugPayload", EmitDefaultValue = false)]
        public CommonResponseObjDebugPayload objDebugPayload { get; set; }

        /// <summary>
        /// Gets or Sets objDebug
        /// </summary>
        [DataMember(Name = "objDebug", EmitDefaultValue = false)]
        public CommonResponseObjDebug objDebug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivesessionGetCurrentV1Response {\n");
            sb.Append("  mPayload: ").Append(mPayload).Append("\n");
            sb.Append("  objDebugPayload: ").Append(objDebugPayload).Append("\n");
            sb.Append("  objDebug: ").Append(objDebug).Append("\n");
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
            return this.Equals(input as ActivesessionGetCurrentV1Response);
        }

        /// <summary>
        /// Returns true if ActivesessionGetCurrentV1Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivesessionGetCurrentV1Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivesessionGetCurrentV1Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.mPayload == input.mPayload ||
                    (this.mPayload != null &&
                    this.mPayload.Equals(input.mPayload))
                ) && 
                (
                    this.objDebugPayload == input.objDebugPayload ||
                    (this.objDebugPayload != null &&
                    this.objDebugPayload.Equals(input.objDebugPayload))
                ) && 
                (
                    this.objDebug == input.objDebug ||
                    (this.objDebug != null &&
                    this.objDebug.Equals(input.objDebug))
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
                if (this.mPayload != null)
                    hashCode = hashCode * 59 + this.mPayload.GetHashCode();
                if (this.objDebugPayload != null)
                    hashCode = hashCode * 59 + this.objDebugPayload.GetHashCode();
                if (this.objDebug != null)
                    hashCode = hashCode * 59 + this.objDebug.GetHashCode();
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
