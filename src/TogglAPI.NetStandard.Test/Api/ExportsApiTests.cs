/* 
 * Toggl API
 *
 * Public Toggl API. Note: We use BasicAuth in a specific way. By the standard you provide `Authentication` header with `base64(user_name:password)` as a `credential`. In our case it will be `base64(user_name:api_token)`.
 *
 * OpenAPI spec version: 9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TogglAPI.NetStandard.Client;
using TogglAPI.NetStandard.Api;
using TogglAPI.NetStandard.Model;

namespace TogglAPI.NetStandard.Test
{
    /// <summary>
    ///  Class for testing ExportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExportsApiTests
    {
        private ExportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExportsApi
            //Assert.IsInstanceOfType(typeof(ExportsApi), instance, "instance is a ExportsApi");
        }

        
        /// <summary>
        /// Test GetMeExport
        /// </summary>
        [Test]
        public void GetMeExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMeExport();
            //Assert.IsInstanceOf<List<ModelsDownloadRequestRecord>> (response, "response is List<ModelsDownloadRequestRecord>");
        }
        
        /// <summary>
        /// Test GetMeExportDataUuidZip
        /// </summary>
        [Test]
        public void GetMeExportDataUuidZipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMeExportDataUuidZip();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetWorkspaceExports
        /// </summary>
        [Test]
        public void GetWorkspaceExportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //var response = instance.GetWorkspaceExports(workspaceId);
            //Assert.IsInstanceOf<List<ModelsDownloadRequestRecord>> (response, "response is List<ModelsDownloadRequestRecord>");
        }
        
        /// <summary>
        /// Test GetWorkspaceExportsDataUuidZip
        /// </summary>
        [Test]
        public void GetWorkspaceExportsDataUuidZipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //var response = instance.GetWorkspaceExportsDataUuidZip(workspaceId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost
        /// </summary>
        [Test]
        public void InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestsEmployeeProfitability parameters = null;
            //var response = instance.InsightsApiV1WorkspaceWorkspaceIdProfitabilityEmployeesExtensionPost(parameters);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost
        /// </summary>
        [Test]
        public void InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestsProjectProfitability parameters = null;
            //string extension = null;
            //var response = instance.InsightsApiV1WorkspaceWorkspaceIdProfitabilityProjectsExtensionPost(parameters, extension);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost
        /// </summary>
        [Test]
        public void InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //string extension = null;
            //ProjectsProjectTrend projectTrend = null;
            //var response = instance.InsightsApiV1WorkspaceWorkspaceIdTrendsProjectsExtensionPost(workspaceId, extension, projectTrend);
            //Assert.IsInstanceOf<List<ProjectsProjectTrends>> (response, "response is List<ProjectsProjectTrends>");
        }
        
        /// <summary>
        /// Test PostMeExport
        /// </summary>
        [Test]
        public void PostMeExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExportPayload dataExportObject = null;
            //var response = instance.PostMeExport(dataExportObject);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostWorkspaceExports
        /// </summary>
        [Test]
        public void PostWorkspaceExportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //List<string> tokensList = null;
            //var response = instance.PostWorkspaceExports(workspaceId, tokensList);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3SharedReportTokenCsvPost
        /// </summary>
        [Test]
        public void ReportsApiV3SharedReportTokenCsvPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportToken = null;
            //string startDate = null;
            //string endDate = null;
            //var response = instance.ReportsApiV3SharedReportTokenCsvPost(reportToken, startDate, endDate);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3SharedReportTokenPdfPost
        /// </summary>
        [Test]
        public void ReportsApiV3SharedReportTokenPdfPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportToken = null;
            //string startDate = null;
            //string endDate = null;
            //string displayMode = null;
            //var response = instance.ReportsApiV3SharedReportTokenPdfPost(reportToken, startDate, endDate, displayMode);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3SharedReportTokenXlsxPost
        /// </summary>
        [Test]
        public void ReportsApiV3SharedReportTokenXlsxPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportToken = null;
            //string startDate = null;
            //string endDate = null;
            //var response = instance.ReportsApiV3SharedReportTokenXlsxPost(reportToken, startDate, endDate);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost
        /// </summary>
        [Test]
        public void ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //string extension = null;
            //DetailedSearchExportPost detailedExportPost = null;
            //var response = instance.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesExtensionPost(workspaceId, extension, detailedExportPost);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost
        /// </summary>
        [Test]
        public void ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //DetailedExportPDFPost detailedExportPdfPost = null;
            //var response = instance.ReportsApiV3WorkspaceWorkspaceIdSearchTimeEntriesPdfPost(workspaceId, detailedExportPdfPost);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost
        /// </summary>
        [Test]
        public void ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //string extension = null;
            //SummaryExportPost summaryExportPost = null;
            //var response = instance.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesExtensionPost(workspaceId, extension, summaryExportPost);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost
        /// </summary>
        [Test]
        public void ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //SummaryExportPDFPost summaryExportPdfPost = null;
            //var response = instance.ReportsApiV3WorkspaceWorkspaceIdSummaryTimeEntriesPdfPost(workspaceId, summaryExportPdfPost);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost
        /// </summary>
        [Test]
        public void ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //WeeklyExportPost weeklyExportPost = null;
            //var response = instance.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesCsvPost(workspaceId, weeklyExportPost);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost
        /// </summary>
        [Test]
        public void ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //WeeklyExportPDFPost weeklyExportPdfPost = null;
            //var response = instance.ReportsApiV3WorkspaceWorkspaceIdWeeklyTimeEntriesPdfPost(workspaceId, weeklyExportPdfPost);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
