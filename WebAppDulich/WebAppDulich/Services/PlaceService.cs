using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models;
using WebAppDulich.Data;

namespace WebAppDulich.Services
{
    public interface IPlaceService
    {
        IEnumerable<Place> GetAll();


        int Create(PlaceRequest request);

        object Detail(long id);

        PlaceRequest Edit(long id);

        int Update(PlaceRequest request);

        int Delete(long id);
    }
    public class PlaceService : IPlaceService
    {
        private readonly TravelContext _travelContext;

        public PlaceService(TravelContext travelContext)
        {
            _travelContext = travelContext;
        }
        public int Create(PlaceRequest request)
        {
            try
            {
                Place Place = new Place()
                {
                    PlaceName = request.PlaceName,
                    Description = request.Description,
                    ShowHome = request.ShowHome,
                    Status = 1,
                    Area = request.Area
                };
                _travelContext.Places.Add(Place);
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
                Place Place = _travelContext.Places.Find(id);
                if (Place == null) return -1;
                _travelContext.Places.Remove(Place);
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

        public PlaceRequest Edit(long id)
        {
            try
            {
                Place Place = _travelContext.Places.Find(id);
                if (Place == null) return null;
                PlaceRequest updatePlacesViewModel = new PlaceRequest()
                {
                    Id = Place.Id,
                    PlaceName = Place.PlaceName,
                    ShowHome = Place.ShowHome,
                    Description = Place.Description,
                    Status = 1,
                    Area=Place.Area
                };

                return updatePlacesViewModel;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Place> GetAll()
        {
            var entities = _travelContext.Places;
            return entities;
        }



        public int Update(PlaceRequest request)
        {
            try
            {
                Place Place = _travelContext.Places.Find(request.Id);
                if (Place == null) return -1;
                Place.PlaceName = request.PlaceName;
                Place.Description = request.Description;
                Place.Status = request.Status;
                Place.ShowHome = request.ShowHome;
                Place.Area = request.Area;
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