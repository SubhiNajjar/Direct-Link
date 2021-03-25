//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.11.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Contact</summary>
	[PublishedModel("contact")]
	public partial class Contact : PublishedContentModel, IContactFormControls, IMainImageControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const string ModelTypeAlias = "contact";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Contact(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Error Message: Enter the message to show on error
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("errorMessage")]
		public global::System.Web.IHtmlString ErrorMessage => global::Umbraco.Web.PublishedModels.ContactFormControls.GetErrorMessage(this);

		///<summary>
		/// Success Message: Enter the message to show on success
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("successMessage")]
		public global::System.Web.IHtmlString SuccessMessage => global::Umbraco.Web.PublishedModels.ContactFormControls.GetSuccessMessage(this);

		///<summary>
		/// Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("cardImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent CardImage => global::Umbraco.Web.PublishedModels.MainImageControls.GetCardImage(this);

		///<summary>
		/// Main Image: Choose the main Image for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("mainImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent MainImage => global::Umbraco.Web.PublishedModels.MainImageControls.GetMainImage(this);
	}
}
