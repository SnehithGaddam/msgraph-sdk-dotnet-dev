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
    /// The interface IContactFolderRequestBuilder.
    /// </summary>
    public partial interface IContactFolderRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IContactFolderRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IContactFolderRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Contacts.
        /// </summary>
        /// <returns>The <see cref="IContactFolderContactsCollectionRequestBuilder"/>.</returns>
        IContactFolderContactsCollectionRequestBuilder Contacts { get; }

        /// <summary>
        /// Gets the request builder for ChildFolders.
        /// </summary>
        /// <returns>The <see cref="IContactFolderChildFoldersCollectionRequestBuilder"/>.</returns>
        IContactFolderChildFoldersCollectionRequestBuilder ChildFolders { get; }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IContactFolderSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IContactFolderSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IContactFolderMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IContactFolderMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }
    
        
    
    }
}
