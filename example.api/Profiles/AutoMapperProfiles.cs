using AutoMapper;
using example.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.api.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, example.api.DomainModels.Student>()
                .ReverseMap();
            CreateMap<Gender, example.api.DomainModels.Gender>()
                .ReverseMap();
            CreateMap<Address, example.api.DomainModels.Address>()
                .ReverseMap();

        }
    }
}
