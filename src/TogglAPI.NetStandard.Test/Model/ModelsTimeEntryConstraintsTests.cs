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
    ///  Class for testing ModelsTimeEntryConstraints
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsTimeEntryConstraintsTests
    {
        // TODO uncomment below to declare an instance variable for ModelsTimeEntryConstraints
        //private ModelsTimeEntryConstraints instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsTimeEntryConstraints
            //instance = new ModelsTimeEntryConstraints();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsTimeEntryConstraints
        /// </summary>
        [Test]
        public void ModelsTimeEntryConstraintsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsTimeEntryConstraints
            //Assert.IsInstanceOfType<ModelsTimeEntryConstraints> (instance, "variable 'instance' is a ModelsTimeEntryConstraints");
        }


        /// <summary>
        /// Test the property 'DescriptionPresent'
        /// </summary>
        [Test]
        public void DescriptionPresentTest()
        {
            // TODO unit test for the property 'DescriptionPresent'
        }
        /// <summary>
        /// Test the property 'ProjectPresent'
        /// </summary>
        [Test]
        public void ProjectPresentTest()
        {
            // TODO unit test for the property 'ProjectPresent'
        }
        /// <summary>
        /// Test the property 'TagPresent'
        /// </summary>
        [Test]
        public void TagPresentTest()
        {
            // TODO unit test for the property 'TagPresent'
        }
        /// <summary>
        /// Test the property 'TaskPresent'
        /// </summary>
        [Test]
        public void TaskPresentTest()
        {
            // TODO unit test for the property 'TaskPresent'
        }
        /// <summary>
        /// Test the property 'TimeEntryConstraintsEnabled'
        /// </summary>
        [Test]
        public void TimeEntryConstraintsEnabledTest()
        {
            // TODO unit test for the property 'TimeEntryConstraintsEnabled'
        }

    }

}
