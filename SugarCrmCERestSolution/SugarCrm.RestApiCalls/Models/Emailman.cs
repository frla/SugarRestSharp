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
    /// A class which represents the emailman table.
    /// </summary>
	[ModuleProperty(ModuleName = "Emailman", TableName="emailman")]
	public partial class Emailman : EntityBase
	{
		[JsonProperty(PropertyName = "date_entered")]
		public virtual DateTime? DateEntered { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "user_id")]
		public virtual string UserId { get; set; }

		[JsonProperty(PropertyName = "id")]
		public virtual int Id { get; set; }

		[JsonProperty(PropertyName = "campaign_id")]
		public virtual string CampaignId { get; set; }

		[JsonProperty(PropertyName = "marketing_id")]
		public virtual string MarketingId { get; set; }

		[JsonProperty(PropertyName = "list_id")]
		public virtual string ListId { get; set; }

		[JsonProperty(PropertyName = "send_date_time")]
		public virtual DateTime? SendDateTime { get; set; }

		[JsonProperty(PropertyName = "modified_user_id")]
		public virtual string ModifiedUserId { get; set; }

		[JsonProperty(PropertyName = "in_queue")]
		public virtual sbyte? InQueue { get; set; }

		[JsonProperty(PropertyName = "in_queue_date")]
		public virtual DateTime? InQueueDate { get; set; }

		[JsonProperty(PropertyName = "send_attempts")]
		public virtual int? SendAttempts { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

		[JsonProperty(PropertyName = "related_id")]
		public virtual string RelatedId { get; set; }

		[JsonProperty(PropertyName = "related_type")]
		public virtual string RelatedType { get; set; }

	}
}