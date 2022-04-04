using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class ProductService
    {
        ProductRepository productRepository;
        public ProductService()
        {
            productRepository = new ProductRepository();
        }
        /// <summary>
        /// Checks the correctness of the given number.
        /// </summary>
        /// <param name="Id"></param>
        void CheckId(int Id)
        {
            if (Id <= 0) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Get physical activity by given Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product GetById(int productId)
        {
            CheckId(productId);
            return productRepository.GetById(productId);
        }
        /// <summary>
        /// Adds given physical activity to database.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool AddProduct(Product product)
        {
            return productRepository.Insert(product);
        }
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> List()
        {
            return productRepository.List();
        }
        /// <summary>
        /// Deletes given product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int productId)
        {
            CheckId(productId);
            Product product = GetById(productId);
            return productRepository.DeleteforAdmin(product);
        }
        /// <summary>
        /// Changes is active property to false for  given productId.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool DeleteforUser(int productId)
        {
            CheckId(productId);
            Product product = GetById(productId);
            return productRepository.DeleteforUser(product);
        }
        /// <summary>
        /// Gets all active products.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetActiveProducts()
        {
            return productRepository.GetActiveProducts();
        }
        /// <summary>
        /// Get products by subcategoryId.
        /// </summary>
        /// <param name="subCategoryId"></param>
        /// <returns></returns>
        public List<Product> GetProductbySubCategoryId(int subCategoryId)
        {
            CheckId(subCategoryId);
            return productRepository.GetProductbySubCategoryId(subCategoryId);            
        }
        /// <summary>
        /// Updates given product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(Product product)
        {            
            return productRepository.UpdateforAdmin(product);
        }

    }
}
