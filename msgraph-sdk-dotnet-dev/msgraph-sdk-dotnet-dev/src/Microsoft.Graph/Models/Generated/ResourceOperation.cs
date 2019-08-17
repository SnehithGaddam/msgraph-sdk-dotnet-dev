// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Resource Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ResourceOperation : Entity
    {
    
        /// <summary>
        /// Gets or sets resource name.
        /// Name of the Resource this operation is performed on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceName", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceName { get; set; }
    
        /// <summary>
        /// Gets or sets action name.
        /// Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionName", Required = Newtonsoft.Json.Required.Default)]
        public string ActionName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
    }
}

