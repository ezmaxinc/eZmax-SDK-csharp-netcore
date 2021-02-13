/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.
 *
 * The version of the OpenAPI document: 1.0.30
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
    /// An Franchisereferalincome Object
    /// </summary>
    [DataContract(Name = "franchisereferalincome-Request")]
    public partial class FranchisereferalincomeRequest : IEquatable<FranchisereferalincomeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchisereferalincomeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeRequest" /> class.
        /// </summary>
        /// <param name="fkiFranchisebrokerID">The unique ID of the Franchisebroker (required).</param>
        /// <param name="fkiFranchisereferalincomeprogramID">The unique ID of the Franchisereferalincomeprogram (required).</param>
        /// <param name="fkiPeriodID">The unique ID of the Period (required).</param>
        /// <param name="dFranchisereferalincomeLoan">The loan amount (required).</param>
        /// <param name="dFranchisereferalincomeFranchiseamount">The amount that will be given to the franchise (required).</param>
        /// <param name="dFranchisereferalincomeFranchisoramount">The amount that will be kept by the franchisor (required).</param>
        /// <param name="dFranchisereferalincomeAgentamount">The amount that will be given to the agent (required).</param>
        /// <param name="dtFranchisereferalincomeDisbursed">The date the amounts were disbursed (required).</param>
        /// <param name="tFranchisereferalincomeComment">A comment about the transaction (required).</param>
        /// <param name="fkiFranchiseofficeID">The unique ID of the Franchisereoffice (required).</param>
        /// <param name="sFranchisereferalincomeRemoteid">sFranchisereferalincomeRemoteid (required).</param>
        public FranchisereferalincomeRequest(int fkiFranchisebrokerID = default(int), int fkiFranchisereferalincomeprogramID = default(int), int fkiPeriodID = default(int), string dFranchisereferalincomeLoan = default(string), string dFranchisereferalincomeFranchiseamount = default(string), string dFranchisereferalincomeFranchisoramount = default(string), string dFranchisereferalincomeAgentamount = default(string), string dtFranchisereferalincomeDisbursed = default(string), string tFranchisereferalincomeComment = default(string), int fkiFranchiseofficeID = default(int), string sFranchisereferalincomeRemoteid = default(string))
        {
            this.fkiFranchisebrokerID = fkiFranchisebrokerID;
            this.fkiFranchisereferalincomeprogramID = fkiFranchisereferalincomeprogramID;
            this.fkiPeriodID = fkiPeriodID;
            // to ensure "dFranchisereferalincomeLoan" is required (not null)
            this.dFranchisereferalincomeLoan = dFranchisereferalincomeLoan ?? throw new ArgumentNullException("dFranchisereferalincomeLoan is a required property for FranchisereferalincomeRequest and cannot be null");
            // to ensure "dFranchisereferalincomeFranchiseamount" is required (not null)
            this.dFranchisereferalincomeFranchiseamount = dFranchisereferalincomeFranchiseamount ?? throw new ArgumentNullException("dFranchisereferalincomeFranchiseamount is a required property for FranchisereferalincomeRequest and cannot be null");
            // to ensure "dFranchisereferalincomeFranchisoramount" is required (not null)
            this.dFranchisereferalincomeFranchisoramount = dFranchisereferalincomeFranchisoramount ?? throw new ArgumentNullException("dFranchisereferalincomeFranchisoramount is a required property for FranchisereferalincomeRequest and cannot be null");
            // to ensure "dFranchisereferalincomeAgentamount" is required (not null)
            this.dFranchisereferalincomeAgentamount = dFranchisereferalincomeAgentamount ?? throw new ArgumentNullException("dFranchisereferalincomeAgentamount is a required property for FranchisereferalincomeRequest and cannot be null");
            // to ensure "dtFranchisereferalincomeDisbursed" is required (not null)
            this.dtFranchisereferalincomeDisbursed = dtFranchisereferalincomeDisbursed ?? throw new ArgumentNullException("dtFranchisereferalincomeDisbursed is a required property for FranchisereferalincomeRequest and cannot be null");
            // to ensure "tFranchisereferalincomeComment" is required (not null)
            this.tFranchisereferalincomeComment = tFranchisereferalincomeComment ?? throw new ArgumentNullException("tFranchisereferalincomeComment is a required property for FranchisereferalincomeRequest and cannot be null");
            this.fkiFranchiseofficeID = fkiFranchiseofficeID;
            // to ensure "sFranchisereferalincomeRemoteid" is required (not null)
            this.sFranchisereferalincomeRemoteid = sFranchisereferalincomeRemoteid ?? throw new ArgumentNullException("sFranchisereferalincomeRemoteid is a required property for FranchisereferalincomeRequest and cannot be null");
        }

        /// <summary>
        /// The unique ID of the Franchisebroker
        /// </summary>
        /// <value>The unique ID of the Franchisebroker</value>
        [DataMember(Name = "fkiFranchisebrokerID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiFranchisebrokerID { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereferalincomeprogram
        /// </summary>
        /// <value>The unique ID of the Franchisereferalincomeprogram</value>
        [DataMember(Name = "fkiFranchisereferalincomeprogramID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiFranchisereferalincomeprogramID { get; set; }

        /// <summary>
        /// The unique ID of the Period
        /// </summary>
        /// <value>The unique ID of the Period</value>
        [DataMember(Name = "fkiPeriodID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiPeriodID { get; set; }

        /// <summary>
        /// The loan amount
        /// </summary>
        /// <value>The loan amount</value>
        [DataMember(Name = "dFranchisereferalincomeLoan", IsRequired = true, EmitDefaultValue = false)]
        public string dFranchisereferalincomeLoan { get; set; }

        /// <summary>
        /// The amount that will be given to the franchise
        /// </summary>
        /// <value>The amount that will be given to the franchise</value>
        [DataMember(Name = "dFranchisereferalincomeFranchiseamount", IsRequired = true, EmitDefaultValue = false)]
        public string dFranchisereferalincomeFranchiseamount { get; set; }

        /// <summary>
        /// The amount that will be kept by the franchisor
        /// </summary>
        /// <value>The amount that will be kept by the franchisor</value>
        [DataMember(Name = "dFranchisereferalincomeFranchisoramount", IsRequired = true, EmitDefaultValue = false)]
        public string dFranchisereferalincomeFranchisoramount { get; set; }

        /// <summary>
        /// The amount that will be given to the agent
        /// </summary>
        /// <value>The amount that will be given to the agent</value>
        [DataMember(Name = "dFranchisereferalincomeAgentamount", IsRequired = true, EmitDefaultValue = false)]
        public string dFranchisereferalincomeAgentamount { get; set; }

        /// <summary>
        /// The date the amounts were disbursed
        /// </summary>
        /// <value>The date the amounts were disbursed</value>
        [DataMember(Name = "dtFranchisereferalincomeDisbursed", IsRequired = true, EmitDefaultValue = false)]
        public string dtFranchisereferalincomeDisbursed { get; set; }

        /// <summary>
        /// A comment about the transaction
        /// </summary>
        /// <value>A comment about the transaction</value>
        [DataMember(Name = "tFranchisereferalincomeComment", IsRequired = true, EmitDefaultValue = false)]
        public string tFranchisereferalincomeComment { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereoffice
        /// </summary>
        /// <value>The unique ID of the Franchisereoffice</value>
        [DataMember(Name = "fkiFranchiseofficeID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiFranchiseofficeID { get; set; }

        /// <summary>
        /// Gets or Sets sFranchisereferalincomeRemoteid
        /// </summary>
        [DataMember(Name = "sFranchisereferalincomeRemoteid", IsRequired = true, EmitDefaultValue = false)]
        public string sFranchisereferalincomeRemoteid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeRequest {\n");
            sb.Append("  fkiFranchisebrokerID: ").Append(fkiFranchisebrokerID).Append("\n");
            sb.Append("  fkiFranchisereferalincomeprogramID: ").Append(fkiFranchisereferalincomeprogramID).Append("\n");
            sb.Append("  fkiPeriodID: ").Append(fkiPeriodID).Append("\n");
            sb.Append("  dFranchisereferalincomeLoan: ").Append(dFranchisereferalincomeLoan).Append("\n");
            sb.Append("  dFranchisereferalincomeFranchiseamount: ").Append(dFranchisereferalincomeFranchiseamount).Append("\n");
            sb.Append("  dFranchisereferalincomeFranchisoramount: ").Append(dFranchisereferalincomeFranchisoramount).Append("\n");
            sb.Append("  dFranchisereferalincomeAgentamount: ").Append(dFranchisereferalincomeAgentamount).Append("\n");
            sb.Append("  dtFranchisereferalincomeDisbursed: ").Append(dtFranchisereferalincomeDisbursed).Append("\n");
            sb.Append("  tFranchisereferalincomeComment: ").Append(tFranchisereferalincomeComment).Append("\n");
            sb.Append("  fkiFranchiseofficeID: ").Append(fkiFranchiseofficeID).Append("\n");
            sb.Append("  sFranchisereferalincomeRemoteid: ").Append(sFranchisereferalincomeRemoteid).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeRequest);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiFranchisebrokerID == input.fkiFranchisebrokerID ||
                    this.fkiFranchisebrokerID.Equals(input.fkiFranchisebrokerID)
                ) && 
                (
                    this.fkiFranchisereferalincomeprogramID == input.fkiFranchisereferalincomeprogramID ||
                    this.fkiFranchisereferalincomeprogramID.Equals(input.fkiFranchisereferalincomeprogramID)
                ) && 
                (
                    this.fkiPeriodID == input.fkiPeriodID ||
                    this.fkiPeriodID.Equals(input.fkiPeriodID)
                ) && 
                (
                    this.dFranchisereferalincomeLoan == input.dFranchisereferalincomeLoan ||
                    (this.dFranchisereferalincomeLoan != null &&
                    this.dFranchisereferalincomeLoan.Equals(input.dFranchisereferalincomeLoan))
                ) && 
                (
                    this.dFranchisereferalincomeFranchiseamount == input.dFranchisereferalincomeFranchiseamount ||
                    (this.dFranchisereferalincomeFranchiseamount != null &&
                    this.dFranchisereferalincomeFranchiseamount.Equals(input.dFranchisereferalincomeFranchiseamount))
                ) && 
                (
                    this.dFranchisereferalincomeFranchisoramount == input.dFranchisereferalincomeFranchisoramount ||
                    (this.dFranchisereferalincomeFranchisoramount != null &&
                    this.dFranchisereferalincomeFranchisoramount.Equals(input.dFranchisereferalincomeFranchisoramount))
                ) && 
                (
                    this.dFranchisereferalincomeAgentamount == input.dFranchisereferalincomeAgentamount ||
                    (this.dFranchisereferalincomeAgentamount != null &&
                    this.dFranchisereferalincomeAgentamount.Equals(input.dFranchisereferalincomeAgentamount))
                ) && 
                (
                    this.dtFranchisereferalincomeDisbursed == input.dtFranchisereferalincomeDisbursed ||
                    (this.dtFranchisereferalincomeDisbursed != null &&
                    this.dtFranchisereferalincomeDisbursed.Equals(input.dtFranchisereferalincomeDisbursed))
                ) && 
                (
                    this.tFranchisereferalincomeComment == input.tFranchisereferalincomeComment ||
                    (this.tFranchisereferalincomeComment != null &&
                    this.tFranchisereferalincomeComment.Equals(input.tFranchisereferalincomeComment))
                ) && 
                (
                    this.fkiFranchiseofficeID == input.fkiFranchiseofficeID ||
                    this.fkiFranchiseofficeID.Equals(input.fkiFranchiseofficeID)
                ) && 
                (
                    this.sFranchisereferalincomeRemoteid == input.sFranchisereferalincomeRemoteid ||
                    (this.sFranchisereferalincomeRemoteid != null &&
                    this.sFranchisereferalincomeRemoteid.Equals(input.sFranchisereferalincomeRemoteid))
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
                hashCode = hashCode * 59 + this.fkiFranchisebrokerID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiFranchisereferalincomeprogramID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiPeriodID.GetHashCode();
                if (this.dFranchisereferalincomeLoan != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeLoan.GetHashCode();
                if (this.dFranchisereferalincomeFranchiseamount != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeFranchiseamount.GetHashCode();
                if (this.dFranchisereferalincomeFranchisoramount != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeFranchisoramount.GetHashCode();
                if (this.dFranchisereferalincomeAgentamount != null)
                    hashCode = hashCode * 59 + this.dFranchisereferalincomeAgentamount.GetHashCode();
                if (this.dtFranchisereferalincomeDisbursed != null)
                    hashCode = hashCode * 59 + this.dtFranchisereferalincomeDisbursed.GetHashCode();
                if (this.tFranchisereferalincomeComment != null)
                    hashCode = hashCode * 59 + this.tFranchisereferalincomeComment.GetHashCode();
                hashCode = hashCode * 59 + this.fkiFranchiseofficeID.GetHashCode();
                if (this.sFranchisereferalincomeRemoteid != null)
                    hashCode = hashCode * 59 + this.sFranchisereferalincomeRemoteid.GetHashCode();
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
