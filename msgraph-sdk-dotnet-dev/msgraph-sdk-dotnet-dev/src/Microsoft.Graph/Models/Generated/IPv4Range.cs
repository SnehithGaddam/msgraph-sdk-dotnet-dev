// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IPv4Range.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IPv4Range : IpRange
    {

        /// <summary>
        /// Gets or sets lowerAddress.
        /// Lower address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lowerAddress", Required = Newtonsoft.Json.Required.Default)]
        public string LowerAddress { get; set; }
    
        /// <summary>
        /// Gets or sets upperAddress.
        /// Upper address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upperAddress", Required = Newtonsoft.Json.Required.Default)]
        public string UpperAddress { get; set; }
    
    }
}
