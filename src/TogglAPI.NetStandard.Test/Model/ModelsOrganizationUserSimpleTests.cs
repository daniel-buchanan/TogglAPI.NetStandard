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
    ///  Class for testing ModelsOrganizationUserSimple
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsOrganizationUserSimpleTests
    {
        // TODO uncomment below to declare an instance variable for ModelsOrganizationUserSimple
        //private ModelsOrganizationUserSimple instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsOrganizationUserSimple
            //instance = new ModelsOrganizationUserSimple();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsOrganizationUserSimple
        /// </summary>
        [Test]
        public void ModelsOrganizationUserSimpleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsOrganizationUserSimple
            //Assert.IsInstanceOfType<ModelsOrganizationUserSimple> (instance, "variable 'instance' is a ModelsOrganizationUserSimple");
        }


        /// <summary>
        /// Test the property 'AvatarUrl'
        /// </summary>
        [Test]
        public void AvatarUrlTest()
        {
            // TODO unit test for the property 'AvatarUrl'
        }
        /// <summary>
        /// Test the property 'Joined'
        /// </summary>
        [Test]
        public void JoinedTest()
        {
            // TODO unit test for the property 'Joined'
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
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

    }

}
