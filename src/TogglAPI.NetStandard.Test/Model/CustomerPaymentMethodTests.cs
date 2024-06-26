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
    ///  Class for testing CustomerPaymentMethod
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CustomerPaymentMethodTests
    {
        // TODO uncomment below to declare an instance variable for CustomerPaymentMethod
        //private CustomerPaymentMethod instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CustomerPaymentMethod
            //instance = new CustomerPaymentMethod();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerPaymentMethod
        /// </summary>
        [Test]
        public void CustomerPaymentMethodInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CustomerPaymentMethod
            //Assert.IsInstanceOfType<CustomerPaymentMethod> (instance, "variable 'instance' is a CustomerPaymentMethod");
        }


        /// <summary>
        /// Test the property 'Card'
        /// </summary>
        [Test]
        public void CardTest()
        {
            // TODO unit test for the property 'Card'
        }
        /// <summary>
        /// Test the property 'SepaDebit'
        /// </summary>
        [Test]
        public void SepaDebitTest()
        {
            // TODO unit test for the property 'SepaDebit'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'UsBankAccount'
        /// </summary>
        [Test]
        public void UsBankAccountTest()
        {
            // TODO unit test for the property 'UsBankAccount'
        }

    }

}
