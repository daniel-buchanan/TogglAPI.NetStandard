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
    ///  Class for testing SummaryReportPost
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SummaryReportPostTests
    {
        // TODO uncomment below to declare an instance variable for SummaryReportPost
        //private SummaryReportPost instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SummaryReportPost
            //instance = new SummaryReportPost();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SummaryReportPost
        /// </summary>
        [Test]
        public void SummaryReportPostInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SummaryReportPost
            //Assert.IsInstanceOfType<SummaryReportPost> (instance, "variable 'instance' is a SummaryReportPost");
        }


        /// <summary>
        /// Test the property 'Audit'
        /// </summary>
        [Test]
        public void AuditTest()
        {
            // TODO unit test for the property 'Audit'
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
        /// Test the property 'ClientIds'
        /// </summary>
        [Test]
        public void ClientIdsTest()
        {
            // TODO unit test for the property 'ClientIds'
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
        /// Test the property 'DistinguishRates'
        /// </summary>
        [Test]
        public void DistinguishRatesTest()
        {
            // TODO unit test for the property 'DistinguishRates'
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
        /// Test the property 'GroupIds'
        /// </summary>
        [Test]
        public void GroupIdsTest()
        {
            // TODO unit test for the property 'GroupIds'
        }
        /// <summary>
        /// Test the property 'Grouping'
        /// </summary>
        [Test]
        public void GroupingTest()
        {
            // TODO unit test for the property 'Grouping'
        }
        /// <summary>
        /// Test the property 'IncludeTimeEntryIds'
        /// </summary>
        [Test]
        public void IncludeTimeEntryIdsTest()
        {
            // TODO unit test for the property 'IncludeTimeEntryIds'
        }
        /// <summary>
        /// Test the property 'MaxDurationSeconds'
        /// </summary>
        [Test]
        public void MaxDurationSecondsTest()
        {
            // TODO unit test for the property 'MaxDurationSeconds'
        }
        /// <summary>
        /// Test the property 'MinDurationSeconds'
        /// </summary>
        [Test]
        public void MinDurationSecondsTest()
        {
            // TODO unit test for the property 'MinDurationSeconds'
        }
        /// <summary>
        /// Test the property 'PostedFields'
        /// </summary>
        [Test]
        public void PostedFieldsTest()
        {
            // TODO unit test for the property 'PostedFields'
        }
        /// <summary>
        /// Test the property 'ProjectIds'
        /// </summary>
        [Test]
        public void ProjectIdsTest()
        {
            // TODO unit test for the property 'ProjectIds'
        }
        /// <summary>
        /// Test the property 'Rounding'
        /// </summary>
        [Test]
        public void RoundingTest()
        {
            // TODO unit test for the property 'Rounding'
        }
        /// <summary>
        /// Test the property 'RoundingMinutes'
        /// </summary>
        [Test]
        public void RoundingMinutesTest()
        {
            // TODO unit test for the property 'RoundingMinutes'
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
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'SubGrouping'
        /// </summary>
        [Test]
        public void SubGroupingTest()
        {
            // TODO unit test for the property 'SubGrouping'
        }
        /// <summary>
        /// Test the property 'TagIds'
        /// </summary>
        [Test]
        public void TagIdsTest()
        {
            // TODO unit test for the property 'TagIds'
        }
        /// <summary>
        /// Test the property 'TaskIds'
        /// </summary>
        [Test]
        public void TaskIdsTest()
        {
            // TODO unit test for the property 'TaskIds'
        }
        /// <summary>
        /// Test the property 'TimeEntryIds'
        /// </summary>
        [Test]
        public void TimeEntryIdsTest()
        {
            // TODO unit test for the property 'TimeEntryIds'
        }
        /// <summary>
        /// Test the property 'UserIds'
        /// </summary>
        [Test]
        public void UserIdsTest()
        {
            // TODO unit test for the property 'UserIds'
        }

    }

}
