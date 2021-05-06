using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();//listeleme
        void Insert(T p);//ekleme
        void Delete(T p);//sime
        void Update(T p);//güncelleme
        List<T> List(Expression<Func<T, bool>> filter);//şartlı listeleme
    }
}
