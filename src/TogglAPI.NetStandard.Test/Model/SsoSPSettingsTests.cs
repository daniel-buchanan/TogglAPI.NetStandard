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
    ///  Class for testing SsoSPSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SsoSPSettingsTests
    {
        // TODO uncomment below to declare an instance variable for SsoSPSettings
        //private SsoSPSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SsoSPSettings
            //instance = new SsoSPSettings();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SsoSPSettings
        /// </summary>
        [Test]
        public void SsoSPSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SsoSPSettings
            //Assert.IsInstanceOfType<SsoSPSettings> (instance, "variable 'instance' is a SsoSPSettings");
        }


        /// <summary>
        /// Test the property 'AcsUrl'
        /// </summary>
        [Test]
        public void AcsUrlTest()
        {
            // TODO unit test for the property 'AcsUrl'
        }
        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Test]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }

    }

}