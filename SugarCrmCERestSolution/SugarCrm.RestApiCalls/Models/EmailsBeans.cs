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
    /// A class which represents the emails_beans table.
    /// </summary>
	[ModuleProperty(ModuleName = "EmailsBeans", TableName="emails_beans")]
	public partial class EmailsBeans : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "email_id")]
		public virtual string EmailId { get; set; }

		[JsonProperty(PropertyName = "bean_id")]
		public virtual string BeanId { get; set; }

		[JsonProperty(PropertyName = "bean_module")]
		public virtual string BeanModule { get; set; }

		[JsonProperty(PropertyName = "campaign_data")]
		public virtual string CampaignData { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

	}
}