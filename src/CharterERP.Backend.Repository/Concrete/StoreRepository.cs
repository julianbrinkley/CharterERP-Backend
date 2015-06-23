using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class StoreRepository : RepositoryBase<EFDbContext>, IStoreRepository
    {


        //Read
        public IEnumerable<Store> Stores
        {
            get { return DataContext.Stores; }
        }
    }
}
