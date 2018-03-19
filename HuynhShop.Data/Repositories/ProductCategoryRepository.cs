using HuynhShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuynhShop.Model.Models;

namespace HuynhShop.Data.Repositories
{
    //dinh nghia cac phuong thuc can phai them
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    internal class ProductCategoryRepository : RepositoryBase<ProductCategory> , IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCateogries.Where(x => x.Alias == alias);
        }
    }
}
