using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DTO.CustomerDataTransferObj;

namespace DTO.MapDTO_Entity
{
	public class MapperDTO_Enity :Profile
	{
		public MapperDTO_Enity()
		{
			#region Map 
			CreateMap<Customer, CustomerDTO>(MemberList.None)
				.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
				.ForMember(dest => dest.Password, opt => opt.Ignore())
				.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
				.ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
				.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
			#endregion
		}
	}
}
