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
    ///  Class for testing TaskResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TaskResponseTests
    {
        // TODO uncomment below to declare an instance variable for TaskResponse
        //private TaskResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TaskResponse
            //instance = new TaskResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaskResponse
        /// </summary>
        [Test]
        public void TaskResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TaskResponse
            //Assert.IsInstanceOfType<TaskResponse> (instance, "variable 'instance' is a TaskResponse");
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }
        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Test]
        public void PageTest()
        {
            // TODO unit test for the property 'Page'
        }
        /// <summary>
        /// Test the property 'PerPage'
        /// </summary>
        [Test]
        public void PerPageTest()
        {
            // TODO unit test for the property 'PerPage'
        }
        /// <summary>
        /// Test the property 'SortField'
        /// </summary>
        [Test]
        public void SortFieldTest()
        {
            // TODO unit test for the property 'SortField'
        }
        /// <summary>
        /// Test the property 'SortOrder'
        /// </summary>
        [Test]
        public void SortOrderTest()
        {
            // TODO unit test for the property 'SortOrder'
        }
        /// <summary>
        /// Test the property 'TotalCount'
        /// </summary>
        [Test]
        public void TotalCountTest()
        {
            // TODO unit test for the property 'TotalCount'
        }

    }

}
