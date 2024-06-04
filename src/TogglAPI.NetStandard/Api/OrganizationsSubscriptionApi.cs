/* 
 * Toggl API
 *
 * Public Toggl API. Note: We use BasicAuth in a specific way. By the standard you provide `Authentication` header with `base64(user_name:password)` as a `credential`. In our case it will be `base64(user_name:api_token)`.
 *
 * OpenAPI spec version: 9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Model;

namespace TogglAPI.NetStandard.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationssubscriptionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// SubscriptionCalculation
        /// </summary>
        /// <remarks>
        /// Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>CalculateResponse</returns>
        CalculateResponse PostOrganizationSubscriptionCalculate (int? organizationId, CalculateCalculateRequest calculationDataRequest);

        /// <summary>
        /// SubscriptionCalculation
        /// </summary>
        /// <remarks>
        /// Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>ApiResponse of CalculateResponse</returns>
        ApiResponse<CalculateResponse> PostOrganizationSubscriptionCalculateWithHttpInfo (int? organizationId, CalculateCalculateRequest calculationDataRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// SubscriptionCalculation
        /// </summary>
        /// <remarks>
        /// Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>Task of CalculateResponse</returns>
        System.Threading.Tasks.Task<CalculateResponse> PostOrganizationSubscriptionCalculateAsync (int? organizationId, CalculateCalculateRequest calculationDataRequest);

        /// <summary>
        /// SubscriptionCalculation
        /// </summary>
        /// <remarks>
        /// Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>Task of ApiResponse (CalculateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalculateResponse>> PostOrganizationSubscriptionCalculateAsyncWithHttpInfo (int? organizationId, CalculateCalculateRequest calculationDataRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrganizationsSubscriptionApi : IOrganizationssubscriptionApi
    {
        private TogglAPI.NetStandard.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsSubscriptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationsSubscriptionApi(String basePath)
        {
            this.Configuration = new TogglAPI.NetStandard.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TogglAPI.NetStandard.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsSubscriptionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrganizationsSubscriptionApi(TogglAPI.NetStandard.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = TogglAPI.NetStandard.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TogglAPI.NetStandard.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public TogglAPI.NetStandard.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TogglAPI.NetStandard.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// SubscriptionCalculation Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>CalculateResponse</returns>
        public CalculateResponse PostOrganizationSubscriptionCalculate (int? organizationId, CalculateCalculateRequest calculationDataRequest)
        {
             ApiResponse<CalculateResponse> localVarResponse = PostOrganizationSubscriptionCalculateWithHttpInfo(organizationId, calculationDataRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// SubscriptionCalculation Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>ApiResponse of CalculateResponse</returns>
        public ApiResponse< CalculateResponse > PostOrganizationSubscriptionCalculateWithHttpInfo (int? organizationId, CalculateCalculateRequest calculationDataRequest)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationssubscriptionApi->PostOrganizationSubscriptionCalculate");
            // verify the required parameter 'calculationDataRequest' is set
            if (calculationDataRequest == null)
                throw new ApiException(400, "Missing required parameter 'calculationDataRequest' when calling OrganizationssubscriptionApi->PostOrganizationSubscriptionCalculate");

            var localVarPath = "/organizations/{organization_id}/subscription/calculate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationId != null) localVarPathParams.Add("organization_id", this.Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
            if (calculationDataRequest != null && calculationDataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(calculationDataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = calculationDataRequest; // byte array
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostOrganizationSubscriptionCalculate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CalculateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalculateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalculateResponse)));
        }

        /// <summary>
        /// SubscriptionCalculation Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>Task of CalculateResponse</returns>
        public async System.Threading.Tasks.Task<CalculateResponse> PostOrganizationSubscriptionCalculateAsync (int? organizationId, CalculateCalculateRequest calculationDataRequest)
        {
             ApiResponse<CalculateResponse> localVarResponse = await PostOrganizationSubscriptionCalculateAsyncWithHttpInfo(organizationId, calculationDataRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// SubscriptionCalculation Returns calculation of the subscription price for given pricing plan, period count, user count, currency, taxes etc.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Numeric ID of the organizaiton.</param>
        /// <param name="calculationDataRequest">Input data for calculation.</param>
        /// <returns>Task of ApiResponse (CalculateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CalculateResponse>> PostOrganizationSubscriptionCalculateAsyncWithHttpInfo (int? organizationId, CalculateCalculateRequest calculationDataRequest)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationssubscriptionApi->PostOrganizationSubscriptionCalculate");
            // verify the required parameter 'calculationDataRequest' is set
            if (calculationDataRequest == null)
                throw new ApiException(400, "Missing required parameter 'calculationDataRequest' when calling OrganizationssubscriptionApi->PostOrganizationSubscriptionCalculate");

            var localVarPath = "/organizations/{organization_id}/subscription/calculate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationId != null) localVarPathParams.Add("organization_id", this.Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
            if (calculationDataRequest != null && calculationDataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(calculationDataRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = calculationDataRequest; // byte array
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostOrganizationSubscriptionCalculate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CalculateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalculateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalculateResponse)));
        }

    }
}
