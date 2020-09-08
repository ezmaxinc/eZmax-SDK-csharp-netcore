/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.13
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
    /// An Ezsignsigner Object
    /// </summary>
    [DataContract(Name = "ezsignsigner-Request")]
    public partial class EzsignsignerRequest : IEquatable<EzsignsignerRequest>, IValidatableObject
    {
        /// <summary>
        /// The method the Ezsignsigner will authenticate to the signing platform.  1. **Password** means the Ezsignsigner will receive a secure link by email. 2. **PasswordPhone** means the Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**. 3. **PasswordQuestion** means the Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer. 4. **InPersonPhone** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**. 5. **InPerson** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type.
        /// </summary>
        /// <value>The method the Ezsignsigner will authenticate to the signing platform.  1. **Password** means the Ezsignsigner will receive a secure link by email. 2. **PasswordPhone** means the Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**. 3. **PasswordQuestion** means the Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer. 4. **InPersonPhone** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**. 5. **InPerson** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EEzsignsignerLogintypeEnum
        {
            /// <summary>
            /// Enum Password for value: Password
            /// </summary>
            [EnumMember(Value = "Password")]
            Password = 1,

            /// <summary>
            /// Enum PasswordPhone for value: PasswordPhone
            /// </summary>
            [EnumMember(Value = "PasswordPhone")]
            PasswordPhone = 2,

            /// <summary>
            /// Enum PasswordQuestion for value: PasswordQuestion
            /// </summary>
            [EnumMember(Value = "PasswordQuestion")]
            PasswordQuestion = 3,

            /// <summary>
            /// Enum InPersonPhone for value: InPersonPhone
            /// </summary>
            [EnumMember(Value = "InPersonPhone")]
            InPersonPhone = 4,

            /// <summary>
            /// Enum InPerson for value: InPerson
            /// </summary>
            [EnumMember(Value = "InPerson")]
            InPerson = 5

        }

        /// <summary>
        /// The method the Ezsignsigner will authenticate to the signing platform.  1. **Password** means the Ezsignsigner will receive a secure link by email. 2. **PasswordPhone** means the Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**. 3. **PasswordQuestion** means the Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer. 4. **InPersonPhone** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**. 5. **InPerson** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type.
        /// </summary>
        /// <value>The method the Ezsignsigner will authenticate to the signing platform.  1. **Password** means the Ezsignsigner will receive a secure link by email. 2. **PasswordPhone** means the Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**. 3. **PasswordQuestion** means the Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer. 4. **InPersonPhone** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**. 5. **InPerson** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type.</value>
        [DataMember(Name = "eEzsignsignerLogintype", EmitDefaultValue = false)]
        public EEzsignsignerLogintypeEnum eEzsignsignerLogintype { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignsignerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignerRequest" /> class.
        /// </summary>
        /// <param name="fkiTaxassignmentID">The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable| (required).</param>
        /// <param name="fkiSecretquestionID">The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)|.</param>
        /// <param name="eEzsignsignerLogintype">The method the Ezsignsigner will authenticate to the signing platform.  1. **Password** means the Ezsignsigner will receive a secure link by email. 2. **PasswordPhone** means the Ezsignsigner will receive a secure link by email and will need to authenticate using SMS or Phone call. **Additional fee applies**. 3. **PasswordQuestion** means the Ezsignsigner will receive a secure link by email and will need to authenticate using a predefined question and answer. 4. **InPersonPhone** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and will need to authenticate using SMS or Phone call. No email will be sent for invitation to sign. **Additional fee applies**. 5. **InPerson** means the Ezsignsigner will only be able to sign \&quot;In-Person\&quot; and there won&#39;t be any authentication. No email will be sent for invitation to sign. Make sure you evaluate the risk of signature denial and at minimum, we recommend you use a handwritten signature type. (required).</param>
        /// <param name="sEzsignsignerSecretanswer">The predefined answer to the secret question the Ezsignsigner will need to provide to successfully authenticate..</param>
        public EzsignsignerRequest(int fkiTaxassignmentID = default(int), int fkiSecretquestionID = default(int), EEzsignsignerLogintypeEnum eEzsignsignerLogintype = default(EEzsignsignerLogintypeEnum), string sEzsignsignerSecretanswer = default(string))
        {
            this.fkiTaxassignmentID = fkiTaxassignmentID;
            this.eEzsignsignerLogintype = eEzsignsignerLogintype;
            this.fkiSecretquestionID = fkiSecretquestionID;
            this.sEzsignsignerSecretanswer = sEzsignsignerSecretanswer;
        }

        /// <summary>
        /// The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable|
        /// </summary>
        /// <value>The unique ID of the Taxassignment.  Valid values:  |Value|Description| |-|-| |1|No tax| |2|GST| |3|HST (ON)| |4|HST (NB)| |5|HST (NS)| |6|HST (NL)| |7|HST (PE)| |8|GST + QST (QC)| |9|GST + QST (QC) Non-Recoverable| |10|GST + PST (BC)| |11|GST + PST (SK)| |12|GST + RST (MB)| |13|GST + PST (BC) Non-Recoverable| |14|GST + PST (SK) Non-Recoverable| |15|GST + RST (MB) Non-Recoverable|</value>
        [DataMember(Name = "fkiTaxassignmentID", EmitDefaultValue = false)]
        public int fkiTaxassignmentID { get; set; }

        /// <summary>
        /// The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)|
        /// </summary>
        /// <value>The unique ID of the Secretquestion.  Valid values:  |Value|Description| |-|-| |1|The name of the hospital in which you were born| |2|The name of your grade school| |3|The last name of your favorite teacher| |4|Your favorite sports team| |5|Your favorite TV show| |6|Your favorite movie| |7|The name of the street on which you grew up| |8|The name of your first employer| |9|Your first car| |10|Your favorite food| |11|The name of your first pet| |12|Favorite musician/band| |13|What instrument you play| |14|Your father&#39;s middle name| |15|Your mother&#39;s maiden name| |16|Name of your eldest child| |17|Your spouse&#39;s middle name| |18|Favorite restaurant| |19|Childhood nickname| |20|Favorite vacation destination| |21|Your boat&#39;s name| |22|Date of Birth (YYYY-MM-DD)|</value>
        [DataMember(Name = "fkiSecretquestionID", EmitDefaultValue = false)]
        public int fkiSecretquestionID { get; set; }

        /// <summary>
        /// The predefined answer to the secret question the Ezsignsigner will need to provide to successfully authenticate.
        /// </summary>
        /// <value>The predefined answer to the secret question the Ezsignsigner will need to provide to successfully authenticate.</value>
        [DataMember(Name = "sEzsignsignerSecretanswer", EmitDefaultValue = false)]
        public string sEzsignsignerSecretanswer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignerRequest {\n");
            sb.Append("  fkiTaxassignmentID: ").Append(fkiTaxassignmentID).Append("\n");
            sb.Append("  fkiSecretquestionID: ").Append(fkiSecretquestionID).Append("\n");
            sb.Append("  eEzsignsignerLogintype: ").Append(eEzsignsignerLogintype).Append("\n");
            sb.Append("  sEzsignsignerSecretanswer: ").Append(sEzsignsignerSecretanswer).Append("\n");
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
            return this.Equals(input as EzsignsignerRequest);
        }

        /// <summary>
        /// Returns true if EzsignsignerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiTaxassignmentID == input.fkiTaxassignmentID ||
                    this.fkiTaxassignmentID.Equals(input.fkiTaxassignmentID)
                ) && 
                (
                    this.fkiSecretquestionID == input.fkiSecretquestionID ||
                    this.fkiSecretquestionID.Equals(input.fkiSecretquestionID)
                ) && 
                (
                    this.eEzsignsignerLogintype == input.eEzsignsignerLogintype ||
                    this.eEzsignsignerLogintype.Equals(input.eEzsignsignerLogintype)
                ) && 
                (
                    this.sEzsignsignerSecretanswer == input.sEzsignsignerSecretanswer ||
                    (this.sEzsignsignerSecretanswer != null &&
                    this.sEzsignsignerSecretanswer.Equals(input.sEzsignsignerSecretanswer))
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
                hashCode = hashCode * 59 + this.fkiTaxassignmentID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiSecretquestionID.GetHashCode();
                hashCode = hashCode * 59 + this.eEzsignsignerLogintype.GetHashCode();
                if (this.sEzsignsignerSecretanswer != null)
                    hashCode = hashCode * 59 + this.sEzsignsignerSecretanswer.GetHashCode();
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
            // fkiTaxassignmentID (int) maximum
            if(this.fkiTaxassignmentID > (int)15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiTaxassignmentID, must be a value less than or equal to 15.", new [] { "fkiTaxassignmentID" });
            }

            // fkiTaxassignmentID (int) minimum
            if(this.fkiTaxassignmentID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiTaxassignmentID, must be a value greater than or equal to 1.", new [] { "fkiTaxassignmentID" });
            }

            yield break;
        }
    }

}
