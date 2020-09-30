/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.17
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
        public FranchisereferalincomeRequest(int fkiFranchisebrokerID = default(int), int fkiFranchisereferalincomeprogramID = default(int), int fkiPeriodID = default(int), string dFranchisereferalincomeLoan = default(string), string dFranchisereferalincomeFranchiseamount = default(string), string dFranchisereferalincomeFranchisoramount = default(string), string dFranchisereferalincomeAgentamount = default(string), string dtFranchisereferalincomeDisbursed = default(string), string tFranchisereferalincomeComment = default(string))
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
        }

        /// <summary>
        /// The unique ID of the Franchisebroker
        /// </summary>
        /// <value>The unique ID of the Franchisebroker</value>
        [DataMember(Name = "fkiFranchisebrokerID", EmitDefaultValue = false)]
        public int fkiFranchisebrokerID { get; set; }

        /// <summary>
        /// The unique ID of the Franchisereferalincomeprogram
        /// </summary>
        /// <value>The unique ID of the Franchisereferalincomeprogram</value>
        [DataMember(Name = "fkiFranchisereferalincomeprogramID", EmitDefaultValue = false)]
        public int fkiFranchisereferalincomeprogramID { get; set; }

        /// <summary>
        /// The unique ID of the Period
        /// </summary>
        /// <value>The unique ID of the Period</value>
        [DataMember(Name = "fkiPeriodID", EmitDefaultValue = false)]
        public int fkiPeriodID { get; set; }

        /// <summary>
        /// The loan amount
        /// </summary>
        /// <value>The loan amount</value>
        [DataMember(Name = "dFranchisereferalincomeLoan", EmitDefaultValue = false)]
        public string dFranchisereferalincomeLoan { get; set; }

        /// <summary>
        /// The amount that will be given to the franchise
        /// </summary>
        /// <value>The amount that will be given to the franchise</value>
        [DataMember(Name = "dFranchisereferalincomeFranchiseamount", EmitDefaultValue = false)]
        public string dFranchisereferalincomeFranchiseamount { get; set; }

        /// <summary>
        /// The amount that will be kept by the franchisor
        /// </summary>
        /// <value>The amount that will be kept by the franchisor</value>
        [DataMember(Name = "dFranchisereferalincomeFranchisoramount", EmitDefaultValue = false)]
        public string dFranchisereferalincomeFranchisoramount { get; set; }

        /// <summary>
        /// The amount that will be given to the agent
        /// </summary>
        /// <value>The amount that will be given to the agent</value>
        [DataMember(Name = "dFranchisereferalincomeAgentamount", EmitDefaultValue = false)]
        public string dFranchisereferalincomeAgentamount { get; set; }

        /// <summary>
        /// The date the amounts were disbursed
        /// </summary>
        /// <value>The date the amounts were disbursed</value>
        [DataMember(Name = "dtFranchisereferalincomeDisbursed", EmitDefaultValue = false)]
        public string dtFranchisereferalincomeDisbursed { get; set; }

        /// <summary>
        /// A comment about the transaction
        /// </summary>
        /// <value>A comment about the transaction</value>
        [DataMember(Name = "tFranchisereferalincomeComment", EmitDefaultValue = false)]
        public string tFranchisereferalincomeComment { get; set; }

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