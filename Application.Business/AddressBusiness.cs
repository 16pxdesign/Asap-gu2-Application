using System;
using System.Collections.Generic;
using System.Text;
using Application.Business.Interfaces;
using Application.Domain;
using Application.Repository;
using Application.Repository.Infrastructure;
using Application.Repository.Models;

namespace Application.Business
{
    public class AddressBusiness : IAddressBusiness
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly AddressRepository addressRepository;

        public AddressBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            addressRepository = new AddressRepository(unitOfWork);
        }


        public void Add(AddressDomain address)
        {
            //var address1 = new Address(){City = address.City, Flat = address.Flat, Street = address.Street, Postcode = address.Postcode};

            var address2 = new Address() {City = "Szczecin00"};

            //var address1 = new Address();
            addressRepository.Insert(null);
        }
    }
}
