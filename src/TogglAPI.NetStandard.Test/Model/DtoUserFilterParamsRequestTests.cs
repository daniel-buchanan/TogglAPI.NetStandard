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
    ///  Class for testing DtoUserFilterParamsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DtoUserFilterParamsRequestTests
    {
        // TODO uncomment below to declare an instance variable for DtoUserFilterParamsRequest
        //private DtoUserFilterParamsRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DtoUserFilterParamsRequest
            //instance = new DtoUserFilterParamsRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DtoUserFilterParamsRequest
        /// </summary>
        [Test]
        public void DtoUserFilterParamsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DtoUserFilterParamsRequest
            //Assert.IsInstanceOfType<DtoUserFilterParamsRequest> (instance, "variable 'instance' is a DtoUserFilterParamsRequest");
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
        /// Test the property 'Admin'
        /// </summary>
        [Test]
        public void AdminTest()
        {
            // TODO unit test for the property 'Admin'
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
        /// Test the property 'Start'
        /// </summary>
        [Test]
        public void StartTest()
        {
            // TODO unit test for the property 'Start'
        }

    }

}
