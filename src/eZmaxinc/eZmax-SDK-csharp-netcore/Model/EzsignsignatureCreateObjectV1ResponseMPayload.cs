/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.12
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp-netcore.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Model
{
    /// <summary>
    /// Payload for the /1/object/ezsignsignature/editObject API Request
    /// </summary>
    [DataContract(Name = "ezsignsignature-createObject-v1-Response-mPayload")]
    public partial class EzsignsignatureCreateObjectV1ResponseMPayload : IEquatable<EzsignsignatureCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignatureCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiEzsignsignatureID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public EzsignsignatureCreateObjectV1ResponseMPayload(List<int> aPkiEzsignsignatureID = default(List<int>))
        {
            // to ensure "aPkiEzsignsignatureID" is required (not null)
            this.a_pkiEzsignsignatureID = aPkiEzsignsignatureID ?? throw new ArgumentNullException("aPkiEzsignsignatureID is a required property for EzsignsignatureCreateObjectV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name = "a_pkiEzsignsignatureID", EmitDefaultValue = false)]
        public List<int> a_pkiEzsignsignatureID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureCreateObjectV1ResponseMPayload {\n");
            sb.Append("  a_pkiEzsignsignatureID: ").Append(a_pkiEzsignsignatureID).Append("\n");
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
            return this.Equals(input as EzsignsignatureCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignsignatureCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_pkiEzsignsignatureID == input.a_pkiEzsignsignatureID ||
                    this.a_pkiEzsignsignatureID != null &&
                    input.a_pkiEzsignsignatureID != null &&
                    this.a_pkiEzsignsignatureID.SequenceEqual(input.a_pkiEzsignsignatureID)
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
                if (this.a_pkiEzsignsignatureID != null)
                    hashCode = hashCode * 59 + this.a_pkiEzsignsignatureID.GetHashCode();
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
