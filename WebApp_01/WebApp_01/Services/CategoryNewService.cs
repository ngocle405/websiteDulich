using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_01.Areas.Admin.Models.CategoryNews;
using WebApp_01.Data;

namespace WebApp_01.Services
{
    public interface ICategoryNewService
    {

        IEnumerable<CategoriesNew> GetAll();
        IEnumerable<CategoryNewsRequest> GetEdit(long id);

        int Create(CategoryNewsRequest request);

        CategoryNewsRequest Detail(long id);

        CategoryNewsRequest Edit(long id);

        int Update(CategoryNewsRequest request);

        int Delete(long id);
    }
    public class CategoryNewService : ICategoryNewService
    {
        private readonly TravelContext _travelContext;

        public CategoryNewService(TravelContext travelContext)
        {
            _travelContext = travelContext;
        }
        public int Create(CategoryNewsRequest request)
        {
            try
            {
                CategoriesNew categoriesNew = new CategoriesNew()
                {
                    Name = request.Name,
                    Description = request.Description,
                    ShowHome = request.ShowHome,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                _travelContext.CategoriesNews.Add(categoriesNew);
                int res =  _travelContext.SaveChanges();
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
                CategoriesNew CategoriesNew = _travelContext .CategoriesNews.Find(id);
                if (CategoriesNew == null) return -1;
                _travelContext.CategoriesNews.Remove(CategoriesNew);
                 _travelContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public CategoryNewsRequest Detail(long id)
        {
            try
            {
                CategoriesNew category =  _travelContext.CategoriesNews.Find(id);
                CategoryNewsRequest detailCategoryNewsViewModel = new CategoryNewsRequest()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ShowHome = category.ShowHome,
                    Description = category.Description,
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };
                return detailCategoryNewsViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public CategoryNewsRequest Edit(long id)
        {
            try
            {
                CategoriesNew category =  _travelContext.CategoriesNews.Find(id);
                if (category == null) return null;
                CategoryNewsRequest updateCategorysViewModel = new CategoryNewsRequest()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ShowHome = category.ShowHome,
                    Description = category.Description,
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };

                return updateCategorysViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<CategoriesNew> GetAll()
        {
            return _travelContext.CategoriesNews;
        }

        public IEnumerable<CategoryNewsRequest> GetEdit(long id)
        {
            return  _travelContext.CategoriesNews.Where(x => x.Id != id).Select(p => new CategoryNewsRequest()
            {

                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ShowHome = p.ShowHome,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToList();
        }

        public int Update(CategoryNewsRequest request)
        {
            try
            {
                CategoriesNew category =  _travelContext.CategoriesNews.Find(request.Id);
                if (category == null) return -1;
                category.Name = request.Name;
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
