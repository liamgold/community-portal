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
	/// Represents a content item of type <see cref="AuthorContent"/>.
	/// </summary>
	public partial class AuthorContent : IContentItemFieldsSource
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.AuthorContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// AuthorContentPhotoMediaFileImage.
		/// </summary>
		public IEnumerable<AssetRelatedItem> AuthorContentPhotoMediaFileImage { get; set; }


		/// <summary>
		/// AuthorContentFirstName.
		/// </summary>
		public string AuthorContentFirstName { get; set; }


		/// <summary>
		/// AuthorContentSurname.
		/// </summary>
		public string AuthorContentSurname { get; set; }


		/// <summary>
		/// AuthorContentCodeName.
		/// </summary>
		public string AuthorContentCodeName { get; set; }


		/// <summary>
		/// AuthorContentMemberID.
		/// </summary>
		public int AuthorContentMemberID { get; set; }


		/// <summary>
		/// AuthorContentBiographyHTML.
		/// </summary>
		public string AuthorContentBiographyHTML { get; set; }
	}
}