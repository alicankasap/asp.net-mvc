//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonelMVCUI.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Personel
    {
        public int Id { get; set; }
        [Display(Name = "Departman Ad?")]
        [Required(ErrorMessage = "Departman ad?n? bo? b?rakamazs?n?z.")]
        public Nullable<int> DepartmanId { get; set; }
        [Required(ErrorMessage = "Ad? bo? b?rakamazs?n?z.")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad? bo? b?rakamazs?n?z.")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Maa?? bo? b?rakamazs?n?z.")]
        [Range(4253, 1000000, ErrorMessage = "Maa? asgari ?cretten d???k olamaz.")]
        public Nullable<short> Maas { get; set; }
        [Display(Name = "Do?um Tarihi")]
        [Required(ErrorMessage = "Do?um tarihini bo? b?rakamazs?n?z.")]
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        [Required(ErrorMessage = "Cinsiyeti bo? b?rakamazs?n?z.")]
        public bool Cinsiyet { get; set; }
        public bool EvliMi { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
