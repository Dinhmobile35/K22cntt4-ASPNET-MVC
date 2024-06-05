using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DcdLab5.Models
{
    public class DcdMember
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "hãy nhập mã số")]
        [DataType(DataType.Currency)]

        public string DcdUserName { get; set; }
        [Required(ErrorMessage = "hãy nhập tên đăng nhập ")]

        public string DcdFullName { get; set; }
        [Required(ErrorMessage = "hãy nhập họ và tên ")]

        public string DcdPassword { get; set; }
        [Required(ErrorMessage = "hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public int? DcdAge { get; set; }
        [Required(ErrorMessage = "hãy nhập tuổi")]
        [Range(18, 50, ErrorMessage = "tuổi từ 18-50")]

        public string DcdEmail { get; set; }


    }
}