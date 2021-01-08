/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.26
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using eZmaxinc/eZmax-SDK-csharp-netcore.Client;
using eZmaxinc/eZmax-SDK-csharp-netcore.Model;

namespace eZmaxinc/eZmax-SDK-csharp-netcore.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchiseofficeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Franchiseoffices and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>CommonGetAutocompleteV1Response</returns>
        CommonGetAutocompleteV1Response FranchiseofficeGetAutocompleteV1(string sSelector, string sQuery = default(string));

        /// <summary>
        /// Retrieve Franchiseoffices and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>ApiResponse of CommonGetAutocompleteV1Response</returns>
        ApiResponse<CommonGetAutocompleteV1Response> FranchiseofficeGetAutocompleteV1WithHttpInfo(string sSelector, string sQuery = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchiseofficeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Franchiseoffices and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommonGetAutocompleteV1Response</returns>
        System.Threading.Tasks.Task<CommonGetAutocompleteV1Response> FranchiseofficeGetAutocompleteV1Async(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve Franchiseoffices and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommonGetAutocompleteV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonGetAutocompleteV1Response>> FranchiseofficeGetAutocompleteV1WithHttpInfoAsync(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchiseofficeApi : IObjectFranchiseofficeApiSync, IObjectFranchiseofficeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectFranchiseofficeApi : IObjectFranchiseofficeApi
    {
        private eZmaxinc/eZmax-SDK-csharp-netcore.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchiseofficeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchiseofficeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchiseofficeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchiseofficeApi(String basePath)
        {
            this.Configuration = eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration.MergeConfigurations(
                eZmaxinc/eZmax-SDK-csharp-netcore.Client.GlobalConfiguration.Instance,
                new eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration { BasePath = basePath }
            );
            this.Client = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchiseofficeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectFranchiseofficeApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration.MergeConfigurations(
                eZmaxinc/eZmax-SDK-csharp-netcore.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchiseofficeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ObjectFranchiseofficeApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.ISynchronousClient client, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IAsynchronousClient asyncClient, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieve Franchiseoffices and IDs Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>CommonGetAutocompleteV1Response</returns>
        public CommonGetAutocompleteV1Response FranchiseofficeGetAutocompleteV1(string sSelector, string sQuery = default(string))
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response> localVarResponse = FranchiseofficeGetAutocompleteV1WithHttpInfo(sSelector, sQuery);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Franchiseoffices and IDs Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>ApiResponse of CommonGetAutocompleteV1Response</returns>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response> FranchiseofficeGetAutocompleteV1WithHttpInfo(string sSelector, string sQuery = default(string))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'sSelector' when calling ObjectFranchiseofficeApi->FranchiseofficeGetAutocompleteV1");

            eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions localVarRequestOptions = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("sSelector", eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.ParameterToString(sSelector)); // path parameter
            if (sQuery != null)
            {
                localVarRequestOptions.QueryParameters.Add(eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.ParameterToMultiMap("", "sQuery", sQuery));
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CommonGetAutocompleteV1Response>("/1/object/franchiseoffice/getAutocomplete/{sSelector}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FranchiseofficeGetAutocompleteV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve Franchiseoffices and IDs Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommonGetAutocompleteV1Response</returns>
        public async System.Threading.Tasks.Task<CommonGetAutocompleteV1Response> FranchiseofficeGetAutocompleteV1Async(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response> localVarResponse = await FranchiseofficeGetAutocompleteV1WithHttpInfoAsync(sSelector, sQuery, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Franchiseoffices and IDs Get the list of Franchiseoffices to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchiseoffices to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommonGetAutocompleteV1Response)</returns>
        public async System.Threading.Tasks.Task<eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response>> FranchiseofficeGetAutocompleteV1WithHttpInfoAsync(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'sSelector' when calling ObjectFranchiseofficeApi->FranchiseofficeGetAutocompleteV1");


            eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions localVarRequestOptions = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("sSelector", eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.ParameterToString(sSelector)); // path parameter
            if (sQuery != null)
            {
                localVarRequestOptions.QueryParameters.Add(eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.ParameterToMultiMap("", "sQuery", sQuery));
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CommonGetAutocompleteV1Response>("/1/object/franchiseoffice/getAutocomplete/{sSelector}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FranchiseofficeGetAutocompleteV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
