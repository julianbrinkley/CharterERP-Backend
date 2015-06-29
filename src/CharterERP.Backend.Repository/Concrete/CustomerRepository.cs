using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class CustomerRepository : RepositoryBase<EFDbContext>, ICustomerRepository
    {
        public IEnumerable<Customer> Customers
        {
            get { return DataContext.Customers; }
        }
    }
}
