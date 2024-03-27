//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS.ContentEngine;
using CMS.MediaLibrary;

namespace Kentico.Community.Portal.Core.Content
{
	/// <summary>
	/// Represents a content item of type <see cref="IntegrationContent"/>.
	/// </summary>
	[RegisterContentTypeMapping(CONTENT_TYPE_NAME)]
	public partial class IntegrationContent : IContentItemFieldsSource
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.IntegrationContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		[SystemField]
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// IntegrationContentTitle.
		/// </summary>
		public string IntegrationContentTitle { get; set; }


		/// <summary>
		/// IntegrationContentLogoMediaFile.
		/// </summary>
		public IEnumerable<AssetRelatedItem> IntegrationContentLogoMediaFile { get; set; }


		/// <summary>
		/// IntegrationContentShortDescription.
		/// </summary>
		public string IntegrationContentShortDescription { get; set; }


		/// <summary>
		/// IntegrationContentRepositoryLinkURL.
		/// </summary>
		public string IntegrationContentRepositoryLinkURL { get; set; }


		/// <summary>
		/// IntegrationContentLibraryLinkURL.
		/// </summary>
		public string IntegrationContentLibraryLinkURL { get; set; }


		/// <summary>
		/// IntegrationContentType.
		/// </summary>
		public string IntegrationContentType { get; set; }


		/// <summary>
		/// IntegrationContentAuthorName.
		/// </summary>
		public string IntegrationContentAuthorName { get; set; }


		/// <summary>
		/// IntegrationContentAuthorLinkURL.
		/// </summary>
		public string IntegrationContentAuthorLinkURL { get; set; }
	}
}