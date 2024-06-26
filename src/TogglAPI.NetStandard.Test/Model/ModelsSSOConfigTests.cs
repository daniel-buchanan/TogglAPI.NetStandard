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
    ///  Class for testing ModelsSSOConfig
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsSSOConfigTests
    {
        // TODO uncomment below to declare an instance variable for ModelsSSOConfig
        //private ModelsSSOConfig instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsSSOConfig
            //instance = new ModelsSSOConfig();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsSSOConfig
        /// </summary>
        [Test]
        public void ModelsSSOConfigInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsSSOConfig
            //Assert.IsInstanceOfType<ModelsSSOConfig> (instance, "variable 'instance' is a ModelsSSOConfig");
        }


        /// <summary>
        /// Test the property 'Certificate'
        /// </summary>
        [Test]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }
        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Test]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Test]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }
        /// <summary>
        /// Test the property 'MetadataUrl'
        /// </summary>
        [Test]
        public void MetadataUrlTest()
        {
            // TODO unit test for the property 'MetadataUrl'
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
        /// Test the property 'SharedSsoProfileId'
        /// </summary>
        [Test]
        public void SharedSsoProfileIdTest()
        {
            // TODO unit test for the property 'SharedSsoProfileId'
        }
        /// <summary>
        /// Test the property 'SsoUrl'
        /// </summary>
        [Test]
        public void SsoUrlTest()
        {
            // TODO unit test for the property 'SsoUrl'
        }

    }

}
