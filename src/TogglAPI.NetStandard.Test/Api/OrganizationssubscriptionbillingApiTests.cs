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
    ///  Class for testing OrganizationssubscriptionbillingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganizationssubscriptionbillingApiTests
    {
        private OrganizationssubscriptionbillingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationssubscriptionbillingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationssubscriptionbillingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganizationssubscriptionbillingApi
            //Assert.IsInstanceOfType(typeof(OrganizationssubscriptionbillingApi), instance, "instance is a OrganizationssubscriptionbillingApi");
        }

        
        /// <summary>
        /// Test CreateBillingPortalSession
        /// </summary>
        [Test]
        public void CreateBillingPortalSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //BillingportalPayload _params = null;
            //instance.CreateBillingPortalSession(organizationId, _params);
            
        }
        
    }

}
