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
    ///  Class for testing BillingFancyPricingPlan
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BillingFancyPricingPlanTests
    {
        // TODO uncomment below to declare an instance variable for BillingFancyPricingPlan
        //private BillingFancyPricingPlan instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BillingFancyPricingPlan
            //instance = new BillingFancyPricingPlan();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingFancyPricingPlan
        /// </summary>
        [Test]
        public void BillingFancyPricingPlanInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BillingFancyPricingPlan
            //Assert.IsInstanceOfType<BillingFancyPricingPlan> (instance, "variable 'instance' is a BillingFancyPricingPlan");
        }


        /// <summary>
        /// Test the property 'ActualPriceInUsdCents'
        /// </summary>
        [Test]
        public void ActualPriceInUsdCentsTest()
        {
            // TODO unit test for the property 'ActualPriceInUsdCents'
        }
        /// <summary>
        /// Test the property 'Campaign'
        /// </summary>
        [Test]
        public void CampaignTest()
        {
            // TODO unit test for the property 'Campaign'
        }
        /// <summary>
        /// Test the property 'ListPriceInUsdCents'
        /// </summary>
        [Test]
        public void ListPriceInUsdCentsTest()
        {
            // TODO unit test for the property 'ListPriceInUsdCents'
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
        /// Test the property 'Period'
        /// </summary>
        [Test]
        public void PeriodTest()
        {
            // TODO unit test for the property 'Period'
        }
        /// <summary>
        /// Test the property 'PricePointHandle'
        /// </summary>
        [Test]
        public void PricePointHandleTest()
        {
            // TODO unit test for the property 'PricePointHandle'
        }
        /// <summary>
        /// Test the property 'PricesMonth'
        /// </summary>
        [Test]
        public void PricesMonthTest()
        {
            // TODO unit test for the property 'PricesMonth'
        }
        /// <summary>
        /// Test the property 'PricesPeriod'
        /// </summary>
        [Test]
        public void PricesPeriodTest()
        {
            // TODO unit test for the property 'PricesPeriod'
        }
        /// <summary>
        /// Test the property 'PricingPlanId'
        /// </summary>
        [Test]
        public void PricingPlanIdTest()
        {
            // TODO unit test for the property 'PricingPlanId'
        }

    }

}
