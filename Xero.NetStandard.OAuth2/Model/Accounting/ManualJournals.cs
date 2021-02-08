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
    /// ManualJournals
    /// </summary>
    [DataContract]
    public partial class ManualJournals :  IEquatable<ManualJournals>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _ManualJournals
        /// </summary>
        [DataMember(Name="ManualJournals", EmitDefaultValue=false)]
        public List<ManualJournal> _ManualJournals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualJournals {\n");
            sb.Append("  _ManualJournals: ").Append(_ManualJournals).Append("\n");
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
            return this.Equals(input as ManualJournals);
        }

        /// <summary>
        /// Returns true if ManualJournals instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualJournals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualJournals input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._ManualJournals == input._ManualJournals ||
                    this._ManualJournals != null &&
                    input._ManualJournals != null &&
                    this._ManualJournals.SequenceEqual(input._ManualJournals)
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
                if (this._ManualJournals != null)
                    hashCode = hashCode * 59 + this._ManualJournals.GetHashCode();
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
