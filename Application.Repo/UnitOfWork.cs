using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseModel _context;
        public AddressRepository AddressRepository { get; private set; }

        public UnitOfWork(DatabaseModel context)
        {
            _context = context;
            this.AddressRepository = new AddressRepository(context);
        }

        

        public void Dispose()
        {
           this._context.Dispose();
        }

        public async Task Commit()
        {
            await this._context.SaveChangesAsync();
        }
    }
}
