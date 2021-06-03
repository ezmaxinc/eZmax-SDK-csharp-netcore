/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
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
    /// A Phone Object
    /// </summary>
    [DataContract(Name = "phone-Request")]
    public partial class PhoneRequest : IEquatable<PhoneRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneRequest" /> class.
        /// </summary>
        /// <param name="fkiPhonetypeID">The unique ID of the Phonetype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Mobile| |4|Fax| |5|Pager| |6|Toll Free| (required).</param>
        /// <param name="ePhoneType">ePhoneType (required).</param>
        /// <param name="sPhoneRegion">The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123.</param>
        /// <param name="sPhoneExchange">The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123.</param>
        /// <param name="sPhoneNumber">The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123.</param>
        /// <param name="sPhoneInternational">The international phone number. (For phone numbers outside of North)  Do not specify the \&quot;011\&quot; part of the phone number used to dial an international phone number from North America.  For example for this sample phone number \&quot;+442071838750\&quot;, you would send \&quot;442071838750\&quot; without the \&quot;+\&quot; sign..</param>
        /// <param name="sPhoneExtension">The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers.</param>
        public PhoneRequest(int fkiPhonetypeID = default(int), FieldEPhoneType ePhoneType = default(FieldEPhoneType), string sPhoneRegion = default(string), string sPhoneExchange = default(string), string sPhoneNumber = default(string), string sPhoneInternational = default(string), string sPhoneExtension = default(string))
        {
            this.FkiPhonetypeID = fkiPhonetypeID;
            // to ensure "ePhoneType" is required (not null)
            this.EPhoneType = ePhoneType ?? throw new ArgumentNullException("ePhoneType is a required property for PhoneRequest and cannot be null");
            this.SPhoneRegion = sPhoneRegion;
            this.SPhoneExchange = sPhoneExchange;
            this.SPhoneNumber = sPhoneNumber;
            this.SPhoneInternational = sPhoneInternational;
            this.SPhoneExtension = sPhoneExtension;
        }

        /// <summary>
        /// The unique ID of the Phonetype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Mobile| |4|Fax| |5|Pager| |6|Toll Free|
        /// </summary>
        /// <value>The unique ID of the Phonetype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Mobile| |4|Fax| |5|Pager| |6|Toll Free|</value>
        [DataMember(Name = "fkiPhonetypeID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiPhonetypeID { get; set; }

        /// <summary>
        /// Gets or Sets EPhoneType
        /// </summary>
        [DataMember(Name = "ePhoneType", IsRequired = true, EmitDefaultValue = false)]
        public FieldEPhoneType EPhoneType { get; set; }

        /// <summary>
        /// The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The region of the phone number. (For a North America Number only)  The region is the \&quot;514\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneRegion", EmitDefaultValue = false)]
        public string SPhoneRegion { get; set; }

        /// <summary>
        /// The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The exchange of the phone number. (For a North America Number only)  The exchange is the \&quot;990\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneExchange", EmitDefaultValue = false)]
        public string SPhoneExchange { get; set; }

        /// <summary>
        /// The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123
        /// </summary>
        /// <value>The number of the phone number. (For a North America Number only)  The number is the \&quot;1516\&quot; section in this sample phone number: (514) 990-1516 x123</value>
        [DataMember(Name = "sPhoneNumber", EmitDefaultValue = false)]
        public string SPhoneNumber { get; set; }

        /// <summary>
        /// The international phone number. (For phone numbers outside of North)  Do not specify the \&quot;011\&quot; part of the phone number used to dial an international phone number from North America.  For example for this sample phone number \&quot;+442071838750\&quot;, you would send \&quot;442071838750\&quot; without the \&quot;+\&quot; sign.
        /// </summary>
        /// <value>The international phone number. (For phone numbers outside of North)  Do not specify the \&quot;011\&quot; part of the phone number used to dial an international phone number from North America.  For example for this sample phone number \&quot;+442071838750\&quot;, you would send \&quot;442071838750\&quot; without the \&quot;+\&quot; sign.</value>
        [DataMember(Name = "sPhoneInternational", EmitDefaultValue = false)]
        public string SPhoneInternational { get; set; }

        /// <summary>
        /// The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers
        /// </summary>
        /// <value>The extension of the phone number.  The extension is the \&quot;123\&quot; section in this sample phone number: (514) 990-1516 x123.  It can also be used with international phone numbers</value>
        [DataMember(Name = "sPhoneExtension", EmitDefaultValue = false)]
        public string SPhoneExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneRequest {\n");
            sb.Append("  FkiPhonetypeID: ").Append(FkiPhonetypeID).Append("\n");
            sb.Append("  EPhoneType: ").Append(EPhoneType).Append("\n");
            sb.Append("  SPhoneRegion: ").Append(SPhoneRegion).Append("\n");
            sb.Append("  SPhoneExchange: ").Append(SPhoneExchange).Append("\n");
            sb.Append("  SPhoneNumber: ").Append(SPhoneNumber).Append("\n");
            sb.Append("  SPhoneInternational: ").Append(SPhoneInternational).Append("\n");
            sb.Append("  SPhoneExtension: ").Append(SPhoneExtension).Append("\n");
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
            return this.Equals(input as PhoneRequest);
        }

        /// <summary>
        /// Returns true if PhoneRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiPhonetypeID == input.FkiPhonetypeID ||
                    this.FkiPhonetypeID.Equals(input.FkiPhonetypeID)
                ) && 
                (
                    this.EPhoneType == input.EPhoneType ||
                    (this.EPhoneType != null &&
                    this.EPhoneType.Equals(input.EPhoneType))
                ) && 
                (
                    this.SPhoneRegion == input.SPhoneRegion ||
                    (this.SPhoneRegion != null &&
                    this.SPhoneRegion.Equals(input.SPhoneRegion))
                ) && 
                (
                    this.SPhoneExchange == input.SPhoneExchange ||
                    (this.SPhoneExchange != null &&
                    this.SPhoneExchange.Equals(input.SPhoneExchange))
                ) && 
                (
                    this.SPhoneNumber == input.SPhoneNumber ||
                    (this.SPhoneNumber != null &&
                    this.SPhoneNumber.Equals(input.SPhoneNumber))
                ) && 
                (
                    this.SPhoneInternational == input.SPhoneInternational ||
                    (this.SPhoneInternational != null &&
                    this.SPhoneInternational.Equals(input.SPhoneInternational))
                ) && 
                (
                    this.SPhoneExtension == input.SPhoneExtension ||
                    (this.SPhoneExtension != null &&
                    this.SPhoneExtension.Equals(input.SPhoneExtension))
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
                hashCode = hashCode * 59 + this.FkiPhonetypeID.GetHashCode();
                if (this.EPhoneType != null)
                    hashCode = hashCode * 59 + this.EPhoneType.GetHashCode();
                if (this.SPhoneRegion != null)
                    hashCode = hashCode * 59 + this.SPhoneRegion.GetHashCode();
                if (this.SPhoneExchange != null)
                    hashCode = hashCode * 59 + this.SPhoneExchange.GetHashCode();
                if (this.SPhoneNumber != null)
                    hashCode = hashCode * 59 + this.SPhoneNumber.GetHashCode();
                if (this.SPhoneInternational != null)
                    hashCode = hashCode * 59 + this.SPhoneInternational.GetHashCode();
                if (this.SPhoneExtension != null)
                    hashCode = hashCode * 59 + this.SPhoneExtension.GetHashCode();
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
