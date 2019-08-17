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
    /// The type WorkbookFunctionsCombinaRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsCombinaRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsCombinaRequest>, IWorkbookFunctionsCombinaRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsCombinaRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        /// <param name="numberChosen">A numberChosen parameter for the OData method call.</param>
        public WorkbookFunctionsCombinaRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken number,
            Newtonsoft.Json.Linq.JToken numberChosen)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
            this.SetParameter("numberChosen", numberChosen, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsCombinaRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsCombinaRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<Newtonsoft.Json.Linq.JToken>("number");
            }

            if (this.HasParameter("numberChosen"))
            {
                request.RequestBody.NumberChosen = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numberChosen");
            }

            return request;
        }
    }
}
