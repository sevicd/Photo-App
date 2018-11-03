using Photo.Models.Common;
using Photo.Repository;
using Photo.Repository.Common;
using Photo.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace Photo.Service
{
    public class PhotoService : IPhotoService
    {
        protected IPhotoRepository PhotoRepository { get; private set; }

        public PhotoService(IPhotoRepository PhotoRepository)
        {
            this.PhotoRepository = PhotoRepository;
        }

        public void AddPhoto(IPhoto p, HttpPostedFileBase main)
        {
            var Photo = p;
            if (main == null)
            {
                Photo.ImgUrl = "default.png";
            }
            else
            {
                var name_without_extt = Path.GetFileNameWithoutExtension(main.FileName);
                var ext = Path.GetExtension(main.FileName);
                Photo.ImgUrl = name_without_extt + DateTime.Now.ToString("MMddyyHmmss") + ext;
                var path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Images/"), Photo.ImgUrl);
                main.SaveAs(path);
            }
            PhotoRepository.Insert(p);
        }
        public IList<IPhoto> GetAllPhotos()
        {
            var photos = PhotoRepository.Get();
            return photos.ToList();
        }
        public void RemovePhoto(IPhoto p)
        {
            PhotoRepository.Delete(p);
        }
        public void RenamePhoto(IPhoto p)
        {
            PhotoRepository.Update(p);
        }


    }
}
