/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.35
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
    /// Request for the /1/module/sspr/resetPasswordRequest API Request
    /// </summary>
    [DataContract(Name = "sspr-resetPasswordRequest-v1-Request")]
    public partial class SsprResetPasswordRequestV1Request : IEquatable<SsprResetPasswordRequestV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsprResetPasswordRequestV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SsprResetPasswordRequestV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsprResetPasswordRequestV1Request" /> class.
        /// </summary>
        /// <param name="pksCustomerCode">The customer code assigned to your account (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="eUserTypeSSPR">eUserTypeSSPR (required).</param>
        /// <param name="sEmailAddress">The email address..</param>
        /// <param name="sUserLoginname">The Login name of the User..</param>
        public SsprResetPasswordRequestV1Request(string pksCustomerCode = default(string), int fkiLanguageID = default(int), FieldEUserTypeSSPR eUserTypeSSPR = default(FieldEUserTypeSSPR), string sEmailAddress = default(string), string sUserLoginname = default(string))
        {
            // to ensure "pksCustomerCode" is required (not null)
            this.pksCustomerCode = pksCustomerCode ?? throw new ArgumentNullException("pksCustomerCode is a required property for SsprResetPasswordRequestV1Request and cannot be null");
            this.fkiLanguageID = fkiLanguageID;
            // to ensure "eUserTypeSSPR" is required (not null)
            this.eUserTypeSSPR = eUserTypeSSPR ?? throw new ArgumentNullException("eUserTypeSSPR is a required property for SsprResetPasswordRequestV1Request and cannot be null");
            this.sEmailAddress = sEmailAddress;
            this.sUserLoginname = sUserLoginname;
        }

        /// <summary>
        /// The customer code assigned to your account
        /// </summary>
        /// <value>The customer code assigned to your account</value>
        [DataMember(Name = "pksCustomerCode", IsRequired = true, EmitDefaultValue = false)]
        public string pksCustomerCode { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// Gets or Sets eUserTypeSSPR
        /// </summary>
        [DataMember(Name = "eUserTypeSSPR", IsRequired = true, EmitDefaultValue = false)]
        public FieldEUserTypeSSPR eUserTypeSSPR { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name = "sEmailAddress", EmitDefaultValue = false)]
        public string sEmailAddress { get; set; }

        /// <summary>
        /// The Login name of the User.
        /// </summary>
        /// <value>The Login name of the User.</value>
        [DataMember(Name = "sUserLoginname", EmitDefaultValue = false)]
        public string sUserLoginname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsprResetPasswordRequestV1Request {\n");
            sb.Append("  pksCustomerCode: ").Append(pksCustomerCode).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  eUserTypeSSPR: ").Append(eUserTypeSSPR).Append("\n");
            sb.Append("  sEmailAddress: ").Append(sEmailAddress).Append("\n");
            sb.Append("  sUserLoginname: ").Append(sUserLoginname).Append("\n");
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
            return this.Equals(input as SsprResetPasswordRequestV1Request);
        }

        /// <summary>
        /// Returns true if SsprResetPasswordRequestV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of SsprResetPasswordRequestV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SsprResetPasswordRequestV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.pksCustomerCode == input.pksCustomerCode ||
                    (this.pksCustomerCode != null &&
                    this.pksCustomerCode.Equals(input.pksCustomerCode))
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    this.fkiLanguageID.Equals(input.fkiLanguageID)
                ) && 
                (
                    this.eUserTypeSSPR == input.eUserTypeSSPR ||
                    (this.eUserTypeSSPR != null &&
                    this.eUserTypeSSPR.Equals(input.eUserTypeSSPR))
                ) && 
                (
                    this.sEmailAddress == input.sEmailAddress ||
                    (this.sEmailAddress != null &&
                    this.sEmailAddress.Equals(input.sEmailAddress))
                ) && 
                (
                    this.sUserLoginname == input.sUserLoginname ||
                    (this.sUserLoginname != null &&
                    this.sUserLoginname.Equals(input.sUserLoginname))
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
                if (this.pksCustomerCode != null)
                    hashCode = hashCode * 59 + this.pksCustomerCode.GetHashCode();
                hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.eUserTypeSSPR != null)
                    hashCode = hashCode * 59 + this.eUserTypeSSPR.GetHashCode();
                if (this.sEmailAddress != null)
                    hashCode = hashCode * 59 + this.sEmailAddress.GetHashCode();
                if (this.sUserLoginname != null)
                    hashCode = hashCode * 59 + this.sUserLoginname.GetHashCode();
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
            // pksCustomerCode (string) maxLength
            if(this.pksCustomerCode != null && this.pksCustomerCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pksCustomerCode, length must be less than 6.", new [] { "pksCustomerCode" });
            }

            // pksCustomerCode (string) minLength
            if(this.pksCustomerCode != null && this.pksCustomerCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pksCustomerCode, length must be greater than 2.", new [] { "pksCustomerCode" });
            }

            // fkiLanguageID (int) maximum
            if(this.fkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value less than or equal to 2.", new [] { "fkiLanguageID" });
            }

            // fkiLanguageID (int) minimum
            if(this.fkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiLanguageID, must be a value greater than or equal to 1.", new [] { "fkiLanguageID" });
            }

            yield break;
        }
    }

}
