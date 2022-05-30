using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.Order;
using WebAppDulich.Data;

namespace WebAppDulich.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();
        IEnumerable<OrderRequest> GetEdit(long id);

        int Create(OrderRequest request);

        OrderRequest Detail(long id);

        object Edit(long id);

        int Update(OrderRequest request);

        int Delete(long id);
    }
    public class OrderService : IOrderService
    {
        private readonly TravelContext _travelContext;
        public OrderService(TravelContext travelContext)
        {
            _travelContext = travelContext;
        }

        public int Create(OrderRequest request)
        {
            throw new NotImplementedException();
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public OrderRequest Detail(long id)
        {
            throw new NotImplementedException();
        }

        public object Edit(long id)
        {
            var res = _travelContext.Orders.Where(x => x.Id == id).FirstOrDefault();
            return res;
        }

        public IEnumerable<Order> GetAll()
        {
            return _travelContext.Orders;
        }

        public IEnumerable<OrderRequest> GetEdit(long id)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderRequest request)
        {
            try
            {
                Order category = _travelContext.Orders.Find(request.Id);
                if (category == null) return -1;
                category.OrderAddress = request.OrderAddress;
                category.OrderEmail = request.OrderEmail;
                category.PaymentStatus = request.PaymentStatus;
                category.OrderName = request.OrderName;
                category.OrderPhone = request.OrderPhone;
                category.TourName = request.TourName;
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
