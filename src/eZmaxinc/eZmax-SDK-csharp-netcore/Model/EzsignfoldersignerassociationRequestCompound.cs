/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.20
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
            this.fkiEzsignfolderID = fkiEzsignfolderID;
            this.objEzsignsigner = objEzsignsigner;
            this.fkiUserID = fkiUserID;
        }

        /// <summary>
        /// Gets or Sets objEzsignsigner
        /// </summary>
        [DataMember(Name = "objEzsignsigner", EmitDefaultValue = false)]
        public EzsignsignerRequestCompound objEzsignsigner { get; set; }

        /// <summary>
        /// A reference to a valid User.  This is only used if the signatory will be a user from the system.
        /// </summary>
        /// <value>A reference to a valid User.  This is only used if the signatory will be a user from the system.</value>
        [DataMember(Name = "fkiUserID", EmitDefaultValue = false)]
        public int fkiUserID { get; set; }

        /// <summary>
        /// A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.</value>
        [DataMember(Name = "fkiEzsignfolderID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiEzsignfolderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationRequestCompound {\n");
            sb.Append("  objEzsignsigner: ").Append(objEzsignsigner).Append("\n");
            sb.Append("  fkiUserID: ").Append(fkiUserID).Append("\n");
            sb.Append("  fkiEzsignfolderID: ").Append(fkiEzsignfolderID).Append("\n");
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
                    this.objEzsignsigner == input.objEzsignsigner ||
                    (this.objEzsignsigner != null &&
                    this.objEzsignsigner.Equals(input.objEzsignsigner))
                ) && 
                (
                    this.fkiUserID == input.fkiUserID ||
                    this.fkiUserID.Equals(input.fkiUserID)
                ) && 
                (
                    this.fkiEzsignfolderID == input.fkiEzsignfolderID ||
                    this.fkiEzsignfolderID.Equals(input.fkiEzsignfolderID)
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
                if (this.objEzsignsigner != null)
                    hashCode = hashCode * 59 + this.objEzsignsigner.GetHashCode();
                hashCode = hashCode * 59 + this.fkiUserID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiEzsignfolderID.GetHashCode();
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
            // fkiUserID (int) minimum
            if(this.fkiUserID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiUserID, must be a value greater than or equal to 1.", new [] { "fkiUserID" });
            }

            // fkiEzsignfolderID (int) minimum
            if(this.fkiEzsignfolderID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsignfolderID, must be a value greater than or equal to 1.", new [] { "fkiEzsignfolderID" });
            }

            yield break;
        }
    }

}
