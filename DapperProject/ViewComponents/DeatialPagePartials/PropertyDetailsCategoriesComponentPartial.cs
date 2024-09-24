﻿using DapperProject.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents.DeatialPagePartials
{
    public class PropertyDetailsCategoriesComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public PropertyDetailsCategoriesComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetCategoryWithCount();
            return View(values);
        }
    }
}
