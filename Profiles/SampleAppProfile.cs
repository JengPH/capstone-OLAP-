using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Capstone_Olapp.Models;
using Capstone_Olapp.Identity;

namespace Capstone_Olapp.Profiles
{
    public class Capstone_OlappProfile : Profile
    {
        public Capstone_OlappProfile()
        {
            CreateMap<Aspnetuser, ApplicationUser>();
        }
    }
}