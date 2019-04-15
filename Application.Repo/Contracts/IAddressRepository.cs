using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Models;

namespace Application.Repo.Contracts
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetByName(string name);
        void Insert(Address address);
    }
}
