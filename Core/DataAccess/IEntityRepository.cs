using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //
{
    // Generic constraint - jenerik kısıt(kısıtlama)
    // class : referans tip | referans tip olabilir
    // IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity, new() // T, IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null); // dataAcces sağ tık / Add / Project referance, seç entities
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void List(T entity);

    }
}
