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
    ///  Class for testing ModelsCardDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsCardDetailsTests
    {
        // TODO uncomment below to declare an instance variable for ModelsCardDetails
        //private ModelsCardDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsCardDetails
            //instance = new ModelsCardDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsCardDetails
        /// </summary>
        [Test]
        public void ModelsCardDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsCardDetails
            //Assert.IsInstanceOfType<ModelsCardDetails> (instance, "variable 'instance' is a ModelsCardDetails");
        }


        /// <summary>
        /// Test the property 'AddedAt'
        /// </summary>
        [Test]
        public void AddedAtTest()
        {
            // TODO unit test for the property 'AddedAt'
        }
        /// <summary>
        /// Test the property 'CardNumber'
        /// </summary>
        [Test]
        public void CardNumberTest()
        {
            // TODO unit test for the property 'CardNumber'
        }
        /// <summary>
        /// Test the property 'CardType'
        /// </summary>
        [Test]
        public void CardTypeTest()
        {
            // TODO unit test for the property 'CardType'
        }
        /// <summary>
        /// Test the property 'CreatorId'
        /// </summary>
        [Test]
        public void CreatorIdTest()
        {
            // TODO unit test for the property 'CreatorId'
        }
        /// <summary>
        /// Test the property 'CreatorName'
        /// </summary>
        [Test]
        public void CreatorNameTest()
        {
            // TODO unit test for the property 'CreatorName'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Test]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }
        /// <summary>
        /// Test the property 'HolderName'
        /// </summary>
        [Test]
        public void HolderNameTest()
        {
            // TODO unit test for the property 'HolderName'
        }

    }

}
