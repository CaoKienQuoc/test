using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    customers = context.Customers.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }
        public static Customer CheckLogin(String email, String password)
        {
            Customer customer = null;
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    customer = context.Customers.FirstOrDefault(c => c.Email == email && c.Password == password);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }
        public static void UpdateInfo(int id, string name,  string email, string city, string country, DateTime birthDay) 
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    Customer customer = context.Customers.FirstOrDefault(c => c.CustomerId == id);
                    if (customer != null)
                    {
                        customer.CustomerName = name;
                        customer.Email = email;
                        customer.City = city;
                        customer.Country = country;
                        customer.Birthday = birthDay;
                        context.SaveChanges();
                    }
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void ChangePassword(int id, string newPassword)
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    Customer customer = context.Customers.FirstOrDefault(c => c.CustomerId == id);
                    if(customer != null)
                    {
                        customer.Password = newPassword;
                        context.SaveChanges();
                    }
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static List<object> GetOrdersHistory(int id)
        {
            List<object> list = new List<object>();
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    var query = from o in context.Orders
                                join od in context.OrderDetails on o.OrderId equals od.OrderId
                                join f in context.FlowerBouquets on od.FlowerBouquetId equals f.FlowerBouquetId
                                where o.CustomerId == id
                                select new { o.OrderId, o.OrderDate, o.ShippedDate, f.FlowerBouquetName, Price = od.Quantity * od.UnitPrice };
                    foreach(var item in query)
                    {
                        list.Add(item);
                    }
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return list;
        }
        public static void CreateNewCustomer(int id, string name, string email, string password, string city, string country, DateTime birthDay)
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    int maxId = context.Customers.Max(c => c.CustomerId) + 1;
                    Customer cus = new Customer
                    {
                        CustomerId = maxId,
                        CustomerName = name,
                        Email = email,
                        Password = password,
                        City = city,
                        Country = country,
                        Birthday = birthDay
                    };
                    context.Customers.Add(cus);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Customer GetCustomerById(int id)
        {
            Customer customer;
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    customer = context.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return customer;
        }
    }
}
