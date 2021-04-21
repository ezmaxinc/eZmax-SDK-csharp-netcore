/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.41
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
    /// Request for the /1/object/franchisereferalincome/createObject API Request
    /// </summary>
    [DataContract(Name = "franchisereferalincome-createObject-v1-Request")]
    public partial class FranchisereferalincomeCreateObjectV1Request : IEquatable<FranchisereferalincomeCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objFranchisereferalincome">objFranchisereferalincome.</param>
        /// <param name="objFranchisereferalincomeCompound">objFranchisereferalincomeCompound.</param>
        public FranchisereferalincomeCreateObjectV1Request(FranchisereferalincomeRequest objFranchisereferalincome = default(FranchisereferalincomeRequest), FranchisereferalincomeRequestCompound objFranchisereferalincomeCompound = default(FranchisereferalincomeRequestCompound))
        {
            this.ObjFranchisereferalincome = objFranchisereferalincome;
            this.ObjFranchisereferalincomeCompound = objFranchisereferalincomeCompound;
        }

        /// <summary>
        /// Gets or Sets ObjFranchisereferalincome
        /// </summary>
        [DataMember(Name = "objFranchisereferalincome", EmitDefaultValue = false)]
        public FranchisereferalincomeRequest ObjFranchisereferalincome { get; set; }

        /// <summary>
        /// Gets or Sets ObjFranchisereferalincomeCompound
        /// </summary>
        [DataMember(Name = "objFranchisereferalincomeCompound", EmitDefaultValue = false)]
        public FranchisereferalincomeRequestCompound ObjFranchisereferalincomeCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeCreateObjectV1Request {\n");
            sb.Append("  ObjFranchisereferalincome: ").Append(ObjFranchisereferalincome).Append("\n");
            sb.Append("  ObjFranchisereferalincomeCompound: ").Append(ObjFranchisereferalincomeCompound).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjFranchisereferalincome == input.ObjFranchisereferalincome ||
                    (this.ObjFranchisereferalincome != null &&
                    this.ObjFranchisereferalincome.Equals(input.ObjFranchisereferalincome))
                ) && 
                (
                    this.ObjFranchisereferalincomeCompound == input.ObjFranchisereferalincomeCompound ||
                    (this.ObjFranchisereferalincomeCompound != null &&
                    this.ObjFranchisereferalincomeCompound.Equals(input.ObjFranchisereferalincomeCompound))
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
                if (this.ObjFranchisereferalincome != null)
                    hashCode = hashCode * 59 + this.ObjFranchisereferalincome.GetHashCode();
                if (this.ObjFranchisereferalincomeCompound != null)
                    hashCode = hashCode * 59 + this.ObjFranchisereferalincomeCompound.GetHashCode();
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
