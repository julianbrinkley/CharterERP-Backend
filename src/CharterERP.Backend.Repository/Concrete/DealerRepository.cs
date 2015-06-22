using CharterERP.Backend.Domain.Entities;
using CharterERP.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public class DealerRepository : RepositoryBase<EFDbContext>, IDealerRepository
    {

        //Create

        //Read

        //Read
        public IEnumerable<Dealer> Dealers
        {
            get { return DataContext.Dealers; }
        }


        //Update




        //Delete




    }
}
