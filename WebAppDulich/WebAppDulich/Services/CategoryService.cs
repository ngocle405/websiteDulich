using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.Category;
using WebAppDulich.Data;
using WebAppDulich.Models;

namespace WebAppDulich.Services
{

    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        IEnumerable<CategoryViewModel> GetEdit(long id);

        int Create(CategoryRequest request);

        object Detail(long id);

        CategoryRequest Edit(long id);

        int Update(CategoryRequest request);

        int Delete(long id);
    }
    public class CategoryService : ICategoryService
    {
        private readonly TravelContext _travelContext;

        public CategoryService(TravelContext travelContext)
        {
            _travelContext = travelContext;
        }
        public int Create(CategoryRequest request)
        {
            try
            {
                Category category = new Category()
                {
                    Name = request.Name,
                    Description = request.Description,
                    ParentId = request.ParentId,
                    ShowHome = request.ShowHome,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = 1,
                    CreateDate = DateTime.Now
                };
                _travelContext.Categories.Add(category);
                int res = _travelContext.SaveChanges();
                return res;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Delete(long id)
        {
            try
            {
                Category category = _travelContext.Categories.Find(id);
                if (category == null) return -1;
                _travelContext.Categories.Remove(category);
                 _travelContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public object Detail(long id)
        {
            throw new NotImplementedException();
        }

        public CategoryRequest Edit(long id)
        {
            try
            {
                Category category = _travelContext.Categories.Find(id);
                if (category == null) return null;
                CategoryRequest updateCategorysViewModel = new CategoryRequest()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ParentId = category.ParentId,
                    ShowHome = category.ShowHome,
                    Description = category.Description,
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };

                return updateCategorysViewModel;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            var entities = _travelContext.Categories;
            return entities;
        }

        public IEnumerable<CategoryViewModel> GetEdit(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(CategoryRequest request)
        {
            try
            {
                Category category = _travelContext.Categories.Find(request.Id);
                if (category == null) return -1;
                category.Name = request.Name;
                category.ParentId = request.ParentId;
                category.Description = request.Description;
                category.Url = request.Url;
                category.DisplayOrder = request.DisplayOrder;
                category.Status = request.Status;
                category.ShowHome = request.ShowHome;
                _travelContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}

