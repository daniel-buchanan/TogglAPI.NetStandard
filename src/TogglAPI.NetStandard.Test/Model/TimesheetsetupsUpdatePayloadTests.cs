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
    ///  Class for testing TimesheetsetupsUpdatePayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TimesheetsetupsUpdatePayloadTests
    {
        // TODO uncomment below to declare an instance variable for TimesheetsetupsUpdatePayload
        //private TimesheetsetupsUpdatePayload instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TimesheetsetupsUpdatePayload
            //instance = new TimesheetsetupsUpdatePayload();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimesheetsetupsUpdatePayload
        /// </summary>
        [Test]
        public void TimesheetsetupsUpdatePayloadInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TimesheetsetupsUpdatePayload
            //Assert.IsInstanceOfType<TimesheetsetupsUpdatePayload> (instance, "variable 'instance' is a TimesheetsetupsUpdatePayload");
        }


        /// <summary>
        /// Test the property 'ApproverId'
        /// </summary>
        [Test]
        public void ApproverIdTest()
        {
            // TODO unit test for the property 'ApproverId'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'ReminderDay'
        /// </summary>
        [Test]
        public void ReminderDayTest()
        {
            // TODO unit test for the property 'ReminderDay'
        }
        /// <summary>
        /// Test the property 'ReminderTime'
        /// </summary>
        [Test]
        public void ReminderTimeTest()
        {
            // TODO unit test for the property 'ReminderTime'
        }

    }

}