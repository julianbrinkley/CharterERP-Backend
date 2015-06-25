using CharterERP.Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
    public interface IDealerRepository
    {
        IEnumerable<Dealer> Dealers { get;  }

        void SaveDealer(Dealer dealer);

        Dealer DeleteDealer(int dealerID);
    }
}
