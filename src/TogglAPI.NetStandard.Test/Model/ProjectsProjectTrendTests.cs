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
    ///  Class for testing ProjectsProjectTrend
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProjectsProjectTrendTests
    {
        // TODO uncomment below to declare an instance variable for ProjectsProjectTrend
        //private ProjectsProjectTrend instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProjectsProjectTrend
            //instance = new ProjectsProjectTrend();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectsProjectTrend
        /// </summary>
        [Test]
        public void ProjectsProjectTrendInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProjectsProjectTrend
            //Assert.IsInstanceOfType<ProjectsProjectTrend> (instance, "variable 'instance' is a ProjectsProjectTrend");
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
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'PreviousPeriodStart'
        /// </summary>
        [Test]
        public void PreviousPeriodStartTest()
        {
            // TODO unit test for the property 'PreviousPeriodStart'
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
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }

    }

}