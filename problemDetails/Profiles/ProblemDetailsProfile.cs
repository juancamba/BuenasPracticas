using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using problemDetails.Dto;
using problemDetails.Models;

namespace problemDetails.Profiles
{
    public class ProblemDetailsProfile : Profile
    {
        public ProblemDetailsProfile()
        {
            CreateMap<OrderDto, Order>()
            .ForMember(d=>d.OrderId, e=>e.MapFrom(s=>s.OrderId))
            .ForMember(d=>d.Date, e=>e.MapFrom(s=>s.Date))
            .ForMember(d=>d.Customer, e=>e.MapFrom(s=>s.Customer))
            .ForMember(d=>d.OrderDetails, e=>e.MapFrom(s=>s.OrderDetails))
            
            
            ;
            CreateMap<ProductDto, Product>();
            CreateMap<OrderDetailDto, OrderDetail>();
            
        }
    }
}