using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class GetCategoryProfile:Profile
    {
        public GetCategoryProfile()
        {
            CreateMap<Category, CategoryDTO>();
        }
        
    }
}
