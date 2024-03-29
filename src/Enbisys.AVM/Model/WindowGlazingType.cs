/* 
 * AVM
 *
 * This is api for AVM (automated valuation machine)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@enbisys.com
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
using OpenAPIDateConverter = Enbisys.AVM.Client.OpenAPIDateConverter;

namespace Enbisys.AVM.Model
{
    /// <summary>
    /// Defines WindowGlazingType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WindowGlazingType
    {
        /// <summary>
        /// Enum Single for value: single
        /// </summary>
        [EnumMember(Value = "single")]
        Single = 1,

        /// <summary>
        /// Enum Secondary for value: secondary
        /// </summary>
        [EnumMember(Value = "secondary")]
        Secondary = 2,

        /// <summary>
        /// Enum Double for value: double
        /// </summary>
        [EnumMember(Value = "double")]
        Double = 3,

        /// <summary>
        /// Enum Triple for value: triple
        /// </summary>
        [EnumMember(Value = "triple")]
        Triple = 4,

        /// <summary>
        /// Enum Multiple for value: multiple
        /// </summary>
        [EnumMember(Value = "multiple")]
        Multiple = 5,

        /// <summary>
        /// Enum Highperformance for value: high_performance
        /// </summary>
        [EnumMember(Value = "high_performance")]
        Highperformance = 6

    }

}
