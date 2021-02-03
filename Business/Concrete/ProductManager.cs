using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService

    {
        IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll(p=>p.CategoryId==2);
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return productDal.GetAll(p =>p.CategoryId==Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }
    }
    
        
         
        
    }

