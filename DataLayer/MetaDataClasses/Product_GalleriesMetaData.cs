﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Product_GalleriesMetaData
    {
        [Key]
        public int GalleryID { get; set; }

        [Display(Name = "کالا")]
        public int ProductID { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }
    }
}