using Photo.Models.Common;
using Photo.Repository.Common;
using Photo.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.Service
{
   public class CategoryService : ICategoryService
    {
        protected ICategoryRepository CategoryRepository { get; private set; }

        public CategoryService(ICategoryRepository CategoryRepository)
        {
            this.CategoryRepository = CategoryRepository;
        }
        public void AddCategories(ICategory p)
        {
            CategoryRepository.Insert(p);
        }
        public IList<ICategory> GetAllCategories()
        {
            var category = CategoryRepository.Get();
            return category.ToList();
        }
        public void RemoveCategory(ICategory p)
        {
            CategoryRepository.Delete(p);
        }
        public void RenameCategory(ICategory p)
        {
            CategoryRepository.Update(p);
        }
        public IList<ICategory> GetFirst5Categories()
        {
            var categories = CategoryRepository.Get();
            return categories.ToList();
        }
    }
}
