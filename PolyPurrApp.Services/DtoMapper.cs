using AutoMapper;
using PolyPurrApp.Core.Dtos;
using PolyPurrApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPurrApp.Services
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<UserAppDto, User>().ReverseMap();
        }
    }
}
