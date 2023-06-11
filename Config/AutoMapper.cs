﻿using AutoMapper;
using BikeStoresApi.Dtos;
using BikeStoresApi.Models;

namespace BikeStoresApi.Config
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, AddCategoryDto>().ReverseMap();
        }
    }
}
