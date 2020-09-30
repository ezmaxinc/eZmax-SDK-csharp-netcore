/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.17
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp-netcore.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Model
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
            this.dtAttemptStart = dtAttemptStart ?? throw new ArgumentNullException("dtAttemptStart is a required property for AttemptResponse and cannot be null");
            // to ensure "sAttemptResult" is required (not null)
            this.sAttemptResult = sAttemptResult ?? throw new ArgumentNullException("sAttemptResult is a required property for AttemptResponse and cannot be null");
            this.iAttemptDuration = iAttemptDuration;
        }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name = "dtAttemptStart", EmitDefaultValue = false)]
        public string dtAttemptStart { get; set; }

        /// <summary>
        /// The Success or Failure message of the attempt when we tried to call the URL to deliver the webhook event.
        /// </summary>
        /// <value>The Success or Failure message of the attempt when we tried to call the URL to deliver the webhook event.</value>
        [DataMember(Name = "sAttemptResult", EmitDefaultValue = false)]
        public string sAttemptResult { get; set; }

        /// <summary>
        /// The number of second it took to process the webhook or get an error
        /// </summary>
        /// <value>The number of second it took to process the webhook or get an error</value>
        [DataMember(Name = "iAttemptDuration", EmitDefaultValue = false)]
        public int iAttemptDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttemptResponse {\n");
            sb.Append("  dtAttemptStart: ").Append(dtAttemptStart).Append("\n");
            sb.Append("  sAttemptResult: ").Append(sAttemptResult).Append("\n");
            sb.Append("  iAttemptDuration: ").Append(iAttemptDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                    this.dtAttemptStart == input.dtAttemptStart ||
                    (this.dtAttemptStart != null &&
                    this.dtAttemptStart.Equals(input.dtAttemptStart))
                ) && 
                (
                    this.sAttemptResult == input.sAttemptResult ||
                    (this.sAttemptResult != null &&
                    this.sAttemptResult.Equals(input.sAttemptResult))
                ) && 
                (
                    this.iAttemptDuration == input.iAttemptDuration ||
                    this.iAttemptDuration.Equals(input.iAttemptDuration)
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
                if (this.dtAttemptStart != null)
                    hashCode = hashCode * 59 + this.dtAttemptStart.GetHashCode();
                if (this.sAttemptResult != null)
                    hashCode = hashCode * 59 + this.sAttemptResult.GetHashCode();
                hashCode = hashCode * 59 + this.iAttemptDuration.GetHashCode();
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