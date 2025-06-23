using DAL.Entities;
using DTO.CustomerDataTransferObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository.IauthCustomer
{
	public interface ICustomerRepository
	{

		IAsyncEnumerable<Customer> GetAllCustomersAsync();
		Task<Customer> GetCustomerByIdAsync(int id);		
		Task<bool> EmailExistsAsync(string email);
		Task<bool> UserNameExistsAsync(string userName);
		Task<CustomerDTO> AddCustomerAsync(CustomerDTO customerDTO);

	}
}
