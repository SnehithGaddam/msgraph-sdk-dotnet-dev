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
    /// The type TeamsTabConfiguration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TeamsTabConfiguration
    {

        /// <summary>
        /// Gets or sets entityId.
        /// Identifier for the entity hosted by the tab provider.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "entityId", Required = Newtonsoft.Json.Required.Default)]
        public string EntityId { get; set; }
    
        /// <summary>
        /// Gets or sets contentUrl.
        /// Url used for rendering tab contents in Teams. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets removeUrl.
        /// Url called by Teams client when a Tab is removed using the Teams Client.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "removeUrl", Required = Newtonsoft.Json.Required.Default)]
        public string RemoveUrl { get; set; }
    
        /// <summary>
        /// Gets or sets websiteUrl.
        /// Url for showing tab contents outside of Teams.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "websiteUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebsiteUrl { get; set; }
    
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
