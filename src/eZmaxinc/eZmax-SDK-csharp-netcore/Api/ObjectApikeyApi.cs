/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.35
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
    public interface IObjectApikeyApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new Apikey
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <returns>ApikeyCreateObjectV1Response</returns>
        ApikeyCreateObjectV1Response ApikeyCreateObjectV1(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request);

        /// <summary>
        /// Create a new Apikey
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <returns>ApiResponse of ApikeyCreateObjectV1Response</returns>
        ApiResponse<ApikeyCreateObjectV1Response> ApikeyCreateObjectV1WithHttpInfo(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectApikeyApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new Apikey
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApikeyCreateObjectV1Response</returns>
        System.Threading.Tasks.Task<ApikeyCreateObjectV1Response> ApikeyCreateObjectV1Async(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a new Apikey
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApikeyCreateObjectV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApikeyCreateObjectV1Response>> ApikeyCreateObjectV1WithHttpInfoAsync(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectApikeyApi : IObjectApikeyApiSync, IObjectApikeyApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectApikeyApi : IObjectApikeyApi
    {
        private eZmaxinc/eZmax-SDK-csharp-netcore.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectApikeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectApikeyApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectApikeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectApikeyApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ObjectApikeyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectApikeyApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ObjectApikeyApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ObjectApikeyApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.ISynchronousClient client, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IAsynchronousClient asyncClient, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IReadableConfiguration configuration)
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
        /// Create a new Apikey The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <returns>ApikeyCreateObjectV1Response</returns>
        public ApikeyCreateObjectV1Response ApikeyCreateObjectV1(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request)
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<ApikeyCreateObjectV1Response> localVarResponse = ApikeyCreateObjectV1WithHttpInfo(apikeyCreateObjectV1Request);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Apikey The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <returns>ApiResponse of ApikeyCreateObjectV1Response</returns>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<ApikeyCreateObjectV1Response> ApikeyCreateObjectV1WithHttpInfo(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request)
        {
            // verify the required parameter 'apikeyCreateObjectV1Request' is set
            if (apikeyCreateObjectV1Request == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'apikeyCreateObjectV1Request' when calling ObjectApikeyApi->ApikeyCreateObjectV1");

            eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions localVarRequestOptions = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = apikeyCreateObjectV1Request;

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApikeyCreateObjectV1Response>("/1/object/apikey", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApikeyCreateObjectV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new Apikey The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApikeyCreateObjectV1Response</returns>
        public async System.Threading.Tasks.Task<ApikeyCreateObjectV1Response> ApikeyCreateObjectV1Async(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<ApikeyCreateObjectV1Response> localVarResponse = await ApikeyCreateObjectV1WithHttpInfoAsync(apikeyCreateObjectV1Request, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Apikey The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apikeyCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApikeyCreateObjectV1Response)</returns>
        public async System.Threading.Tasks.Task<eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<ApikeyCreateObjectV1Response>> ApikeyCreateObjectV1WithHttpInfoAsync(List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'apikeyCreateObjectV1Request' is set
            if (apikeyCreateObjectV1Request == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'apikeyCreateObjectV1Request' when calling ObjectApikeyApi->ApikeyCreateObjectV1");


            eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions localVarRequestOptions = new eZmaxinc/eZmax-SDK-csharp-netcore.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = eZmaxinc/eZmax-SDK-csharp-netcore.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = apikeyCreateObjectV1Request;

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ApikeyCreateObjectV1Response>("/1/object/apikey", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApikeyCreateObjectV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
