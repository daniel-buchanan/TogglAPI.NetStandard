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
    ///  Class for testing MePayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MePayloadTests
    {
        // TODO uncomment below to declare an instance variable for MePayload
        //private MePayload instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MePayload
            //instance = new MePayload();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MePayload
        /// </summary>
        [Test]
        public void MePayloadInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MePayload
            //Assert.IsInstanceOfType<MePayload> (instance, "variable 'instance' is a MePayload");
        }


        /// <summary>
        /// Test the property 'BeginningOfWeek'
        /// </summary>
        [Test]
        public void BeginningOfWeekTest()
        {
            // TODO unit test for the property 'BeginningOfWeek'
        }
        /// <summary>
        /// Test the property 'CountryId'
        /// </summary>
        [Test]
        public void CountryIdTest()
        {
            // TODO unit test for the property 'CountryId'
        }
        /// <summary>
        /// Test the property 'CurrentPassword'
        /// </summary>
        [Test]
        public void CurrentPasswordTest()
        {
            // TODO unit test for the property 'CurrentPassword'
        }
        /// <summary>
        /// Test the property 'DefaultWorkspaceId'
        /// </summary>
        [Test]
        public void DefaultWorkspaceIdTest()
        {
            // TODO unit test for the property 'DefaultWorkspaceId'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'Fullname'
        /// </summary>
        [Test]
        public void FullnameTest()
        {
            // TODO unit test for the property 'Fullname'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'Timezone'
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO unit test for the property 'Timezone'
        }

    }

}