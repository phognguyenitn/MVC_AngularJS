using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IRespository<T> where T:class
    {
        //Marks an entity as
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingleById(int id);
        //Thêm các bảng con
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] include =null);

        //Lấy tất
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        //Phân trang
        IQueryable<T> GetMultiPaging(Expression<Func<T,bool>>filter,out int total, int index = 0, int size =50, string[] include=null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);

    }
}
