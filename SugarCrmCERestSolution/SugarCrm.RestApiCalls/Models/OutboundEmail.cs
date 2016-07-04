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
    /// A class which represents the outbound_email table.
    /// </summary>
	[ModuleProperty(ModuleName = "OutboundEmail", TableName="outbound_email")]
	public partial class OutboundEmail : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "type")]
		public virtual string Type { get; set; }

		[JsonProperty(PropertyName = "user_id")]
		public virtual string UserId { get; set; }

		[JsonProperty(PropertyName = "mail_sendtype")]
		public virtual string MailSendtype { get; set; }

		[JsonProperty(PropertyName = "mail_smtptype")]
		public virtual string MailSmtptype { get; set; }

		[JsonProperty(PropertyName = "mail_smtpserver")]
		public virtual string MailSmtpserver { get; set; }

		[JsonProperty(PropertyName = "mail_smtpport")]
		public virtual int? MailSmtpport { get; set; }

		[JsonProperty(PropertyName = "mail_smtpuser")]
		public virtual string MailSmtpuser { get; set; }

		[JsonProperty(PropertyName = "mail_smtppass")]
		public virtual string MailSmtppass { get; set; }

		[JsonProperty(PropertyName = "mail_smtpauth_req")]
		public virtual sbyte? MailSmtpauthReq { get; set; }

		[JsonProperty(PropertyName = "mail_smtpssl")]
		public virtual int? MailSmtpssl { get; set; }

	}
}