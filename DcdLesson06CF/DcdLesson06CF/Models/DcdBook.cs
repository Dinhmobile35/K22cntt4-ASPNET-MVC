using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcdLesson06CF.Models
{
    public class DcdBook
    {
        public int DcdId {get; set;}
        public string DcdTitle { get; set; }
        public string DcdAuthor { get; set; }
        public int DcdYear { get; set; }
        public string DcdPulisher  { get; set; }
        public string DcdPicture { get; set; }
        public int DcdCategoryId { get; set; }
        //thuộc tính quan hệ 
        public virtual DcdCategory DcdCategory { get; set; }
    }
}