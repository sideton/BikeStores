﻿using BikeStoresApi.Dtos;
using BikeStoresApi.Models;

namespace BikeStoresApi.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<GetCategoryDto>>> GetCategories();
        Task<ServiceResponse<GetCategoryDto>> GetCategoryById(long id);
        Task<ServiceResponse<List<GetCategoryDto>>> AddCategory(AddCategoryDto newCategory);
    }
}
