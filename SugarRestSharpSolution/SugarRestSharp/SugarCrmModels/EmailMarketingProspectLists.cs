// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarRestSharp.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the email_marketing_prospect_lists table.
    /// </summary>
	[ModuleProperty(ModuleName = "EmailMarketingProspectLists", TableName="email_marketing_prospect_lists")]
	public partial class EmailMarketingProspectLists : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "prospect_list_id")]
		public virtual string ProspectListId { get; set; }

		[JsonProperty(PropertyName = "email_marketing_id")]
		public virtual string EmailMarketingId { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

	}
}