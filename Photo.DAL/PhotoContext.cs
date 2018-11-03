using Photo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo.DAL
{
    public class PhotoContext : DbContext, IPhotoContext
    {
        public DbSet<PhotoEntity> Photos { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
        public new DbEntityEntry Entry<T>(T entity) where T : class
        {
            return base.Entry(entity);
        }
        public void SetModified<T>(T entity) where T : class
        {
            Entry(entity).State = EntityState.Modified;
        }
        public PhotoContext() : base("name=DefaultConnection")
        {

        }
    }
}
