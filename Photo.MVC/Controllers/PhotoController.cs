using Photo.Models.Common;
using Photo.MVC.ViewModels;
using Photo.Service.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Photo.MVC.Controllers
{
    public class PhotoController : Controller
    {

        private ICategoryService CategoryService;
        private IPhotoService PhotoService;
        
        public PhotoController (ICategoryService CategoryService,
            IPhotoService PhotoService)
        {
            this.CategoryService = CategoryService;
            this.PhotoService = PhotoService;
        }
        //get
        public ActionResult Add()
        {
            FullPhotoViewModel qwe = new FullPhotoViewModel();
            qwe.Items = CategoryService.GetAllCategories().
                Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });
            return View(qwe);
        }
        //post
        [HttpPost]
        public ActionResult Add2(FullPhotoViewModel qwe, HttpPostedFileBase main)
        {
            qwe.CategoryID = qwe.SelectedID.ElementAt(0);
            qwe.CreatedTime = DateTime.Now;
            PhotoService.AddPhoto(AutoMapper.Mapper.Map<IPhoto>(qwe),main);
            return RedirectToAction("ShowAllPhotos",new { id= qwe.CategoryID});
        }
        public ActionResult ShowAllPhotos(int id)
        {
            var lista = PhotoService.GetAllPhotos().Where(x=>x.CategoryID==id);
            var lista2 = AutoMapper.Mapper.Map<List<PhotoViewModel>>(lista);
            return View(lista2);

        }

        [HttpPost]
        public ActionResult ShowAllPhotos(FormCollection x)
        {
            //var lista = PhotoService.GetAllPhotos();
            //var lista2 = AutoMapper.Mapper.Map<List<PhotoViewModel>>(lista);
            //return View(lista2);

            using (StreamWriter _testData = new StreamWriter(Server.MapPath("~/data.txt"), false))
            {
                foreach(var file in x.AllKeys)
                _testData.WriteLine(file); 
            }
            return View("Finish");
        }

   
        //public ActionResult AddCategory()
        //{
        //    return View();
        //}
        //TREBA VIEW DODATI ->
        //[HttpPost]
        //public ActionResult AddCategory(FullCategoryViewModel category)
        //{
        //    CategoryService.AddCategories(AutoMapper.Mapper.Map<ICategory>(category));
        //    return View();
        //}
        //public ActionResult ShowAllCategories()
        //{
        //    var lista = CategoryService.GetAllCategories();
        //    var lista2 = AutoMapper.Mapper.Map<List<CategoryViewModel>>(lista);
        //    return View(lista2);
        //}

        //// GET: Photo
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}