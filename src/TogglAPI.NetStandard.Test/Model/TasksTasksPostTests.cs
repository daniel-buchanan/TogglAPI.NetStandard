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
    ///  Class for testing TasksTasksPost
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TasksTasksPostTests
    {
        // TODO uncomment below to declare an instance variable for TasksTasksPost
        //private TasksTasksPost instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TasksTasksPost
            //instance = new TasksTasksPost();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TasksTasksPost
        /// </summary>
        [Test]
        public void TasksTasksPostInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TasksTasksPost
            //Assert.IsInstanceOfType<TasksTasksPost> (instance, "variable 'instance' is a TasksTasksPost");
        }


        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'Ids'
        /// </summary>
        [Test]
        public void IdsTest()
        {
            // TODO unit test for the property 'Ids'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO unit test for the property 'PageSize'
        }
        /// <summary>
        /// Test the property 'ProjectActive'
        /// </summary>
        [Test]
        public void ProjectActiveTest()
        {
            // TODO unit test for the property 'ProjectActive'
        }
        /// <summary>
        /// Test the property 'ProjectIds'
        /// </summary>
        [Test]
        public void ProjectIdsTest()
        {
            // TODO unit test for the property 'ProjectIds'
        }
        /// <summary>
        /// Test the property 'Start'
        /// </summary>
        [Test]
        public void StartTest()
        {
            // TODO unit test for the property 'Start'
        }
        /// <summary>
        /// Test the property 'UserIds'
        /// </summary>
        [Test]
        public void UserIdsTest()
        {
            // TODO unit test for the property 'UserIds'
        }

    }

}
