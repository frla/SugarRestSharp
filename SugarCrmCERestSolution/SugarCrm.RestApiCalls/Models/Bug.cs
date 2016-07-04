// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarCrm.RestApiCalls.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the bugs table.
    /// </summary>
	[ModuleProperty(ModuleName = "Bugs", TableName="bugs")]
	public partial class Bug : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "description")]
		public virtual string Description { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "assigned_user_id")]
		public virtual string AssignedUserId { get; set; }

		[JsonProperty(PropertyName = "bug_number")]
		public virtual int BugNumber { get; set; }

		[JsonProperty(PropertyName = "type")]
		public virtual string Type { get; set; }

		[JsonProperty(PropertyName = "status")]
		public virtual string Status { get; set; }

		[JsonProperty(PropertyName = "priority")]
		public virtual string Priority { get; set; }

		[JsonProperty(PropertyName = "resolution")]
		public virtual string Resolution { get; set; }

		[JsonProperty(PropertyName = "work_log")]
		public virtual string WorkLog { get; set; }

		[JsonProperty(PropertyName = "found_in_release")]
		public virtual string FoundInRelease { get; set; }

		[JsonProperty(PropertyName = "fixed_in_release")]
		public virtual string FixedInRelease { get; set; }

		[JsonProperty(PropertyName = "source")]
		public virtual string Source { get; set; }

		[JsonProperty(PropertyName = "product_category")]
		public virtual string ProductCategory { get; set; }

	}
}