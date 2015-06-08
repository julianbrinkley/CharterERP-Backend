using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class ProductRepository : RepositoryBase<EFDbContext>, IProductRepository
    {

        //Get Product By Id
        public Product GetProduct(int productId)
        {
            using (DataContext)
            {
                return DataContext.Products
                        .Where(p => p.Id == productId).SingleOrDefault();
            }
        }




        //Create



        //Read
        public IEnumerable<Product> Products
        {
            get { return DataContext.Products; }
        }


        //Update



        //Delete

    }
}
