/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.17
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
    /// Request for the /1/object/ezsigndocument/createObject API Request
    /// </summary>
    [DataContract(Name = "ezsigndocument-createObject-v1-Request")]
    public partial class EzsigndocumentCreateObjectV1Request : IEquatable<EzsigndocumentCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigndocument">objEzsigndocument.</param>
        /// <param name="objEzsigndocumentCompound">objEzsigndocumentCompound.</param>
        public EzsigndocumentCreateObjectV1Request(EzsigndocumentRequest objEzsigndocument = default(EzsigndocumentRequest), EzsigndocumentRequestCompound objEzsigndocumentCompound = default(EzsigndocumentRequestCompound))
        {
            this.objEzsigndocument = objEzsigndocument;
            this.objEzsigndocumentCompound = objEzsigndocumentCompound;
        }

        /// <summary>
        /// Gets or Sets objEzsigndocument
        /// </summary>
        [DataMember(Name = "objEzsigndocument", EmitDefaultValue = false)]
        public EzsigndocumentRequest objEzsigndocument { get; set; }

        /// <summary>
        /// Gets or Sets objEzsigndocumentCompound
        /// </summary>
        [DataMember(Name = "objEzsigndocumentCompound", EmitDefaultValue = false)]
        public EzsigndocumentRequestCompound objEzsigndocumentCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentCreateObjectV1Request {\n");
            sb.Append("  objEzsigndocument: ").Append(objEzsigndocument).Append("\n");
            sb.Append("  objEzsigndocumentCompound: ").Append(objEzsigndocumentCompound).Append("\n");
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
            return this.Equals(input as EzsigndocumentCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsigndocumentCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objEzsigndocument == input.objEzsigndocument ||
                    (this.objEzsigndocument != null &&
                    this.objEzsigndocument.Equals(input.objEzsigndocument))
                ) && 
                (
                    this.objEzsigndocumentCompound == input.objEzsigndocumentCompound ||
                    (this.objEzsigndocumentCompound != null &&
                    this.objEzsigndocumentCompound.Equals(input.objEzsigndocumentCompound))
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
                if (this.objEzsigndocument != null)
                    hashCode = hashCode * 59 + this.objEzsigndocument.GetHashCode();
                if (this.objEzsigndocumentCompound != null)
                    hashCode = hashCode * 59 + this.objEzsigndocumentCompound.GetHashCode();
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