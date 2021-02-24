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
    public interface IObjectFranchisereferalincomeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>FranchisereferalincomeCreateObjectV1Response</returns>
        FranchisereferalincomeCreateObjectV1Response FranchisereferalincomeCreateObjectV1(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request);

        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>ApiResponse of FranchisereferalincomeCreateObjectV1Response</returns>
        ApiResponse<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1WithHttpInfo(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchisereferalincomeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FranchisereferalincomeCreateObjectV1Response</returns>
        System.Threading.Tasks.Task<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1Async(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FranchisereferalincomeCreateObjectV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FranchisereferalincomeCreateObjectV1Response>> FranchisereferalincomeCreateObjectV1WithHttpInfoAsync(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchisereferalincomeApi : IObjectFranchisereferalincomeApiSync, IObjectFranchisereferalincomeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectFranchisereferalincomeApi : IObjectFranchisereferalincomeApi
    {
        private eZmaxinc/eZmax-SDK-csharp-netcore.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchisereferalincomeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchisereferalincomeApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectFranchisereferalincomeApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ObjectFranchisereferalincomeApi(eZmaxinc/eZmax-SDK-csharp-netcore.Client.ISynchronousClient client, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IAsynchronousClient asyncClient, eZmaxinc/eZmax-SDK-csharp-netcore.Client.IReadableConfiguration configuration)
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
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>FranchisereferalincomeCreateObjectV1Response</returns>
        public FranchisereferalincomeCreateObjectV1Response FranchisereferalincomeCreateObjectV1(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request)
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<FranchisereferalincomeCreateObjectV1Response> localVarResponse = FranchisereferalincomeCreateObjectV1WithHttpInfo(franchisereferalincomeCreateObjectV1Request);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>ApiResponse of FranchisereferalincomeCreateObjectV1Response</returns>
        public eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1WithHttpInfo(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request)
        {
            // verify the required parameter 'franchisereferalincomeCreateObjectV1Request' is set
            if (franchisereferalincomeCreateObjectV1Request == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'franchisereferalincomeCreateObjectV1Request' when calling ObjectFranchisereferalincomeApi->FranchisereferalincomeCreateObjectV1");

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

            localVarRequestOptions.Data = franchisereferalincomeCreateObjectV1Request;

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<FranchisereferalincomeCreateObjectV1Response>("/1/object/franchisereferalincome", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FranchisereferalincomeCreateObjectV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FranchisereferalincomeCreateObjectV1Response</returns>
        public async System.Threading.Tasks.Task<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1Async(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<FranchisereferalincomeCreateObjectV1Response> localVarResponse = await FranchisereferalincomeCreateObjectV1WithHttpInfoAsync(franchisereferalincomeCreateObjectV1Request, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FranchisereferalincomeCreateObjectV1Response)</returns>
        public async System.Threading.Tasks.Task<eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiResponse<FranchisereferalincomeCreateObjectV1Response>> FranchisereferalincomeCreateObjectV1WithHttpInfoAsync(List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'franchisereferalincomeCreateObjectV1Request' is set
            if (franchisereferalincomeCreateObjectV1Request == null)
                throw new eZmaxinc/eZmax-SDK-csharp-netcore.Client.ApiException(400, "Missing required parameter 'franchisereferalincomeCreateObjectV1Request' when calling ObjectFranchisereferalincomeApi->FranchisereferalincomeCreateObjectV1");


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

            localVarRequestOptions.Data = franchisereferalincomeCreateObjectV1Request;

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FranchisereferalincomeCreateObjectV1Response>("/1/object/franchisereferalincome", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FranchisereferalincomeCreateObjectV1", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
