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
    ///  Class for testing OrganizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganizationsApiTests
    {
        private OrganizationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganizationsApi
            //Assert.IsInstanceOfType(typeof(OrganizationsApi), instance, "instance is a OrganizationsApi");
        }

        
        /// <summary>
        /// Test DeleteOrganizationGroup
        /// </summary>
        [Test]
        public void DeleteOrganizationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //int? groupId = null;
            //var response = instance.DeleteOrganizationGroup(organizationId, groupId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteOrganizationUsersLeave
        /// </summary>
        [Test]
        public void DeleteOrganizationUsersLeaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.DeleteOrganizationUsersLeave(organizationId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetOrganization
        /// </summary>
        [Test]
        public void GetOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.GetOrganization(organizationId);
            //Assert.IsInstanceOf<ModelsMeOrganization> (response, "response is ModelsMeOrganization");
        }
        
        /// <summary>
        /// Test GetOrganizationGroups
        /// </summary>
        [Test]
        public void GetOrganizationGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //string name = null;
            //string workspace = null;
            //var response = instance.GetOrganizationGroups(organizationId, name, workspace);
            //Assert.IsInstanceOf<List<GroupOrganizationGroupResponse>> (response, "response is List<GroupOrganizationGroupResponse>");
        }
        
        /// <summary>
        /// Test GetOrganizationOwner
        /// </summary>
        [Test]
        public void GetOrganizationOwnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.GetOrganizationOwner(organizationId);
            //Assert.IsInstanceOf<ModelsOrganizationOwner> (response, "response is ModelsOrganizationOwner");
        }
        
        /// <summary>
        /// Test GetOrganizationRoles
        /// </summary>
        [Test]
        public void GetOrganizationRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.GetOrganizationRoles(organizationId);
            //Assert.IsInstanceOf<List<TypesRole>> (response, "response is List<TypesRole>");
        }
        
        /// <summary>
        /// Test GetOrganizationSegmentation
        /// </summary>
        [Test]
        public void GetOrganizationSegmentationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.GetOrganizationSegmentation(organizationId);
            //Assert.IsInstanceOf<ModelsOrganizationSegmentation> (response, "response is ModelsOrganizationSegmentation");
        }
        
        /// <summary>
        /// Test GetOrganizationUsers
        /// </summary>
        [Test]
        public void GetOrganizationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //string filter = null;
            //string activeStatus = null;
            //string onlyAdmins = null;
            //string groups = null;
            //string workspaces = null;
            //int? page = null;
            //int? perPage = null;
            //string sortDir = null;
            //var response = instance.GetOrganizationUsers(organizationId, filter, activeStatus, onlyAdmins, groups, workspaces, page, perPage, sortDir);
            //Assert.IsInstanceOf<List<ModelsOrgUser>> (response, "response is List<ModelsOrgUser>");
        }
        
        /// <summary>
        /// Test GetOrganizationUsersDetailed
        /// </summary>
        [Test]
        public void GetOrganizationUsersDetailedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //string filter = null;
            //string activeStatus = null;
            //string onlyAdmins = null;
            //string groups = null;
            //string workspaces = null;
            //int? page = null;
            //int? perPage = null;
            //string sortDir = null;
            //var response = instance.GetOrganizationUsersDetailed(organizationId, filter, activeStatus, onlyAdmins, groups, workspaces, page, perPage, sortDir);
            //Assert.IsInstanceOf<List<ModelsOrgUserDetailed>> (response, "response is List<ModelsOrgUserDetailed>");
        }
        
        /// <summary>
        /// Test GetOrganizationWorkspacesGroups
        /// </summary>
        [Test]
        public void GetOrganizationWorkspacesGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //int? workspaceId = null;
            //var response = instance.GetOrganizationWorkspacesGroups(organizationId, workspaceId);
            //Assert.IsInstanceOf<List<GroupOrganizationGroupResponse>> (response, "response is List<GroupOrganizationGroupResponse>");
        }
        
        /// <summary>
        /// Test GetOrganizationWorkspacesStatistics
        /// </summary>
        [Test]
        public void GetOrganizationWorkspacesStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetOrganizationWorkspacesStatistics();
            //Assert.IsInstanceOf<Dictionary<string, ModelsStatistics>> (response, "response is Dictionary<string, ModelsStatistics>");
        }
        
        /// <summary>
        /// Test GetOrganizationsPaymentsRecords
        /// </summary>
        [Test]
        public void GetOrganizationsPaymentsRecordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //bool? isUnified = null;
            //string next = null;
            //string prev = null;
            //var response = instance.GetOrganizationsPaymentsRecords(organizationId, isUnified, next, prev);
            //Assert.IsInstanceOf<List<ModelsUnifiedSubscriptionInvoiceList>> (response, "response is List<ModelsUnifiedSubscriptionInvoiceList>");
        }
        
        /// <summary>
        /// Test GetOrganizationsPlans
        /// </summary>
        [Test]
        public void GetOrganizationsPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.GetOrganizationsPlans(organizationId);
            //Assert.IsInstanceOf<BillingPricingStruct> (response, "response is BillingPricingStruct");
        }
        
        /// <summary>
        /// Test GetOrganizationsPlans_0
        /// </summary>
        [Test]
        public void GetOrganizationsPlans_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //int? planId = null;
            //var response = instance.GetOrganizationsPlans_0(organizationId, planId);
            //Assert.IsInstanceOf<BillingPricingStruct> (response, "response is BillingPricingStruct");
        }
        
        /// <summary>
        /// Test PatchOrganizationGroup
        /// </summary>
        [Test]
        public void PatchOrganizationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //int? groupId = null;
            //List<GroupsPatchInput> patchGroupRequest = null;
            //var response = instance.PatchOrganizationGroup(organizationId, groupId, patchGroupRequest);
            //Assert.IsInstanceOf<GroupsPatchOutput> (response, "response is GroupsPatchOutput");
        }
        
        /// <summary>
        /// Test PatchOrganizationUsers
        /// </summary>
        [Test]
        public void PatchOrganizationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //UserPatchParams _params = null;
            //var response = instance.PatchOrganizationUsers(organizationId, _params);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostOrganization
        /// </summary>
        [Test]
        public void PostOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ModelsPostPayload postOrganizationsRequest = null;
            //var response = instance.PostOrganization(postOrganizationsRequest);
            //Assert.IsInstanceOf<OrganizationPostOrganizationReply> (response, "response is OrganizationPostOrganizationReply");
        }
        
        /// <summary>
        /// Test PostOrganizationAcceptInvitation
        /// </summary>
        [Test]
        public void PostOrganizationAcceptInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string inviutationCode = null;
            //var response = instance.PostOrganizationAcceptInvitation(inviutationCode);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostOrganizationGroup
        /// </summary>
        [Test]
        public void PostOrganizationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //GroupPayload postGroupRequest = null;
            //var response = instance.PostOrganizationGroup(organizationId, postGroupRequest);
            //Assert.IsInstanceOf<GroupOrganizationGroupResponse> (response, "response is GroupOrganizationGroupResponse");
        }
        
        /// <summary>
        /// Test PostOrganizationInvitation
        /// </summary>
        [Test]
        public void PostOrganizationInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //InvitationPost postInvitationRequest = null;
            //var response = instance.PostOrganizationInvitation(organizationId, postInvitationRequest);
            //Assert.IsInstanceOf<InvitationResult> (response, "response is InvitationResult");
        }
        
        /// <summary>
        /// Test PostOrganizationWorkspaces
        /// </summary>
        [Test]
        public void PostOrganizationWorkspacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //WorkspacePayload post = null;
            //var response = instance.PostOrganizationWorkspaces(organizationId, post);
            //Assert.IsInstanceOf<WorkspaceWorkspace> (response, "response is WorkspaceWorkspace");
        }
        
        /// <summary>
        /// Test PutOrganization
        /// </summary>
        [Test]
        public void PutOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //ModelsPutPayload putOrganizationsRequest = null;
            //var response = instance.PutOrganization(organizationId, putOrganizationsRequest);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PutOrganizationGroup
        /// </summary>
        [Test]
        public void PutOrganizationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //GroupPayload putGroupRequest = null;
            //var response = instance.PutOrganizationGroup(organizationId, putGroupRequest);
            //Assert.IsInstanceOf<GroupOrganizationGroupResponse> (response, "response is GroupOrganizationGroupResponse");
        }
        
        /// <summary>
        /// Test PutOrganizationSegmentation
        /// </summary>
        [Test]
        public void PutOrganizationSegmentationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //var response = instance.PutOrganizationSegmentation(organizationId);
            //Assert.IsInstanceOf<ModelsOrganizationSegmentation> (response, "response is ModelsOrganizationSegmentation");
        }
        
        /// <summary>
        /// Test PutOrganizationUsers
        /// </summary>
        [Test]
        public void PutOrganizationUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //UserPayload _params = null;
            //var response = instance.PutOrganizationUsers(organizationId, _params);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PutOrganizationWorkspacesAssignments
        /// </summary>
        [Test]
        public void PutOrganizationWorkspacesAssignmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //int? workspaceId = null;
            //UserAssignmentsPayload post = null;
            //var response = instance.PutOrganizationWorkspacesAssignments(organizationId, workspaceId, post);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}