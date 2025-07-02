using DAL.Dbcontext;
using DAL.Entities;
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
	
        public CustomerRepository(CannabisAccessorriesDBContext context)
        {
			this._context = context;
        }
		
		// sử dụng bất đồng bộ để lấy danh sách 
		public async IAsyncEnumerable<Customer> GetAllCustomersAsync()
		{
			await foreach (var customer in _context.Customers.AsNoTracking().AsAsyncEnumerable())
			{
				yield return customer;
			}
		}
		//lấy khách hàng theo id
		public async Task<Customer?> GetCustomerByIdAsync(int id)
		{
			var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == id);
			return customer;
		}
		//thêm 1 tài khoản mới
		public async Task<Customer> AddCustomerAsync(Customer customer)
		{
			
			_context.Customers.Add(customer);
			await _context.SaveChangesAsync();
			return customer;

		}

		//check username tồn tại chưa
		public async Task<bool> UserNameExistsAsync(string userName)
		{
			return await _context.Customers.AnyAsync(c => c.Username == userName);
		}
		//check email tồn tại chưa
		public async Task<bool> EmailExistsAsync(string email)
		{
			return await _context.Customers.AnyAsync(c => c.Email == email);
		}	

		public async Task<Customer?> GetByUsernameAsync(string username)
		{
			var customer= await _context.Customers
				.AsNoTracking()
				.FirstOrDefaultAsync(c => c.Username == username);
			return customer;
		}
	}
}
