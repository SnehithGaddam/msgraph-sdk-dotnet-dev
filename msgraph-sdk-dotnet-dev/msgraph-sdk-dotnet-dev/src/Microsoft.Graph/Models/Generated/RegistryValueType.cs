// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RegistryValueType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RegistryValueType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Binary
        /// </summary>
        Binary = 1,
	
        /// <summary>
        /// Dword
        /// </summary>
        Dword = 2,
	
        /// <summary>
        /// Dword Little Endian
        /// </summary>
        DwordLittleEndian = 3,
	
        /// <summary>
        /// Dword Big Endian
        /// </summary>
        DwordBigEndian = 4,
	
        /// <summary>
        /// Expand Sz
        /// </summary>
        ExpandSz = 5,
	
        /// <summary>
        /// Link
        /// </summary>
        Link = 6,
	
        /// <summary>
        /// Multi Sz
        /// </summary>
        MultiSz = 7,
	
        /// <summary>
        /// None
        /// </summary>
        None = 8,
	
        /// <summary>
        /// Qword
        /// </summary>
        Qword = 9,
	
        /// <summary>
        /// Qwordlittle Endian
        /// </summary>
        QwordlittleEndian = 10,
	
        /// <summary>
        /// Sz
        /// </summary>
        Sz = 11,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
