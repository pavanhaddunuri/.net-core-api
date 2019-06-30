using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.DAL.Interfaces;
using Northwind.DAL.Models;
using Northwind.DotnetCore.API.DTO;

namespace Northwind.DotnetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customersRepository;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerRepository customersRepository, IMapper mapper)
        {
            this._customersRepository = customersRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Customers>> Get()
        {
            var customers = await _customersRepository.GetAllCustomersAsync();
            return Ok(_mapper.Map<List<CustomerDTO>>(customers));
        }

        [HttpGet("id")]
        public async Task<ActionResult<Customers>> GetCustomer(string id)
        {
            var customer = await _customersRepository.GetCustomerAsync(id);

            if (customer == null) return NotFound($"Customer with { id } is not found");

            return Ok(_mapper.Map<CustomerDTO>(customer));
        }


    }
}