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
    /// A class which represents the folders table.
    /// </summary>
	[ModuleProperty(ModuleName = "Folders", TableName="folders")]
	public partial class Folder : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "name")]
		public virtual string Name { get; set; }

		[JsonProperty(PropertyName = "folder_type")]
		public virtual string FolderType { get; set; }

		[JsonProperty(PropertyName = "parent_folder")]
		public virtual string ParentFolder { get; set; }

		[JsonProperty(PropertyName = "has_child")]
		public virtual sbyte? HasChild { get; set; }

		[JsonProperty(PropertyName = "is_group")]
		public virtual sbyte? IsGroup { get; set; }

		[JsonProperty(PropertyName = "is_dynamic")]
		public virtual sbyte? IsDynamic { get; set; }

		[JsonProperty(PropertyName = "dynamic_query")]
		public virtual string DynamicQuery { get; set; }

		[JsonProperty(PropertyName = "assign_to_id")]
		public virtual string AssignToId { get; set; }

		[JsonProperty(PropertyName = "created_by")]
		public virtual string CreatedBy { get; set; }

		[JsonProperty(PropertyName = "modified_by")]
		public virtual string ModifiedBy { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

	}
}