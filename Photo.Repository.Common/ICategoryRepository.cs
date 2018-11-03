using Photo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Repository.Common
{
   public interface ICategoryRepository
    {
        ICategory GetById(object id);
        void Insert(ICategory entity);
        void Update(ICategory entity);
        void Delete(ICategory entity);
        IList<ICategory> Get();
    }
}
