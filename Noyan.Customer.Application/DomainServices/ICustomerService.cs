using Noyan.Customers.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Application.DomainServices
{
    public interface ICustomerService
    {

        /// <summary>
        /// get an existing customer 
        /// </summary>
        /// <param name="id">id of customer </param>
        /// <returns></returns>
        Task<CustomerDto> Get(int id);
        /// <summary>
        /// add new customer
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<long> CreateCustomr(CreateCustomerDto input);

        /// <summary>
        /// update an existing cusotmer
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateCustomer(UpdateCustomerDto input);

        /// <summary>
        /// get all customers 
        /// </summary>
        /// <returns></returns>
        Task<List<CustomerListDto>> GetAllCustomers();

        /// <summary>
        /// delete an existing customer 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteCustomer(int id);


    }
}
