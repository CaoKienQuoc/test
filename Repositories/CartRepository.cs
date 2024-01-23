using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CartRepository : ICartRepository
    {
        CartDAO cartDAO = new CartDAO();
        public bool AddToCart(FlowerBouquet flowerBouquet, int quantity) => cartDAO.AddToCart(flowerBouquet, quantity);

        public void Checkout(int id, decimal total) => cartDAO.Checkout(id, total);

        public IEnumerable GetCart() => cartDAO.GetCart();

        public decimal GetTotal() => cartDAO.GetTotal();
    }
}
