using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DcdLesson06CF.Models
{
    public class DcdCategory
    {
        [Key]
        public int DcdId { get; set; }
        public string DcdCategoryName { get; set; }
        //thuộc tính quan hệ 
        public virtual ICollection <DcdBook> DcdBooks { get; set; }
    }
}