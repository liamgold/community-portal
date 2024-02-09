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

namespace Kentico.Community.Portal.Core.Content
{
	/// <summary>
	/// Represents a content item of type <see cref="MediaAssetContent"/>.
	/// </summary>
	public partial class MediaAssetContent : IContentItemFieldsSource
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.MediaAssetContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// MediaAssetContentTitle.
		/// </summary>
		public string MediaAssetContentTitle { get; set; }


		/// <summary>
		/// MediaAssetContentShortDescription.
		/// </summary>
		public string MediaAssetContentShortDescription { get; set; }


		/// <summary>
		/// MediaAssetContentAsset.
		/// </summary>
		public ContentItemAsset MediaAssetContentAsset { get; set; }


		/// <summary>
		/// MediaAssetContentImageWidth.
		/// </summary>
		public int MediaAssetContentImageWidth { get; set; }


		/// <summary>
		/// MediaAssetContentImageHeight.
		/// </summary>
		public int MediaAssetContentImageHeight { get; set; }
	}
}