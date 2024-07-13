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
using CMS.Websites;

namespace Kentico.Community.Portal.Core.Content
{
	/// <summary>
	/// Represents a page of type <see cref="CommunityLandingPage"/>.
	/// </summary>
	[RegisterContentTypeMapping(CONTENT_TYPE_NAME)]
	public partial class CommunityLandingPage : IWebPageFieldsSource, IWebPageMeta
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.CommunityLandingPage";


		/// <summary>
		/// Represents system properties for a web page item.
		/// </summary>
		[SystemField]
		public WebPageFields SystemFields { get; set; }


		/// <summary>
		/// CommunityLandingPageTitle.
		/// </summary>
		public string CommunityLandingPageTitle { get; set; }


		/// <summary>
		/// CommunityLandingPageShortDescription.
		/// </summary>
		public string CommunityLandingPageShortDescription { get; set; }


		/// <summary>
		/// WebPageMetaTitle.
		/// </summary>
		public string WebPageMetaTitle { get; set; }


		/// <summary>
		/// WebPageMetaDescription.
		/// </summary>
		public string WebPageMetaDescription { get; set; }


		/// <summary>
		/// WebPageMetaExcludeFromSitemap.
		/// </summary>
		public bool WebPageMetaExcludeFromSitemap { get; set; }


		/// <summary>
		/// WebPageMetaRobots.
		/// </summary>
		public string WebPageMetaRobots { get; set; }


		/// <summary>
		/// WebPageCanonicalURL.
		/// </summary>
		public string WebPageCanonicalURL { get; set; }
	}
}