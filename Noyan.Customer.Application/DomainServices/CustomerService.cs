using AutoMapper;
using Noyan.Customers.Application.Contracts;
using Noyan.Customers.Core.Domain;
using Noyan.Customers.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Application.DomainServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public CustomerService(IUnitOfWork unitOfWork,             
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper= mapper;
        }

        public async Task<CustomerDto> Get(int id)
        {
            var item = await _unitOfWork.CustomerRepository.Get(id);
            var mapped = _mapper.Map<CustomerDto>(item);
            return mapped;
        }

        public async Task<long> CreateCustomr(CreateCustomerDto input )
        {
            var mapped = _mapper.Map<Customer>(input);
            var response = await _unitOfWork.CustomerRepository.Add(mapped);
            await _unitOfWork.SaveAsync();
            return response.Id;
        }

        public async Task UpdateCustomer(UpdateCustomerDto input )
        {
            var item = await _unitOfWork.CustomerRepository.Get(input.Id);
            if (item is null) throw new Exception("EntityNotFound");
            _mapper.Map(input, item);
            await _unitOfWork.CustomerRepository.Update(item);
            await _unitOfWork.SaveAsync();
           
        }

        public async Task<List<CustomerListDto>> GetAllCustomers()
        {
            var lst =await _unitOfWork.CustomerRepository.GetAll();
            return _mapper.Map<List<CustomerListDto>>(lst);
        }

        public async Task DeleteCustomer(int id)
        {
            var item = await _unitOfWork.CustomerRepository.Get(id);
            if (item is null) throw new Exception("EntityNotFound");
            await _unitOfWork.CustomerRepository.Delete(item);
            await _unitOfWork.SaveAsync();
        }
    }
}
 