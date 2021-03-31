using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.AdminDtos
{
    public class AdminUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("E Posta")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Password { get; set; }

        [DisplayName("Güvenlik Sorusu")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SecurityQuestion { get; set; }

        [DisplayName("Güvenlik Sorusu Cevabı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SQAnswer { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
