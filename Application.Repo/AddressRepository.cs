using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        private readonly DatabaseModel _context;


        public AddressRepository(DatabaseModel context) : base(context)
        {
            this._context = context;
        }

        public IEnumerable<Address> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(Address address)
        {
            this._context.Add(address);
            this._context.SaveChanges();
        }
    }

}
