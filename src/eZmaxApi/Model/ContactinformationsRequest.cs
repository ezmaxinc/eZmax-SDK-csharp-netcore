/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.39
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
    /// A Contactinformations Object
    /// </summary>
    [DataContract(Name = "contactinformations-Request")]
    public partial class ContactinformationsRequest : IEquatable<ContactinformationsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactinformationsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequest" /> class.
        /// </summary>
        /// <param name="iAddressDefault">The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iPhoneDefault">The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iEmailDefault">The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iWebsiteDefault">The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        public ContactinformationsRequest(int iAddressDefault = default(int), int iPhoneDefault = default(int), int iEmailDefault = default(int), int iWebsiteDefault = default(int))
        {
            this.IAddressDefault = iAddressDefault;
            this.IPhoneDefault = iPhoneDefault;
            this.IEmailDefault = iEmailDefault;
            this.IWebsiteDefault = iWebsiteDefault;
        }

        /// <summary>
        /// The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name = "iAddressDefault", IsRequired = true, EmitDefaultValue = false)]
        public int IAddressDefault { get; set; }

        /// <summary>
        /// The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name = "iPhoneDefault", IsRequired = true, EmitDefaultValue = false)]
        public int IPhoneDefault { get; set; }

        /// <summary>
        /// The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name = "iEmailDefault", IsRequired = true, EmitDefaultValue = false)]
        public int IEmailDefault { get; set; }

        /// <summary>
        /// The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty.
        /// </summary>
        /// <value>The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty.</value>
        [DataMember(Name = "iWebsiteDefault", IsRequired = true, EmitDefaultValue = false)]
        public int IWebsiteDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactinformationsRequest {\n");
            sb.Append("  IAddressDefault: ").Append(IAddressDefault).Append("\n");
            sb.Append("  IPhoneDefault: ").Append(IPhoneDefault).Append("\n");
            sb.Append("  IEmailDefault: ").Append(IEmailDefault).Append("\n");
            sb.Append("  IWebsiteDefault: ").Append(IWebsiteDefault).Append("\n");
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
            return this.Equals(input as ContactinformationsRequest);
        }

        /// <summary>
        /// Returns true if ContactinformationsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactinformationsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactinformationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IAddressDefault == input.IAddressDefault ||
                    this.IAddressDefault.Equals(input.IAddressDefault)
                ) && 
                (
                    this.IPhoneDefault == input.IPhoneDefault ||
                    this.IPhoneDefault.Equals(input.IPhoneDefault)
                ) && 
                (
                    this.IEmailDefault == input.IEmailDefault ||
                    this.IEmailDefault.Equals(input.IEmailDefault)
                ) && 
                (
                    this.IWebsiteDefault == input.IWebsiteDefault ||
                    this.IWebsiteDefault.Equals(input.IWebsiteDefault)
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
                hashCode = hashCode * 59 + this.IAddressDefault.GetHashCode();
                hashCode = hashCode * 59 + this.IPhoneDefault.GetHashCode();
                hashCode = hashCode * 59 + this.IEmailDefault.GetHashCode();
                hashCode = hashCode * 59 + this.IWebsiteDefault.GetHashCode();
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