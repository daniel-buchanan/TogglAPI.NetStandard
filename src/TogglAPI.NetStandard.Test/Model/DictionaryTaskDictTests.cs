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
    ///  Class for testing DictionaryTaskDict
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DictionaryTaskDictTests
    {
        // TODO uncomment below to declare an instance variable for DictionaryTaskDict
        //private DictionaryTaskDict instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DictionaryTaskDict
            //instance = new DictionaryTaskDict();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DictionaryTaskDict
        /// </summary>
        [Test]
        public void DictionaryTaskDictInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DictionaryTaskDict
            //Assert.IsInstanceOfType<DictionaryTaskDict> (instance, "variable 'instance' is a DictionaryTaskDict");
        }


        /// <summary>
        /// Test the property 'EstimatedSeconds'
        /// </summary>
        [Test]
        public void EstimatedSecondsTest()
        {
            // TODO unit test for the property 'EstimatedSeconds'
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
        /// Test the property 'ProjectId'
        /// </summary>
        [Test]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'TrackedSeconds'
        /// </summary>
        [Test]
        public void TrackedSecondsTest()
        {
            // TODO unit test for the property 'TrackedSeconds'
        }

    }

}
