using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.InterestsDtos
{
    public class InterestsUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("İlgi Alanı")]
        [MaxLength(300, ErrorMessage = "{0} en fazla 300 karakter olmalıdır.")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
