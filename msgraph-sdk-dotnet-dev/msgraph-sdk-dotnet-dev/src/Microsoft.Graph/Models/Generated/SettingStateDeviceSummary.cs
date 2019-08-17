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
    /// The type Setting State Device Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SettingStateDeviceSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets setting name.
        /// Name of the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets instance path.
        /// Name of the InstancePath for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instancePath", Required = Newtonsoft.Json.Required.Default)]
        public string InstancePath { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// Device Unkown count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable device count.
        /// Device Not Applicable count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notApplicableDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotApplicableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets compliant device count.
        /// Device Compliant count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated device count.
        /// Device Compliant count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediatedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemediatedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant device count.
        /// Device NonCompliant count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nonCompliantDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NonCompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Device error count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict device count.
        /// Device conflict error count for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conflictDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConflictDeviceCount { get; set; }
    
    }
}

