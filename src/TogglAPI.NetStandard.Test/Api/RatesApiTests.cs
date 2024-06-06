/* 
 * Toggl API
 *
 * Public Toggl API. Note: We use BasicAuth in a specific way. By the standard you provide `Authentication` header with `base64(user_name:password)` as a `credential`. In our case it will be `base64(user_name:api_token)`.
 *
 * OpenAPI spec version: 9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Model;

namespace TogglAPI.NetStandard.Test
{
    /// <summary>
    ///  Class for testing RatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RatesApiTests
    {
        private RatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RatesApi
            //Assert.IsInstanceOfType(typeof(RatesApi), instance, "instance is a RatesApi");
        }

        
        /// <summary>
        /// Test CreateRate
        /// </summary>
        [Test]
        public void CreateRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //DtoCreationRequest ratePost = null;
            //var response = instance.CreateRate(workspaceId, ratePost);
            //Assert.IsInstanceOf<DtoGetResponse> (response, "response is DtoGetResponse");
        }
        
        /// <summary>
        /// Test DeleteRate
        /// </summary>
        [Test]
        public void DeleteRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? rateId = null;
            //instance.DeleteRate(workspaceId, rateId);
            
        }
        
        /// <summary>
        /// Test GetRatesByLevel
        /// </summary>
        [Test]
        public void GetRatesByLevelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //string level = null;
            //int? levelId = null;
            //var response = instance.GetRatesByLevel(workspaceId, level, levelId);
            //Assert.IsInstanceOf<List<DtoGetResponse>> (response, "response is List<DtoGetResponse>");
        }
        
    }

}