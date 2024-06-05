using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DcdLesson06.Models;

namespace DcdLesson06.Controllers
{
    public class DcdSongController : Controller
    {
        private static List<DcdSong> dcdSongs = new List<DcdSong>() 
        { 
            new DcdSong{Id=221090095,DcdTitle="Đinh Công Định",DcdAuthor="K22CNT4",DcdArtist="NTU",DcdYearRelease=2022 },
             new DcdSong{Id=221090096,DcdTitle="Đinh Công Định",DcdAuthor="K22CNT4",DcdArtist="NTU",DcdYearRelease=2022 }
        };
        // GET: DcdSong
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Author :Đinh Công Định 
        /// </summary>
        /// <returns></returns>
        public ActionResult DcdIndex()
        {
            return View(dcdSongs);
        }
        //Get : DcdCreate 
        /// <summary>
        /// Thêm mới bài hát
        /// Author :Đinh Công Định 
        /// </summary>
        /// <returns></returns>
        public ActionResult DcdCreate()
        {
            var dcdSong = new DcdSong();
            return View(dcdSong);
        }
    }
}