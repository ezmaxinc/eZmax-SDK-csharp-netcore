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
    /// An Ezsignfoldersignerassociation Object and children to create a complete structure
    /// </summary>
    [DataContract(Name = "ezsignfoldersignerassociation-RequestCompound")]
    public partial class EzsignfoldersignerassociationRequestCompound : IEquatable<EzsignfoldersignerassociationRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationRequestCompound" /> class.
        /// </summary>
        /// <param name="objEzsignsigner">objEzsignsigner.</param>
        /// <param name="fkiUserID">A reference to a valid User.  This is only used if the signatory will be a user from the system..</param>
        /// <param name="fkiEzsignfolderID">A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation. (required).</param>
        public EzsignfoldersignerassociationRequestCompound(EzsignsignerRequestCompound objEzsignsigner = default(EzsignsignerRequestCompound), int fkiUserID = default(int), int fkiEzsignfolderID = default(int))
        {
            this.FkiEzsignfolderID = fkiEzsignfolderID;
            this.ObjEzsignsigner = objEzsignsigner;
            this.FkiUserID = fkiUserID;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignsigner
        /// </summary>
        [DataMember(Name = "objEzsignsigner", EmitDefaultValue = false)]
        public EzsignsignerRequestCompound ObjEzsignsigner { get; set; }

        /// <summary>
        /// A reference to a valid User.  This is only used if the signatory will be a user from the system.
        /// </summary>
        /// <value>A reference to a valid User.  This is only used if the signatory will be a user from the system.</value>
        [DataMember(Name = "fkiUserID", EmitDefaultValue = false)]
        public int FkiUserID { get; set; }

        /// <summary>
        /// A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.</value>
        [DataMember(Name = "fkiEzsignfolderID", IsRequired = true, EmitDefaultValue = false)]
        public int FkiEzsignfolderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationRequestCompound {\n");
            sb.Append("  ObjEzsignsigner: ").Append(ObjEzsignsigner).Append("\n");
            sb.Append("  FkiUserID: ").Append(FkiUserID).Append("\n");
            sb.Append("  FkiEzsignfolderID: ").Append(FkiEzsignfolderID).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsignsigner == input.ObjEzsignsigner ||
                    (this.ObjEzsignsigner != null &&
                    this.ObjEzsignsigner.Equals(input.ObjEzsignsigner))
                ) && 
                (
                    this.FkiUserID == input.FkiUserID ||
                    this.FkiUserID.Equals(input.FkiUserID)
                ) && 
                (
                    this.FkiEzsignfolderID == input.FkiEzsignfolderID ||
                    this.FkiEzsignfolderID.Equals(input.FkiEzsignfolderID)
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
                if (this.ObjEzsignsigner != null)
                    hashCode = hashCode * 59 + this.ObjEzsignsigner.GetHashCode();
                hashCode = hashCode * 59 + this.FkiUserID.GetHashCode();
                hashCode = hashCode * 59 + this.FkiEzsignfolderID.GetHashCode();
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
            // FkiUserID (int) minimum
            if(this.FkiUserID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiUserID, must be a value greater than or equal to 1.", new [] { "FkiUserID" });
            }

            // FkiEzsignfolderID (int) minimum
            if(this.FkiEzsignfolderID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignfolderID, must be a value greater than or equal to 1.", new [] { "FkiEzsignfolderID" });
            }

            yield break;
        }
    }

}
