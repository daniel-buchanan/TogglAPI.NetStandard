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
    ///  Class for testing HandlercalendarPostDetailsSuggestionRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HandlercalendarPostDetailsSuggestionRequestTests
    {
        // TODO uncomment below to declare an instance variable for HandlercalendarPostDetailsSuggestionRequest
        //private HandlercalendarPostDetailsSuggestionRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of HandlercalendarPostDetailsSuggestionRequest
            //instance = new HandlercalendarPostDetailsSuggestionRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HandlercalendarPostDetailsSuggestionRequest
        /// </summary>
        [Test]
        public void HandlercalendarPostDetailsSuggestionRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" HandlercalendarPostDetailsSuggestionRequest
            //Assert.IsInstanceOfType<HandlercalendarPostDetailsSuggestionRequest> (instance, "variable 'instance' is a HandlercalendarPostDetailsSuggestionRequest");
        }


        /// <summary>
        /// Test the property 'EventIds'
        /// </summary>
        [Test]
        public void EventIdsTest()
        {
            // TODO unit test for the property 'EventIds'
        }

    }

}
