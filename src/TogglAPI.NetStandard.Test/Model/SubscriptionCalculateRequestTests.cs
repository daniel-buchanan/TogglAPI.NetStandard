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
    ///  Class for testing SubscriptionCalculateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriptionCalculateRequestTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionCalculateRequest
        //private SubscriptionCalculateRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionCalculateRequest
            //instance = new SubscriptionCalculateRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionCalculateRequest
        /// </summary>
        [Test]
        public void SubscriptionCalculateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SubscriptionCalculateRequest
            //Assert.IsInstanceOfType<SubscriptionCalculateRequest> (instance, "variable 'instance' is a SubscriptionCalculateRequest");
        }


        /// <summary>
        /// Test the property 'Period'
        /// </summary>
        [Test]
        public void PeriodTest()
        {
            // TODO unit test for the property 'Period'
        }
        /// <summary>
        /// Test the property 'PricingPlanId'
        /// </summary>
        [Test]
        public void PricingPlanIdTest()
        {
            // TODO unit test for the property 'PricingPlanId'
        }
        /// <summary>
        /// Test the property 'UserCount'
        /// </summary>
        [Test]
        public void UserCountTest()
        {
            // TODO unit test for the property 'UserCount'
        }

    }

}
