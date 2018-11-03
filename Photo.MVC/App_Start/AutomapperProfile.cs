using AutoMapper;
using Photo.DAL.Entities;
using Photo.Models;
using Photo.Models.Common;
using Photo.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Photo.MVC.App_Start
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            
            CreateMap<CategoryEntity, Category>().ReverseMap();
            CreateMap<PhotoEntity, Photo.Models.Photo>().ReverseMap();
            CreateMap<CategoryEntity, ICategory>().ReverseMap();
            CreateMap<PhotoEntity, IPhoto>().ReverseMap();
            CreateMap<Category, ICategory>().ReverseMap();
            CreateMap<Photo.Models.Photo, IPhoto>().ReverseMap();
            CreateMap<FullPhotoViewModel, IPhoto>().ReverseMap();
            CreateMap<PhotoViewModel, IPhoto>().ReverseMap();
            CreateMap<CategoryViewModel, ICategory>().ReverseMap();


        }
    }
}