using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.ExperiencesDtos
{
    public class ExperiencesAddDto
    {
        [DisplayName("Deneyim Başlığı")]
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage ="{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }

        [DisplayName("Deneyim Yeri")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string WorkPlace { get; set; }

        [DisplayName("Çalışma Süresi")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Duration { get; set; }

        [DisplayName("Deneyim Açıklaması")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(300, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Description { get; set; }
    }
}
