using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApp_01.Areas.Admin.Models.Tour;
using WebApp_01.Data;
using WebApp_01.Models;

namespace WebApp_01.Services
{

    public interface ITourService
    {
        //Task<List<ProductViewModel>> GetDiscountProduct();
        //  Task<PaginationViewModel> Pagination(Dictionary<string, object> data);

        IEnumerable<TourViewModel> GetAll();

        int Create(TourUpdateRequest request);

        // Task<ProductViewModel> Detail(long id);

        TourUpdateRequest Edit(long id);

        int Update(TourUpdateRequest request);

        int Delete(long id);
        public IEnumerable<TourViewModel> ShowTours();
    }
    public class TourService : ITourService
    {
        private readonly TravelContext _travelContext;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public TourService(TravelContext travelContext,IStorageService storageService)
        {
            _travelContext = travelContext;
            _storageService = storageService;
        }

        public IEnumerable<TourViewModel> GetAll()
        {
            return  _travelContext.Tours.Select(p => new TourViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Logo = p.Logo,
                CategoryName = p.Category.Name,
                Description = p.Description,
                Price = p.Price,
              
                PriceDiscount = p.PriceDiscount,
                IsNew = p.IsNew,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate,
                Code=p.Code,
                PlaceName=p.Place.PlaceName,
                Destination=p.Destination,
                DeparturePoint=p.DeparturePoint,
                Start=p.Start,
                Vehicle=p.Vehicle,
                Time=p.Time
            });
        }
        public IEnumerable<TourViewModel> ShowTours()
        {
            return _travelContext.Tours.Select(p => new TourViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Logo = p.Logo,
                CategoryName = p.Category.Name,
                Description = p.Description,
                Price = p.Price,

                PriceDiscount = p.PriceDiscount,
                IsNew = p.IsNew,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate,
                Code = p.Code,
                PlaceName = p.Place.PlaceName,
                Destination = p.Destination,
                DeparturePoint = p.DeparturePoint,
                Start = p.Start,
                Vehicle = p.Vehicle,
                Time = p.Time
            }).Take(12);
        }
        //public async Task<List<ProductViewModel>> GetDiscountProduct()
        //{

        //    return await _flowerContext.Products.Where(x => x.Status == 1 && x.PriceDiscount != null).Select(p => new ProductViewModel()
        //    {
        //        Id = p.Id,
        //        Name = p.Name,
        //        Logo = p.Logo,
        //        CategotyName = p.Category.Name,
        //        Description = p.Description,
        //        Price = p.Price,
        //        Detail = p.Detail,
        //        PriceDiscount = p.PriceDiscount,
        //        IsNew = p.IsNew,
        //        Url = p.Url,
        //        DisplayOrder = p.DisplayOrder,
        //        Status = p.Status,
        //        CreateDate = p.CreateDate
        //    }).ToListAsync();
        //}

        //public async Task<PaginationViewModel> Pagination(Dictionary<string, object> data)
        //{
        //    PaginationViewModel paginationViewModel = new PaginationViewModel();
        //    try
        //    {
        //        int page = int.Parse(data["page"].ToString());
        //        int pageSize = int.Parse(data["pageSize"].ToString());
        //        string nameSearch = "";
        //        if (data.ContainsKey("nameSearch") && !string.IsNullOrEmpty(data["nameSearch"].ToString().Trim()))
        //            nameSearch = data["nameSearch"].ToString().Trim().ToLower();
        //        paginationViewModel.Page = page;
        //        paginationViewModel.PageSize = pageSize;
        //        paginationViewModel.TotalItems = await _flowerContext.Products.Where(x => x.Name.ToLower().IndexOf(nameSearch) >= 0).CountAsync();
        //        var model = from pro in _flowerContext.Products
        //                    select new ProductViewModel
        //                    {
        //                        Id = pro.Id,
        //                        Name = pro.Name,
        //                        Logo = pro.Logo,
        //                        CategotyName = pro.Category.Name,
        //                        Description = pro.Description,
        //                        Price = pro.Price,
        //                        Detail = pro.Detail,
        //                        PriceDiscount = pro.PriceDiscount,
        //                        IsNew = pro.IsNew,
        //                        Url = pro.Url,
        //                        DisplayOrder = pro.DisplayOrder,
        //                        Status = pro.Status,
        //                        CreateDate = pro.CreateDate
        //                    };
        //        string sortByName = "";
        //        if (data.ContainsKey("sortByName") && !string.IsNullOrEmpty(data["sortByName"].ToString().Trim()))
        //            sortByName = data["sortByName"].ToString().Trim().ToLower();
        //        switch (sortByName)
        //        {
        //            case "asc":
        //                model = model.OrderBy(x => x.Name);
        //                break;

        //            case "desc":
        //                model = model.OrderByDescending(x => x.Name);
        //                break;
        //        }
        //        string sortByCreatedDate = "";
        //        if (data.ContainsKey("sortByCreatedDate") && !string.IsNullOrEmpty(data["sortByCreatedDate"].ToString().Trim()))
        //            sortByCreatedDate = data["sortByCreatedDate"].ToString().Trim().ToLower();
        //        switch (sortByCreatedDate)
        //        {
        //            case "asc":
        //                model = model.OrderBy(x => x.CreateDate);
        //                break;

        //            case "desc":
        //                model = model.OrderByDescending(x => x.CreateDate);
        //                break;
        //        }
        //        string sortByPrice = "";
        //        if (data.ContainsKey("sortByPrice") && !string.IsNullOrEmpty(data["sortByPrice"].ToString().Trim()))
        //            sortByPrice = data["sortByPrice"].ToString().Trim().ToLower();
        //        switch (sortByPrice)
        //        {
        //            case "asc":
        //                model = model.OrderBy(x => x.Price);
        //                break;

        //            case "desc":
        //                model = model.OrderByDescending(x => x.Price);
        //                break;
        //        }
        //        paginationViewModel.Data = model.Where(x => x.Name.ToLower().IndexOf(nameSearch) >= 0).Skip((page - 1) * pageSize).Take(pageSize);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return paginationViewModel;
        //}

        public int Create(TourUpdateRequest request)
        {
            try
            {
                Tour product = new Tour()
                {
                    Name = request.Name,
                    Logo = request.Logo,
                    CategoryId = request.CategoryId,
                    Description = request.Description,
                    Price = request.Price,
                    PlaceId = request.PlaceId,
                    PriceDiscount = request.PriceDiscount,
                    IsNew = request.IsNew,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = 1,
                    CreateDate = DateTime.Now,
                    Code = request.Code,
                    DeparturePoint = request.DeparturePoint,
                    Destination = request.Destination,
                    Start = request.Start,
                    Time = request.Time,
                    Vehicle = request.Vehicle,
                    PlaceName = request.PlaceName
                };
                if (request.FileUpload != null)
                {
                    product.Logo = SaveFile(request.FileUpload);
                }
                _travelContext.Tours.Add(product);
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
                Tour product = _travelContext.Tours.Find(id);
                if (product == null) return -1;
                if (product.Logo != null)
                {
                    _storageService.DeleteFileAsync(product.Logo);
                }
                _travelContext.Tours.Remove(product);
                _travelContext.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        //public async Task<ProductViewModel> Detail(long id)
        //{
        //    try
        //    {
        //        return await _flowerContext.Products.Where(x => x.Id == id).Select(p => new ProductViewModel()
        //        {
        //            Id = p.Id,
        //            Name = p.Name,
        //            Logo = p.Logo,
        //            CategotyName = p.Category.Name,
        //            Description = p.Description,
        //            Price = p.Price,
        //            Detail = p.Detail,
        //            PriceDiscount = p.PriceDiscount,
        //            IsNew = p.IsNew
        //        }).FirstOrDefaultAsync();
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public TourUpdateRequest Edit(long id)
        {
            try
            {
                Tour product = _travelContext.Tours.Find(id);
                if (product == null) return null;
                TourUpdateRequest updateProductsViewModel = new TourUpdateRequest()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Code = product.Code,
                    Logo = product.Logo,
                    CategoryId = product.CategoryId,
                    Description = product.Description,
                    PlaceId = product.PlaceId,
                    Price = product.Price,

                    PriceDiscount = product.PriceDiscount,
                    IsNew = product.IsNew,
                    Url = product.Url,
                    DisplayOrder = product.DisplayOrder,
                    Status = product.Status,
                    Destination = product.Destination,
                    DeparturePoint = product.DeparturePoint,
                    Start = product.Start,
                    Vehicle = product.Vehicle,
                    PlaceName = product.PlaceName,
                    Time = product.Time
                };

                return updateProductsViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Update(TourUpdateRequest request)
        {
            try
            {
                Tour product = _travelContext.Tours.Find(request.Id);
                if (product == null) return -1;
                product.Name = request.Name;
               // product.Logo = request.Logo;
                product.CategoryId = request.CategoryId;
                product.PlaceId = request.PlaceId;
                product.Description = request.Description;
                product.Price = request.Price;

                product.PriceDiscount = request.PriceDiscount;
                product.IsNew = request.IsNew;
                product.Url = request.Url;
                product.DisplayOrder = request.DisplayOrder;
                product.Status = request.Status;

                product.Code = request.Code;
                product.DeparturePoint = request.DeparturePoint;
                product.Destination = request.Destination;
                product.Start = request.Start;
                product.Time = request.Time;
                product.Vehicle = request.Vehicle;
                product.PlaceName = request.PlaceName;
                product.EditDate = DateTime.Now;
                if (request.FileUpload != null)
                {
                    _storageService.DeleteFileAsync(product.Logo);
                    product.Logo = SaveFile(request.FileUpload);
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
