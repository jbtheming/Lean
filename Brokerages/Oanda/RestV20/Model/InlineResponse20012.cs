/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.15
 * Contact: api@oanda.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// InlineResponse20012
    /// </summary>
    [DataContract]
    public partial class InlineResponse20012 :  IEquatable<InlineResponse20012>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20012" /> class.
        /// </summary>
        /// <param name="Positions">The list of open Positions in the Account..</param>
        /// <param name="LastTransactionID">The ID of the most recent Transaction created for the Account.</param>
        public InlineResponse20012(List<Position> Positions = default(List<Position>), string LastTransactionID = default(string))
        {
            this.Positions = Positions;
            this.LastTransactionID = LastTransactionID;
        }
        
        /// <summary>
        /// The list of open Positions in the Account.
        /// </summary>
        /// <value>The list of open Positions in the Account.</value>
        [DataMember(Name="positions", EmitDefaultValue=false)]
        public List<Position> Positions { get; set; }
        /// <summary>
        /// The ID of the most recent Transaction created for the Account
        /// </summary>
        /// <value>The ID of the most recent Transaction created for the Account</value>
        [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
        public string LastTransactionID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20012 {\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20012);
        }

        /// <summary>
        /// Returns true if InlineResponse20012 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20012 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20012 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Positions == other.Positions ||
                    this.Positions != null &&
                    this.Positions.SequenceEqual(other.Positions)
                ) && 
                (
                    this.LastTransactionID == other.LastTransactionID ||
                    this.LastTransactionID != null &&
                    this.LastTransactionID.Equals(other.LastTransactionID)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Positions != null)
                    hash = hash * 59 + this.Positions.GetHashCode();
                if (this.LastTransactionID != null)
                    hash = hash * 59 + this.LastTransactionID.GetHashCode();
                return hash;
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
