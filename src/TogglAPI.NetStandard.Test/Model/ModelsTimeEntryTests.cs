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
    ///  Class for testing ModelsTimeEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsTimeEntryTests
    {
        // TODO uncomment below to declare an instance variable for ModelsTimeEntry
        //private ModelsTimeEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsTimeEntry
            //instance = new ModelsTimeEntry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsTimeEntry
        /// </summary>
        [Test]
        public void ModelsTimeEntryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsTimeEntry
            //Assert.IsInstanceOfType<ModelsTimeEntry> (instance, "variable 'instance' is a ModelsTimeEntry");
        }


        /// <summary>
        /// Test the property 'At'
        /// </summary>
        [Test]
        public void AtTest()
        {
            // TODO unit test for the property 'At'
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
        /// Test the property 'ClientName'
        /// </summary>
        [Test]
        public void ClientNameTest()
        {
            // TODO unit test for the property 'ClientName'
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
        /// Test the property 'Duronly'
        /// </summary>
        [Test]
        public void DuronlyTest()
        {
            // TODO unit test for the property 'Duronly'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Permissions'
        /// </summary>
        [Test]
        public void PermissionsTest()
        {
            // TODO unit test for the property 'Permissions'
        }
        /// <summary>
        /// Test the property 'Pid'
        /// </summary>
        [Test]
        public void PidTest()
        {
            // TODO unit test for the property 'Pid'
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
        /// Test the property 'ProjectColor'
        /// </summary>
        [Test]
        public void ProjectColorTest()
        {
            // TODO unit test for the property 'ProjectColor'
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
        /// Test the property 'ProjectName'
        /// </summary>
        [Test]
        public void ProjectNameTest()
        {
            // TODO unit test for the property 'ProjectName'
        }
        /// <summary>
        /// Test the property 'ServerDeletedAt'
        /// </summary>
        [Test]
        public void ServerDeletedAtTest()
        {
            // TODO unit test for the property 'ServerDeletedAt'
        }
        /// <summary>
        /// Test the property 'SharedWith'
        /// </summary>
        [Test]
        public void SharedWithTest()
        {
            // TODO unit test for the property 'SharedWith'
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
        /// Test the property 'Stop'
        /// </summary>
        [Test]
        public void StopTest()
        {
            // TODO unit test for the property 'Stop'
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
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
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
        /// Test the property 'TaskName'
        /// </summary>
        [Test]
        public void TaskNameTest()
        {
            // TODO unit test for the property 'TaskName'
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
        /// Test the property 'Uid'
        /// </summary>
        [Test]
        public void UidTest()
        {
            // TODO unit test for the property 'Uid'
        }
        /// <summary>
        /// Test the property 'UserAvatarUrl'
        /// </summary>
        [Test]
        public void UserAvatarUrlTest()
        {
            // TODO unit test for the property 'UserAvatarUrl'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property 'Wid'
        /// </summary>
        [Test]
        public void WidTest()
        {
            // TODO unit test for the property 'Wid'
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
