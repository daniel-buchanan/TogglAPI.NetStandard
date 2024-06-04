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
    ///  Class for testing SubscriptionCalculatedData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriptionCalculatedDataTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionCalculatedData
        //private SubscriptionCalculatedData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionCalculatedData
            //instance = new SubscriptionCalculatedData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionCalculatedData
        /// </summary>
        [Test]
        public void SubscriptionCalculatedDataInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SubscriptionCalculatedData
            //Assert.IsInstanceOfType<SubscriptionCalculatedData> (instance, "variable 'instance' is a SubscriptionCalculatedData");
        }


        /// <summary>
        /// Test the property 'Calculation'
        /// </summary>
        [Test]
        public void CalculationTest()
        {
            // TODO unit test for the property 'Calculation'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
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
        /// Test the property 'TaxPercentage'
        /// </summary>
        [Test]
        public void TaxPercentageTest()
        {
            // TODO unit test for the property 'TaxPercentage'
        }
        /// <summary>
        /// Test the property 'TotalAmount'
        /// </summary>
        [Test]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
        }

    }

}
