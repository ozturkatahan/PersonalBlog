using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.AboutMeDtos
{
    public class AboutMeUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string LastName { get; set; }

        [DisplayName("Profil Fotoğrafı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ImagePath { get; set; }

        [DisplayName("Meslek")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(60, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string MyJob { get; set; }

        [DisplayName("Meslek İkonu")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string MyJobFA { get; set; }

        [DisplayName("Doğum Tarihi")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Özgeçmiş Dosyası")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string MyCVPath { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
