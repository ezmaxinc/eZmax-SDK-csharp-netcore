/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.44
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
            this.ObjEzsignsignature = objEzsignsignature;
            this.ObjEzsignsignatureCompound = objEzsignsignatureCompound;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignsignature
        /// </summary>
        [DataMember(Name = "objEzsignsignature", EmitDefaultValue = false)]
        public EzsignsignatureRequest ObjEzsignsignature { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzsignsignatureCompound
        /// </summary>
        [DataMember(Name = "objEzsignsignatureCompound", EmitDefaultValue = false)]
        public EzsignsignatureRequestCompound ObjEzsignsignatureCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureCreateObjectV1Request {\n");
            sb.Append("  ObjEzsignsignature: ").Append(ObjEzsignsignature).Append("\n");
            sb.Append("  ObjEzsignsignatureCompound: ").Append(ObjEzsignsignatureCompound).Append("\n");
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
                    this.ObjEzsignsignature == input.ObjEzsignsignature ||
                    (this.ObjEzsignsignature != null &&
                    this.ObjEzsignsignature.Equals(input.ObjEzsignsignature))
                ) && 
                (
                    this.ObjEzsignsignatureCompound == input.ObjEzsignsignatureCompound ||
                    (this.ObjEzsignsignatureCompound != null &&
                    this.ObjEzsignsignatureCompound.Equals(input.ObjEzsignsignatureCompound))
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
                if (this.ObjEzsignsignature != null)
                    hashCode = hashCode * 59 + this.ObjEzsignsignature.GetHashCode();
                if (this.ObjEzsignsignatureCompound != null)
                    hashCode = hashCode * 59 + this.ObjEzsignsignatureCompound.GetHashCode();
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
