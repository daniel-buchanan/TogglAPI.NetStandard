/* 
 * Toggl API
 *
 * Public Toggl API. Note: We use BasicAuth in a specific way. By the standard you provide `Authentication` header with `base64(user_name:password)` as a `credential`. In our case it will be `base64(user_name:api_token)`.
 *
 * OpenAPI spec version: 9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Model;
using TogglAPI.NetStandard.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TogglAPI.NetStandard.Test
{
    /// <summary>
    ///  Class for testing HandlerfavoritesPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HandlerfavoritesPayloadTests
    {
        // TODO uncomment below to declare an instance variable for HandlerfavoritesPayload
        //private HandlerfavoritesPayload instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HandlerfavoritesPayload
            //instance = new HandlerfavoritesPayload();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HandlerfavoritesPayload
        /// </summary>
        [Test]
        public void HandlerfavoritesPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HandlerfavoritesPayload
            //Assert.IsInstanceOfType<HandlerfavoritesPayload> (instance, "variable 'instance' is a HandlerfavoritesPayload");
        }


        /// <summary>
        /// Test the property 'Billable'
        /// </summary>
        [Test]
        public void BillableTest()
        {
            // TODO unit test for the property 'Billable'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'ProjectId'
        /// </summary>
        [Test]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'TagIds'
        /// </summary>
        [Test]
        public void TagIdsTest()
        {
            // TODO unit test for the property 'TagIds'
        }
        /// <summary>
        /// Test the property 'TaskId'
        /// </summary>
        [Test]
        public void TaskIdTest()
        {
            // TODO unit test for the property 'TaskId'
        }
        /// <summary>
        /// Test the property 'WorkspaceId'
        /// </summary>
        [Test]
        public void WorkspaceIdTest()
        {
            // TODO unit test for the property 'WorkspaceId'
        }

    }

}
