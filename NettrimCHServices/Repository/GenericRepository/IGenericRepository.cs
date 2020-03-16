﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NettrimCHServices.Repository.GenericRepository
{
    public interface IGenericRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(object id);
        Task Save();
    }
}
