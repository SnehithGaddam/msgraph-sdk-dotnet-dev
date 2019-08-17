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
    /// The type UserPhotosCollectionRequestBuilder.
    /// </summary>
    public partial class UserPhotosCollectionRequestBuilder : BaseRequestBuilder, IUserPhotosCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserPhotosCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserPhotosCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserPhotosCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserPhotosCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserPhotosCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IProfilePhotoRequestBuilder"/> for the specified UserProfilePhoto.
        /// </summary>
        /// <param name="id">The ID for the UserProfilePhoto.</param>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        public IProfilePhotoRequestBuilder this[string id]
        {
            get
            {
                return new ProfilePhotoRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
