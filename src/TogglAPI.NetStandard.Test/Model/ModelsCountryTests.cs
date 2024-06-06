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
    ///  Class for testing ModelsCountry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsCountryTests
    {
        // TODO uncomment below to declare an instance variable for ModelsCountry
        //private ModelsCountry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsCountry
            //instance = new ModelsCountry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsCountry
        /// </summary>
        [Test]
        public void ModelsCountryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsCountry
            //Assert.IsInstanceOfType<ModelsCountry> (instance, "variable 'instance' is a ModelsCountry");
        }


        /// <summary>
        /// Test the property 'CountryCode'
        /// </summary>
        [Test]
        public void CountryCodeTest()
        {
            // TODO unit test for the property 'CountryCode'
        }
        /// <summary>
        /// Test the property 'DefaultCurrencyId'
        /// </summary>
        [Test]
        public void DefaultCurrencyIdTest()
        {
            // TODO unit test for the property 'DefaultCurrencyId'
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'VatApplicable'
        /// </summary>
        [Test]
        public void VatApplicableTest()
        {
            // TODO unit test for the property 'VatApplicable'
        }
        /// <summary>
        /// Test the property 'VatPercentage'
        /// </summary>
        [Test]
        public void VatPercentageTest()
        {
            // TODO unit test for the property 'VatPercentage'
        }
        /// <summary>
        /// Test the property 'VatRegex'
        /// </summary>
        [Test]
        public void VatRegexTest()
        {
            // TODO unit test for the property 'VatRegex'
        }

    }

}