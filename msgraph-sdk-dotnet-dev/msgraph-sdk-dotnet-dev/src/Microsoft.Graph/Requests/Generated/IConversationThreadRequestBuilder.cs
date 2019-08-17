// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IConversationThreadRequestBuilder.
    /// </summary>
    public partial interface IConversationThreadRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IConversationThreadRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IConversationThreadRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Posts.
        /// </summary>
        /// <returns>The <see cref="IConversationThreadPostsCollectionRequestBuilder"/>.</returns>
        IConversationThreadPostsCollectionRequestBuilder Posts { get; }
    
        /// <summary>
        /// Gets the request builder for ConversationThreadReply.
        /// </summary>
        /// <returns>The <see cref="IConversationThreadReplyRequestBuilder"/>.</returns>
        IConversationThreadReplyRequestBuilder Reply(
            Post Post);
    
    }
}
