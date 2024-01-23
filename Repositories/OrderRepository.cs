using DataAccessObjects;
using System;
using System.Collections;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public object GetOrderById(int id) => OrderDAO.GetOrderById(id);

        public IEnumerable GetOrders() => OrderDAO.GetOrders();
        public IEnumerable SearchOrdersByDate(DateTime fromDate, DateTime toDate) => OrderDAO.SearchOrdersByDate(fromDate, toDate);

        public void UpdateOrder(int id, DateTime shippedDate, string status) => OrderDAO.UpdateOrder(id, shippedDate, status);
    }
}
