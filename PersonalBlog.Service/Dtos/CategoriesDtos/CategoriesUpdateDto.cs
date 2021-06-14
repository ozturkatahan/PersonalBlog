using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Service.Dtos.CategoriesDtos
{
    public class CategoriesUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Name { get; set; }

        [DisplayName("Kategori İkon")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string CategoryFA { get; set; }


        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(2000, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
