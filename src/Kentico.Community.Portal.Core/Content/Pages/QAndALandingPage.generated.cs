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
using CMS.Websites;

namespace Kentico.Community.Portal.Core.Content
{
	/// <summary>
	/// Represents a page of type <see cref="QAndALandingPage"/>.
	/// </summary>
	public partial class QAndALandingPage : IWebPageFieldsSource, IWebPageMeta
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.QAndALandingPage";


		/// <summary>
		/// Represents system properties for a web page item.
		/// </summary>
		public WebPageFields SystemFields { get; set; }


		/// <summary>
		/// QAndALandingPageTitle.
		/// </summary>
		public string QAndALandingPageTitle { get; set; }


		/// <summary>
		/// QAndALandingPageShortDescription.
		/// </summary>
		public string QAndALandingPageShortDescription { get; set; }


		/// <summary>
		/// QAndALandingPageMarkdownFormHelpMessageHTML.
		/// </summary>
		public string QAndALandingPageMarkdownFormHelpMessageHTML { get; set; }


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
	}
}