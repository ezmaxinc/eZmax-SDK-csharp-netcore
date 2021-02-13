/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.
 *
 * The version of the OpenAPI document: 1.0.30
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
    /// Payload for the /1/object/ezsigndocument/createObject API Request
    /// </summary>
    [DataContract(Name = "ezsigndocument-createObject-v1-Response-mPayload")]
    public partial class EzsigndocumentCreateObjectV1ResponseMPayload : IEquatable<EzsigndocumentCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiEzsigndocumentID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public EzsigndocumentCreateObjectV1ResponseMPayload(List<int> aPkiEzsigndocumentID = default(List<int>))
        {
            // to ensure "aPkiEzsigndocumentID" is required (not null)
            this.a_pkiEzsigndocumentID = aPkiEzsigndocumentID ?? throw new ArgumentNullException("aPkiEzsigndocumentID is a required property for EzsigndocumentCreateObjectV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name = "a_pkiEzsigndocumentID", IsRequired = true, EmitDefaultValue = false)]
        public List<int> a_pkiEzsigndocumentID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentCreateObjectV1ResponseMPayload {\n");
            sb.Append("  a_pkiEzsigndocumentID: ").Append(a_pkiEzsigndocumentID).Append("\n");
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
            return this.Equals(input as EzsigndocumentCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigndocumentCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_pkiEzsigndocumentID == input.a_pkiEzsigndocumentID ||
                    this.a_pkiEzsigndocumentID != null &&
                    input.a_pkiEzsigndocumentID != null &&
                    this.a_pkiEzsigndocumentID.SequenceEqual(input.a_pkiEzsigndocumentID)
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
                if (this.a_pkiEzsigndocumentID != null)
                    hashCode = hashCode * 59 + this.a_pkiEzsigndocumentID.GetHashCode();
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
