using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CommandLineApi.Core.DTO;
using CommandLineApi.Infrastructure.Models;

namespace CommandLineApi.Core.Profiles
{
    public class CommandLineProfile : Profile
    {
        public CommandLineProfile()
        {
            CreateMap<Command, CommandResponseDto>();
        }
    }
}
