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
    /// A class which represents the emails table.
    /// </summary>
	[ModuleProperty(ModuleName = "Emails", TableName="emails")]
	public partial class Email : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "assigned_user_id")]
		public virtual string AssignedUserId { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "date_sent")]
		public virtual DateTime? DateSent { get; set; }

		[JsonProperty(PropertyName = "message_id")]
		public virtual string MessageId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "type")]
		public virtual string Type { get; set; }

		[JsonProperty(PropertyName = "status")]
		public virtual string Status { get; set; }

		[JsonProperty(PropertyName = "flagged")]
		public virtual sbyte? Flagged { get; set; }

		[JsonProperty(PropertyName = "reply_to_status")]
		public virtual sbyte? ReplyToStatus { get; set; }

		[JsonProperty(PropertyName = "intent")]
		public virtual string Intent { get; set; }

		[JsonProperty(PropertyName = "mailbox_id")]
		public virtual string MailboxId { get; set; }

		[JsonProperty(PropertyName = "parent_type")]
		public virtual string ParentType { get; set; }

		[JsonProperty(PropertyName = "parent_id")]
		public virtual string ParentId { get; set; }

	}
}