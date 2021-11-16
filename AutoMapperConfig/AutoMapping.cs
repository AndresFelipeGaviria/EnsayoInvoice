using AutoMapper;
using Prueba1.Dtos;
using Prueba1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba1.AutoMapperConfig
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<ClienteDto, ClienteResponseDto>().ReverseMap();
            CreateMap<ClienteDto, ClienteRequestDto>().ReverseMap();
        }
    }
}
