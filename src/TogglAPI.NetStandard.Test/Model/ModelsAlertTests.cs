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
    ///  Class for testing ModelsAlert
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsAlertTests
    {
        // TODO uncomment below to declare an instance variable for ModelsAlert
        //private ModelsAlert instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsAlert
            //instance = new ModelsAlert();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsAlert
        /// </summary>
        [Test]
        public void ModelsAlertInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsAlert
            //Assert.IsInstanceOfType<ModelsAlert> (instance, "variable 'instance' is a ModelsAlert");
        }


        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Test]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
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
        /// Test the property 'ObjectType'
        /// </summary>
        [Test]
        public void ObjectTypeTest()
        {
            // TODO unit test for the property 'ObjectType'
        }
        /// <summary>
        /// Test the property 'ProjectId'
        /// </summary>
        [Test]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'ReceiverGroups'
        /// </summary>
        [Test]
        public void ReceiverGroupsTest()
        {
            // TODO unit test for the property 'ReceiverGroups'
        }
        /// <summary>
        /// Test the property 'ReceiverRoles'
        /// </summary>
        [Test]
        public void ReceiverRolesTest()
        {
            // TODO unit test for the property 'ReceiverRoles'
        }
        /// <summary>
        /// Test the property 'ReceiverUsers'
        /// </summary>
        [Test]
        public void ReceiverUsersTest()
        {
            // TODO unit test for the property 'ReceiverUsers'
        }
        /// <summary>
        /// Test the property 'Receivers'
        /// </summary>
        [Test]
        public void ReceiversTest()
        {
            // TODO unit test for the property 'Receivers'
        }
        /// <summary>
        /// Test the property 'SourceKind'
        /// </summary>
        [Test]
        public void SourceKindTest()
        {
            // TODO unit test for the property 'SourceKind'
        }
        /// <summary>
        /// Test the property 'Threshold'
        /// </summary>
        [Test]
        public void ThresholdTest()
        {
            // TODO unit test for the property 'Threshold'
        }
        /// <summary>
        /// Test the property 'ThresholdType'
        /// </summary>
        [Test]
        public void ThresholdTypeTest()
        {
            // TODO unit test for the property 'ThresholdType'
        }
        /// <summary>
        /// Test the property 'Thresholds'
        /// </summary>
        [Test]
        public void ThresholdsTest()
        {
            // TODO unit test for the property 'Thresholds'
        }
        /// <summary>
        /// Test the property 'Wid'
        /// </summary>
        [Test]
        public void WidTest()
        {
            // TODO unit test for the property 'Wid'
        }

    }

}