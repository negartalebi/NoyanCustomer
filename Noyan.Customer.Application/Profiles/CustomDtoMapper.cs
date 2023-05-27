using AutoMapper;
using Noyan.Customers.Core.Domain;
using Noyan.Customers.Core.DTOs;
using Noyan.Customers.Core.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Application.Profiles
{
    public class CustomDtoMapper:Profile
    {
        public CustomDtoMapper()
        {
            CreateMap<Customer, CustomerListDto>()
                .ForMember(dest => dest.NameFamily, opt => opt.MapFrom(src => $"{src.Name} {src.Family}"))
                .ForMember(dest => dest.BirthdateFa, opt => opt.MapFrom(src => src.Birthdate.ToPersianDate()));

            CreateMap<Customer, CustomerDto>() 
               .ForMember(dest => dest.BirthdateFa, opt => opt.MapFrom(src => src.Birthdate.ToPersianDate()));

            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
           
        }
    }
}
