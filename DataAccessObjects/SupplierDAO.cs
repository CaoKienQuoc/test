using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class SupplierDAO
    {
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> list = null;
            try
            {               
                using (var context = new FUFlowerBouquetManagementContext())
                {
                    list = context.Suppliers.ToList();
                }
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
            return list;
        } 
    }
}
