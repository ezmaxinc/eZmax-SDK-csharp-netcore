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
            this.PkiUserID = pkiUserID;
            this.FkiLanguageID = fkiLanguageID;
            // to ensure "eUserType" is required (not null)
            this.EUserType = eUserType ?? throw new ArgumentNullException("eUserType is a required property for UserResponseAllOf and cannot be null");
            // to ensure "sUserFirstname" is required (not null)
            this.SUserFirstname = sUserFirstname ?? throw new ArgumentNullException("sUserFirstname is a required property for UserResponseAllOf and cannot be null");
            // to ensure "sUserLastname" is required (not null)
            this.SUserLastname = sUserLastname ?? throw new ArgumentNullException("sUserLastname is a required property for UserResponseAllOf and cannot be null");
            // to ensure "sUserLoginname" is required (not null)
            this.SUserLoginname = sUserLoginname ?? throw new ArgumentNullException("sUserLoginname is a required property for UserResponseAllOf and cannot be null");
            // to ensure "objAudit" is required (not null)
            this.ObjAudit = objAudit ?? throw new ArgumentNullException("objAudit is a required property for UserResponseAllOf and cannot be null");
        }

        /// <summary>
        /// The unique ID of the User
        /// </summary>
        /// <value>The unique ID of the User</value>
        [DataMember(Name = "pkiUserID", IsRequired = true, EmitDefaultValue = false)]
        public int PkiUserID { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name = "fkiLanguageID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// Gets or Sets EUserType
        /// </summary>
        [DataMember(Name = "eUserType", IsRequired = true, EmitDefaultValue = false)]
        public FieldEUserType EUserType { get; set; }

        /// <summary>
        /// The First name of the user
        /// </summary>
        /// <value>The First name of the user</value>
        [DataMember(Name = "sUserFirstname", IsRequired = true, EmitDefaultValue = false)]
        public string SUserFirstname { get; set; }

        /// <summary>
        /// The Last name of the user
        /// </summary>
        /// <value>The Last name of the user</value>
        [DataMember(Name = "sUserLastname", IsRequired = true, EmitDefaultValue = false)]
        public string SUserLastname { get; set; }

        /// <summary>
        /// The Login name of the User.
        /// </summary>
        /// <value>The Login name of the User.</value>
        [DataMember(Name = "sUserLoginname", IsRequired = true, EmitDefaultValue = false)]
        public string SUserLoginname { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name = "objAudit", IsRequired = true, EmitDefaultValue = false)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponseAllOf {\n");
            sb.Append("  PkiUserID: ").Append(PkiUserID).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  EUserType: ").Append(EUserType).Append("\n");
            sb.Append("  SUserFirstname: ").Append(SUserFirstname).Append("\n");
            sb.Append("  SUserLastname: ").Append(SUserLastname).Append("\n");
            sb.Append("  SUserLoginname: ").Append(SUserLoginname).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
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
                    this.PkiUserID == input.PkiUserID ||
                    this.PkiUserID.Equals(input.PkiUserID)
                ) && 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    this.FkiLanguageID.Equals(input.FkiLanguageID)
                ) && 
                (
                    this.EUserType == input.EUserType ||
                    (this.EUserType != null &&
                    this.EUserType.Equals(input.EUserType))
                ) && 
                (
                    this.SUserFirstname == input.SUserFirstname ||
                    (this.SUserFirstname != null &&
                    this.SUserFirstname.Equals(input.SUserFirstname))
                ) && 
                (
                    this.SUserLastname == input.SUserLastname ||
                    (this.SUserLastname != null &&
                    this.SUserLastname.Equals(input.SUserLastname))
                ) && 
                (
                    this.SUserLoginname == input.SUserLoginname ||
                    (this.SUserLoginname != null &&
                    this.SUserLoginname.Equals(input.SUserLoginname))
                ) && 
                (
                    this.ObjAudit == input.ObjAudit ||
                    (this.ObjAudit != null &&
                    this.ObjAudit.Equals(input.ObjAudit))
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
                hashCode = hashCode * 59 + this.PkiUserID.GetHashCode();
                hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.EUserType != null)
                    hashCode = hashCode * 59 + this.EUserType.GetHashCode();
                if (this.SUserFirstname != null)
                    hashCode = hashCode * 59 + this.SUserFirstname.GetHashCode();
                if (this.SUserLastname != null)
                    hashCode = hashCode * 59 + this.SUserLastname.GetHashCode();
                if (this.SUserLoginname != null)
                    hashCode = hashCode * 59 + this.SUserLoginname.GetHashCode();
                if (this.ObjAudit != null)
                    hashCode = hashCode * 59 + this.ObjAudit.GetHashCode();
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
            // FkiLanguageID (int) maximum
            if(this.FkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value less than or equal to 2.", new [] { "FkiLanguageID" });
            }

            // FkiLanguageID (int) minimum
            if(this.FkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value greater than or equal to 1.", new [] { "FkiLanguageID" });
            }

            yield break;
        }
    }

}
