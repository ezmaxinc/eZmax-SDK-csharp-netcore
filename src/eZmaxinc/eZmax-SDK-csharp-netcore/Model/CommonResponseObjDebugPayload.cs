/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.35
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
    /// This is a debug object containing debugging information on the actual function
    /// </summary>
    [DataContract(Name = "Common-Response-objDebugPayload")]
    public partial class CommonResponseObjDebugPayload : IEquatable<CommonResponseObjDebugPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjDebugPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseObjDebugPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjDebugPayload" /> class.
        /// </summary>
        /// <param name="iVersionMin">The minimum version of the function that can be called (required).</param>
        /// <param name="iVersionMax">The maximum version of the function that can be called (required).</param>
        /// <param name="aRequiredPermissions">An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them. (required).</param>
        public CommonResponseObjDebugPayload(int iVersionMin = default(int), int iVersionMax = default(int), List<int> aRequiredPermissions = default(List<int>))
        {
            this.iVersionMin = iVersionMin;
            this.iVersionMax = iVersionMax;
            // to ensure "aRequiredPermissions" is required (not null)
            this.a_RequiredPermissions = aRequiredPermissions ?? throw new ArgumentNullException("aRequiredPermissions is a required property for CommonResponseObjDebugPayload and cannot be null");
        }

        /// <summary>
        /// The minimum version of the function that can be called
        /// </summary>
        /// <value>The minimum version of the function that can be called</value>
        [DataMember(Name = "iVersionMin", IsRequired = true, EmitDefaultValue = false)]
        public int iVersionMin { get; set; }

        /// <summary>
        /// The maximum version of the function that can be called
        /// </summary>
        /// <value>The maximum version of the function that can be called</value>
        [DataMember(Name = "iVersionMax", IsRequired = true, EmitDefaultValue = false)]
        public int iVersionMax { get; set; }

        /// <summary>
        /// An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them.
        /// </summary>
        /// <value>An array of permissions required to access this function.  If the value \&quot;0\&quot; is present in the array, anyone can call this function.  You must have one of the permission to access the function. You don&#39;t need to have all of them.</value>
        [DataMember(Name = "a_RequiredPermissions", IsRequired = true, EmitDefaultValue = false)]
        public List<int> a_RequiredPermissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseObjDebugPayload {\n");
            sb.Append("  iVersionMin: ").Append(iVersionMin).Append("\n");
            sb.Append("  iVersionMax: ").Append(iVersionMax).Append("\n");
            sb.Append("  a_RequiredPermissions: ").Append(a_RequiredPermissions).Append("\n");
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
            return this.Equals(input as CommonResponseObjDebugPayload);
        }

        /// <summary>
        /// Returns true if CommonResponseObjDebugPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseObjDebugPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseObjDebugPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.iVersionMin == input.iVersionMin ||
                    this.iVersionMin.Equals(input.iVersionMin)
                ) && 
                (
                    this.iVersionMax == input.iVersionMax ||
                    this.iVersionMax.Equals(input.iVersionMax)
                ) && 
                (
                    this.a_RequiredPermissions == input.a_RequiredPermissions ||
                    this.a_RequiredPermissions != null &&
                    input.a_RequiredPermissions != null &&
                    this.a_RequiredPermissions.SequenceEqual(input.a_RequiredPermissions)
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
                hashCode = hashCode * 59 + this.iVersionMin.GetHashCode();
                hashCode = hashCode * 59 + this.iVersionMax.GetHashCode();
                if (this.a_RequiredPermissions != null)
                    hashCode = hashCode * 59 + this.a_RequiredPermissions.GetHashCode();
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
