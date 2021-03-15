/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.33
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
    /// The signature step of the Ezsigndocument.
    /// </summary>
    /// <value>The signature step of the Ezsigndocument.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEEzsigndocumentStep
    {
        /// <summary>
        /// Enum Unsent for value: Unsent
        /// </summary>
        [EnumMember(Value = "Unsent")]
        Unsent = 1,

        /// <summary>
        /// Enum Unsigned for value: Unsigned
        /// </summary>
        [EnumMember(Value = "Unsigned")]
        Unsigned = 2,

        /// <summary>
        /// Enum PartiallySigned for value: PartiallySigned
        /// </summary>
        [EnumMember(Value = "PartiallySigned")]
        PartiallySigned = 3,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 4

    }

}
