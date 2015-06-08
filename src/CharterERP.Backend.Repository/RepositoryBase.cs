using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterERP.Backend.Repository
{
   public class RepositoryBase<C> : IDisposable where C : DbContext, new()
    {
       private C _DataContext;

       public virtual C DataContext
       {
           get
           {
               if (_DataContext == null)
               {
                   _DataContext = new C();
                   this.AllowSerialization = true;
               }
               return _DataContext;
           }


       }

       protected virtual bool AllowSerialization
       {
           get
           {
               return _DataContext.Configuration.ProxyCreationEnabled;
           }
           set
           {
               _DataContext.Configuration.ProxyCreationEnabled = !value;
           }
       }


       public virtual void Dispose()
       {
           if (DataContext != null) DataContext.Dispose();
       }
    }
}
