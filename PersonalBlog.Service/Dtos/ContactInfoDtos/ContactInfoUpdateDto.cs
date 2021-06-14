using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Service.Dtos.ContactInfoDtos
{
    public class ContactInfoUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]   
        public string PhoneNumber { get; set; }

        [DisplayName("E Posta")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Email { get; set; }


        [DisplayName("Başlık(Eğitim)")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ShortAdress { get; set; }


        [DisplayName("Başlık(Eğitim)")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
