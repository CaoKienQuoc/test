using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        public static List<object> GetOrders()
        {
            List<object> orders = new List<object>();
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    var query = from o in context.Orders
                                join c in context.Customers on o.CustomerId equals c.CustomerId
                                select new
                                {
                                    o.OrderId, 
                                    c.CustomerName, 
                                    o.OrderDate,
                                    o.ShippedDate,
                                    o.Total,
                                    o.OrderStatus
                                };
                    foreach(var item in query)
                    {
                        orders.Add(item);
                    }
                }
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public static List<object> SearchOrdersByDate(DateTime fromDate, DateTime toDate) 
        {
            List<object> orders = new List<object>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var query = from o in context.Orders
                                join c in context.Customers on o.CustomerId equals c.CustomerId
                                where o.OrderDate >= fromDate && o.OrderDate <= toDate
                                select new
                                {
                                    o.OrderId,
                                    c.CustomerName,
                                    o.OrderDate,
                                    o.ShippedDate,
                                    o.Total,
                                    o.OrderStatus
                                };
                    foreach (var item in query)
                    {
                        orders.Add(item);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }
        public static dynamic GetOrderById(int id)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var query = from o in context.Orders
                                join c in context.Customers on o.CustomerId equals c.CustomerId
                                where o.OrderId == id
                                select new
                                {
                                    o.OrderId,
                                    c.CustomerName,
                                    o.OrderDate,
                                    o.ShippedDate,
                                    o.Total,
                                    o.OrderStatus
                                };
                    return query.FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
        public static void UpdateOrder(int id, DateTime shippedDate, string status)
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    Order order = context.Orders.FirstOrDefault(o => o.OrderId == id);
                    order.ShippedDate = shippedDate;
                    order.OrderStatus = status;
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
