using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class RegisterUserProfile:Profile
    {
        public RegisterUserProfile()
        {
            CreateMap<RegisterUserDTO, User>();
        }
    }
}
