using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.SkillsDtos
{
    public class SkillsAddDto
    {
        [DisplayName("Yetenek")]
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [MaxLength(25, ErrorMessage ="{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }

        [DisplayName("Yetenek Yüzdesi")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Range(0,100, ErrorMessage ="{0} alanının değeri {1} ile {2} arasında olmalıdır.")]
        public int PercentageValue { get; set; }
    }
}
