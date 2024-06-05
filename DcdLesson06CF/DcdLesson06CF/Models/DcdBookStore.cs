using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DcdLesson06CF.Models
{
    public class DcdBookStore:DbContext
    {
        public DcdBookStore():base() { }

        //khai báo các thuộc tính tương ứng với các bảng csdl 
        public DbSet<DcdCategory> DcdCategories { get; set; }
        public DbSet<DcdBook> DcdBooks { get; set; }
    }
}