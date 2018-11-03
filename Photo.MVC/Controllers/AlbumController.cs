using Photo.DAL.Entities;
using Photo.Models;
using Photo.Models.Common;
using Photo.MVC.ViewModels;
using Photo.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Photo.MVC.Controllers
{
    public class AlbumController : Controller
    {
        private ICategoryService CategoryService;
        private IPhotoService PhotoService;

        public AlbumController(ICategoryService CategoryService,
            IPhotoService PhotoService)
        {
            this.CategoryService = CategoryService;
            this.PhotoService = PhotoService;
        }

        // GET: Album
        public ActionResult Index()
        {
            var albumi = CategoryService.GetAllCategories();
            var lista2 = AutoMapper.Mapper.Map<List<FullCategoryViewModel>>(albumi);
            return View(lista2);
        }

        public ActionResult Delete(int id = 0)
        {
            CategoryService.RemoveCategory(CategoryService.GetAllCategories().FirstOrDefault(p => p.Id == id));

            return RedirectToAction("Index");
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(FullCategoryViewModel a)
        {
            CategoryService.AddCategories(AutoMapper.Mapper.Map<Category>(a));
            return RedirectToAction("Index");
        }


    }
}