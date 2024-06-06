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
    ///  Class for testing SavedPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SavedPayloadTests
    {
        // TODO uncomment below to declare an instance variable for SavedPayload
        //private SavedPayload instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SavedPayload
            //instance = new SavedPayload();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SavedPayload
        /// </summary>
        [Test]
        public void SavedPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SavedPayload
            //Assert.IsInstanceOfType<SavedPayload> (instance, "variable 'instance' is a SavedPayload");
        }


        /// <summary>
        /// Test the property 'FixedDaterange'
        /// </summary>
        [Test]
        public void FixedDaterangeTest()
        {
            // TODO unit test for the property 'FixedDaterange'
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Params'
        /// </summary>
        [Test]
        public void ParamsTest()
        {
            // TODO unit test for the property 'Params'
        }
        /// <summary>
        /// Test the property 'Public'
        /// </summary>
        [Test]
        public void PublicTest()
        {
            // TODO unit test for the property 'Public'
        }
        /// <summary>
        /// Test the property 'RegenerateToken'
        /// </summary>
        [Test]
        public void RegenerateTokenTest()
        {
            // TODO unit test for the property 'RegenerateToken'
        }

    }

}