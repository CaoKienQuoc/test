using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class FlowerBouquetDAO
    {
        public static List<FlowerBouquet> GetFlowerBouquets()
        {
            List<FlowerBouquet> list = new List<FlowerBouquet>();
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    var query = (from fb in context.FlowerBouquets
                                 join c in context.Categories on fb.CategoryId equals c.CategoryId
                                 join s in context.Suppliers on fb.SupplierId equals s.SupplierId
                                 select new { fb.FlowerBouquetId, c.CategoryName, fb.FlowerBouquetName, fb.Description, fb.UnitPrice, fb.UnitsInStock, s.SupplierName });
                    foreach (var item in query)
                    {
                        list.Add(new FlowerBouquet
                        {
                            FlowerBouquetId = Convert.ToInt32(item.FlowerBouquetId),
                            FlowerBouquetName = item.FlowerBouquetName,
                            Description = item.Description,
                            UnitPrice = item.UnitPrice,
                            UnitsInStock = item.UnitsInStock,
                            CategoryName = item.CategoryName,
                            SupplierName = item.SupplierName
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static void UpdateFlowerBouquet(int id, string name, string description, decimal unitPirce, int unitInStock, bool status, int categoryId, int supplierId)
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    FlowerBouquet flowerBouquet = GetFlowerBouquetById(id);
                    if (flowerBouquet != null)
                    {
                        context.Attach(flowerBouquet);
                        flowerBouquet.FlowerBouquetName = name;
                        flowerBouquet.Description = description;
                        flowerBouquet.UnitPrice = unitPirce;
                        flowerBouquet.UnitsInStock = unitInStock;
                        flowerBouquet.CategoryId = categoryId;
                        flowerBouquet.FlowerBouquetStatus = Convert.ToByte(status);
                        flowerBouquet.SupplierId = supplierId;
                        context.SaveChanges();
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void CreateNewFlowerBouquet(string name, string description, decimal unitPirce, int unitInStock, bool status, int categoryId, int supplierId) 
        {
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    int id = context.FlowerBouquets.Max(f => f.FlowerBouquetId) + 1;
                    FlowerBouquet flowerBouquet = new FlowerBouquet()
                    {
                        FlowerBouquetId = id,
                        FlowerBouquetName = name,
                        Description = description,
                        UnitPrice = unitPirce,
                        UnitsInStock = unitInStock,
                        FlowerBouquetStatus=Convert.ToByte(status),
                        CategoryId = categoryId,
                        SupplierId = supplierId
                    };
                    context.FlowerBouquets.Add(flowerBouquet);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static FlowerBouquet GetFlowerBouquetById(int id)
        {
            FlowerBouquet flowerBouquet = null;
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    var query = from fb in context.FlowerBouquets
                                join c in context.Categories on fb.CategoryId equals c.CategoryId
                                join s in context.Suppliers on fb.SupplierId equals s.SupplierId
                                where fb.FlowerBouquetId == id
                                select new
                                {
                                    fb.FlowerBouquetId,
                                    c.CategoryName,
                                    fb.FlowerBouquetName,
                                    fb.Description,
                                    fb.FlowerBouquetStatus,
                                    fb.UnitPrice,
                                    fb.UnitsInStock,
                                    s.SupplierName
                                };
                    foreach(var item in query)
                    {
                        flowerBouquet = new FlowerBouquet()
                        {
                            FlowerBouquetId = item.FlowerBouquetId,
                            FlowerBouquetName = item.FlowerBouquetName,
                            FlowerBouquetStatus = item.FlowerBouquetStatus,
                            SupplierName = item.SupplierName,
                            Description = item.Description,
                            UnitPrice = item.UnitPrice,
                            UnitsInStock = item.UnitsInStock,
                        };
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flowerBouquet;
        }
        public static void DeleteFlowerBouquet(int id)
        {
            try
            {
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    FlowerBouquet flowerBouquet = GetFlowerBouquetById(id);
                    var exist = context.OrderDetails.Where(o => o.FlowerBouquetId == flowerBouquet.FlowerBouquetId).ToList();
                    if(exist.Count > 0)
                    {
                        context.Attach(flowerBouquet);
                        flowerBouquet.FlowerBouquetStatus = 0; 
                    }
                    else
                    {
                        context.FlowerBouquets.Remove(flowerBouquet);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message); 
            }
        }
    }
}
