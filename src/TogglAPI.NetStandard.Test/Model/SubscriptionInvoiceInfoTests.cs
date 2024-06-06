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
    ///  Class for testing SubscriptionInvoiceInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriptionInvoiceInfoTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionInvoiceInfo
        //private SubscriptionInvoiceInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionInvoiceInfo
            //instance = new SubscriptionInvoiceInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionInvoiceInfo
        /// </summary>
        [Test]
        public void SubscriptionInvoiceInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SubscriptionInvoiceInfo
            //Assert.IsInstanceOfType<SubscriptionInvoiceInfo> (instance, "variable 'instance' is a SubscriptionInvoiceInfo");
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'CurrencyId'
        /// </summary>
        [Test]
        public void CurrencyIdTest()
        {
            // TODO unit test for the property 'CurrencyId'
        }
        /// <summary>
        /// Test the property 'Due'
        /// </summary>
        [Test]
        public void DueTest()
        {
            // TODO unit test for the property 'Due'
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
        /// Test the property 'PaidAt'
        /// </summary>
        [Test]
        public void PaidAtTest()
        {
            // TODO unit test for the property 'PaidAt'
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