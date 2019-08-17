// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFilterApplyTopPercentFilterRequestBuilder.
    /// </summary>
    public partial class WorkbookFilterApplyTopPercentFilterRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFilterApplyTopPercentFilterRequest>, IWorkbookFilterApplyTopPercentFilterRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFilterApplyTopPercentFilterRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="percent">A percent parameter for the OData method call.</param>
        public WorkbookFilterApplyTopPercentFilterRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 percent)
            : base(requestUrl, client)
        {
            this.SetParameter("percent", percent, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFilterApplyTopPercentFilterRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFilterApplyTopPercentFilterRequest(functionUrl, this.Client, options);

            if (this.HasParameter("percent"))
            {
                request.RequestBody.Percent = this.GetParameter<Int32>("percent");
            }

            return request;
        }
    }
}
