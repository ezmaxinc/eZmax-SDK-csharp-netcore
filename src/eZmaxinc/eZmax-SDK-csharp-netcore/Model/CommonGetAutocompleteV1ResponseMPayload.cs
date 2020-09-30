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
    /// Generic Autocomplete Response
    /// </summary>
    [DataContract(Name = "Common-getAutocomplete-v1-Response-mPayload")]
    public partial class CommonGetAutocompleteV1ResponseMPayload : IEquatable<CommonGetAutocompleteV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetAutocompleteV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonGetAutocompleteV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetAutocompleteV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="group">The Category (ie group) for the dropdown or an empty string if not categorized (required).</param>
        /// <param name="id">The Unique ID of the element (required).</param>
        /// <param name="option">The Description of the element (required).</param>
        public CommonGetAutocompleteV1ResponseMPayload(string group = default(string), string id = default(string), string option = default(string))
        {
            // to ensure "group" is required (not null)
            this.group = group ?? throw new ArgumentNullException("group is a required property for CommonGetAutocompleteV1ResponseMPayload and cannot be null");
            // to ensure "id" is required (not null)
            this.id = id ?? throw new ArgumentNullException("id is a required property for CommonGetAutocompleteV1ResponseMPayload and cannot be null");
            // to ensure "option" is required (not null)
            this.option = option ?? throw new ArgumentNullException("option is a required property for CommonGetAutocompleteV1ResponseMPayload and cannot be null");
        }

        /// <summary>
        /// The Category (ie group) for the dropdown or an empty string if not categorized
        /// </summary>
        /// <value>The Category (ie group) for the dropdown or an empty string if not categorized</value>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string group { get; set; }

        /// <summary>
        /// The Unique ID of the element
        /// </summary>
        /// <value>The Unique ID of the element</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string id { get; set; }

        /// <summary>
        /// The Description of the element
        /// </summary>
        /// <value>The Description of the element</value>
        [DataMember(Name = "option", EmitDefaultValue = false)]
        public string option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonGetAutocompleteV1ResponseMPayload {\n");
            sb.Append("  group: ").Append(group).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  option: ").Append(option).Append("\n");
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
            return this.Equals(input as CommonGetAutocompleteV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if CommonGetAutocompleteV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonGetAutocompleteV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonGetAutocompleteV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.group == input.group ||
                    (this.group != null &&
                    this.group.Equals(input.group))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.option == input.option ||
                    (this.option != null &&
                    this.option.Equals(input.option))
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
                if (this.group != null)
                    hashCode = hashCode * 59 + this.group.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.option != null)
                    hashCode = hashCode * 59 + this.option.GetHashCode();
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