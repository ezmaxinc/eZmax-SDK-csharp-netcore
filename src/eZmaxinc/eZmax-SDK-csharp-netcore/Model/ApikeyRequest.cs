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
    /// An Apikey Object
    /// </summary>
    [DataContract(Name = "apikey-Request")]
    public partial class ApikeyRequest : IEquatable<ApikeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApikeyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyRequest" /> class.
        /// </summary>
        /// <param name="fkiUserID">The unique ID of the User (required).</param>
        /// <param name="objApikeyDescription">objApikeyDescription (required).</param>
        public ApikeyRequest(int fkiUserID = default(int), MultilingualApikeyDescription objApikeyDescription = default(MultilingualApikeyDescription))
        {
            this.fkiUserID = fkiUserID;
            // to ensure "objApikeyDescription" is required (not null)
            this.objApikeyDescription = objApikeyDescription ?? throw new ArgumentNullException("objApikeyDescription is a required property for ApikeyRequest and cannot be null");
        }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name = "fkiUserID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiUserID { get; set; }

        /// <summary>
        /// Gets or Sets objApikeyDescription
        /// </summary>
        [DataMember(Name = "objApikeyDescription", IsRequired = true, EmitDefaultValue = false)]
        public MultilingualApikeyDescription objApikeyDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApikeyRequest {\n");
            sb.Append("  fkiUserID: ").Append(fkiUserID).Append("\n");
            sb.Append("  objApikeyDescription: ").Append(objApikeyDescription).Append("\n");
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
            return this.Equals(input as ApikeyRequest);
        }

        /// <summary>
        /// Returns true if ApikeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiUserID == input.fkiUserID ||
                    this.fkiUserID.Equals(input.fkiUserID)
                ) && 
                (
                    this.objApikeyDescription == input.objApikeyDescription ||
                    (this.objApikeyDescription != null &&
                    this.objApikeyDescription.Equals(input.objApikeyDescription))
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
                hashCode = hashCode * 59 + this.fkiUserID.GetHashCode();
                if (this.objApikeyDescription != null)
                    hashCode = hashCode * 59 + this.objApikeyDescription.GetHashCode();
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
