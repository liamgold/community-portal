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
	/// Represents a content item of type <see cref="ContactDetailsContent"/>.
	/// </summary>
	public partial class ContactDetailsContent : IContentItemFieldsSource
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.ContactDetailsContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// ContactDetailsContentTitle.
		/// </summary>
		public string ContactDetailsContentTitle { get; set; }


		/// <summary>
		/// ContactDetailsContentPhoneNumber.
		/// </summary>
		public string ContactDetailsContentPhoneNumber { get; set; }


		/// <summary>
		/// ContactDetailsContentEmailAddress.
		/// </summary>
		public string ContactDetailsContentEmailAddress { get; set; }
	}
}