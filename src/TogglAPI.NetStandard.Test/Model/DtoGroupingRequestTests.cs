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
    ///  Class for testing DtoGroupingRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DtoGroupingRequestTests
    {
        // TODO uncomment below to declare an instance variable for DtoGroupingRequest
        //private DtoGroupingRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DtoGroupingRequest
            //instance = new DtoGroupingRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DtoGroupingRequest
        /// </summary>
        [Test]
        public void DtoGroupingRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DtoGroupingRequest
            //Assert.IsInstanceOfType<DtoGroupingRequest> (instance, "variable 'instance' is a DtoGroupingRequest");
        }


        /// <summary>
        /// Test the property 'Alias'
        /// </summary>
        [Test]
        public void AliasTest()
        {
            // TODO unit test for the property 'Alias'
        }
        /// <summary>
        /// Test the property 'Property'
        /// </summary>
        [Test]
        public void PropertyTest()
        {
            // TODO unit test for the property 'Property'
        }
        /// <summary>
        /// Test the property 'ShowEmpty'
        /// </summary>
        [Test]
        public void ShowEmptyTest()
        {
            // TODO unit test for the property 'ShowEmpty'
        }

    }

}
