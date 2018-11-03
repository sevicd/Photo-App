using Photo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Repository.Common
{
   public interface IPhotoRepository
    {
        IPhoto GetById(object id);
        void Insert(IPhoto entity);
        void Update(IPhoto entity);
        void Delete(IPhoto entity);
        IList<IPhoto> Get();
    }
}
