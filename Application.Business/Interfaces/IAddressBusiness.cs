using System;
using System.Collections.Generic;
using System.Text;
using Application.Domain;
using Application.Repository.Models;

namespace Application.Business.Interfaces
{
    public interface IAddressBusiness
    {
        void Add(AddressDomain address);
    }
}
