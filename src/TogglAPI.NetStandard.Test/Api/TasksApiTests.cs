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
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TasksApiTests
    {
        private TasksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TasksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TasksApi
            //Assert.IsInstanceOfType(typeof(TasksApi), instance, "instance is a TasksApi");
        }

        
        /// <summary>
        /// Test DeleteWorkspaceProjectTask
        /// </summary>
        [Test]
        public void DeleteWorkspaceProjectTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? projectId = null;
            //int? taskId = null;
            //var response = instance.DeleteWorkspaceProjectTask(workspaceId, projectId, taskId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetWorkspaceProjectTask
        /// </summary>
        [Test]
        public void GetWorkspaceProjectTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? projectId = null;
            //int? taskId = null;
            //var response = instance.GetWorkspaceProjectTask(workspaceId, projectId, taskId);
            //Assert.IsInstanceOf<ModelsTask> (response, "response is ModelsTask");
        }
        
        /// <summary>
        /// Test GetWorkspaceProjectTasks
        /// </summary>
        [Test]
        public void GetWorkspaceProjectTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? projectId = null;
            //var response = instance.GetWorkspaceProjectTasks(workspaceId, projectId);
            //Assert.IsInstanceOf<ModelsTask> (response, "response is ModelsTask");
        }
        
        /// <summary>
        /// Test GetWorkspaceTasks
        /// </summary>
        [Test]
        public void GetWorkspaceTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? since = null;
            //int? page = null;
            //int? perPage = null;
            //string sortOrder = null;
            //string sortField = null;
            //bool? active = null;
            //int? pid = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //var response = instance.GetWorkspaceTasks(workspaceId, since, page, perPage, sortOrder, sortField, active, pid, startDate, endDate);
            //Assert.IsInstanceOf<TaskResponse> (response, "response is TaskResponse");
        }
        
        /// <summary>
        /// Test PatchWorkspaceProjectTasks
        /// </summary>
        [Test]
        public void PatchWorkspaceProjectTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? projectId = null;
            //string taskIds = null;
            //List<TaskPatchInput> patchInput = null;
            //var response = instance.PatchWorkspaceProjectTasks(workspaceId, projectId, taskIds, patchInput);
            //Assert.IsInstanceOf<TaskPatchOutput> (response, "response is TaskPatchOutput");
        }
        
        /// <summary>
        /// Test PostWorkspaceProjectTasks
        /// </summary>
        [Test]
        public void PostWorkspaceProjectTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? projectId = null;
            //TaskPayload postInput = null;
            //var response = instance.PostWorkspaceProjectTasks(workspaceId, projectId, postInput);
            //Assert.IsInstanceOf<ModelsTask> (response, "response is ModelsTask");
        }
        
        /// <summary>
        /// Test PutWorkspaceProjectTask
        /// </summary>
        [Test]
        public void PutWorkspaceProjectTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? workspaceId = null;
            //int? projectId = null;
            //string taskId = null;
            //TaskPayload patchInput = null;
            //var response = instance.PutWorkspaceProjectTask(workspaceId, projectId, taskId, patchInput);
            //Assert.IsInstanceOf<ModelsTask> (response, "response is ModelsTask");
        }
        
    }

}