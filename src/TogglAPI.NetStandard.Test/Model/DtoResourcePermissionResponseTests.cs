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
    ///  Class for testing DtoResourcePermissionResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DtoResourcePermissionResponseTests
    {
        // TODO uncomment below to declare an instance variable for DtoResourcePermissionResponse
        //private DtoResourcePermissionResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DtoResourcePermissionResponse
            //instance = new DtoResourcePermissionResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DtoResourcePermissionResponse
        /// </summary>
        [Test]
        public void DtoResourcePermissionResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DtoResourcePermissionResponse
            //Assert.IsInstanceOfType<DtoResourcePermissionResponse> (instance, "variable 'instance' is a DtoResourcePermissionResponse");
        }


        /// <summary>
        /// Test the property 'AllowedActions'
        /// </summary>
        [Test]
        public void AllowedActionsTest()
        {
            // TODO unit test for the property 'AllowedActions'
        }
        /// <summary>
        /// Test the property 'GroupId'
        /// </summary>
        [Test]
        public void GroupIdTest()
        {
            // TODO unit test for the property 'GroupId'
        }
        /// <summary>
        /// Test the property 'OrganizationId'
        /// </summary>
        [Test]
        public void OrganizationIdTest()
        {
            // TODO unit test for the property 'OrganizationId'
        }
        /// <summary>
        /// Test the property 'PermissionType'
        /// </summary>
        [Test]
        public void PermissionTypeTest()
        {
            // TODO unit test for the property 'PermissionType'
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
        /// Test the property 'WorkspaceId'
        /// </summary>
        [Test]
        public void WorkspaceIdTest()
        {
            // TODO unit test for the property 'WorkspaceId'
        }

    }

}
