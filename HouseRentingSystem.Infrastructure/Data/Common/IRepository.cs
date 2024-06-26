﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Data.Common
{
    public interface IRepository
    {
        //IQueryable<T> All<T>();
        IQueryable<T> All<T>() where T : class;
        //IQueryable<T> AllReadOnly<T>();
        IQueryable<T> AllReadOnly<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task<int> SaveChangesAsync();
    }
}
