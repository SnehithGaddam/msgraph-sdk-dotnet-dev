// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceManagementRequest.
    /// </summary>
    public partial class DeviceManagementRequest : BaseRequest, IDeviceManagementRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagement using POST.
        /// </summary>
        /// <param name="deviceManagementToCreate">The DeviceManagement to create.</param>
        /// <returns>The created DeviceManagement.</returns>
        public System.Threading.Tasks.Task<DeviceManagement> CreateAsync(DeviceManagement deviceManagementToCreate)
        {
            return this.CreateAsync(deviceManagementToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagement using POST.
        /// </summary>
        /// <param name="deviceManagementToCreate">The DeviceManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagement.</returns>
        public async System.Threading.Tasks.Task<DeviceManagement> CreateAsync(DeviceManagement deviceManagementToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagement>(deviceManagementToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceManagement.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagement>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagement.
        /// </summary>
        /// <returns>The DeviceManagement.</returns>
        public System.Threading.Tasks.Task<DeviceManagement> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagement.</returns>
        public async System.Threading.Tasks.Task<DeviceManagement> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagement>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagement using PATCH.
        /// </summary>
        /// <param name="deviceManagementToUpdate">The DeviceManagement to update.</param>
        /// <returns>The updated DeviceManagement.</returns>
        public System.Threading.Tasks.Task<DeviceManagement> UpdateAsync(DeviceManagement deviceManagementToUpdate)
        {
            return this.UpdateAsync(deviceManagementToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagement using PATCH.
        /// </summary>
        /// <param name="deviceManagementToUpdate">The DeviceManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagement.</returns>
        public async System.Threading.Tasks.Task<DeviceManagement> UpdateAsync(DeviceManagement deviceManagementToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementToUpdate.AdditionalData != null)
			{
				if (deviceManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementToUpdate.AdditionalData != null)
            {
                if (deviceManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagement>(deviceManagementToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementRequest Expand(Expression<Func<DeviceManagement, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementRequest Select(Expression<Func<DeviceManagement, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="deviceManagementToInitialize">The <see cref="DeviceManagement"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagement deviceManagementToInitialize)
        {

            if (deviceManagementToInitialize != null && deviceManagementToInitialize.AdditionalData != null)
            {

                if (deviceManagementToInitialize.TermsAndConditions != null && deviceManagementToInitialize.TermsAndConditions.CurrentPage != null)
                {
                    deviceManagementToInitialize.TermsAndConditions.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("termsAndConditions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.TermsAndConditions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DetectedApps != null && deviceManagementToInitialize.DetectedApps.CurrentPage != null)
                {
                    deviceManagementToInitialize.DetectedApps.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("detectedApps@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DetectedApps.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.ManagedDevices != null && deviceManagementToInitialize.ManagedDevices.CurrentPage != null)
                {
                    deviceManagementToInitialize.ManagedDevices.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("managedDevices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.ManagedDevices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DeviceConfigurations != null && deviceManagementToInitialize.DeviceConfigurations.CurrentPage != null)
                {
                    deviceManagementToInitialize.DeviceConfigurations.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("deviceConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DeviceConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DeviceCompliancePolicies != null && deviceManagementToInitialize.DeviceCompliancePolicies.CurrentPage != null)
                {
                    deviceManagementToInitialize.DeviceCompliancePolicies.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("deviceCompliancePolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DeviceCompliancePolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DeviceCompliancePolicySettingStateSummaries != null && deviceManagementToInitialize.DeviceCompliancePolicySettingStateSummaries.CurrentPage != null)
                {
                    deviceManagementToInitialize.DeviceCompliancePolicySettingStateSummaries.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("deviceCompliancePolicySettingStateSummaries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DeviceCompliancePolicySettingStateSummaries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.IosUpdateStatuses != null && deviceManagementToInitialize.IosUpdateStatuses.CurrentPage != null)
                {
                    deviceManagementToInitialize.IosUpdateStatuses.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("iosUpdateStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.IosUpdateStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DeviceCategories != null && deviceManagementToInitialize.DeviceCategories.CurrentPage != null)
                {
                    deviceManagementToInitialize.DeviceCategories.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("deviceCategories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DeviceCategories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.ExchangeConnectors != null && deviceManagementToInitialize.ExchangeConnectors.CurrentPage != null)
                {
                    deviceManagementToInitialize.ExchangeConnectors.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("exchangeConnectors@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.ExchangeConnectors.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DeviceEnrollmentConfigurations != null && deviceManagementToInitialize.DeviceEnrollmentConfigurations.CurrentPage != null)
                {
                    deviceManagementToInitialize.DeviceEnrollmentConfigurations.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("deviceEnrollmentConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DeviceEnrollmentConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.MobileThreatDefenseConnectors != null && deviceManagementToInitialize.MobileThreatDefenseConnectors.CurrentPage != null)
                {
                    deviceManagementToInitialize.MobileThreatDefenseConnectors.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("mobileThreatDefenseConnectors@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.MobileThreatDefenseConnectors.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.DeviceManagementPartners != null && deviceManagementToInitialize.DeviceManagementPartners.CurrentPage != null)
                {
                    deviceManagementToInitialize.DeviceManagementPartners.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("deviceManagementPartners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.DeviceManagementPartners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.NotificationMessageTemplates != null && deviceManagementToInitialize.NotificationMessageTemplates.CurrentPage != null)
                {
                    deviceManagementToInitialize.NotificationMessageTemplates.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("notificationMessageTemplates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.NotificationMessageTemplates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.RoleDefinitions != null && deviceManagementToInitialize.RoleDefinitions.CurrentPage != null)
                {
                    deviceManagementToInitialize.RoleDefinitions.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("roleDefinitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.RoleDefinitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.RoleAssignments != null && deviceManagementToInitialize.RoleAssignments.CurrentPage != null)
                {
                    deviceManagementToInitialize.RoleAssignments.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("roleAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.RoleAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.ResourceOperations != null && deviceManagementToInitialize.ResourceOperations.CurrentPage != null)
                {
                    deviceManagementToInitialize.ResourceOperations.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("resourceOperations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.ResourceOperations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.TelecomExpenseManagementPartners != null && deviceManagementToInitialize.TelecomExpenseManagementPartners.CurrentPage != null)
                {
                    deviceManagementToInitialize.TelecomExpenseManagementPartners.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("telecomExpenseManagementPartners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.TelecomExpenseManagementPartners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.RemoteAssistancePartners != null && deviceManagementToInitialize.RemoteAssistancePartners.CurrentPage != null)
                {
                    deviceManagementToInitialize.RemoteAssistancePartners.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("remoteAssistancePartners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.RemoteAssistancePartners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.WindowsInformationProtectionAppLearningSummaries != null && deviceManagementToInitialize.WindowsInformationProtectionAppLearningSummaries.CurrentPage != null)
                {
                    deviceManagementToInitialize.WindowsInformationProtectionAppLearningSummaries.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("windowsInformationProtectionAppLearningSummaries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.WindowsInformationProtectionAppLearningSummaries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.WindowsInformationProtectionNetworkLearningSummaries != null && deviceManagementToInitialize.WindowsInformationProtectionNetworkLearningSummaries.CurrentPage != null)
                {
                    deviceManagementToInitialize.WindowsInformationProtectionNetworkLearningSummaries.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("windowsInformationProtectionNetworkLearningSummaries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.WindowsInformationProtectionNetworkLearningSummaries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementToInitialize.TroubleshootingEvents != null && deviceManagementToInitialize.TroubleshootingEvents.CurrentPage != null)
                {
                    deviceManagementToInitialize.TroubleshootingEvents.AdditionalData = deviceManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementToInitialize.AdditionalData.TryGetValue("troubleshootingEvents@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementToInitialize.TroubleshootingEvents.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}