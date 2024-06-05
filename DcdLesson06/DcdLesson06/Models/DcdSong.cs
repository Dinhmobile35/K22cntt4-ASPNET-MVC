using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DcdLesson06.Models
{
    public class DcdSong
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Dcd: hãy nhập tiêu đề")]
        [DisplayName("tiêu đề")]
        public string DcdTitle { get; set; }
        [Required (ErrorMessage ="Dcd: hãy nhập tác giả ")]
        public string DcdAuthor { get; set; }
        [Required (ErrorMessage ="Dcd: hãy nhập nghệ sĩ ")]
        [StringLength (50,MinimumLength =2,ErrorMessage ="Dcd: tên nghệ sĩ tối thiêu 2 ký tự,tối đa 50 ")]
        [DisplayName("nghệ sĩ" )]
        public string DcdArtist { get; set; }
        [Required (ErrorMessage ="Dcd: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4} ",ErrorMessage ="Dcd:Năm xuất bản phải có 4 ký tự số") ]
        [Range(1900,2024,ErrorMessage ="Dcd: Năm xuất bản trong khoảng 1900-2024")]
        [DisplayName("năm xuất bản")]
        public int DcdYearRelease { get; set; }
    }
}