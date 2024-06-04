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
    ///  Class for testing InvitationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvitationsApiTests
    {
        private InvitationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvitationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvitationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvitationsApi
            //Assert.IsInstanceOfType(typeof(InvitationsApi), instance, "instance is a InvitationsApi");
        }

        
        /// <summary>
        /// Test GetInvitations
        /// </summary>
        [Test]
        public void GetInvitationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invitationCode = null;
            //var response = instance.GetInvitations(invitationCode);
            //Assert.IsInstanceOf<ModelsSSOInvitation> (response, "response is ModelsSSOInvitation");
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
        /// Test PostRejectInvitation
        /// </summary>
        [Test]
        public void PostRejectInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string inviutationCode = null;
            //var response = instance.PostRejectInvitation(inviutationCode);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PutInvitation
        /// </summary>
        [Test]
        public void PutInvitationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organizationId = null;
            //string invitationCode = null;
            //var response = instance.PutInvitation(organizationId, invitationCode);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
