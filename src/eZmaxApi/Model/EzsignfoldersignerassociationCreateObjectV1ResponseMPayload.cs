/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.45
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
    /// Payload for the /1/object/ezsignfoldersignerassociation/createObject API Request
    /// </summary>
    [DataContract(Name = "ezsignfoldersignerassociation-createObject-v1-Response-mPayload")]
    public partial class EzsignfoldersignerassociationCreateObjectV1ResponseMPayload : IEquatable<EzsignfoldersignerassociationCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiEzsignfoldersignerassociationID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public EzsignfoldersignerassociationCreateObjectV1ResponseMPayload(List<int> aPkiEzsignfoldersignerassociationID = default(List<int>))
        {
            // to ensure "aPkiEzsignfoldersignerassociationID" is required (not null)
            this.APkiEzsignfoldersignerassociationID = aPkiEzsignfoldersignerassociationID ?? throw new ArgumentNullException("aPkiEzsignfoldersignerassociationID is a required property for EzsignfoldersignerassociationCreateObjectV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name = "a_pkiEzsignfoldersignerassociationID", IsRequired = true, EmitDefaultValue = false)]
        public List<int> APkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationCreateObjectV1ResponseMPayload {\n");
            sb.Append("  APkiEzsignfoldersignerassociationID: ").Append(APkiEzsignfoldersignerassociationID).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APkiEzsignfoldersignerassociationID == input.APkiEzsignfoldersignerassociationID ||
                    this.APkiEzsignfoldersignerassociationID != null &&
                    input.APkiEzsignfoldersignerassociationID != null &&
                    this.APkiEzsignfoldersignerassociationID.SequenceEqual(input.APkiEzsignfoldersignerassociationID)
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
                if (this.APkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.APkiEzsignfoldersignerassociationID.GetHashCode();
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
