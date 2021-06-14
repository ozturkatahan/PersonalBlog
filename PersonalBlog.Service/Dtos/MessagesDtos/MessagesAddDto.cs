using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Service.Dtos.MessagesDtos
{
    public class MessagesAddDto
    {

        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string FirstName { get; set; }


        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(25, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string LastName { get; set; }


        [DisplayName("E Posta")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Email { get; set; }


        [DisplayName("Konu")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Subject { get; set; }


        [DisplayName("Mesajınız")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(512, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Text { get; set; }
    }
}
