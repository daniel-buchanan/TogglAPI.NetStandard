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
    public interface IAvatarsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles DELETE avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string DeleteAvatars ();

        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles DELETE avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteAvatarsWithHttpInfo ();
        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles POST avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>ModelsAvatar</returns>
        ModelsAvatar PostAvatars (string _file);

        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles POST avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>ApiResponse of ModelsAvatar</returns>
        ApiResponse<ModelsAvatar> PostAvatarsWithHttpInfo (string _file);
        /// <summary>
        /// UseGravatar
        /// </summary>
        /// <remarks>
        /// Change user avatar to gravatar.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ModelsAvatar</returns>
        ModelsAvatar PostUseGravatar ();

        /// <summary>
        /// UseGravatar
        /// </summary>
        /// <remarks>
        /// Change user avatar to gravatar.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ModelsAvatar</returns>
        ApiResponse<ModelsAvatar> PostUseGravatarWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles DELETE avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteAvatarsAsync ();

        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles DELETE avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteAvatarsAsyncWithHttpInfo ();
        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles POST avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>Task of ModelsAvatar</returns>
        System.Threading.Tasks.Task<ModelsAvatar> PostAvatarsAsync (string _file);

        /// <summary>
        /// Avatars
        /// </summary>
        /// <remarks>
        /// Handles POST avatar requests.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>Task of ApiResponse (ModelsAvatar)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelsAvatar>> PostAvatarsAsyncWithHttpInfo (string _file);
        /// <summary>
        /// UseGravatar
        /// </summary>
        /// <remarks>
        /// Change user avatar to gravatar.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ModelsAvatar</returns>
        System.Threading.Tasks.Task<ModelsAvatar> PostUseGravatarAsync ();

        /// <summary>
        /// UseGravatar
        /// </summary>
        /// <remarks>
        /// Change user avatar to gravatar.
        /// </remarks>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ModelsAvatar)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelsAvatar>> PostUseGravatarAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AvatarsApi : IAvatarsApi
    {
        private TogglAPI.NetStandard.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvatarsApi(String basePath)
        {
            this.Configuration = new TogglAPI.NetStandard.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TogglAPI.NetStandard.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AvatarsApi(TogglAPI.NetStandard.Client.Configuration configuration = null)
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
        /// Avatars Handles DELETE avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string DeleteAvatars ()
        {
             ApiResponse<string> localVarResponse = DeleteAvatarsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Avatars Handles DELETE avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteAvatarsWithHttpInfo ()
        {

            var localVarPath = "/avatars";
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


            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Avatars Handles DELETE avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteAvatarsAsync ()
        {
             ApiResponse<string> localVarResponse = await DeleteAvatarsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Avatars Handles DELETE avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteAvatarsAsyncWithHttpInfo ()
        {

            var localVarPath = "/avatars";
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


            // authentication (BasicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Avatars Handles POST avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>ModelsAvatar</returns>
        public ModelsAvatar PostAvatars (string _file)
        {
             ApiResponse<ModelsAvatar> localVarResponse = PostAvatarsWithHttpInfo(_file);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Avatars Handles POST avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>ApiResponse of ModelsAvatar</returns>
        public ApiResponse< ModelsAvatar > PostAvatarsWithHttpInfo (string _file)
        {
            // verify the required parameter '_file' is set
            if (_file == null)
                throw new ApiException(400, "Missing required parameter '_file' when calling AvatarsApi->PostAvatars");

            var localVarPath = "/avatars";
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

            if (_file != null) localVarFormParams.Add("file", this.Configuration.ApiClient.ParameterToString(_file)); // form parameter

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
                Exception exception = ExceptionFactory("PostAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelsAvatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelsAvatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelsAvatar)));
        }

        /// <summary>
        /// Avatars Handles POST avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>Task of ModelsAvatar</returns>
        public async System.Threading.Tasks.Task<ModelsAvatar> PostAvatarsAsync (string _file)
        {
             ApiResponse<ModelsAvatar> localVarResponse = await PostAvatarsAsyncWithHttpInfo(_file);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Avatars Handles POST avatar requests.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_file">file form data</param>
        /// <returns>Task of ApiResponse (ModelsAvatar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelsAvatar>> PostAvatarsAsyncWithHttpInfo (string _file)
        {
            // verify the required parameter '_file' is set
            if (_file == null)
                throw new ApiException(400, "Missing required parameter '_file' when calling AvatarsApi->PostAvatars");

            var localVarPath = "/avatars";
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

            if (_file != null) localVarFormParams.Add("file", this.Configuration.ApiClient.ParameterToString(_file)); // form parameter

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
                Exception exception = ExceptionFactory("PostAvatars", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelsAvatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelsAvatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelsAvatar)));
        }

        /// <summary>
        /// UseGravatar Change user avatar to gravatar.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ModelsAvatar</returns>
        public ModelsAvatar PostUseGravatar ()
        {
             ApiResponse<ModelsAvatar> localVarResponse = PostUseGravatarWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// UseGravatar Change user avatar to gravatar.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ModelsAvatar</returns>
        public ApiResponse< ModelsAvatar > PostUseGravatarWithHttpInfo ()
        {

            var localVarPath = "/avatars/use_gravatar";
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
                Exception exception = ExceptionFactory("PostUseGravatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelsAvatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelsAvatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelsAvatar)));
        }

        /// <summary>
        /// UseGravatar Change user avatar to gravatar.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ModelsAvatar</returns>
        public async System.Threading.Tasks.Task<ModelsAvatar> PostUseGravatarAsync ()
        {
             ApiResponse<ModelsAvatar> localVarResponse = await PostUseGravatarAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// UseGravatar Change user avatar to gravatar.
        /// </summary>
        /// <exception cref="TogglAPI.NetStandard.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ModelsAvatar)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelsAvatar>> PostUseGravatarAsyncWithHttpInfo ()
        {

            var localVarPath = "/avatars/use_gravatar";
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
                Exception exception = ExceptionFactory("PostUseGravatar", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelsAvatar>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ModelsAvatar) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelsAvatar)));
        }

    }
}
