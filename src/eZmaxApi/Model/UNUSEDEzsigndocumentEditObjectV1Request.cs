/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.42
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
    /// Request for the /1/object/ezsigndocument/editObject API Request
    /// </summary>
    [DataContract(Name = "UNUSED-ezsigndocument-editObject-v1-Request")]
    public partial class UNUSEDEzsigndocumentEditObjectV1Request : IEquatable<UNUSEDEzsigndocumentEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UNUSEDEzsigndocumentEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigndocument">objEzsigndocument.</param>
        public UNUSEDEzsigndocumentEditObjectV1Request(EzsigndocumentRequest objEzsigndocument = default(EzsigndocumentRequest))
        {
            this.ObjEzsigndocument = objEzsigndocument;
        }

        /// <summary>
        /// Gets or Sets ObjEzsigndocument
        /// </summary>
        [DataMember(Name = "objEzsigndocument", EmitDefaultValue = false)]
        public EzsigndocumentRequest ObjEzsigndocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UNUSEDEzsigndocumentEditObjectV1Request {\n");
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
            return this.Equals(input as UNUSEDEzsigndocumentEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if UNUSEDEzsigndocumentEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UNUSEDEzsigndocumentEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UNUSEDEzsigndocumentEditObjectV1Request input)
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
