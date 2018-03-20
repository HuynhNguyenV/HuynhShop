using HuynhShop.Data.Infrastructure;
using HuynhShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhShop.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {

    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
