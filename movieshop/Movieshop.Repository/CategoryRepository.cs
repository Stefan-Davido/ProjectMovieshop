namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;

        public CategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddCategory(Category category)
        {
            _dataContext.Category.Add(category);
            _dataContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            Category category = GetCategoryById(categoryId);
            _dataContext.Category.Remove(category);
            _dataContext.SaveChanges();
        }

        public void EditCategory(Category category)
        {
            _dataContext.Category.Update(category);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var result = _dataContext.Category.AsEnumerable();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = _dataContext.Category.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
