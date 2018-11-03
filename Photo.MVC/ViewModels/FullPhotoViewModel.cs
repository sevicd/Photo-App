using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Photo.MVC.ViewModels
{
    public class FullPhotoViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public DateTime CreatedTime { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryID { get; set; }

        public IEnumerable<SelectListItem> Items { get; set; }
        public int[] SelectedID { get; set; }
    }
}