using Photo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Service.Common
{
   public interface ICategoryService
    {
        void AddCategories(ICategory category);
        void RemoveCategory(ICategory category);
        void RenameCategory(ICategory category);
        IList<ICategory> GetAllCategories();
        IList<ICategory> GetFirst5Categories();

    }
}
