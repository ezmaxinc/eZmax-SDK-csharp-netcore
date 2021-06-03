/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
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
    /// Response for the /1/object/ezsigndocument/editObject API Request
    /// </summary>
    [DataContract(Name = "UNUSED-ezsigndocument-editObject-v1-Response")]
    public partial class UNUSEDEzsigndocumentEditObjectV1Response : IEquatable<UNUSEDEzsigndocumentEditObjectV1Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UNUSEDEzsigndocumentEditObjectV1Response" /> class.
        /// </summary>
        /// <param name="objDebugPayload">objDebugPayload.</param>
        /// <param name="objDebug">objDebug.</param>
        public UNUSEDEzsigndocumentEditObjectV1Response(CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug))
        {
            this.ObjDebugPayload = objDebugPayload;
            this.ObjDebug = objDebug;
        }

        /// <summary>
        /// Gets or Sets ObjDebugPayload
        /// </summary>
        [DataMember(Name = "objDebugPayload", EmitDefaultValue = false)]
        public CommonResponseObjDebugPayload ObjDebugPayload { get; set; }

        /// <summary>
        /// Gets or Sets ObjDebug
        /// </summary>
        [DataMember(Name = "objDebug", EmitDefaultValue = false)]
        public CommonResponseObjDebug ObjDebug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UNUSEDEzsigndocumentEditObjectV1Response {\n");
            sb.Append("  ObjDebugPayload: ").Append(ObjDebugPayload).Append("\n");
            sb.Append("  ObjDebug: ").Append(ObjDebug).Append("\n");
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
            return this.Equals(input as UNUSEDEzsigndocumentEditObjectV1Response);
        }

        /// <summary>
        /// Returns true if UNUSEDEzsigndocumentEditObjectV1Response instances are equal
        /// </summary>
        /// <param name="input">Instance of UNUSEDEzsigndocumentEditObjectV1Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UNUSEDEzsigndocumentEditObjectV1Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjDebugPayload == input.ObjDebugPayload ||
                    (this.ObjDebugPayload != null &&
                    this.ObjDebugPayload.Equals(input.ObjDebugPayload))
                ) && 
                (
                    this.ObjDebug == input.ObjDebug ||
                    (this.ObjDebug != null &&
                    this.ObjDebug.Equals(input.ObjDebug))
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
                if (this.ObjDebugPayload != null)
                    hashCode = hashCode * 59 + this.ObjDebugPayload.GetHashCode();
                if (this.ObjDebug != null)
                    hashCode = hashCode * 59 + this.ObjDebug.GetHashCode();
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
