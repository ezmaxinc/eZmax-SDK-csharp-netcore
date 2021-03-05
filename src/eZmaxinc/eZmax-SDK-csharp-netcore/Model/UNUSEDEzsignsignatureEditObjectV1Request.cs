/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.32
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
    /// Request for the /1/object/ezsignsignature/editObject API Request
    /// </summary>
    [DataContract(Name = "UNUSED-ezsignsignature-editObject-v1-Request")]
    public partial class UNUSEDEzsignsignatureEditObjectV1Request : IEquatable<UNUSEDEzsignsignatureEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UNUSEDEzsignsignatureEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignsignature">objEzsignsignature.</param>
        public UNUSEDEzsignsignatureEditObjectV1Request(EzsignsignatureRequest objEzsignsignature = default(EzsignsignatureRequest))
        {
            this.objEzsignsignature = objEzsignsignature;
        }

        /// <summary>
        /// Gets or Sets objEzsignsignature
        /// </summary>
        [DataMember(Name = "objEzsignsignature", EmitDefaultValue = false)]
        public EzsignsignatureRequest objEzsignsignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UNUSEDEzsignsignatureEditObjectV1Request {\n");
            sb.Append("  objEzsignsignature: ").Append(objEzsignsignature).Append("\n");
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
            return this.Equals(input as UNUSEDEzsignsignatureEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if UNUSEDEzsignsignatureEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UNUSEDEzsignsignatureEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UNUSEDEzsignsignatureEditObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objEzsignsignature == input.objEzsignsignature ||
                    (this.objEzsignsignature != null &&
                    this.objEzsignsignature.Equals(input.objEzsignsignature))
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
