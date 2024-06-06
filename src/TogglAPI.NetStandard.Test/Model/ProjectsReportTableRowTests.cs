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
    ///  Class for testing ProjectsReportTableRow
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProjectsReportTableRowTests
    {
        // TODO uncomment below to declare an instance variable for ProjectsReportTableRow
        //private ProjectsReportTableRow instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProjectsReportTableRow
            //instance = new ProjectsReportTableRow();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectsReportTableRow
        /// </summary>
        [Test]
        public void ProjectsReportTableRowInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProjectsReportTableRow
            //Assert.IsInstanceOfType<ProjectsReportTableRow> (instance, "variable 'instance' is a ProjectsReportTableRow");
        }


        /// <summary>
        /// Test the property 'BillableSeconds'
        /// </summary>
        [Test]
        public void BillableSecondsTest()
        {
            // TODO unit test for the property 'BillableSeconds'
        }
        /// <summary>
        /// Test the property 'Color'
        /// </summary>
        [Test]
        public void ColorTest()
        {
            // TODO unit test for the property 'Color'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Earnings'
        /// </summary>
        [Test]
        public void EarningsTest()
        {
            // TODO unit test for the property 'Earnings'
        }
        /// <summary>
        /// Test the property 'LabourCost'
        /// </summary>
        [Test]
        public void LabourCostTest()
        {
            // TODO unit test for the property 'LabourCost'
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
        /// Test the property 'ProjectId'
        /// </summary>
        [Test]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }
        /// <summary>
        /// Test the property 'TotalSeconds'
        /// </summary>
        [Test]
        public void TotalSecondsTest()
        {
            // TODO unit test for the property 'TotalSeconds'
        }

    }

}