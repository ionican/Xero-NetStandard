/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Setup
    /// </summary>
    [DataContract]
    public partial class Setup :  IEquatable<Setup>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets ConversionDate
        /// </summary>
        [DataMember(Name="ConversionDate", EmitDefaultValue=false)]
        public ConversionDate ConversionDate { get; set; }

        /// <summary>
        /// Balance supplied for each account that has a value as at the conversion date.
        /// </summary>
        /// <value>Balance supplied for each account that has a value as at the conversion date.</value>
        [DataMember(Name="ConversionBalances", EmitDefaultValue=false)]
        public List<ConversionBalances> ConversionBalances { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="Accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Setup {\n");
            sb.Append("  ConversionDate: ").Append(ConversionDate).Append("\n");
            sb.Append("  ConversionBalances: ").Append(ConversionBalances).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as Setup);
        }

        /// <summary>
        /// Returns true if Setup instances are equal
        /// </summary>
        /// <param name="input">Instance of Setup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Setup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConversionDate == input.ConversionDate ||
                    (this.ConversionDate != null &&
                    this.ConversionDate.Equals(input.ConversionDate))
                ) && 
                (
                    this.ConversionBalances == input.ConversionBalances ||
                    this.ConversionBalances != null &&
                    input.ConversionBalances != null &&
                    this.ConversionBalances.SequenceEqual(input.ConversionBalances)
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.ConversionDate != null)
                    hashCode = hashCode * 59 + this.ConversionDate.GetHashCode();
                if (this.ConversionBalances != null)
                    hashCode = hashCode * 59 + this.ConversionBalances.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
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
