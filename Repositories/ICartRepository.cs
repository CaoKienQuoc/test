using BusinessObjects;
using System.Collections;

namespace Repositories
{
    public interface ICartRepository
    {
        public decimal GetTotal();
        public IEnumerable GetCart();
        public bool AddToCart(FlowerBouquet flowerBouquet, int quantity);
        public void Checkout(int id, decimal total);
    }
}
