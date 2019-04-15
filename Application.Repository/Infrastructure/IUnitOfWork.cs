using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Return the database reference
        /// </summary>
        DbContext Db { get; }

    }
}
