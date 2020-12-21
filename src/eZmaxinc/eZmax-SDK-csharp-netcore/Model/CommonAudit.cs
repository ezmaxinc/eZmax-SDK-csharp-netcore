/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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
    /// Gives informations about the user that created the object and the last user to have modified it.  If the object was never modified after creation, both Created and Modified informations will be the same.  Apikey details will only be provided if the changes were made by an API key.  
    /// </summary>
    [DataContract(Name = "Common-Audit")]
    public partial class CommonAudit : IEquatable<CommonAudit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAudit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonAudit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAudit" /> class.
        /// </summary>
        /// <param name="fkiUserIDCreated">The id of the User that created the object. (required).</param>
        /// <param name="fkiUserIDModified">The id of the User that made the last modification on the object. (required).</param>
        /// <param name="fkiApikeyIDCreated">The id of the API Key that created the object..</param>
        /// <param name="fkiApikeyIDModified">The id of the API Key that made the last modification on the object..</param>
        /// <param name="dtCreatedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="dtModifiedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        public CommonAudit(int fkiUserIDCreated = default(int), int fkiUserIDModified = default(int), int fkiApikeyIDCreated = default(int), int fkiApikeyIDModified = default(int), string dtCreatedDate = default(string), string dtModifiedDate = default(string))
        {
            this.fkiUserIDCreated = fkiUserIDCreated;
            this.fkiUserIDModified = fkiUserIDModified;
            // to ensure "dtCreatedDate" is required (not null)
            this.dtCreatedDate = dtCreatedDate ?? throw new ArgumentNullException("dtCreatedDate is a required property for CommonAudit and cannot be null");
            // to ensure "dtModifiedDate" is required (not null)
            this.dtModifiedDate = dtModifiedDate ?? throw new ArgumentNullException("dtModifiedDate is a required property for CommonAudit and cannot be null");
            this.fkiApikeyIDCreated = fkiApikeyIDCreated;
            this.fkiApikeyIDModified = fkiApikeyIDModified;
        }

        /// <summary>
        /// The id of the User that created the object.
        /// </summary>
        /// <value>The id of the User that created the object.</value>
        [DataMember(Name = "fkiUserIDCreated", IsRequired = true, EmitDefaultValue = false)]
        public int fkiUserIDCreated { get; set; }

        /// <summary>
        /// The id of the User that made the last modification on the object.
        /// </summary>
        /// <value>The id of the User that made the last modification on the object.</value>
        [DataMember(Name = "fkiUserIDModified", IsRequired = true, EmitDefaultValue = false)]
        public int fkiUserIDModified { get; set; }

        /// <summary>
        /// The id of the API Key that created the object.
        /// </summary>
        /// <value>The id of the API Key that created the object.</value>
        [DataMember(Name = "fkiApikeyIDCreated", EmitDefaultValue = false)]
        public int fkiApikeyIDCreated { get; set; }

        /// <summary>
        /// The id of the API Key that made the last modification on the object.
        /// </summary>
        /// <value>The id of the API Key that made the last modification on the object.</value>
        [DataMember(Name = "fkiApikeyIDModified", EmitDefaultValue = false)]
        public int fkiApikeyIDModified { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name = "dtCreatedDate", IsRequired = true, EmitDefaultValue = false)]
        public string dtCreatedDate { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name = "dtModifiedDate", IsRequired = true, EmitDefaultValue = false)]
        public string dtModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonAudit {\n");
            sb.Append("  fkiUserIDCreated: ").Append(fkiUserIDCreated).Append("\n");
            sb.Append("  fkiUserIDModified: ").Append(fkiUserIDModified).Append("\n");
            sb.Append("  fkiApikeyIDCreated: ").Append(fkiApikeyIDCreated).Append("\n");
            sb.Append("  fkiApikeyIDModified: ").Append(fkiApikeyIDModified).Append("\n");
            sb.Append("  dtCreatedDate: ").Append(dtCreatedDate).Append("\n");
            sb.Append("  dtModifiedDate: ").Append(dtModifiedDate).Append("\n");
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
            return this.Equals(input as CommonAudit);
        }

        /// <summary>
        /// Returns true if CommonAudit instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonAudit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiUserIDCreated == input.fkiUserIDCreated ||
                    this.fkiUserIDCreated.Equals(input.fkiUserIDCreated)
                ) && 
                (
                    this.fkiUserIDModified == input.fkiUserIDModified ||
                    this.fkiUserIDModified.Equals(input.fkiUserIDModified)
                ) && 
                (
                    this.fkiApikeyIDCreated == input.fkiApikeyIDCreated ||
                    this.fkiApikeyIDCreated.Equals(input.fkiApikeyIDCreated)
                ) && 
                (
                    this.fkiApikeyIDModified == input.fkiApikeyIDModified ||
                    this.fkiApikeyIDModified.Equals(input.fkiApikeyIDModified)
                ) && 
                (
                    this.dtCreatedDate == input.dtCreatedDate ||
                    (this.dtCreatedDate != null &&
                    this.dtCreatedDate.Equals(input.dtCreatedDate))
                ) && 
                (
                    this.dtModifiedDate == input.dtModifiedDate ||
                    (this.dtModifiedDate != null &&
                    this.dtModifiedDate.Equals(input.dtModifiedDate))
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
                hashCode = hashCode * 59 + this.fkiUserIDCreated.GetHashCode();
                hashCode = hashCode * 59 + this.fkiUserIDModified.GetHashCode();
                hashCode = hashCode * 59 + this.fkiApikeyIDCreated.GetHashCode();
                hashCode = hashCode * 59 + this.fkiApikeyIDModified.GetHashCode();
                if (this.dtCreatedDate != null)
                    hashCode = hashCode * 59 + this.dtCreatedDate.GetHashCode();
                if (this.dtModifiedDate != null)
                    hashCode = hashCode * 59 + this.dtModifiedDate.GetHashCode();
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
