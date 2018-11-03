using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Models.Common
{
   public interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        ICollection<IPhoto> Photos { get; set; }
    }
}
