using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.AccountsDtos
{
    public class AccountsUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Sosyal Medya Hesapları")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karaketer uzunluğunda olabilir.")]
        public string Account { get; set; }

        [DisplayName("Sosyal Medya Hesap İkonu")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(120, ErrorMessage = "{0} alanı en fazla {1} karaketer uzunluğunda olabilir.")]
        public string AccountFA { get; set; }

        [DisplayName("Sosyal Medya Hesap Linki")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karaketer uzunluğunda olabilir.")]
        public string AccountURL { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Aktif yapmak istiyor musunuz?")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Silinsin mi?")]
        public bool IsDeleted { get; set; }
    }
}
