/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.31
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
    public interface IObjectFranchisebrokerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Franchisebrokers and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>CommonGetAutocompleteV1Response</returns>
        CommonGetAutocompleteV1Response FranchisebrokerGetAutocompleteV1(string sSelector, string sQuery = default(string));

        /// <summary>
        /// Retrieve Franchisebrokers and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>ApiResponse of CommonGetAutocompleteV1Response</returns>
        ApiResponse<CommonGetAutocompleteV1Response> FranchisebrokerGetAutocompleteV1WithHttpInfo(string sSelector, string sQuery = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchisebrokerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Franchisebrokers and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommonGetAutocompleteV1Response</returns>
        System.Threading.Tasks.Task<CommonGetAutocompleteV1Response> FranchisebrokerGetAutocompleteV1Async(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve Franchisebrokers and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommonGetAutocompleteV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonGetAutocompleteV1Response>> FranchisebrokerGetAutocompleteV1WithHttpInfoAsync(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchisebrokerApi : IObjectFranchisebrokerApiSync, IObjectFranchisebrokerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectFranchisebrokerApi : IObjectFranchisebrokerApi
    {
        private eZmaxinc/eZmax-SDK-csharp-netcore.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisebrokerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchisebrokerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisebrokerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchisebrokerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ObjectFranchisebrokerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectFranchisebrokerApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ObjectFranchisebrokerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ObjectFranchisebrokerApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.ISynchronousClient client, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IAsynchronousClient asyncClient, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IReadableConfiguration configuration)
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
        /// Retrieve Franchisebrokers and IDs Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>CommonGetAutocompleteV1Response</returns>
        public CommonGetAutocompleteV1Response FranchisebrokerGetAutocompleteV1(string sSelector, string sQuery = default(string))
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response> localVarResponse = FranchisebrokerGetAutocompleteV1WithHttpInfo(sSelector, sQuery);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Franchisebrokers and IDs Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>ApiResponse of CommonGetAutocompleteV1Response</returns>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response> FranchisebrokerGetAutocompleteV1WithHttpInfo(string sSelector, string sQuery = default(string))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'sSelector' when calling ObjectFranchisebrokerApi->FranchisebrokerGetAutocompleteV1");

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
            var localVarResponse = this.Client.Get<CommonGetAutocompleteV1Response>("/1/object/franchisebroker/getAutocomplete/{sSelector}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FranchisebrokerGetAutocompleteV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve Franchisebrokers and IDs Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CommonGetAutocompleteV1Response</returns>
        public async System.Threading.Tasks.Task<CommonGetAutocompleteV1Response> FranchisebrokerGetAutocompleteV1Async(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response> localVarResponse = await FranchisebrokerGetAutocompleteV1WithHttpInfoAsync(sSelector, sQuery, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Franchisebrokers and IDs Get the list of Franchisebrokers to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The type of Franchisebrokers to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CommonGetAutocompleteV1Response)</returns>
        public async System.Threading.Tasks.Task<eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<CommonGetAutocompleteV1Response>> FranchisebrokerGetAutocompleteV1WithHttpInfoAsync(string sSelector, string sQuery = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'sSelector' when calling ObjectFranchisebrokerApi->FranchisebrokerGetAutocompleteV1");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CommonGetAutocompleteV1Response>("/1/object/franchisebroker/getAutocomplete/{sSelector}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FranchisebrokerGetAutocompleteV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
