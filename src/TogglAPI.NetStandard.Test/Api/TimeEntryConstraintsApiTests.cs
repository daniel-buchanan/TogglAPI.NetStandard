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
    ///  Class for testing TimeEntryConstraintsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TimeEntryConstraintsApiTests
    {
        private TimeEntryConstraintsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeEntryConstraintsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimeEntryConstraintsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TimeEntryConstraintsApi
            //Assert.IsInstanceOfType(typeof(TimeEntryConstraintsApi), instance, "instance is a TimeEntryConstraintsApi");
        }

        
        /// <summary>
        /// Test GetWorkspaceTimeEntryConstraints
        /// </summary>
        [Test]
        public void GetWorkspaceTimeEntryConstraintsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //var response = instance.GetWorkspaceTimeEntryConstraints(workspaceId);
            //Assert.IsInstanceOf<ModelsTimeEntryConstraints> (response, "response is ModelsTimeEntryConstraints");
        }
        
    }

}
