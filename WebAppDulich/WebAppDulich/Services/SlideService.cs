using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.Slide;
using WebAppDulich.Data;
using WebAppDulich.Models;

namespace WebAppDulich.Services
{
    public interface ISlideService
    {
        IEnumerable<SlideViewModel>GetAll();

        int Create(SlideCreateRequest request);

        SlideViewModel Detail(long id);

        SlideUpdateRequest Edit(long id);

        int Update(SlideUpdateRequest request);

        int Delete(long id);
    }
    public class SlideService: ISlideService
    {
        private readonly TravelContext _travelContext1;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public SlideService(TravelContext travelContext, IStorageService storageService)
        {
            _travelContext1 = travelContext;
            _storageService = storageService;
        }

        public IEnumerable<SlideViewModel> GetAll()
        {

            return  _travelContext1.Slides.Select(p => new SlideViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Logo = p.Logo,
                Link = p.Link,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToList();
        }

        public int Create(SlideCreateRequest request)
        {
            try
            {
                Slide slide = new Slide()
                {
                    Name = request.Name,
                    Logo = request.Logo,
                    Link = request.Link,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                if (request.FileUpload != null)
                {
                    slide.Logo =  SaveFile(request.FileUpload);
                }
                _travelContext1.Slides.Add(slide);
                int res =  _travelContext1.SaveChanges();
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
                Slide slide =  _travelContext1.Slides.Find(id);
                if (slide == null) return -1;
                if (slide.Logo != null)
                {
                     _storageService.DeleteFileAsync(slide.Logo);
                }
                _travelContext1.Slides.Remove(slide);
                 _travelContext1.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public SlideViewModel Detail(long id)
        {
            try
            {
                return  _travelContext1.Slides.Where(x => x.Id == id).Select(p => new SlideViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Logo = p.Logo,
                    Link = p.Link
                }).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SlideUpdateRequest Edit(long id)
        {
            try
            {
                Slide slide =  _travelContext1.Slides.Find(id);
                if (slide == null) return null;
                SlideUpdateRequest updateSlideViewModel = new SlideUpdateRequest()
                {
                    Id = slide.Id,
                    Name = slide.Name,
                    Logo = slide.Logo,
                    Link = slide.Link,
                    DisplayOrder = slide.DisplayOrder,
                    Status = slide.Status
                };

                return updateSlideViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Update(SlideUpdateRequest request)
        {
            try
            {
                Slide slide =  _travelContext1.Slides.Find(request.Id);
                if (slide == null) return -1;
                slide.Name = request.Name;
                slide.Link = request.Link;
                slide.DisplayOrder = request.DisplayOrder;
                slide.Status = request.Status;
                if (request.FileUpload != null)
                {
                     _storageService.DeleteFileAsync(slide.Logo);
                    slide.Logo =  SaveFile(request.FileUpload);
                }
                 _travelContext1.SaveChanges();
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
