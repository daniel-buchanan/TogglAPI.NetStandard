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
    ///  Class for testing ModelsTimelineEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsTimelineEventTests
    {
        // TODO uncomment below to declare an instance variable for ModelsTimelineEvent
        //private ModelsTimelineEvent instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsTimelineEvent
            //instance = new ModelsTimelineEvent();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsTimelineEvent
        /// </summary>
        [Test]
        public void ModelsTimelineEventInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsTimelineEvent
            //Assert.IsInstanceOfType<ModelsTimelineEvent> (instance, "variable 'instance' is a ModelsTimelineEvent");
        }


        /// <summary>
        /// Test the property 'DesktopId'
        /// </summary>
        [Test]
        public void DesktopIdTest()
        {
            // TODO unit test for the property 'DesktopId'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
        }
        /// <summary>
        /// Test the property 'Filename'
        /// </summary>
        [Test]
        public void FilenameTest()
        {
            // TODO unit test for the property 'Filename'
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
        /// Test the property 'Idle'
        /// </summary>
        [Test]
        public void IdleTest()
        {
            // TODO unit test for the property 'Idle'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

    }

}