using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;
using TeduShop.Data.Infrastructure;
namespace TeduShop.Data.Respositories
{
    //Không có sẵn trong Repository base
    public interface IproductCategoryRespository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    class ProductCategoryRepository : RepositoryBase<ProductCategory>,IproductCategoryRespository
    {
      
        //Constructor: khởi tạo, kế thừa từ Respository=> nên khởi tạo Respository có IDbFactory 
        public ProductCategoryRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        {
            //Bao gồm các phương thức đã triển khai trong RespositoryBase
        }
        //Định nghĩa lớp Interface ở trên

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);
        }
    }
}
