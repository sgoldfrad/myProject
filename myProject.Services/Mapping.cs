using AutoMapper;
using myProject.Common.DTOs;
using myProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Services
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            //CreateMap<Role, RoleDTO>().ReverseMap();
            //CreateMap<Permission, PermissionDTO>().ReverseMap();
            //CreateMap<Claim, ClaimDTO>().ReverseMap();
        }
    }
}
