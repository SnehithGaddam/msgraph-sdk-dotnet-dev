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
    /// The interface IDeviceComplianceDeviceOverviewRequest.
    /// </summary>
    public partial interface IDeviceComplianceDeviceOverviewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceComplianceDeviceOverview using POST.
        /// </summary>
        /// <param name="deviceComplianceDeviceOverviewToCreate">The DeviceComplianceDeviceOverview to create.</param>
        /// <returns>The created DeviceComplianceDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceOverview> CreateAsync(DeviceComplianceDeviceOverview deviceComplianceDeviceOverviewToCreate);        /// <summary>
        /// Creates the specified DeviceComplianceDeviceOverview using POST.
        /// </summary>
        /// <param name="deviceComplianceDeviceOverviewToCreate">The DeviceComplianceDeviceOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceOverview> CreateAsync(DeviceComplianceDeviceOverview deviceComplianceDeviceOverviewToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceOverview.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceOverview.
        /// </summary>
        /// <returns>The DeviceComplianceDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceOverview> GetAsync();

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceOverview> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceOverview using PATCH.
        /// </summary>
        /// <param name="deviceComplianceDeviceOverviewToUpdate">The DeviceComplianceDeviceOverview to update.</param>
        /// <returns>The updated DeviceComplianceDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceOverview> UpdateAsync(DeviceComplianceDeviceOverview deviceComplianceDeviceOverviewToUpdate);

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceOverview using PATCH.
        /// </summary>
        /// <param name="deviceComplianceDeviceOverviewToUpdate">The DeviceComplianceDeviceOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceOverview> UpdateAsync(DeviceComplianceDeviceOverview deviceComplianceDeviceOverviewToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceOverviewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceOverviewRequest Expand(Expression<Func<DeviceComplianceDeviceOverview, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceOverviewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceOverviewRequest Select(Expression<Func<DeviceComplianceDeviceOverview, object>> selectExpression);

    }
}
