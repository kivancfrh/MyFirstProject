using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint - kısıtlama
    //class : referans tip
    //IEntity : Ya IEntity olabilir ya da Entity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı. Bu yüzden IEntity new lenemeyeceği için kullanılamayacak!

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Filtre vermiyorsa tüm datayı istiyordur demektir.
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
