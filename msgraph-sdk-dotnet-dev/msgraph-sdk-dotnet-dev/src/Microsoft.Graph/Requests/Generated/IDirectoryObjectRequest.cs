// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDirectoryObjectRequest.
    /// </summary>
    public partial interface IDirectoryObjectRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryObject using POST.
        /// </summary>
        /// <param name="directoryObjectToCreate">The DirectoryObject to create.</param>
        /// <returns>The created DirectoryObject.</returns>
        System.Threading.Tasks.Task<DirectoryObject> CreateAsync(DirectoryObject directoryObjectToCreate);        /// <summary>
        /// Creates the specified DirectoryObject using POST.
        /// </summary>
        /// <param name="directoryObjectToCreate">The DirectoryObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryObject.</returns>
        System.Threading.Tasks.Task<DirectoryObject> CreateAsync(DirectoryObject directoryObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectoryObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryObject.
        /// </summary>
        /// <returns>The DirectoryObject.</returns>
        System.Threading.Tasks.Task<DirectoryObject> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryObject.</returns>
        System.Threading.Tasks.Task<DirectoryObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryObject using PATCH.
        /// </summary>
        /// <param name="directoryObjectToUpdate">The DirectoryObject to update.</param>
        /// <returns>The updated DirectoryObject.</returns>
        System.Threading.Tasks.Task<DirectoryObject> UpdateAsync(DirectoryObject directoryObjectToUpdate);

        /// <summary>
        /// Updates the specified DirectoryObject using PATCH.
        /// </summary>
        /// <param name="directoryObjectToUpdate">The DirectoryObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DirectoryObject.</returns>
        System.Threading.Tasks.Task<DirectoryObject> UpdateAsync(DirectoryObject directoryObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectRequest Expand(Expression<Func<DirectoryObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectRequest Select(Expression<Func<DirectoryObject, object>> selectExpression);

    }
}
