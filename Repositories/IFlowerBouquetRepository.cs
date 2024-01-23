using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFlowerBouquetRepository
    {
        public IEnumerable<FlowerBouquet> GetFlowerBouquets();
        public IEnumerable<Category> GetCategories();
        public IEnumerable<Supplier> GetSuppliers();
        public void CreateNewFlowerBouquet(string name, string description, decimal unitPirce, int unitInStock, bool status, int categoryId, int supplierId);
        public void UpdateFlowerBouquet(int id, string name, string description, decimal unitPirce, int unitInStock, bool status, int categoryId, int supplierId);
        public FlowerBouquet GetFlowerBouquetById(int id);
        public void DeleteFlowerBouquet(int id);
    }
}
