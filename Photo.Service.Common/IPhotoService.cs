using Photo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Photo.Service.Common
{
    public interface IPhotoService
    {
        void AddPhoto(IPhoto photo, HttpPostedFileBase main);
        void RemovePhoto(IPhoto photo);
        void RenamePhoto(IPhoto photo);
        IList<IPhoto> GetAllPhotos();

    }
}