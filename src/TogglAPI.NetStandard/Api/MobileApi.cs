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
    public interface IMobileApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// MobileFeedback
        /// </summary>
        /// <remarks>
        /// Send Mobile Feedback.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>string</returns>
        string PostMobileFeedback (ModelsMobileFeedback mobileFeedbackPost);

        /// <summary>
        /// MobileFeedback
        /// </summary>
        /// <remarks>
        /// Send Mobile Feedback.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostMobileFeedbackWithHttpInfo (ModelsMobileFeedback mobileFeedbackPost);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// MobileFeedback
        /// </summary>
        /// <remarks>
        /// Send Mobile Feedback.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostMobileFeedbackAsync (ModelsMobileFeedback mobileFeedbackPost);

        /// <summary>
        /// MobileFeedback
        /// </summary>
        /// <remarks>
        /// Send Mobile Feedback.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostMobileFeedbackAsyncWithHttpInfo (ModelsMobileFeedback mobileFeedbackPost);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MobileApi : IMobileApi
    {
        private TogglAPI.NetStandard.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MobileApi(String basePath)
        {
            this.Configuration = new TogglAPI.NetStandard.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TogglAPI.NetStandard.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MobileApi(TogglAPI.NetStandard.Client.Configuration configuration = null)
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
        /// MobileFeedback Send Mobile Feedback.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>string</returns>
        public string PostMobileFeedback (ModelsMobileFeedback mobileFeedbackPost)
        {
             ApiResponse<string> localVarResponse = PostMobileFeedbackWithHttpInfo(mobileFeedbackPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// MobileFeedback Send Mobile Feedback.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostMobileFeedbackWithHttpInfo (ModelsMobileFeedback mobileFeedbackPost)
        {
            // verify the required parameter 'mobileFeedbackPost' is set
            if (mobileFeedbackPost == null)
                throw new ApiException(400, "Missing required parameter 'mobileFeedbackPost' when calling MobileApi->PostMobileFeedback");

            var localVarPath = "/mobile/feedback";
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

            if (mobileFeedbackPost != null && mobileFeedbackPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(mobileFeedbackPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mobileFeedbackPost; // byte array
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
                Exception exception = ExceptionFactory("PostMobileFeedback", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// MobileFeedback Send Mobile Feedback.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostMobileFeedbackAsync (ModelsMobileFeedback mobileFeedbackPost)
        {
             ApiResponse<string> localVarResponse = await PostMobileFeedbackAsyncWithHttpInfo(mobileFeedbackPost);
             return localVarResponse.Data;

        }

        /// <summary>
        /// MobileFeedback Send Mobile Feedback.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mobileFeedbackPost">Feedback parameters.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostMobileFeedbackAsyncWithHttpInfo (ModelsMobileFeedback mobileFeedbackPost)
        {
            // verify the required parameter 'mobileFeedbackPost' is set
            if (mobileFeedbackPost == null)
                throw new ApiException(400, "Missing required parameter 'mobileFeedbackPost' when calling MobileApi->PostMobileFeedback");

            var localVarPath = "/mobile/feedback";
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

            if (mobileFeedbackPost != null && mobileFeedbackPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(mobileFeedbackPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mobileFeedbackPost; // byte array
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
                Exception exception = ExceptionFactory("PostMobileFeedback", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
