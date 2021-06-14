using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Service.Dtos.SummaryDtos
{
    public class SummaryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [DisplayName("Özet Bilgisi")]
        [MinLength(200, ErrorMessage ="{0} alanı en az {1} karakter olmalıdır.")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
