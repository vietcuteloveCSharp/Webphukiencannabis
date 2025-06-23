using DAL.Dbcontext;
using DAL.Entities;
using DTO.CustomerDataTransferObj;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository.IauthCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Repository.Repository.authCustomer
{
	public class CustomerRepository : ICustomerRepository
	{
		private readonly CannabisAccessorriesDBContext _context;
		private readonly IMapper _mapper;
        public CustomerRepository(CannabisAccessorriesDBContext context, IMapper mapper)
        {
			this._context = context;
			this._mapper = mapper;
        }
		//check email tồn tại chưa
		public async Task<bool> EmailExistsAsync(string email)
		{
			return await _context.Customers.AnyAsync(c => c.Email == email);
		}

		// sử dụng bất đồng bộ để lấy danh sách 
		public async IAsyncEnumerable<Customer> GetAllCustomersAsync()
		{
			await foreach (var customer in _context.Customers.AsAsyncEnumerable())
			{
				yield return customer;
			}
		}
		//lấy khách hàng theo id
		public async Task<Customer> GetCustomerByIdAsync(int id)
		{
			var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == id);
			return customer ?? throw new KeyNotFoundException($"Customer with ID {id} not found.");
		}

		public async Task<CustomerDTO> AddCustomerAsync(CustomerDTO customerDTO)
		{
			var existsEmail = await EmailExistsAsync(customerDTO.Email);

			if (existsEmail)
			{
				throw new InvalidOperationException("Email already exists.");
			}
			var existsUserName = await UserNameExistsAsync(customerDTO.Username);
			if (existsUserName)
			{
				throw new InvalidOperationException("Username already exists.");
			}
			//chuyển đổi từ DTO sang Entity
			var customer = _mapper.Map<Customer>(customerDTO);
			//mã hóa mật khẩu
			var hasher = new PasswordHasher<Customer>();
			customer.HashPassword = hasher.HashPassword(customer,customerDTO.Password);
			//thêm customer mới
			_context.Customers.Add(customer);
			await _context.SaveChangesAsync();
			return _mapper.Map<CustomerDTO>(customer);
		}

		//check username tồn tại chưa
		public async Task<bool> UserNameExistsAsync(string userName)
		{
			return await _context.Customers.AnyAsync(c => c.Username == userName);
		}

	}
}
