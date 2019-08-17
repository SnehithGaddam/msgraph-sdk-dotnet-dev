// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DriveItemSubscriptionsCollectionRequestBuilder.
    /// </summary>
    public partial class DriveItemSubscriptionsCollectionRequestBuilder : BaseRequestBuilder, IDriveItemSubscriptionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DriveItemSubscriptionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DriveItemSubscriptionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDriveItemSubscriptionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDriveItemSubscriptionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DriveItemSubscriptionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISubscriptionRequestBuilder"/> for the specified DriveItemSubscription.
        /// </summary>
        /// <param name="id">The ID for the DriveItemSubscription.</param>
        /// <returns>The <see cref="ISubscriptionRequestBuilder"/>.</returns>
        public ISubscriptionRequestBuilder this[string id]
        {
            get
            {
                return new SubscriptionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
