using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        HuynhShopDbContext dbContext;
        public HuynhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HuynhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
