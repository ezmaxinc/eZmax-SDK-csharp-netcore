/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.20
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
    /// Definition of objSQLQuery Object
    /// </summary>
    [DataContract(Name = "Common-Response-objSQLQuery")]
    public partial class CommonResponseObjSQLQuery : IEquatable<CommonResponseObjSQLQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjSQLQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseObjSQLQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseObjSQLQuery" /> class.
        /// </summary>
        /// <param name="sQuery">The SQL Query (required).</param>
        /// <param name="fDuration">Execution time of the SQL Query in seconds (required).</param>
        public CommonResponseObjSQLQuery(string sQuery = default(string), float fDuration = default(float))
        {
            // to ensure "sQuery" is required (not null)
            this.sQuery = sQuery ?? throw new ArgumentNullException("sQuery is a required property for CommonResponseObjSQLQuery and cannot be null");
            this.fDuration = fDuration;
        }

        /// <summary>
        /// The SQL Query
        /// </summary>
        /// <value>The SQL Query</value>
        [DataMember(Name = "sQuery", IsRequired = true, EmitDefaultValue = false)]
        public string sQuery { get; set; }

        /// <summary>
        /// Execution time of the SQL Query in seconds
        /// </summary>
        /// <value>Execution time of the SQL Query in seconds</value>
        [DataMember(Name = "fDuration", IsRequired = true, EmitDefaultValue = false)]
        public float fDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseObjSQLQuery {\n");
            sb.Append("  sQuery: ").Append(sQuery).Append("\n");
            sb.Append("  fDuration: ").Append(fDuration).Append("\n");
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
            return this.Equals(input as CommonResponseObjSQLQuery);
        }

        /// <summary>
        /// Returns true if CommonResponseObjSQLQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseObjSQLQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseObjSQLQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sQuery == input.sQuery ||
                    (this.sQuery != null &&
                    this.sQuery.Equals(input.sQuery))
                ) && 
                (
                    this.fDuration == input.fDuration ||
                    this.fDuration.Equals(input.fDuration)
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
                if (this.sQuery != null)
                    hashCode = hashCode * 59 + this.sQuery.GetHashCode();
                hashCode = hashCode * 59 + this.fDuration.GetHashCode();
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
