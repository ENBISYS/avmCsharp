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
    /// Defines WallInsulation
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WallInsulation
    {
        /// <summary>
        /// Enum No for value: no
        /// </summary>
        [EnumMember(Value = "no")]
        No = 1,

        /// <summary>
        /// Enum Partial for value: partial
        /// </summary>
        [EnumMember(Value = "partial")]
        Partial = 2,

        /// <summary>
        /// Enum Insulated for value: insulated
        /// </summary>
        [EnumMember(Value = "insulated")]
        Insulated = 3,

        /// <summary>
        /// Enum Additional for value: additional
        /// </summary>
        [EnumMember(Value = "additional")]
        Additional = 4

    }

}