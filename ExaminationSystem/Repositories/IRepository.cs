﻿using ExaminationSystem.Models;

namespace ExaminationSystem.Repositories
{
    public interface IRepository<T> 
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
