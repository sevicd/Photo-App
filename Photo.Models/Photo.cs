﻿using Photo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Models
{
   public class Photo : IPhoto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public DateTime CreatedTime { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryID { get; set; }
    }
}