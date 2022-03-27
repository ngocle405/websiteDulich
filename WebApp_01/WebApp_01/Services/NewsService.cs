using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApp_01.Areas.Admin.Models.News;
using WebApp_01.Data;
using WebApp_01.Models;

namespace WebApp_01.Services
{
    public interface INewsService
    {
        IEnumerable<News> GetAll();

        int Create(NewsCreateRequest request);

        NewsViewModel Detail(long id);

        NewsUpdateRequest Edit(long id);

        int Update(NewsUpdateRequest request);

        int Delete(long id);
    }
    public class NewsService : INewsService
    {
        private readonly TravelContext _travelContext;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public NewsService(TravelContext travelContext, IStorageService storageService)
        {
            _travelContext = travelContext;
            _storageService = storageService;
        }

        public int Create(NewsCreateRequest request)
        {
            try
            {
                News news = new News()
                {
                    Name = request.Name,
                    Logo = request.Logo,
                    CategoryId = request.CategoryId,
                    Description = request.Description,
                    Detail = request.Detail,
                    IsNew = request.IsNew,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                if (request.FileUpload != null)
                {
                    news.Logo = SaveFile(request.FileUpload);
                }
                _travelContext.News.Add(news);
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
                News news =  _travelContext.News.Find(id);
                if (news == null) return -1;
                if (news.Logo != null)
                {
                     _storageService.DeleteFileAsync(news.Logo);
                }
                _travelContext.News.Remove(news);
                 _travelContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public NewsViewModel Detail(long id)
        {
            try
            {
                return  _travelContext.News.Where(x => x.Id == id).Select(p => new NewsViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Logo = p.Logo,
                    CategotyName = p.Category.Name,
                    Description = p.Description,
                    Detail = p.Detail,
                    IsNew = p.IsNew
                }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public NewsUpdateRequest Edit(long id)
        {
            try
            {
                News news =  _travelContext.News.Find(id);
                if (news == null) return null;
                NewsUpdateRequest updateNewsViewModel = new NewsUpdateRequest()
                {
                    Id = news.Id,
                    Name = news.Name,
                    Logo = news.Logo,
                    CategoryId = news.CategoryId,
                    Description = news.Description,
                    Detail = news.Detail,
                    IsNew = news.IsNew,
                    Url = news.Url,
                    DisplayOrder = news.DisplayOrder,
                    Status = news.Status
                };

                return updateNewsViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<News> GetAll()
        {
            return _travelContext.News;

        }

        public int Update(NewsUpdateRequest request)
        {
            try
            {
                News news =  _travelContext.News.Find(request.Id);
                if (news == null) return -1;
                news.Name = request.Name;
                news.CategoryId = request.CategoryId;
                news.Description = request.Description;
                news.Detail = request.Detail;
                news.IsNew = request.IsNew;
                news.Url = request.Url;
                news.DisplayOrder = request.DisplayOrder;
                news.Status = request.Status;
                news.EditDate = DateTime.Now;
                if (request.FileUpload != null)
                {
                     _storageService.DeleteFileAsync(news.Logo);
                    news.Logo =  SaveFile(request.FileUpload);
                }
                 _travelContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private string SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
             _storageService.SaveFile(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }
    }
}
