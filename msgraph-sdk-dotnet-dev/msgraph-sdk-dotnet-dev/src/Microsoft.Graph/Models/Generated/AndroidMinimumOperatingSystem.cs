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
    /// The type AndroidMinimumOperatingSystem.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AndroidMinimumOperatingSystem
    {

        /// <summary>
        /// Gets or sets v4_0.
        /// Version 4.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v4_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V4_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_0_3.
        /// Version 4.0.3 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v4_0_3", Required = Newtonsoft.Json.Required.Default)]
        public bool? V4_0_3 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_1.
        /// Version 4.1 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v4_1", Required = Newtonsoft.Json.Required.Default)]
        public bool? V4_1 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_2.
        /// Version 4.2 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v4_2", Required = Newtonsoft.Json.Required.Default)]
        public bool? V4_2 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_3.
        /// Version 4.3 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v4_3", Required = Newtonsoft.Json.Required.Default)]
        public bool? V4_3 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_4.
        /// Version 4.4 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v4_4", Required = Newtonsoft.Json.Required.Default)]
        public bool? V4_4 { get; set; }
    
        /// <summary>
        /// Gets or sets v5_0.
        /// Version 5.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v5_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V5_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v5_1.
        /// Version 5.1 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v5_1", Required = Newtonsoft.Json.Required.Default)]
        public bool? V5_1 { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
