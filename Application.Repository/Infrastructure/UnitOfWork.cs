using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseModel _dbContext;

        public UnitOfWork()
        {
            _dbContext = new DatabaseModel();
        }

        public DbContext Db => _dbContext;

        public void Dispose()
        {
        }
    }
}
