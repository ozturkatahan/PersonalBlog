using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalBlog.Entities.Dtos.ArticlesDtos
{
    public class ArticlesAddDto
    {

        [DisplayName("Makale Başlığı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }


        [DisplayName("Kısa İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ShortContent { get; set; }


        [DisplayName("Makale Yazısı")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Content { get; set; }


        [DisplayName("Makale Resmi")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Thumbnail { get; set; }


        [DisplayName("SEO Anahtar Kelimeleri")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SeoTags { get; set; }


        [DisplayName("SEO Açıklaması")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SeoDescription { get; set; }


        [DisplayName("Kategori Id")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public int CategoryId { get; set; }
        
    }
}
