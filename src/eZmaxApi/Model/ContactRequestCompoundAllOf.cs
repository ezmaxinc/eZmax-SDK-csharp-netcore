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
    /// ContactRequestCompoundAllOf
    /// </summary>
    [DataContract(Name = "contact_RequestCompound_allOf")]
    public partial class ContactRequestCompoundAllOf : IEquatable<ContactRequestCompoundAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequestCompoundAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactRequestCompoundAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactRequestCompoundAllOf" /> class.
        /// </summary>
        /// <param name="objContactinformations">objContactinformations (required).</param>
        public ContactRequestCompoundAllOf(ContactinformationsRequestCompound objContactinformations = default(ContactinformationsRequestCompound))
        {
            // to ensure "objContactinformations" is required (not null)
            this.ObjContactinformations = objContactinformations ?? throw new ArgumentNullException("objContactinformations is a required property for ContactRequestCompoundAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ObjContactinformations
        /// </summary>
        [DataMember(Name = "objContactinformations", IsRequired = true, EmitDefaultValue = false)]
        public ContactinformationsRequestCompound ObjContactinformations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactRequestCompoundAllOf {\n");
            sb.Append("  ObjContactinformations: ").Append(ObjContactinformations).Append("\n");
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
            return this.Equals(input as ContactRequestCompoundAllOf);
        }

        /// <summary>
        /// Returns true if ContactRequestCompoundAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactRequestCompoundAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactRequestCompoundAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjContactinformations == input.ObjContactinformations ||
                    (this.ObjContactinformations != null &&
                    this.ObjContactinformations.Equals(input.ObjContactinformations))
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
                if (this.ObjContactinformations != null)
                    hashCode = hashCode * 59 + this.ObjContactinformations.GetHashCode();
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
