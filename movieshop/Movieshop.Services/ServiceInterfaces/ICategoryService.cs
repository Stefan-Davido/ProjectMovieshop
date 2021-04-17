namespace Movieshop.Services.ServiceInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface ICategoryService
    {
        void Add(Category category);
        void Edit(Category category);
        void Delete(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
    }
}
