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
    ///  Class for testing GroupsPatchOutput
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GroupsPatchOutputTests
    {
        // TODO uncomment below to declare an instance variable for GroupsPatchOutput
        //private GroupsPatchOutput instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GroupsPatchOutput
            //instance = new GroupsPatchOutput();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsPatchOutput
        /// </summary>
        [Test]
        public void GroupsPatchOutputInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GroupsPatchOutput
            //Assert.IsInstanceOfType<GroupsPatchOutput> (instance, "variable 'instance' is a GroupsPatchOutput");
        }


        /// <summary>
        /// Test the property 'Failure'
        /// </summary>
        [Test]
        public void FailureTest()
        {
            // TODO unit test for the property 'Failure'
        }
        /// <summary>
        /// Test the property 'Success'
        /// </summary>
        [Test]
        public void SuccessTest()
        {
            // TODO unit test for the property 'Success'
        }

    }

}
