using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkstationStudioGarment_WinForm.containers;
using WorkstationStudioGarment_WinForm.manager;

namespace WorkstationStudioGarment_WinForm.control
{
    class ProductsManager
    {
        private DbManager manager = new DbManager();

        public void Add(PRODUCT product)
        {
            manager.AddProduct(product);
            
            //for (int i = 0; i < productEntity.ProductStructures.Count; i++)
            //{
            //    productEntity.ProductStructures[i].id_product = idProduct;
            //    manager.AddProductStructure(productEntity.ProductStructures[i]);
            //}
        }

        public void Add(SUPPLY supply)
        {
            manager.AddSupply(supply);
        }

        public void Edit()
        {

        }

        public void Delete()
        {

        }

        public List<PRODUCT> GetAllProducts()
        {
            try
            {
                return manager.GetProducts();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SUPPLY> GetAllSupplies()
        {
            try
            {
                return manager.GetSupplies();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<PRODUCT> GetSuppliesProducts(int idSupply)
        {
            try
            {
                return manager.GetSuppliesProducts(idSupply);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SUPPLY> GetProductsSupplies(int idProduct)
        {
            try
            {
                return manager.GetProductsSupplies(idProduct);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<ProductStructureEntity> GetProductStructure(int idProduct)
        {
            try
            {
                return manager.GetProductStructure(idProduct);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
