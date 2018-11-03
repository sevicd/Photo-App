using Photo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Photo.MVC.ViewModels
{
    public class FullCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<IPhoto> Photos { get; set; }
    }
}