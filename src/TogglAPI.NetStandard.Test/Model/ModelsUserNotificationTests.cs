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
    ///  Class for testing ModelsUserNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsUserNotificationTests
    {
        // TODO uncomment below to declare an instance variable for ModelsUserNotification
        //private ModelsUserNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsUserNotification
            //instance = new ModelsUserNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsUserNotification
        /// </summary>
        [Test]
        public void ModelsUserNotificationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsUserNotification
            //Assert.IsInstanceOfType<ModelsUserNotification> (instance, "variable 'instance' is a ModelsUserNotification");
        }


        /// <summary>
        /// Test the property 'Actions'
        /// </summary>
        [Test]
        public void ActionsTest()
        {
            // TODO unit test for the property 'Actions'
        }
        /// <summary>
        /// Test the property 'Class'
        /// </summary>
        [Test]
        public void ClassTest()
        {
            // TODO unit test for the property 'Class'
        }
        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Test]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
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
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'NotificationType'
        /// </summary>
        [Test]
        public void NotificationTypeTest()
        {
            // TODO unit test for the property 'NotificationType'
        }
        /// <summary>
        /// Test the property 'OrganizationId'
        /// </summary>
        [Test]
        public void OrganizationIdTest()
        {
            // TODO unit test for the property 'OrganizationId'
        }
        /// <summary>
        /// Test the property 'ReadAt'
        /// </summary>
        [Test]
        public void ReadAtTest()
        {
            // TODO unit test for the property 'ReadAt'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'WorkspaceId'
        /// </summary>
        [Test]
        public void WorkspaceIdTest()
        {
            // TODO unit test for the property 'WorkspaceId'
        }

    }

}
