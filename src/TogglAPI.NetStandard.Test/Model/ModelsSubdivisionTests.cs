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
    ///  Class for testing ModelsSubdivision
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsSubdivisionTests
    {
        // TODO uncomment below to declare an instance variable for ModelsSubdivision
        //private ModelsSubdivision instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsSubdivision
            //instance = new ModelsSubdivision();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsSubdivision
        /// </summary>
        [Test]
        public void ModelsSubdivisionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsSubdivision
            //Assert.IsInstanceOfType<ModelsSubdivision> (instance, "variable 'instance' is a ModelsSubdivision");
        }


        /// <summary>
        /// Test the property 'CompanyId'
        /// </summary>
        [Test]
        public void CompanyIdTest()
        {
            // TODO unit test for the property 'CompanyId'
        }
        /// <summary>
        /// Test the property 'CountryId'
        /// </summary>
        [Test]
        public void CountryIdTest()
        {
            // TODO unit test for the property 'CountryId'
        }
        /// <summary>
        /// Test the property 'CountrySubdivisionId'
        /// </summary>
        [Test]
        public void CountrySubdivisionIdTest()
        {
            // TODO unit test for the property 'CountrySubdivisionId'
        }
        /// <summary>
        /// Test the property 'IsoCode'
        /// </summary>
        [Test]
        public void IsoCodeTest()
        {
            // TODO unit test for the property 'IsoCode'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

    }

}
