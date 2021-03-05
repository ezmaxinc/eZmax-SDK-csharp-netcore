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
    /// Payload for the /1/object/franchisereferalincome/createObject API Request
    /// </summary>
    [DataContract(Name = "franchisereferalincome-createObject-v1-Response-mPayload")]
    public partial class FranchisereferalincomeCreateObjectV1ResponseMPayload : IEquatable<FranchisereferalincomeCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchisereferalincomeCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiFranchisereferalincomeID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public FranchisereferalincomeCreateObjectV1ResponseMPayload(List<int> aPkiFranchisereferalincomeID = default(List<int>))
        {
            // to ensure "aPkiFranchisereferalincomeID" is required (not null)
            this.a_pkiFranchisereferalincomeID = aPkiFranchisereferalincomeID ?? throw new ArgumentNullException("aPkiFranchisereferalincomeID is a required property for FranchisereferalincomeCreateObjectV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name = "a_pkiFranchisereferalincomeID", IsRequired = true, EmitDefaultValue = false)]
        public List<int> a_pkiFranchisereferalincomeID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeCreateObjectV1ResponseMPayload {\n");
            sb.Append("  a_pkiFranchisereferalincomeID: ").Append(a_pkiFranchisereferalincomeID).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_pkiFranchisereferalincomeID == input.a_pkiFranchisereferalincomeID ||
                    this.a_pkiFranchisereferalincomeID != null &&
                    input.a_pkiFranchisereferalincomeID != null &&
                    this.a_pkiFranchisereferalincomeID.SequenceEqual(input.a_pkiFranchisereferalincomeID)
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
                if (this.a_pkiFranchisereferalincomeID != null)
                    hashCode = hashCode * 59 + this.a_pkiFranchisereferalincomeID.GetHashCode();
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
