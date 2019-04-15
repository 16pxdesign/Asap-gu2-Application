using System;
using System.Collections.Generic;
using System.Text;
using Application.Repository.Infrastructure;
using Application.Repository.Models;

namespace Application.Repository
{
    public class AddressRepository : BaseRepository<Address>
    {
        public AddressRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
