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
    /// An Address Object
    /// </summary>
    [DataContract(Name = "address-Request")]
    public partial class AddressRequest : IEquatable<AddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRequest" /> class.
        /// </summary>
        /// <param name="fkiAddresstypeID">The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping| (required).</param>
        /// <param name="sAddressCivic">The Civic number. (required).</param>
        /// <param name="sAddressStreet">The Street Name (required).</param>
        /// <param name="sAddressSuite">The Suite or appartment number (required).</param>
        /// <param name="sAddressCity">The City name (required).</param>
        /// <param name="fkiProvinceID">The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming| (required).</param>
        /// <param name="fkiCountryID">The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States| (required).</param>
        /// <param name="sAddressZip">The Postal/Zip Code  The value must be entered without spaces (required).</param>
        public AddressRequest(int fkiAddresstypeID = default(int), string sAddressCivic = default(string), string sAddressStreet = default(string), string sAddressSuite = default(string), string sAddressCity = default(string), int fkiProvinceID = default(int), int fkiCountryID = default(int), string sAddressZip = default(string))
        {
            this.fkiAddresstypeID = fkiAddresstypeID;
            // to ensure "sAddressCivic" is required (not null)
            this.sAddressCivic = sAddressCivic ?? throw new ArgumentNullException("sAddressCivic is a required property for AddressRequest and cannot be null");
            // to ensure "sAddressStreet" is required (not null)
            this.sAddressStreet = sAddressStreet ?? throw new ArgumentNullException("sAddressStreet is a required property for AddressRequest and cannot be null");
            // to ensure "sAddressSuite" is required (not null)
            this.sAddressSuite = sAddressSuite ?? throw new ArgumentNullException("sAddressSuite is a required property for AddressRequest and cannot be null");
            // to ensure "sAddressCity" is required (not null)
            this.sAddressCity = sAddressCity ?? throw new ArgumentNullException("sAddressCity is a required property for AddressRequest and cannot be null");
            this.fkiProvinceID = fkiProvinceID;
            this.fkiCountryID = fkiCountryID;
            // to ensure "sAddressZip" is required (not null)
            this.sAddressZip = sAddressZip ?? throw new ArgumentNullException("sAddressZip is a required property for AddressRequest and cannot be null");
        }

        /// <summary>
        /// The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping|
        /// </summary>
        /// <value>The unique ID of the Addresstype.  Valid values:  |Value|Description| |-|-| |1|Office| |2|Home| |3|Real Estate Invoice| |4|Invoicing| |5|Shipping|</value>
        [DataMember(Name = "fkiAddresstypeID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiAddresstypeID { get; set; }

        /// <summary>
        /// The Civic number.
        /// </summary>
        /// <value>The Civic number.</value>
        [DataMember(Name = "sAddressCivic", IsRequired = true, EmitDefaultValue = false)]
        public string sAddressCivic { get; set; }

        /// <summary>
        /// The Street Name
        /// </summary>
        /// <value>The Street Name</value>
        [DataMember(Name = "sAddressStreet", IsRequired = true, EmitDefaultValue = false)]
        public string sAddressStreet { get; set; }

        /// <summary>
        /// The Suite or appartment number
        /// </summary>
        /// <value>The Suite or appartment number</value>
        [DataMember(Name = "sAddressSuite", IsRequired = true, EmitDefaultValue = false)]
        public string sAddressSuite { get; set; }

        /// <summary>
        /// The City name
        /// </summary>
        /// <value>The City name</value>
        [DataMember(Name = "sAddressCity", IsRequired = true, EmitDefaultValue = false)]
        public string sAddressCity { get; set; }

        /// <summary>
        /// The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming|
        /// </summary>
        /// <value>The unique ID of the Province.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|(Canada) Alberta |2|(Canada) British Columbia| |3|(Canada) Manitoba| |3|(Canada) Manitoba| |4|(Canada) New Brunswick| |5|(Canada) Newfoundland| |6|(Canada) Northwest Territories| |7|(Canada) Nova Scotia| |8|(Canada) Nunavut| |9|(Canada) Ontario| |10|(Canada) Prince Edward Island| |11|(Canada) Quebec| |12|(Canada) Saskatchewan| |13|(Canada) Yukon| |14|(United-States) Alabama| |15|(United-States) Alaska| |16|(United-States) Arizona| |17|(United-States) Arkansas| |18|(United-States) California| |19|(United-States) Colorado| |20|(United-States) Connecticut| |21|(United-States) Delaware| |22|(United-States) District of Columbia| |23|(United-States) Florida| |24|(United-States) Georgia| |25|(United-States) Hawaii| |26|(United-States) Idaho| |27|(United-States) Illinois| |28|(United-States) Indiana| |29|(United-States) Iowa| |30|(United-States) Kansas| |31|(United-States) Kentucky| |32|(United-States) Louisiane| |33|(United-States) Maine| |34|(United-States) Maryland| |35|(United-States) Massachusetts| |36|(United-States) Michigan| |37|(United-States) Minnesota| |38|(United-States) Mississippi| |39|(United-States) Missouri| |40|(United-States) Montana| |41|(United-States) Nebraska| |42|(United-States) Nevada| |43|(United-States) New Hampshire| |44|(United-States) New Jersey| |45|(United-States) New Mexico| |46|(United-States) New York| |47|(United-States) North Carolina| |48|(United-States) North Dakota| |49|(United-States) Ohio| |50|(United-States) Oklahoma| |51|(United-States) Oregon| |52|(United-States) Pennsylvania| |53|(United-States) Rhode Island| |54|(United-States) South Carolina| |55|(United-States) South Dakota| |56|(United-States) Tennessee| |57|(United-States) Texas| |58|(United-States) Utah| |60|(United-States) Vermont| |59|(United-States) Virginia| |61|(United-States) Washington| |62|(United-States) West Virginia| |63|(United-States) Wisconsin| |64|(United-States) Wyoming|</value>
        [DataMember(Name = "fkiProvinceID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiProvinceID { get; set; }

        /// <summary>
        /// The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States|
        /// </summary>
        /// <value>The unique ID of the Country.  Here are some common values (Complete list must be retrieved from API):  |Value|Description| |-|-| |1|Canada| |2|United-States|</value>
        [DataMember(Name = "fkiCountryID", IsRequired = true, EmitDefaultValue = false)]
        public int fkiCountryID { get; set; }

        /// <summary>
        /// The Postal/Zip Code  The value must be entered without spaces
        /// </summary>
        /// <value>The Postal/Zip Code  The value must be entered without spaces</value>
        [DataMember(Name = "sAddressZip", IsRequired = true, EmitDefaultValue = false)]
        public string sAddressZip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressRequest {\n");
            sb.Append("  fkiAddresstypeID: ").Append(fkiAddresstypeID).Append("\n");
            sb.Append("  sAddressCivic: ").Append(sAddressCivic).Append("\n");
            sb.Append("  sAddressStreet: ").Append(sAddressStreet).Append("\n");
            sb.Append("  sAddressSuite: ").Append(sAddressSuite).Append("\n");
            sb.Append("  sAddressCity: ").Append(sAddressCity).Append("\n");
            sb.Append("  fkiProvinceID: ").Append(fkiProvinceID).Append("\n");
            sb.Append("  fkiCountryID: ").Append(fkiCountryID).Append("\n");
            sb.Append("  sAddressZip: ").Append(sAddressZip).Append("\n");
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
            return this.Equals(input as AddressRequest);
        }

        /// <summary>
        /// Returns true if AddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiAddresstypeID == input.fkiAddresstypeID ||
                    this.fkiAddresstypeID.Equals(input.fkiAddresstypeID)
                ) && 
                (
                    this.sAddressCivic == input.sAddressCivic ||
                    (this.sAddressCivic != null &&
                    this.sAddressCivic.Equals(input.sAddressCivic))
                ) && 
                (
                    this.sAddressStreet == input.sAddressStreet ||
                    (this.sAddressStreet != null &&
                    this.sAddressStreet.Equals(input.sAddressStreet))
                ) && 
                (
                    this.sAddressSuite == input.sAddressSuite ||
                    (this.sAddressSuite != null &&
                    this.sAddressSuite.Equals(input.sAddressSuite))
                ) && 
                (
                    this.sAddressCity == input.sAddressCity ||
                    (this.sAddressCity != null &&
                    this.sAddressCity.Equals(input.sAddressCity))
                ) && 
                (
                    this.fkiProvinceID == input.fkiProvinceID ||
                    this.fkiProvinceID.Equals(input.fkiProvinceID)
                ) && 
                (
                    this.fkiCountryID == input.fkiCountryID ||
                    this.fkiCountryID.Equals(input.fkiCountryID)
                ) && 
                (
                    this.sAddressZip == input.sAddressZip ||
                    (this.sAddressZip != null &&
                    this.sAddressZip.Equals(input.sAddressZip))
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
                hashCode = hashCode * 59 + this.fkiAddresstypeID.GetHashCode();
                if (this.sAddressCivic != null)
                    hashCode = hashCode * 59 + this.sAddressCivic.GetHashCode();
                if (this.sAddressStreet != null)
                    hashCode = hashCode * 59 + this.sAddressStreet.GetHashCode();
                if (this.sAddressSuite != null)
                    hashCode = hashCode * 59 + this.sAddressSuite.GetHashCode();
                if (this.sAddressCity != null)
                    hashCode = hashCode * 59 + this.sAddressCity.GetHashCode();
                hashCode = hashCode * 59 + this.fkiProvinceID.GetHashCode();
                hashCode = hashCode * 59 + this.fkiCountryID.GetHashCode();
                if (this.sAddressZip != null)
                    hashCode = hashCode * 59 + this.sAddressZip.GetHashCode();
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
