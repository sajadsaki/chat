using System.Diagnostics;
using MediatR;
using Persistent;
using Domin;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Application.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Activiti,Activiti>();
        }
    }
}