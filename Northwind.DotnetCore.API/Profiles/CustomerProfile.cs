using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Northwind.DAL.Models;
using Northwind.DotnetCore.API.DTO;

namespace Northwind.DotnetCore.API.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            this.CreateMap<Customers, CustomerDTO>().ReverseMap();
        }
    }
}
