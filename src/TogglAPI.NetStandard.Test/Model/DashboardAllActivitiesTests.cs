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
    ///  Class for testing DashboardAllActivities
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DashboardAllActivitiesTests
    {
        // TODO uncomment below to declare an instance variable for DashboardAllActivities
        //private DashboardAllActivities instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DashboardAllActivities
            //instance = new DashboardAllActivities();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DashboardAllActivities
        /// </summary>
        [Test]
        public void DashboardAllActivitiesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DashboardAllActivities
            //Assert.IsInstanceOfType<DashboardAllActivities> (instance, "variable 'instance' is a DashboardAllActivities");
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
        /// Test the property 'Duration'
        /// </summary>
        [Test]
        public void DurationTest()
        {
            // TODO unit test for the property 'Duration'
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
        /// Test the property 'Stop'
        /// </summary>
        [Test]
        public void StopTest()
        {
            // TODO unit test for the property 'Stop'
        }
        /// <summary>
        /// Test the property 'Tid'
        /// </summary>
        [Test]
        public void TidTest()
        {
            // TODO unit test for the property 'Tid'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

    }

}
