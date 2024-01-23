using System;
using System.Collections;

namespace Repositories
{
    public interface IOrderRepository
    {
        public IEnumerable GetOrders();
        public IEnumerable SearchOrdersByDate(DateTime fromDate, DateTime toDate);
        public object GetOrderById(int id);
        public void UpdateOrder(int id,DateTime shippedDate, string status);
    }
}
