using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.AccountsDtos
{
    public class AccountsAddDto
    {
        [DisplayName("Sosyal Medya Hesapları")]
        [Required(ErrorMessage ="{0} zorunludur.")]
        [MaxLength(30, ErrorMessage ="{0} alanı en fazla 30 karaketer uzunluğunda olabilir.")]
        public string Account { get; set; }

        [DisplayName("Sosyal Medya Hesap İkonu")]
        [Required(ErrorMessage = "{0} zorunludur.")]
        [MaxLength(120, ErrorMessage = "{0} alanı en fazla 120 karaketer uzunluğunda olabilir.")]
        public string AccountFA { get; set; }

        [DisplayName("Sosyal Medya Hesap Linki")]
        [Required(ErrorMessage = "{0} zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla 150 karaketer uzunluğunda olabilir.")]
        public string AccountURL { get; set; }
    }
}
