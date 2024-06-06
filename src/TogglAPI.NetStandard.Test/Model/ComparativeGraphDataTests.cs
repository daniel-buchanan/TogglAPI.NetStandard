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
    ///  Class for testing ComparativeGraphData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ComparativeGraphDataTests
    {
        // TODO uncomment below to declare an instance variable for ComparativeGraphData
        //private ComparativeGraphData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ComparativeGraphData
            //instance = new ComparativeGraphData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ComparativeGraphData
        /// </summary>
        [Test]
        public void ComparativeGraphDataInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ComparativeGraphData
            //Assert.IsInstanceOfType<ComparativeGraphData> (instance, "variable 'instance' is a ComparativeGraphData");
        }


        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Test]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'TotalSeconds'
        /// </summary>
        [Test]
        public void TotalSecondsTest()
        {
            // TODO unit test for the property 'TotalSeconds'
        }

    }

}