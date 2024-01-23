using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        public void ChangePassword(int id, string newPassword) => CustomerDAO.ChangePassword(id, newPassword);

        public Customer CheckLogin(String email, String password) => CustomerDAO.CheckLogin(email, password);

        public void CreateNewCustomer(int id, string name, string email, string password, string city, string country, DateTime birthDay) => CustomerDAO.CreateNewCustomer(id, name, email, password, city, country, birthDay);  

        public IEnumerable GetCustomers() => CustomerDAO.GetCustomers();

        public IEnumerable GetOrdersHistory(int id) => CustomerDAO.GetOrdersHistory(id);

        public void UpdateInfo(int id, string name, string email, string city, string country, DateTime birthDay) => CustomerDAO.UpdateInfo(id, name, email, city, country, birthDay);

        public Customer GetCustomerById(int id) => CustomerDAO.GetCustomerById(id);
    }
}
