using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.SlidersDtos
{
    public class SlidersUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karaketer uzunluğunda olabilir.")]
        public string Title { get; set; }

        [DisplayName("Kısa İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1} karaketer uzunluğunda olabilir.")]
        public string ShortContent { get; set; }

        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
