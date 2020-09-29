/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.16
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
    /// A Contactinformations Object and children to create a complete structure
    /// </summary>
    [DataContract(Name = "contactinformations-RequestCompound")]
    public partial class ContactinformationsRequestCompound : ContactinformationsRequest, IEquatable<ContactinformationsRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactinformationsRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactinformationsRequestCompound" /> class.
        /// </summary>
        /// <param name="aObjAddress">aObjAddress (required).</param>
        /// <param name="aObjPhone">aObjPhone (required).</param>
        /// <param name="aObjEmail">aObjEmail (required).</param>
        /// <param name="aObjWebsite">aObjWebsite (required).</param>
        /// <param name="iAddressDefault">The index in the a_objAddress array (zero based index) representing the Address object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iPhoneDefault">The index in the a_objPhone array (zero based index) representing the Phone object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iEmailDefault">The index in the a_objEmail array (zero based index) representing the Email object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        /// <param name="iWebsiteDefault">The index in the a_objWebsite array (zero based index) representing the Website object that should become the default one.  You can leave the value to 0 if the array is empty. (required).</param>
        public ContactinformationsRequestCompound(List<AddressRequest> aObjAddress = default(List<AddressRequest>), List<PhoneRequest> aObjPhone = default(List<PhoneRequest>), List<EmailRequest> aObjEmail = default(List<EmailRequest>), List<WebsiteRequest> aObjWebsite = default(List<WebsiteRequest>), int iAddressDefault = default(int), int iPhoneDefault = default(int), int iEmailDefault = default(int), int iWebsiteDefault = default(int)) : base()
        {
            // to ensure "aObjAddress" is required (not null)
            this.a_objAddress = aObjAddress ?? throw new ArgumentNullException("aObjAddress is a required property for ContactinformationsRequestCompound and cannot be null");
            // to ensure "aObjPhone" is required (not null)
            this.a_objPhone = aObjPhone ?? throw new ArgumentNullException("aObjPhone is a required property for ContactinformationsRequestCompound and cannot be null");
            // to ensure "aObjEmail" is required (not null)
            this.a_objEmail = aObjEmail ?? throw new ArgumentNullException("aObjEmail is a required property for ContactinformationsRequestCompound and cannot be null");
            // to ensure "aObjWebsite" is required (not null)
            this.a_objWebsite = aObjWebsite ?? throw new ArgumentNullException("aObjWebsite is a required property for ContactinformationsRequestCompound and cannot be null");
        }

        /// <summary>
        /// Gets or Sets a_objAddress
        /// </summary>
        [DataMember(Name = "a_objAddress", EmitDefaultValue = false)]
        public List<AddressRequest> a_objAddress { get; set; }

        /// <summary>
        /// Gets or Sets a_objPhone
        /// </summary>
        [DataMember(Name = "a_objPhone", EmitDefaultValue = false)]
        public List<PhoneRequest> a_objPhone { get; set; }

        /// <summary>
        /// Gets or Sets a_objEmail
        /// </summary>
        [DataMember(Name = "a_objEmail", EmitDefaultValue = false)]
        public List<EmailRequest> a_objEmail { get; set; }

        /// <summary>
        /// Gets or Sets a_objWebsite
        /// </summary>
        [DataMember(Name = "a_objWebsite", EmitDefaultValue = false)]
        public List<WebsiteRequest> a_objWebsite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactinformationsRequestCompound {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  a_objAddress: ").Append(a_objAddress).Append("\n");
            sb.Append("  a_objPhone: ").Append(a_objPhone).Append("\n");
            sb.Append("  a_objEmail: ").Append(a_objEmail).Append("\n");
            sb.Append("  a_objWebsite: ").Append(a_objWebsite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ContactinformationsRequestCompound);
        }

        /// <summary>
        /// Returns true if ContactinformationsRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactinformationsRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactinformationsRequestCompound input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.a_objAddress == input.a_objAddress ||
                    this.a_objAddress != null &&
                    input.a_objAddress != null &&
                    this.a_objAddress.SequenceEqual(input.a_objAddress)
                ) && base.Equals(input) && 
                (
                    this.a_objPhone == input.a_objPhone ||
                    this.a_objPhone != null &&
                    input.a_objPhone != null &&
                    this.a_objPhone.SequenceEqual(input.a_objPhone)
                ) && base.Equals(input) && 
                (
                    this.a_objEmail == input.a_objEmail ||
                    this.a_objEmail != null &&
                    input.a_objEmail != null &&
                    this.a_objEmail.SequenceEqual(input.a_objEmail)
                ) && base.Equals(input) && 
                (
                    this.a_objWebsite == input.a_objWebsite ||
                    this.a_objWebsite != null &&
                    input.a_objWebsite != null &&
                    this.a_objWebsite.SequenceEqual(input.a_objWebsite)
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
                int hashCode = base.GetHashCode();
                if (this.a_objAddress != null)
                    hashCode = hashCode * 59 + this.a_objAddress.GetHashCode();
                if (this.a_objPhone != null)
                    hashCode = hashCode * 59 + this.a_objPhone.GetHashCode();
                if (this.a_objEmail != null)
                    hashCode = hashCode * 59 + this.a_objEmail.GetHashCode();
                if (this.a_objWebsite != null)
                    hashCode = hashCode * 59 + this.a_objWebsite.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
