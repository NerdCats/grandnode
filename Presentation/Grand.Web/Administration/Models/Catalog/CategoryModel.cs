﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using Grand.Admin.Models.Customers;
using Grand.Admin.Models.Discounts;
using Grand.Admin.Models.Stores;
using Grand.Admin.Validators.Catalog;
using Grand.Web.Framework;
using Grand.Web.Framework.Localization;
using Grand.Web.Framework.Mvc;
using System;

namespace Grand.Admin.Models.Catalog
{
    [Validator(typeof(CategoryValidator))]
    public partial class CategoryModel : BaseNopEntityModel, ILocalizedModel<CategoryLocalizedModel>
    {
        public CategoryModel()
        {
            if (PageSize < 1)
            {
                PageSize = 5;
            }
            Locales = new List<CategoryLocalizedModel>();
            AvailableCategoryTemplates = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
        }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Description")]
        [AllowHtml]
        public string Description { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.CategoryTemplate")]
        public string CategoryTemplateId { get; set; }
        public IList<SelectListItem> AvailableCategoryTemplates { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Parent")]
        public string ParentCategoryId { get; set; }

        [UIHint("Picture")]
        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Picture")]
        public string PictureId { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.PageSize")]
        public int PageSize { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.PriceRanges")]
        [AllowHtml]
        public string PriceRanges { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.IncludeInTopMenu")]
        public bool IncludeInTopMenu { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Published")]
        public bool Published { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Deleted")]
        public bool Deleted { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
        
        public IList<CategoryLocalizedModel> Locales { get; set; }

        public string Breadcrumb { get; set; }

        //ACL
        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }


        public IList<SelectListItem> AvailableCategories { get; set; }


        //discounts
        public List<DiscountModel> AvailableDiscounts { get; set; }
        public string[] SelectedDiscountIds { get; set; }


        #region Nested classes

        public partial class CategoryProductModel : BaseNopEntityModel
        {
            public string CategoryId { get; set; }

            public string ProductId { get; set; }

            [GrandResourceDisplayName("Admin.Catalog.Categories.Products.Fields.Product")]
            public string ProductName { get; set; }

            [GrandResourceDisplayName("Admin.Catalog.Categories.Products.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [GrandResourceDisplayName("Admin.Catalog.Categories.Products.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class AddCategoryProductModel : BaseGrandModel
        {
            public AddCategoryProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [GrandResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
            [AllowHtml]
            public string SearchProductName { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public string CategoryId { get; set; }

            public string[] SelectedProductIds { get; set; }
        }

        public partial class ActivityLogModel : BaseNopEntityModel
        {
            [GrandResourceDisplayName("Admin.Catalog.Categories.ActivityLogType")]
            public string ActivityLogTypeName { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Categories.ActivityLog.Comment")]
            public string Comment { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Categories.ActivityLog.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [GrandResourceDisplayName("Admin.Catalog.Categories.ActivityLog.Customer")]
            public string CustomerId { get; set; }
            public string CustomerEmail { get; set; }
        }


        #endregion
    }

    public partial class CategoryLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.Description")]
        [AllowHtml]
        public string Description {get;set;}

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.MetaKeywords")]
        [AllowHtml]
        public string MetaKeywords { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.MetaDescription")]
        [AllowHtml]
        public string MetaDescription { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.MetaTitle")]
        [AllowHtml]
        public string MetaTitle { get; set; }

        [GrandResourceDisplayName("Admin.Catalog.Categories.Fields.SeName")]
        [AllowHtml]
        public string SeName { get; set; }
    }

}