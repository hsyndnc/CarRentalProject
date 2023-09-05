using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class ,IEntity , new()
    {
        //Filter==null yani filtre verilmezse tüm datayı getireceğiz
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
       //verilen filtreye uygun datayı getirir.
        T Get(Expression<Func<T, bool>> filter ); 
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

       
    }
}
