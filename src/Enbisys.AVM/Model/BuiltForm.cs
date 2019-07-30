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
    /// Defines BuiltForm
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BuiltForm
    {
        /// <summary>
        /// Enum Detached for value: detached
        /// </summary>
        [EnumMember(Value = "detached")]
        Detached = 1,

        /// <summary>
        /// Enum Semidetached for value: semi_detached
        /// </summary>
        [EnumMember(Value = "semi_detached")]
        Semidetached = 2,

        /// <summary>
        /// Enum Enclosedmidterrace for value: enclosed_mid_terrace
        /// </summary>
        [EnumMember(Value = "enclosed_mid_terrace")]
        Enclosedmidterrace = 3,

        /// <summary>
        /// Enum Enclosedendterrace for value: enclosed_end_terrace
        /// </summary>
        [EnumMember(Value = "enclosed_end_terrace")]
        Enclosedendterrace = 4,

        /// <summary>
        /// Enum Endterrace for value: end_terrace
        /// </summary>
        [EnumMember(Value = "end_terrace")]
        Endterrace = 5,

        /// <summary>
        /// Enum Midterrace for value: mid_terrace
        /// </summary>
        [EnumMember(Value = "mid_terrace")]
        Midterrace = 6

    }

}
