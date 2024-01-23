using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class CartDAO: Dictionary<int, Item>
    {
        public List<Item> GetCart()
        {
            List<Item> cart = new List<Item>();
            try
            {
                foreach (var item in this)
                {
                    cart.Add(item.Value);
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cart;
        }
        public bool AddToCart(FlowerBouquet flowerBouquet, int quantity)
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    int key = flowerBouquet.FlowerBouquetId;
                    int unitInStock = context.FlowerBouquets.Where(f => f.FlowerBouquetId == key).Select(f => f.UnitsInStock).FirstOrDefault();
                    if(unitInStock > 0)
                    {
                        if(this.ContainsKey(key))
                        {
                            this[key].Quantity += quantity;
                            this[key].Price = this[key].Quantity * this[key].Price;
                        }
                        else
                        {
                            Item item = new Item()
                            {
                                FlowerBouquet = flowerBouquet,
                                Quantity = quantity,
                                Price = flowerBouquet.UnitPrice * quantity 
                            };
                            this.Add(key, item);
                        }
                        return true;
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
        public decimal GetTotal() 
        {
            decimal total = 0;
            try
            {
                foreach (var item in this)
                {
                    total += item.Value.Price;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return total;
        }
        public void Checkout(int customerID, decimal total)
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    int orderID = context.Orders.Max(o => o.OrderId) + 1;
                    Order order = new Order()
                    {
                        OrderId = orderID,
                        CustomerId = customerID,
                        OrderDate = DateTime.Now,
                        Total = total,
                        OrderStatus = "Not Yet"
                    };
                    context.Orders.Add(order);
                    context.SaveChanges();
                    foreach(var item in this)
                    {
                        OrderDetail orderDetail = new OrderDetail()
                        {
                            OrderId = orderID,
                            FlowerBouquetId = item.Value.FlowerBouquet.FlowerBouquetId,
                            UnitPrice = item.Value.FlowerBouquet.UnitPrice,
                            Quantity = item.Value.Quantity,
                            Discount = 0,
                        };
                        context.OrderDetails.Add(orderDetail);
                        context.SaveChanges();
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            this.Clear();
        }
    }
}
