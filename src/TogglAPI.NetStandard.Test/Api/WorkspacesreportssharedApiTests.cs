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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Model;

namespace TogglAPI.NetStandard.Test
{
    /// <summary>
    ///  Class for testing WorkspacesreportssharedApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkspacesreportssharedApiTests
    {
        private WorkspacesreportssharedApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspacesreportssharedApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkspacesreportssharedApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkspacesreportssharedApi
            //Assert.IsInstanceOfType(typeof(WorkspacesreportssharedApi), instance, "instance is a WorkspacesreportssharedApi");
        }

        
        /// <summary>
        /// Test BulkDeleteSavedReportResource
        /// </summary>
        [Test]
        public void BulkDeleteSavedReportResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //SharedBulkDeleteInputData inputData = null;
            //var response = instance.BulkDeleteSavedReportResource(workspaceId, inputData);
            //Assert.IsInstanceOf<List<ModelsSavedReport>> (response, "response is List<ModelsSavedReport>");
        }
        
    }

}
