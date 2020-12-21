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
    /// Request for the /1/object/ezsignsignature/createObject API Request
    /// </summary>
    [DataContract(Name = "ezsignsignature-createObject-v1-Request")]
    public partial class EzsignsignatureCreateObjectV1Request : IEquatable<EzsignsignatureCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignsignature">objEzsignsignature.</param>
        /// <param name="objEzsignsignatureCompound">objEzsignsignatureCompound.</param>
        public EzsignsignatureCreateObjectV1Request(EzsignsignatureRequest objEzsignsignature = default(EzsignsignatureRequest), EzsignsignatureRequestCompound objEzsignsignatureCompound = default(EzsignsignatureRequestCompound))
        {
            this.objEzsignsignature = objEzsignsignature;
            this.objEzsignsignatureCompound = objEzsignsignatureCompound;
        }

        /// <summary>
        /// Gets or Sets objEzsignsignature
        /// </summary>
        [DataMember(Name = "objEzsignsignature", EmitDefaultValue = false)]
        public EzsignsignatureRequest objEzsignsignature { get; set; }

        /// <summary>
        /// Gets or Sets objEzsignsignatureCompound
        /// </summary>
        [DataMember(Name = "objEzsignsignatureCompound", EmitDefaultValue = false)]
        public EzsignsignatureRequestCompound objEzsignsignatureCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureCreateObjectV1Request {\n");
            sb.Append("  objEzsignsignature: ").Append(objEzsignsignature).Append("\n");
            sb.Append("  objEzsignsignatureCompound: ").Append(objEzsignsignatureCompound).Append("\n");
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
            return this.Equals(input as EzsignsignatureCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsignsignatureCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objEzsignsignature == input.objEzsignsignature ||
                    (this.objEzsignsignature != null &&
                    this.objEzsignsignature.Equals(input.objEzsignsignature))
                ) && 
                (
                    this.objEzsignsignatureCompound == input.objEzsignsignatureCompound ||
                    (this.objEzsignsignatureCompound != null &&
                    this.objEzsignsignatureCompound.Equals(input.objEzsignsignatureCompound))
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
                if (this.objEzsignsignature != null)
                    hashCode = hashCode * 59 + this.objEzsignsignature.GetHashCode();
                if (this.objEzsignsignatureCompound != null)
                    hashCode = hashCode * 59 + this.objEzsignsignatureCompound.GetHashCode();
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
