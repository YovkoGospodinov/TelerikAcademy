﻿using System.Collections.Generic;

namespace SuperHeroesUniverse.Common
{
    interface IRepository<T> 
        where T : class
    {
        IEnumerable<T> All();

        T GetById(object id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
