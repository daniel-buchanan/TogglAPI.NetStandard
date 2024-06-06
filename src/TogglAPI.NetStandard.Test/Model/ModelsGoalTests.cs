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
    ///  Class for testing ModelsGoal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ModelsGoalTests
    {
        // TODO uncomment below to declare an instance variable for ModelsGoal
        //private ModelsGoal instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ModelsGoal
            //instance = new ModelsGoal();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ModelsGoal
        /// </summary>
        [Test]
        public void ModelsGoalInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ModelsGoal
            //Assert.IsInstanceOfType<ModelsGoal> (instance, "variable 'instance' is a ModelsGoal");
        }


        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'Billable'
        /// </summary>
        [Test]
        public void BillableTest()
        {
            // TODO unit test for the property 'Billable'
        }
        /// <summary>
        /// Test the property 'Comparison'
        /// </summary>
        [Test]
        public void ComparisonTest()
        {
            // TODO unit test for the property 'Comparison'
        }
        /// <summary>
        /// Test the property 'CreatorUserID'
        /// </summary>
        [Test]
        public void CreatorUserIDTest()
        {
            // TODO unit test for the property 'CreatorUserID'
        }
        /// <summary>
        /// Test the property 'CreatorUserName'
        /// </summary>
        [Test]
        public void CreatorUserNameTest()
        {
            // TODO unit test for the property 'CreatorUserName'
        }
        /// <summary>
        /// Test the property 'CurrentRecurrenceEndDate'
        /// </summary>
        [Test]
        public void CurrentRecurrenceEndDateTest()
        {
            // TODO unit test for the property 'CurrentRecurrenceEndDate'
        }
        /// <summary>
        /// Test the property 'CurrentRecurrenceStartDate'
        /// </summary>
        [Test]
        public void CurrentRecurrenceStartDateTest()
        {
            // TODO unit test for the property 'CurrentRecurrenceStartDate'
        }
        /// <summary>
        /// Test the property 'CurrentRecurrenceTrackedSeconds'
        /// </summary>
        [Test]
        public void CurrentRecurrenceTrackedSecondsTest()
        {
            // TODO unit test for the property 'CurrentRecurrenceTrackedSeconds'
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
        /// Test the property 'Icon'
        /// </summary>
        [Test]
        public void IconTest()
        {
            // TODO unit test for the property 'Icon'
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
        /// Test the property 'LastCompletedRecurrenceEndDate'
        /// </summary>
        [Test]
        public void LastCompletedRecurrenceEndDateTest()
        {
            // TODO unit test for the property 'LastCompletedRecurrenceEndDate'
        }
        /// <summary>
        /// Test the property 'LastNotifiedAt'
        /// </summary>
        [Test]
        public void LastNotifiedAtTest()
        {
            // TODO unit test for the property 'LastNotifiedAt'
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
        /// Test the property 'ProjectIDs'
        /// </summary>
        [Test]
        public void ProjectIDsTest()
        {
            // TODO unit test for the property 'ProjectIDs'
        }
        /// <summary>
        /// Test the property 'Recurrence'
        /// </summary>
        [Test]
        public void RecurrenceTest()
        {
            // TODO unit test for the property 'Recurrence'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Streak'
        /// </summary>
        [Test]
        public void StreakTest()
        {
            // TODO unit test for the property 'Streak'
        }
        /// <summary>
        /// Test the property 'TagIDs'
        /// </summary>
        [Test]
        public void TagIDsTest()
        {
            // TODO unit test for the property 'TagIDs'
        }
        /// <summary>
        /// Test the property 'TargetSeconds'
        /// </summary>
        [Test]
        public void TargetSecondsTest()
        {
            // TODO unit test for the property 'TargetSeconds'
        }
        /// <summary>
        /// Test the property 'TaskIDs'
        /// </summary>
        [Test]
        public void TaskIDsTest()
        {
            // TODO unit test for the property 'TaskIDs'
        }
        /// <summary>
        /// Test the property 'TeamGoal'
        /// </summary>
        [Test]
        public void TeamGoalTest()
        {
            // TODO unit test for the property 'TeamGoal'
        }
        /// <summary>
        /// Test the property 'UserID'
        /// </summary>
        [Test]
        public void UserIDTest()
        {
            // TODO unit test for the property 'UserID'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property 'WorkspaceID'
        /// </summary>
        [Test]
        public void WorkspaceIDTest()
        {
            // TODO unit test for the property 'WorkspaceID'
        }

    }

}