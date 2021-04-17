namespace Movieshop.Repository.RepositoryInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
    }
}
