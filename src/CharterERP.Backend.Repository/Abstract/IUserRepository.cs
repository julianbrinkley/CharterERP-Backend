using CharterERP.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
   public interface IUserRepository
    {
       IEnumerable<User> Users { get; }
    }
}
