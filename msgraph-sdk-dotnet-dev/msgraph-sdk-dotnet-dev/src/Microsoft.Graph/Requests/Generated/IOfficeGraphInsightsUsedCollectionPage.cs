// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IOfficeGraphInsightsUsedCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<OfficeGraphInsightsUsedCollectionPage>))]
    public interface IOfficeGraphInsightsUsedCollectionPage : ICollectionPage<UsedInsight>
    {
        /// <summary>
        /// Gets the next page <see cref="IOfficeGraphInsightsUsedCollectionRequest"/> instance.
        /// </summary>
        IOfficeGraphInsightsUsedCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
