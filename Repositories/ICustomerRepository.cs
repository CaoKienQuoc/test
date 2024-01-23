using System;
using System.Collections;
using BusinessObjects;
namespace Repositories
{
    public interface ICustomerRepository
    {
        public Customer CheckLogin(String email, String password);
        public void UpdateInfo(int id, string name, string email, string city, string country, DateTime birthDay);
        public void ChangePassword(int id, string newPassword);
        public IEnumerable GetOrdersHistory(int id);
        public IEnumerable GetCustomers();
        public void CreateNewCustomer(int id, string name, string email, string password, string city, string country, DateTime birthDay);
        public Customer GetCustomerById(int id);
    }
}
