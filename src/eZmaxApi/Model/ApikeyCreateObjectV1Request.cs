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
    /// Request for the /1/object/apikey/createObject API Request
    /// </summary>
    [DataContract(Name = "apikey-createObject-v1-Request")]
    public partial class ApikeyCreateObjectV1Request : IEquatable<ApikeyCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objApikey">objApikey.</param>
        /// <param name="objApikeyCompound">objApikeyCompound.</param>
        public ApikeyCreateObjectV1Request(ApikeyRequest objApikey = default(ApikeyRequest), ApikeyRequestCompound objApikeyCompound = default(ApikeyRequestCompound))
        {
            this.ObjApikey = objApikey;
            this.ObjApikeyCompound = objApikeyCompound;
        }

        /// <summary>
        /// Gets or Sets ObjApikey
        /// </summary>
        [DataMember(Name = "objApikey", EmitDefaultValue = false)]
        public ApikeyRequest ObjApikey { get; set; }

        /// <summary>
        /// Gets or Sets ObjApikeyCompound
        /// </summary>
        [DataMember(Name = "objApikeyCompound", EmitDefaultValue = false)]
        public ApikeyRequestCompound ObjApikeyCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApikeyCreateObjectV1Request {\n");
            sb.Append("  ObjApikey: ").Append(ObjApikey).Append("\n");
            sb.Append("  ObjApikeyCompound: ").Append(ObjApikeyCompound).Append("\n");
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
            return this.Equals(input as ApikeyCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if ApikeyCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjApikey == input.ObjApikey ||
                    (this.ObjApikey != null &&
                    this.ObjApikey.Equals(input.ObjApikey))
                ) && 
                (
                    this.ObjApikeyCompound == input.ObjApikeyCompound ||
                    (this.ObjApikeyCompound != null &&
                    this.ObjApikeyCompound.Equals(input.ObjApikeyCompound))
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
                if (this.ObjApikey != null)
                    hashCode = hashCode * 59 + this.ObjApikey.GetHashCode();
                if (this.ObjApikeyCompound != null)
                    hashCode = hashCode * 59 + this.ObjApikeyCompound.GetHashCode();
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
