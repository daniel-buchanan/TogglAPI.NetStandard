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
    ///  Class for testing ModelsPaymentRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsPaymentRecordTests
    {
        // TODO uncomment below to declare an instance variable for ModelsPaymentRecord
        //private ModelsPaymentRecord instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsPaymentRecord
            //instance = new ModelsPaymentRecord();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsPaymentRecord
        /// </summary>
        [Test]
        public void ModelsPaymentRecordInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsPaymentRecord
            //Assert.IsInstanceOfType<ModelsPaymentRecord> (instance, "variable 'instance' is a ModelsPaymentRecord");
        }


        /// <summary>
        /// Test the property 'CreationDate'
        /// </summary>
        [Test]
        public void CreationDateTest()
        {
            // TODO unit test for the property 'CreationDate'
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
        /// Test the property 'CurrencyId'
        /// </summary>
        [Test]
        public void CurrencyIdTest()
        {
            // TODO unit test for the property 'CurrencyId'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'InitialId'
        /// </summary>
        [Test]
        public void InitialIdTest()
        {
            // TODO unit test for the property 'InitialId'
        }
        /// <summary>
        /// Test the property 'RecordType'
        /// </summary>
        [Test]
        public void RecordTypeTest()
        {
            // TODO unit test for the property 'RecordType'
        }
        /// <summary>
        /// Test the property 'TotalAmount'
        /// </summary>
        [Test]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
        }
        /// <summary>
        /// Test the property 'Uid'
        /// </summary>
        [Test]
        public void UidTest()
        {
            // TODO unit test for the property 'Uid'
        }

    }

}