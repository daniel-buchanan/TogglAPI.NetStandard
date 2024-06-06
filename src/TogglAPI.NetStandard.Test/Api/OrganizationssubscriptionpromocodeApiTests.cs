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

namespace TogglAPI.NetStandard.Test
{
    /// <summary>
    ///  Class for testing OrganizationssubscriptionpromocodeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganizationssubscriptionpromocodeApiTests
    {
        private OrganizationssubscriptionpromocodeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationssubscriptionpromocodeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationssubscriptionpromocodeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganizationssubscriptionpromocodeApi
            //Assert.IsInstanceOfType(typeof(OrganizationssubscriptionpromocodeApi), instance, "instance is a OrganizationssubscriptionpromocodeApi");
        }

        
        /// <summary>
        /// Test DeletePromotionCode
        /// </summary>
        [Test]
        public void DeletePromotionCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //instance.DeletePromotionCode(organizationId);
            
        }
        
        /// <summary>
        /// Test PostPromotionCode
        /// </summary>
        [Test]
        public void PostPromotionCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //instance.PostPromotionCode(organizationId);
            
        }
        
    }

}