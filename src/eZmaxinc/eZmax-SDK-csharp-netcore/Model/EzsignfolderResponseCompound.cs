/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.15
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
    /// An Ezsignfolder Object and children to create a complete structure
    /// </summary>
    [DataContract(Name = "ezsignfolder-ResponseCompound")]
    public partial class EzsignfolderResponseCompound : EzsignfolderResponse, IEquatable<EzsignfolderResponseCompound>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponseCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderResponseCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponseCompound" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here. (required).</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="tEzsignfolderNote">Somes extra notes about the eZsign Folder (required).</param>
        /// <param name="eEzsignfolderSendreminderfrequency">eEzsignfolderSendreminderfrequency (required).</param>
        /// <param name="pkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsignfolderSentdate">The date and time at which the Ezsign folder was sent the last time. (required).</param>
        /// <param name="eEzsignfolderStep">eEzsignfolderStep (required).</param>
        /// <param name="dtEzsignfolderClose">The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely. (required).</param>
        /// <param name="fkiUserIDCreated">The id of the User that created the object. (required).</param>
        /// <param name="fkiUserIDModified">The id of the User that made the last modification on the object. (required).</param>
        /// <param name="fkiApikeyIDCreated">The id of the API Key that created the object..</param>
        /// <param name="fkiApikeyIDModified">The id of the API Key that made the last modification on the object..</param>
        /// <param name="dtCreatedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="dtModifiedDate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        public EzsignfolderResponseCompound(int fkiEzsignfoldertypeID = default(int), int fkiEzsigntsarequirementID = default(int), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency = default(FieldEEzsignfolderSendreminderfrequency), int pkiEzsignfolderID = default(int), string dtEzsignfolderSentdate = default(string), FieldEEzsignfolderStep eEzsignfolderStep = default(FieldEEzsignfolderStep), string dtEzsignfolderClose = default(string), int fkiUserIDCreated = default(int), int fkiUserIDModified = default(int), int fkiApikeyIDCreated = default(int), int fkiApikeyIDModified = default(int), string dtCreatedDate = default(string), string dtModifiedDate = default(string)) : base()
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderResponseCompound {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as EzsignfolderResponseCompound);
        }

        /// <summary>
        /// Returns true if EzsignfolderResponseCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderResponseCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderResponseCompound input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
