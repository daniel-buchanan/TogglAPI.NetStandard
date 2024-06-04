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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TogglAPI.NetStandard.Client.SwaggerDateConverter;

namespace TogglAPI.NetStandard.Model
{
    /// <summary>
    /// WorkspaceWithActiveProjectCount
    /// </summary>
    [DataContract]
    public partial class WorkspaceWithActiveProjectCount :  IEquatable<WorkspaceWithActiveProjectCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceWithActiveProjectCount" /> class.
        /// </summary>
        /// <param name="activeProjectCount">activeProjectCount.</param>
        /// <param name="admin">Current user is workspace admin.</param>
        /// <param name="apiToken">deprecated.</param>
        /// <param name="at">Timestamp of last workspace change.</param>
        /// <param name="businessWs">Workspace on Premium subscription.</param>
        /// <param name="csvUpload">CSV upload data.</param>
        /// <param name="defaultCurrency">Default currency, premium feature, optional, only for existing WS, will be &#39;USD&#39; initially.</param>
        /// <param name="defaultHourlyRate">The default hourly rate, premium feature, optional, only for existing WS, will be 0.0 initially.</param>
        /// <param name="hideStartEndTimes">hideStartEndTimes.</param>
        /// <param name="icalEnabled">Calendar integration enabled.</param>
        /// <param name="icalUrl">URL of calendar.</param>
        /// <param name="id">Identifier of the workspace.</param>
        /// <param name="lastModified">Last modification of data in the workspace.</param>
        /// <param name="logoUrl">URL of workspace logo.</param>
        /// <param name="maxDataRetentionDays">How far back free workspaces can access data..</param>
        /// <param name="name">Name of the workspace.</param>
        /// <param name="onlyAdminsMayCreateProjects">Only admins will be able to create projects, optional, only for existing WS, will be false initially.</param>
        /// <param name="onlyAdminsMayCreateTags">Only admins will be able to create tags, optional, only for existing WS, will be false initially.</param>
        /// <param name="onlyAdminsSeeBillableRates">Whether only admins will be able to see billable rates, premium feature, optional, only for existing WS. Will be false initially.</param>
        /// <param name="onlyAdminsSeeTeamDashboard">Only admins will be able to see the team dashboard, optional, only for existing WS, will be false initially.</param>
        /// <param name="organizationId">Identifier of the organization.</param>
        /// <param name="permissions">Permissions list.</param>
        /// <param name="premium">Workspace on Starter subscription.</param>
        /// <param name="profile">deprecated.</param>
        /// <param name="projectsBillableByDefault">New projects billable by default.</param>
        /// <param name="projectsPrivateByDefault">Workspace setting for default project visbility..</param>
        /// <param name="rateLastUpdated">Timestamp of last workspace rate update.</param>
        /// <param name="reportsCollapse">Whether reports should be collapsed by default, optional, only for existing WS, will be true initially.</param>
        /// <param name="role">Role of the current user in the workspace.</param>
        /// <param name="rounding">Default rounding, premium feature, optional, only for existing WS. 0 - nearest, 1 - round up, -1 - round down.</param>
        /// <param name="roundingMinutes">Default rounding in minutes, premium feature, optional, only for existing WS.</param>
        /// <param name="serverDeletedAt">Timestamp of deletion.</param>
        /// <param name="subscription">deprecated.</param>
        /// <param name="suspendedAt">Timestamp of suspension.</param>
        /// <param name="teConstraints">Time entry constraints setting.</param>
        /// <param name="workingHoursInMinutes">Working hours in minutes.</param>
        public WorkspaceWithActiveProjectCount(int? activeProjectCount = default(int?), bool? admin = default(bool?), string apiToken = default(string), string at = default(string), bool? businessWs = default(bool?), ModelsCsvUpload csvUpload = default(ModelsCsvUpload), string defaultCurrency = default(string), decimal? defaultHourlyRate = default(decimal?), bool? hideStartEndTimes = default(bool?), bool? icalEnabled = default(bool?), string icalUrl = default(string), int? id = default(int?), string lastModified = default(string), string logoUrl = default(string), int? maxDataRetentionDays = default(int?), string name = default(string), bool? onlyAdminsMayCreateProjects = default(bool?), bool? onlyAdminsMayCreateTags = default(bool?), bool? onlyAdminsSeeBillableRates = default(bool?), bool? onlyAdminsSeeTeamDashboard = default(bool?), int? organizationId = default(int?), string permissions = default(string), bool? premium = default(bool?), int? profile = default(int?), bool? projectsBillableByDefault = default(bool?), bool? projectsPrivateByDefault = default(bool?), string rateLastUpdated = default(string), bool? reportsCollapse = default(bool?), string role = default(string), int? rounding = default(int?), int? roundingMinutes = default(int?), DateTime? serverDeletedAt = default(DateTime?), ModelsSubscription subscription = default(ModelsSubscription), DateTime? suspendedAt = default(DateTime?), ModelsTimeEntryConstraints teConstraints = default(ModelsTimeEntryConstraints), int? workingHoursInMinutes = default(int?))
        {
            this.ActiveProjectCount = activeProjectCount;
            this.Admin = admin;
            this.ApiToken = apiToken;
            this.At = at;
            this.BusinessWs = businessWs;
            this.CsvUpload = csvUpload;
            this.DefaultCurrency = defaultCurrency;
            this.DefaultHourlyRate = defaultHourlyRate;
            this.HideStartEndTimes = hideStartEndTimes;
            this.IcalEnabled = icalEnabled;
            this.IcalUrl = icalUrl;
            this.Id = id;
            this.LastModified = lastModified;
            this.LogoUrl = logoUrl;
            this.MaxDataRetentionDays = maxDataRetentionDays;
            this.Name = name;
            this.OnlyAdminsMayCreateProjects = onlyAdminsMayCreateProjects;
            this.OnlyAdminsMayCreateTags = onlyAdminsMayCreateTags;
            this.OnlyAdminsSeeBillableRates = onlyAdminsSeeBillableRates;
            this.OnlyAdminsSeeTeamDashboard = onlyAdminsSeeTeamDashboard;
            this.OrganizationId = organizationId;
            this.Permissions = permissions;
            this.Premium = premium;
            this.Profile = profile;
            this.ProjectsBillableByDefault = projectsBillableByDefault;
            this.ProjectsPrivateByDefault = projectsPrivateByDefault;
            this.RateLastUpdated = rateLastUpdated;
            this.ReportsCollapse = reportsCollapse;
            this.Role = role;
            this.Rounding = rounding;
            this.RoundingMinutes = roundingMinutes;
            this.ServerDeletedAt = serverDeletedAt;
            this.Subscription = subscription;
            this.SuspendedAt = suspendedAt;
            this.TeConstraints = teConstraints;
            this.WorkingHoursInMinutes = workingHoursInMinutes;
        }
        
