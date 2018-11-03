using Photo.DAL.Entities;
using Photo.Models.Common;
using Photo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Repository
{
   public  class PhotoRepository : IPhotoRepository
    {
        protected IGenericRepository  Repository { get; set; }
        public PhotoRepository(IGenericRepository Repository)
        {
            this.Repository = Repository;
        }
        public void Delete(IPhoto entity)
        {
            Repository.Delete(AutoMapper.Mapper.Map<PhotoEntity>(entity));
        }
        public IList<IPhoto> Get()
        {
            return AutoMapper.Mapper.Map<List<IPhoto>>(Repository.Get<PhotoEntity>());
        }
        public IPhoto GetById(object id)
        {
            return AutoMapper.Mapper.Map<IPhoto>(Repository.GetById<PhotoEntity>(id));
        }
        public void Insert(IPhoto entity)
        {
            Repository.Insert <PhotoEntity>(AutoMapper.Mapper.Map<PhotoEntity>(entity));
        }
        public void Update(IPhoto entity)
        {
            Repository.Update(AutoMapper.Mapper.Map<PhotoEntity>(entity));
        }

    }
}
