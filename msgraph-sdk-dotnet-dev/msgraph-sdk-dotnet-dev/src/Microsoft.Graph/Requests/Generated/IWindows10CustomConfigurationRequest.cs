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
    /// The interface IWindows10CustomConfigurationRequest.
    /// </summary>
    public partial interface IWindows10CustomConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10CustomConfiguration using POST.
        /// </summary>
        /// <param name="windows10CustomConfigurationToCreate">The Windows10CustomConfiguration to create.</param>
        /// <returns>The created Windows10CustomConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10CustomConfiguration> CreateAsync(Windows10CustomConfiguration windows10CustomConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows10CustomConfiguration using POST.
        /// </summary>
        /// <param name="windows10CustomConfigurationToCreate">The Windows10CustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10CustomConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10CustomConfiguration> CreateAsync(Windows10CustomConfiguration windows10CustomConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10CustomConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10CustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10CustomConfiguration.
        /// </summary>
        /// <returns>The Windows10CustomConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10CustomConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows10CustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10CustomConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10CustomConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10CustomConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10CustomConfigurationToUpdate">The Windows10CustomConfiguration to update.</param>
        /// <returns>The updated Windows10CustomConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10CustomConfiguration> UpdateAsync(Windows10CustomConfiguration windows10CustomConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows10CustomConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10CustomConfigurationToUpdate">The Windows10CustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10CustomConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10CustomConfiguration> UpdateAsync(Windows10CustomConfiguration windows10CustomConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CustomConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CustomConfigurationRequest Expand(Expression<Func<Windows10CustomConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CustomConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CustomConfigurationRequest Select(Expression<Func<Windows10CustomConfiguration, object>> selectExpression);

    }
}
