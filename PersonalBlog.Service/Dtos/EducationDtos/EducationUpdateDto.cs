using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Service.Dtos.EducationDtos
{
    public class EducationUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Başlık(Eğitim)")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }

        [DisplayName("Okul Adı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SchoolName { get; set; }

        [DisplayName("Eğitim Süresi")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Duration { get; set; }

        [DisplayName("Eğitim Açıklaması")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
