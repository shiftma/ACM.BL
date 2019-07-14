using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductId = 5;
                product.ProductName = "Danon";
                product.CurrentPrice = 12.36M;
            };

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //Call an Insert stored procedure
                    }
                    else
                    {
                        //Call an Update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;

        }
    }
}
