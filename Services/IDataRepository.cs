using System.Collections.Generic;
using Assignment_11._4.Model;
namespace Assignment_11._4.Services
{
    public interface IDataRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
