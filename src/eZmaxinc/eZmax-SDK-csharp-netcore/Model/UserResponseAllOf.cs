/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.31
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
    /// UserResponseAllOf
    /// </summary>
    [DataContract(Name = "user_Response_allOf")]
    public partial class UserResponseAllOf : IEquatable<UserResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResponseAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseAllOf" /> class.
        /// </summary>
        /// <param name="pkiUserID">The unique ID of the User (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="eUserType">eUserType (required).</param>
        /// <param name="sUserFirstname">The First name of the user (required).</param>
        /// <param name="sUserLastname">The Last name of the user (required).</param>
        /// <param name="sUserLoginname">The Login name of the User. (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public UserResponseAllOf(int pkiUserID = default(int), int fkiLanguageID = default(int), FieldEUserType eUserType = default(FieldEUserType), string sUserFirstname = default(string), string sUserLastname = default(string), string sUserLoginname = default(string), CommonAudit objAudit = default(CommonAudit))
        {
            this.pkiUserID = pkiUserID;
            this.fkiLanguageID = fkiLanguageID;
            // to ensure "eUserType" is required (not null)
            this.eUserType = eUserType ?? throw new ArgumentNullException("eUserType is a required property for UserResponseAllOf and cannot be null");
            // to ensure "sUserFirstname" is required (not null)
            this.sUserFirstname = sUserFirstname ?? throw new ArgumentNullException("sUserFirstname is a required property for UserResponseAllOf and cannot be null");
            // to ensure "sUserLastname" is required (not null)
            this.sUserLastname = sUserLastname ?? throw new ArgumentNullException("sUserLastname is a required property for UserResponseAllOf and cannot be null");
            // to ensure "sUserLoginname" is required (not null)
            this.sUserLoginname = sUserLoginname ?? throw new ArgumentNullException("sUserLoginname is a required property for UserResponseAllOf and cannot be null");
            // to ensure "objAudit" is required (not null)
            this.objAudit = objAudit ?? throw new ArgumentNullException("objAudit is a required property for UserResponseAllOf and cannot be null");
        }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name = "pkiUserID", IsRequired = true, EmitDefaultValue = false)]
        public int pkiUserID { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiLanguageID { get; set; }

        /// <summary>
        /// Gets or Sets eUserType
        /// </summary>
        [DataMember(Name = "eUserType", IsRequired = true, EmitDefaultValue = false)]
        public FieldEUserType eUserType { get; set; }

        /// <summary>
        /// The First name of the user
        /// </summary>
        /// <value>The First name of the user</value>
        [DataMember(Name = "sUserFirstname", IsRequired = true, EmitDefaultValue = false)]
        public string sUserFirstname { get; set; }

        /// <summary>
        /// The Last name of the user
        /// </summary>
        /// <value>The Last name of the user</value>
        [DataMember(Name = "sUserLastname", IsRequired = true, EmitDefaultValue = false)]
        public string sUserLastname { get; set; }

        /// <summary>
        /// The Login name of the User.
        /// </summary>
        /// <value>The Login name of the User.</value>
        [DataMember(Name = "sUserLoginname", IsRequired = true, EmitDefaultValue = false)]
        public string sUserLoginname { get; set; }

        /// <summary>
        /// Gets or Sets objAudit
        /// </summary>
        [DataMember(Name = "objAudit", IsRequired = true, EmitDefaultValue = false)]
        public CommonAudit objAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponseAllOf {\n");
            sb.Append("  pkiUserID: ").Append(pkiUserID).Append("\n");
            sb.Append("  fkiLanguageID: ").Append(fkiLanguageID).Append("\n");
            sb.Append("  eUserType: ").Append(eUserType).Append("\n");
            sb.Append("  sUserFirstname: ").Append(sUserFirstname).Append("\n");
            sb.Append("  sUserLastname: ").Append(sUserLastname).Append("\n");
            sb.Append("  sUserLoginname: ").Append(sUserLoginname).Append("\n");
            sb.Append("  objAudit: ").Append(objAudit).Append("\n");
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
            return this.Equals(input as UserResponseAllOf);
        }

        /// <summary>
        /// Returns true if UserResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UserResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.pkiUserID == input.pkiUserID ||
                    this.pkiUserID.Equals(input.pkiUserID)
                ) && 
                (
                    this.fkiLanguageID == input.fkiLanguageID ||
                    this.fkiLanguageID.Equals(input.fkiLanguageID)
                ) && 
                (
                    this.eUserType == input.eUserType ||
                    (this.eUserType != null &&
                    this.eUserType.Equals(input.eUserType))
                ) && 
                (
                    this.sUserFirstname == input.sUserFirstname ||
                    (this.sUserFirstname != null &&
                    this.sUserFirstname.Equals(input.sUserFirstname))
                ) && 
                (
                    this.sUserLastname == input.sUserLastname ||
                    (this.sUserLastname != null &&
                    this.sUserLastname.Equals(input.sUserLastname))
                ) && 
                (
                    this.sUserLoginname == input.sUserLoginname ||
                    (this.sUserLoginname != null &&
                    this.sUserLoginname.Equals(input.sUserLoginname))
                ) && 
                (
                    this.objAudit == input.objAudit ||
                    (this.objAudit != null &&
                    this.objAudit.Equals(input.objAudit))
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
                hashCode = hashCode * 59 + this.pkiUserID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiLanguageID.GetHashCode();
                if (this.eUserType != null)
                    hashCode = hashCode * 59 + this.eUserType.GetHashCode();
                if (this.sUserFirstname != null)
                    hashCode = hashCode * 59 + this.sUserFirstname.GetHashCode();
                if (this.sUserLastname != null)
                    hashCode = hashCode * 59 + this.sUserLastname.GetHashCode();
                if (this.sUserLoginname != null)
                    hashCode = hashCode * 59 + this.sUserLoginname.GetHashCode();
                if (this.objAudit != null)
                    hashCode = hashCode * 59 + this.objAudit.GetHashCode();
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
