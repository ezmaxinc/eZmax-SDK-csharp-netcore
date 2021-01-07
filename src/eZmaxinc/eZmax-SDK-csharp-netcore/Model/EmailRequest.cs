/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.24
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
    /// A Contact Object
    /// </summary>
    [DataContract(Name = "email-Request")]
    public partial class EmailRequest : IEquatable<EmailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailRequest" /> class.
        /// </summary>
        /// <param name="fkiEmailtypeID">The unique ID of the Emailtype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| (required).</param>
        /// <param name="sEmailAddress">The email address. (required).</param>
        public EmailRequest(int fkiEmailtypeID = default(int), string sEmailAddress = default(string))
        {
            this.fkiEmailtypeID = fkiEmailtypeID;
            // to ensure "sEmailAddress" is required (not null)
            this.sEmailAddress = sEmailAddress ?? throw new ArgumentNullException("sEmailAddress is a required property for EmailRequest and cannot be null");
        }

        /// <summary>
        /// The unique ID of the Emailtype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home|
        /// </summary>
        /// <value>The unique ID of the Emailtype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home|</value>
        [DataMember(Name = "fkiEmailtypeID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiEmailtypeID { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name = "sEmailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string sEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailRequest {\n");
            sb.Append("  fkiEmailtypeID: ").Append(fkiEmailtypeID).Append("\n");
            sb.Append("  sEmailAddress: ").Append(sEmailAddress).Append("\n");
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
            return this.Equals(input as EmailRequest);
        }

        /// <summary>
        /// Returns true if EmailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiEmailtypeID == input.fkiEmailtypeID ||
                    this.fkiEmailtypeID.Equals(input.fkiEmailtypeID)
                ) && 
                (
                    this.sEmailAddress == input.sEmailAddress ||
                    (this.sEmailAddress != null &&
                    this.sEmailAddress.Equals(input.sEmailAddress))
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
                hashCode = hashCode * 59 + this.fkiEmailtypeID.GetHashCode();
                if (this.sEmailAddress != null)
                    hashCode = hashCode * 59 + this.sEmailAddress.GetHashCode();
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
