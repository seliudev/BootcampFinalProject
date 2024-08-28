using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//The core layee does not take any references
namespace Core.DataAccess
{
    //Generic constraint where T: reference type, an object implemented from the interface or interface itself
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Generic
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Use of Expression for filter operation
        T Get(Expression<Func<T, bool>> filter); //Example: p=>p.CategoryId==2 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}


