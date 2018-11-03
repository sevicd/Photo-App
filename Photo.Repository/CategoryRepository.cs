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
   public class CategoryRepository : ICategoryRepository
    {
        protected IGenericRepository Repository { get; set; }
        public CategoryRepository(IGenericRepository Repository)
        {
            this.Repository = Repository;
        }
        public void Delete(ICategory entity)
        {
            Repository.Delete(AutoMapper.Mapper.Map<CategoryEntity>(entity));
        }
        public IList<ICategory> Get()
        {
            return AutoMapper.Mapper.Map<List<ICategory>>(Repository.Get<CategoryEntity>());
        }
        public ICategory GetById(object id)
        {
            return AutoMapper.Mapper.Map<ICategory>(Repository.GetById<CategoryEntity>(id));
        }
        public void Insert(ICategory entity)
        {
            Repository.Insert<CategoryEntity>(AutoMapper.Mapper.Map<CategoryEntity>(entity));
        }
        public void Update(ICategory entity)
        {
            Repository.Update(AutoMapper.Mapper.Map<CategoryEntity>(entity));
        }
    }
}
