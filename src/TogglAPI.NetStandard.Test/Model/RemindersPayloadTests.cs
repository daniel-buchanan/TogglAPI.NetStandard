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
    ///  Class for testing RemindersPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RemindersPayloadTests
    {
        // TODO uncomment below to declare an instance variable for RemindersPayload
        //private RemindersPayload instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RemindersPayload
            //instance = new RemindersPayload();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RemindersPayload
        /// </summary>
        [Test]
        public void RemindersPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RemindersPayload
            //Assert.IsInstanceOfType<RemindersPayload> (instance, "variable 'instance' is a RemindersPayload");
        }


        /// <summary>
        /// Test the property 'Frequency'
        /// </summary>
        [Test]
        public void FrequencyTest()
        {
            // TODO unit test for the property 'Frequency'
        }
        /// <summary>
        /// Test the property 'GroupIds'
        /// </summary>
        [Test]
        public void GroupIdsTest()
        {
            // TODO unit test for the property 'GroupIds'
        }
        /// <summary>
        /// Test the property 'Threshold'
        /// </summary>
        [Test]
        public void ThresholdTest()
        {
            // TODO unit test for the property 'Threshold'
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
