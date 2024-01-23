using BusinessObjects;
using DataAccessObjects;
using System.Collections.Generic;


namespace Repositories
{
    public class FlowerBouquetRepository: IFlowerBouquetRepository
    {
        public IEnumerable<FlowerBouquet> GetFlowerBouquets() => FlowerBouquetDAO.GetFlowerBouquets();
        public IEnumerable<Category> GetCategories() => CategoryDAO.GetCategories();
        public IEnumerable<Supplier> GetSuppliers() => SupplierDAO.GetSuppliers();

        public void CreateNewFlowerBouquet(string name, string description, decimal unitPirce, int unitInStock, bool status, int categoryId, int supplierId) 
            => FlowerBouquetDAO.CreateNewFlowerBouquet(name, description, unitPirce, unitInStock, status, categoryId, supplierId);

        public void UpdateFlowerBouquet(int id, string name, string description, decimal unitPirce, int unitInStock, bool status, int categoryId, int supplierId)
            => FlowerBouquetDAO.UpdateFlowerBouquet(id, name, description, unitPirce, unitInStock, status, categoryId, supplierId);

        public FlowerBouquet GetFlowerBouquetById(int id) => FlowerBouquetDAO.GetFlowerBouquetById(id);

        public void DeleteFlowerBouquet(int id) => FlowerBouquetDAO.DeleteFlowerBouquet(id);
    }
}