        /// <summary>
        /// Gets or Sets ActiveProjectCount
        /// </summary>
        [DataMember(Name="active_project_count", EmitDefaultValue=false)]
        public int? ActiveProjectCount { get; set; }

        /// <summary>
        /// Current user is workspace admin
        /// </summary>
        /// <value>Current user is workspace admin</value>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        /// <value>deprecated</value>
        [DataMember(Name="api_token", EmitDefaultValue=false)]
        public string ApiToken { get; set; }

        /// <summary>
        /// Timestamp of last workspace change
        /// </summary>
        /// <value>Timestamp of last workspace change</value>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public string At { get; set; }

        /// <summary>
        /// Workspace on Premium subscription
        /// </summary>
        /// <value>Workspace on Premium subscription</value>
        [DataMember(Name="business_ws", EmitDefaultValue=false)]
        public bool? BusinessWs { get; set; }

        /// <summary>
        /// CSV upload data
        /// </summary>
        /// <value>CSV upload data</value>
        [DataMember(Name="csv_upload", EmitDefaultValue=false)]
        public ModelsCsvUpload CsvUpload { get; set; }

        /// <summary>
        /// Default currency, premium feature, optional, only for existing WS, will be &#39;USD&#39; initially
        /// </summary>
        /// <value>Default currency, premium feature, optional, only for existing WS, will be &#39;USD&#39; initially</value>
        [DataMember(Name="default_currency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The default hourly rate, premium feature, optional, only for existing WS, will be 0.0 initially
        /// </summary>
        /// <value>The default hourly rate, premium feature, optional, only for existing WS, will be 0.0 initially</value>
        [DataMember(Name="default_hourly_rate", EmitDefaultValue=false)]
        public decimal? DefaultHourlyRate { get; set; }

        /// <summary>
        /// Gets or Sets HideStartEndTimes
        /// </summary>
        [DataMember(Name="hide_start_end_times", EmitDefaultValue=false)]
        public bool? HideStartEndTimes { get; set; }

        /// <summary>
        /// Calendar integration enabled
        /// </summary>
        /// <value>Calendar integration enabled</value>
        [DataMember(Name="ical_enabled", EmitDefaultValue=false)]
        public bool? IcalEnabled { get; set; }

        /// <summary>
        /// URL of calendar
        /// </summary>
        /// <value>URL of calendar</value>
        [DataMember(Name="ical_url", EmitDefaultValue=false)]
        public string IcalUrl { get; set; }

        /// <summary>
        /// Identifier of the workspace
        /// </summary>
        /// <value>Identifier of the workspace</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Last modification of data in the workspace
        /// </summary>
        /// <value>Last modification of data in the workspace</value>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// URL of workspace logo
        /// </summary>
        /// <value>URL of workspace logo</value>
        [DataMember(Name="logo_url", EmitDefaultValue=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// How far back free workspaces can access data.
        /// </summary>
        /// <value>How far back free workspaces can access data.</value>
        [DataMember(Name="max_data_retention_days", EmitDefaultValue=false)]
        public int? MaxDataRetentionDays { get; set; }

        /// <summary>
        /// Name of the workspace
        /// </summary>
        /// <value>Name of the workspace</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Only admins will be able to create projects, optional, only for existing WS, will be false initially
        /// </summary>
        /// <value>Only admins will be able to create projects, optional, only for existing WS, will be false initially</value>
        [DataMember(Name="only_admins_may_create_projects", EmitDefaultValue=false)]
        public bool? OnlyAdminsMayCreateProjects { get; set; }

        /// <summary>
        /// Only admins will be able to create tags, optional, only for existing WS, will be false initially
        /// </summary>
        /// <value>Only admins will be able to create tags, optional, only for existing WS, will be false initially</value>
        [DataMember(Name="only_admins_may_create_tags", EmitDefaultValue=false)]
        public bool? OnlyAdminsMayCreateTags { get; set; }

        /// <summary>
        /// Whether only admins will be able to see billable rates, premium feature, optional, only for existing WS. Will be false initially
        /// </summary>
        /// <value>Whether only admins will be able to see billable rates, premium feature, optional, only for existing WS. Will be false initially</value>
        [DataMember(Name="only_admins_see_billable_rates", EmitDefaultValue=false)]
        public bool? OnlyAdminsSeeBillableRates { get; set; }

        /// <summary>
        /// Only admins will be able to see the team dashboard, optional, only for existing WS, will be false initially
        /// </summary>
        /// <value>Only admins will be able to see the team dashboard, optional, only for existing WS, will be false initially</value>
        [DataMember(Name="only_admins_see_team_dashboard", EmitDefaultValue=false)]
        public bool? OnlyAdminsSeeTeamDashboard { get; set; }

        /// <summary>
        /// Identifier of the organization
        /// </summary>
        /// <value>Identifier of the organization</value>
        [DataMember(Name="organization_id", EmitDefaultValue=false)]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Permissions list
        /// </summary>
        /// <value>Permissions list</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// Workspace on Starter subscription
        /// </summary>
        /// <value>Workspace on Starter subscription</value>
        [DataMember(Name="premium", EmitDefaultValue=false)]
        public bool? Premium { get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        /// <value>deprecated</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public int? Profile { get; set; }

        /// <summary>
        /// New projects billable by default
        /// </summary>
        /// <value>New projects billable by default</value>
        [DataMember(Name="projects_billable_by_default", EmitDefaultValue=false)]
        public bool? ProjectsBillableByDefault { get; set; }

        /// <summary>
        /// Workspace setting for default project visbility.
        /// </summary>
        /// <value>Workspace setting for default project visbility.</value>
        [DataMember(Name="projects_private_by_default", EmitDefaultValue=false)]
        public bool? ProjectsPrivateByDefault { get; set; }

        /// <summary>
        /// Timestamp of last workspace rate update
        /// </summary>
        /// <value>Timestamp of last workspace rate update</value>
        [DataMember(Name="rate_last_updated", EmitDefaultValue=false)]
        public string RateLastUpdated { get; set; }

        /// <summary>
        /// Whether reports should be collapsed by default, optional, only for existing WS, will be true initially
        /// </summary>
        /// <value>Whether reports should be collapsed by default, optional, only for existing WS, will be true initially</value>
        [DataMember(Name="reports_collapse", EmitDefaultValue=false)]
        public bool? ReportsCollapse { get; set; }

        /// <summary>
        /// Role of the current user in the workspace
        /// </summary>
        /// <value>Role of the current user in the workspace</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Default rounding, premium feature, optional, only for existing WS. 0 - nearest, 1 - round up, -1 - round down
        /// </summary>
        /// <value>Default rounding, premium feature, optional, only for existing WS. 0 - nearest, 1 - round up, -1 - round down</value>
        [DataMember(Name="rounding", EmitDefaultValue=false)]
        public int? Rounding { get; set; }

        /// <summary>
        /// Default rounding in minutes, premium feature, optional, only for existing WS
        /// </summary>
        /// <value>Default rounding in minutes, premium feature, optional, only for existing WS</value>
        [DataMember(Name="rounding_minutes", EmitDefaultValue=false)]
        public int? RoundingMinutes { get; set; }

        /// <summary>
        /// Timestamp of deletion
        /// </summary>
        /// <value>Timestamp of deletion</value>
        [DataMember(Name="server_deleted_at", EmitDefaultValue=false)]
        public DateTime? ServerDeletedAt { get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        /// <value>deprecated</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public ModelsSubscription Subscription { get; set; }

        /// <summary>
        /// Timestamp of suspension
        /// </summary>
        /// <value>Timestamp of suspension</value>
        [DataMember(Name="suspended_at", EmitDefaultValue=false)]
        public DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// Time entry constraints setting
        /// </summary>
        /// <value>Time entry constraints setting</value>
        [DataMember(Name="te_constraints", EmitDefaultValue=false)]
        public ModelsTimeEntryConstraints TeConstraints { get; set; }

        /// <summary>
        /// Working hours in minutes
        /// </summary>
        /// <value>Working hours in minutes</value>
        [DataMember(Name="working_hours_in_minutes", EmitDefaultValue=false)]
        public int? WorkingHoursInMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkspaceWithActiveProjectCount {\n");
            sb.Append("  ActiveProjectCount: ").Append(ActiveProjectCount).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  ApiToken: ").Append(ApiToken).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  BusinessWs: ").Append(BusinessWs).Append("\n");
            sb.Append("  CsvUpload: ").Append(CsvUpload).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  DefaultHourlyRate: ").Append(DefaultHourlyRate).Append("\n");
            sb.Append("  HideStartEndTimes: ").Append(HideStartEndTimes).Append("\n");
            sb.Append("  IcalEnabled: ").Append(IcalEnabled).Append("\n");
            sb.Append("  IcalUrl: ").Append(IcalUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  MaxDataRetentionDays: ").Append(MaxDataRetentionDays).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnlyAdminsMayCreateProjects: ").Append(OnlyAdminsMayCreateProjects).Append("\n");
            sb.Append("  OnlyAdminsMayCreateTags: ").Append(OnlyAdminsMayCreateTags).Append("\n");
            sb.Append("  OnlyAdminsSeeBillableRates: ").Append(OnlyAdminsSeeBillableRates).Append("\n");
            sb.Append("  OnlyAdminsSeeTeamDashboard: ").Append(OnlyAdminsSeeTeamDashboard).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Premium: ").Append(Premium).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  ProjectsBillableByDefault: ").Append(ProjectsBillableByDefault).Append("\n");
            sb.Append("  ProjectsPrivateByDefault: ").Append(ProjectsPrivateByDefault).Append("\n");
            sb.Append("  RateLastUpdated: ").Append(RateLastUpdated).Append("\n");
            sb.Append("  ReportsCollapse: ").Append(ReportsCollapse).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Rounding: ").Append(Rounding).Append("\n");
            sb.Append("  RoundingMinutes: ").Append(RoundingMinutes).Append("\n");
            sb.Append("  ServerDeletedAt: ").Append(ServerDeletedAt).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SuspendedAt: ").Append(SuspendedAt).Append("\n");
            sb.Append("  TeConstraints: ").Append(TeConstraints).Append("\n");
            sb.Append("  WorkingHoursInMinutes: ").Append(WorkingHoursInMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkspaceWithActiveProjectCount);
        }

        /// <summary>
        /// Returns true if WorkspaceWithActiveProjectCount instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkspaceWithActiveProjectCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkspaceWithActiveProjectCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveProjectCount == input.ActiveProjectCount ||
                    (this.ActiveProjectCount != null &&
                    this.ActiveProjectCount.Equals(input.ActiveProjectCount))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.ApiToken == input.ApiToken ||
                    (this.ApiToken != null &&
                    this.ApiToken.Equals(input.ApiToken))
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.BusinessWs == input.BusinessWs ||
                    (this.BusinessWs != null &&
                    this.BusinessWs.Equals(input.BusinessWs))
                ) && 
                (
                    this.CsvUpload == input.CsvUpload ||
                    (this.CsvUpload != null &&
                    this.CsvUpload.Equals(input.CsvUpload))
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    (this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(input.DefaultCurrency))
                ) && 
                (
                    this.DefaultHourlyRate == input.DefaultHourlyRate ||
                    (this.DefaultHourlyRate != null &&
                    this.DefaultHourlyRate.Equals(input.DefaultHourlyRate))
                ) && 
                (
                    this.HideStartEndTimes == input.HideStartEndTimes ||
                    (this.HideStartEndTimes != null &&
                    this.HideStartEndTimes.Equals(input.HideStartEndTimes))
                ) && 
                (
                    this.IcalEnabled == input.IcalEnabled ||
                    (this.IcalEnabled != null &&
                    this.IcalEnabled.Equals(input.IcalEnabled))
                ) && 
                (
                    this.IcalUrl == input.IcalUrl ||
                    (this.IcalUrl != null &&
                    this.IcalUrl.Equals(input.IcalUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.MaxDataRetentionDays == input.MaxDataRetentionDays ||
                    (this.MaxDataRetentionDays != null &&
                    this.MaxDataRetentionDays.Equals(input.MaxDataRetentionDays))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OnlyAdminsMayCreateProjects == input.OnlyAdminsMayCreateProjects ||
                    (this.OnlyAdminsMayCreateProjects != null &&
                    this.OnlyAdminsMayCreateProjects.Equals(input.OnlyAdminsMayCreateProjects))
                ) && 
                (
                    this.OnlyAdminsMayCreateTags == input.OnlyAdminsMayCreateTags ||
                    (this.OnlyAdminsMayCreateTags != null &&
                    this.OnlyAdminsMayCreateTags.Equals(input.OnlyAdminsMayCreateTags))
                ) && 
                (
                    this.OnlyAdminsSeeBillableRates == input.OnlyAdminsSeeBillableRates ||
                    (this.OnlyAdminsSeeBillableRates != null &&
                    this.OnlyAdminsSeeBillableRates.Equals(input.OnlyAdminsSeeBillableRates))
                ) && 
                (
                    this.OnlyAdminsSeeTeamDashboard == input.OnlyAdminsSeeTeamDashboard ||
                    (this.OnlyAdminsSeeTeamDashboard != null &&
                    this.OnlyAdminsSeeTeamDashboard.Equals(input.OnlyAdminsSeeTeamDashboard))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Premium == input.Premium ||
                    (this.Premium != null &&
                    this.Premium.Equals(input.Premium))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.ProjectsBillableByDefault == input.ProjectsBillableByDefault ||
                    (this.ProjectsBillableByDefault != null &&
                    this.ProjectsBillableByDefault.Equals(input.ProjectsBillableByDefault))
                ) && 
                (
                    this.ProjectsPrivateByDefault == input.ProjectsPrivateByDefault ||
                    (this.ProjectsPrivateByDefault != null &&
                    this.ProjectsPrivateByDefault.Equals(input.ProjectsPrivateByDefault))
                ) && 
                (
                    this.RateLastUpdated == input.RateLastUpdated ||
                    (this.RateLastUpdated != null &&
                    this.RateLastUpdated.Equals(input.RateLastUpdated))
                ) && 
                (
                    this.ReportsCollapse == input.ReportsCollapse ||
                    (this.ReportsCollapse != null &&
                    this.ReportsCollapse.Equals(input.ReportsCollapse))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Rounding == input.Rounding ||
                    (this.Rounding != null &&
                    this.Rounding.Equals(input.Rounding))
                ) && 
                (
                    this.RoundingMinutes == input.RoundingMinutes ||
                    (this.RoundingMinutes != null &&
                    this.RoundingMinutes.Equals(input.RoundingMinutes))
                ) && 
                (
                    this.ServerDeletedAt == input.ServerDeletedAt ||
                    (this.ServerDeletedAt != null &&
                    this.ServerDeletedAt.Equals(input.ServerDeletedAt))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.SuspendedAt == input.SuspendedAt ||
                    (this.SuspendedAt != null &&
                    this.SuspendedAt.Equals(input.SuspendedAt))
                ) && 
                (
                    this.TeConstraints == input.TeConstraints ||
                    (this.TeConstraints != null &&
                    this.TeConstraints.Equals(input.TeConstraints))
                ) && 
                (
                    this.WorkingHoursInMinutes == input.WorkingHoursInMinutes ||
                    (this.WorkingHoursInMinutes != null &&
                    this.WorkingHoursInMinutes.Equals(input.WorkingHoursInMinutes))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActiveProjectCount != null)
                    hashCode = hashCode * 59 + this.ActiveProjectCount.GetHashCode();
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.ApiToken != null)
                    hashCode = hashCode * 59 + this.ApiToken.GetHashCode();
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.BusinessWs != null)
                    hashCode = hashCode * 59 + this.BusinessWs.GetHashCode();
                if (this.CsvUpload != null)
                    hashCode = hashCode * 59 + this.CsvUpload.GetHashCode();
                if (this.DefaultCurrency != null)
                    hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.DefaultHourlyRate != null)
                    hashCode = hashCode * 59 + this.DefaultHourlyRate.GetHashCode();
                if (this.HideStartEndTimes != null)
                    hashCode = hashCode * 59 + this.HideStartEndTimes.GetHashCode();
                if (this.IcalEnabled != null)
                    hashCode = hashCode * 59 + this.IcalEnabled.GetHashCode();
                if (this.IcalUrl != null)
                    hashCode = hashCode * 59 + this.IcalUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LogoUrl != null)
                    hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.MaxDataRetentionDays != null)
                    hashCode = hashCode * 59 + this.MaxDataRetentionDays.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OnlyAdminsMayCreateProjects != null)
                    hashCode = hashCode * 59 + this.OnlyAdminsMayCreateProjects.GetHashCode();
                if (this.OnlyAdminsMayCreateTags != null)
                    hashCode = hashCode * 59 + this.OnlyAdminsMayCreateTags.GetHashCode();
                if (this.OnlyAdminsSeeBillableRates != null)
                    hashCode = hashCode * 59 + this.OnlyAdminsSeeBillableRates.GetHashCode();
                if (this.OnlyAdminsSeeTeamDashboard != null)
                    hashCode = hashCode * 59 + this.OnlyAdminsSeeTeamDashboard.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Premium != null)
                    hashCode = hashCode * 59 + this.Premium.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.ProjectsBillableByDefault != null)
                    hashCode = hashCode * 59 + this.ProjectsBillableByDefault.GetHashCode();
                if (this.ProjectsPrivateByDefault != null)
                    hashCode = hashCode * 59 + this.ProjectsPrivateByDefault.GetHashCode();
                if (this.RateLastUpdated != null)
                    hashCode = hashCode * 59 + this.RateLastUpdated.GetHashCode();
                if (this.ReportsCollapse != null)
                    hashCode = hashCode * 59 + this.ReportsCollapse.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Rounding != null)
                    hashCode = hashCode * 59 + this.Rounding.GetHashCode();
                if (this.RoundingMinutes != null)
                    hashCode = hashCode * 59 + this.RoundingMinutes.GetHashCode();
                if (this.ServerDeletedAt != null)
                    hashCode = hashCode * 59 + this.ServerDeletedAt.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.SuspendedAt != null)
                    hashCode = hashCode * 59 + this.SuspendedAt.GetHashCode();
                if (this.TeConstraints != null)
                    hashCode = hashCode * 59 + this.TeConstraints.GetHashCode();
                if (this.WorkingHoursInMinutes != null)
                    hashCode = hashCode * 59 + this.WorkingHoursInMinutes.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
