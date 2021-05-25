/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.43
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
    /// An Attempt object
    /// </summary>
    [DataContract(Name = "attempt-Response")]
    public partial class AttemptResponse : IEquatable<AttemptResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttemptResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptResponse" /> class.
        /// </summary>
        /// <param name="dtAttemptStart">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="sAttemptResult">The Success or Failure message of the attempt when we tried to call the URL to deliver the webhook event. (required).</param>
        /// <param name="iAttemptDuration">The number of second it took to process the webhook or get an error (required).</param>
        public AttemptResponse(string dtAttemptStart = default(string), string sAttemptResult = default(string), int iAttemptDuration = default(int))
        {
            // to ensure "dtAttemptStart" is required (not null)
            this.DtAttemptStart = dtAttemptStart ?? throw new ArgumentNullException("dtAttemptStart is a required property for AttemptResponse and cannot be null");
            // to ensure "sAttemptResult" is required (not null)
            this.SAttemptResult = sAttemptResult ?? throw new ArgumentNullException("sAttemptResult is a required property for AttemptResponse and cannot be null");
            this.IAttemptDuration = iAttemptDuration;
        }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name = "dtAttemptStart", IsRequired = true, EmitDefaultValue = false)]
        public string DtAttemptStart { get; set; }

        /// <summary>
        /// The Success or Failure message of the attempt when we tried to call the URL to deliver the webhook event.
        /// </summary>
        /// <value>The Success or Failure message of the attempt when we tried to call the URL to deliver the webhook event.</value>
        [DataMember(Name = "sAttemptResult", IsRequired = true, EmitDefaultValue = false)]
        public string SAttemptResult { get; set; }

        /// <summary>
        /// The number of second it took to process the webhook or get an error
        /// </summary>
        /// <value>The number of second it took to process the webhook or get an error</value>
        [DataMember(Name = "iAttemptDuration", IsRequired = true, EmitDefaultValue = false)]
        public int IAttemptDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttemptResponse {\n");
            sb.Append("  DtAttemptStart: ").Append(DtAttemptStart).Append("\n");
            sb.Append("  SAttemptResult: ").Append(SAttemptResult).Append("\n");
            sb.Append("  IAttemptDuration: ").Append(IAttemptDuration).Append("\n");
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
            return this.Equals(input as AttemptResponse);
        }

        /// <summary>
        /// Returns true if AttemptResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AttemptResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttemptResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DtAttemptStart == input.DtAttemptStart ||
                    (this.DtAttemptStart != null &&
                    this.DtAttemptStart.Equals(input.DtAttemptStart))
                ) && 
                (
                    this.SAttemptResult == input.SAttemptResult ||
                    (this.SAttemptResult != null &&
                    this.SAttemptResult.Equals(input.SAttemptResult))
                ) && 
                (
                    this.IAttemptDuration == input.IAttemptDuration ||
                    this.IAttemptDuration.Equals(input.IAttemptDuration)
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
                if (this.DtAttemptStart != null)
                    hashCode = hashCode * 59 + this.DtAttemptStart.GetHashCode();
                if (this.SAttemptResult != null)
                    hashCode = hashCode * 59 + this.SAttemptResult.GetHashCode();
                hashCode = hashCode * 59 + this.IAttemptDuration.GetHashCode();
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
