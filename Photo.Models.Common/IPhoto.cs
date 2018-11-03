using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Models.Common
{
   public interface IPhoto
    {
        int Id { get; set; }
        string Description { get; set; }
        string Tags { get; set; }
        DateTime CreatedTime { get; set; }
        string ImgUrl { get; set; }
        int CategoryID { get; set; }
    }
}
