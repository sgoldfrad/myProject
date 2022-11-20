using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myProject.Mock;
using myProject.Repositories.Entities;
using myProject.Repositories.Interfaces;
using myProject.Repositories.Rpositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myProject.Services.Interfaces;
using myProject.Common.DTOs;

namespace MyProject.WebAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public List<RoleDTO> Get()
        {
            return _roleService.GetAll();
        }

        [HttpGet("{id}")]
        public RoleDTO Get(int id)
        {
            return _roleService.GetById(id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleService.Delete(id);
        }
        //[HttpPost]
        //public RoleDTO Post([FromBody] RoleModel model)
        //{
        //    return new Role { Id = model.Id };
        //}
        //[HttpPut("{id},{name},{d}")]
        //public Role Put(int id, string name,string d)
        //{
        //    Role r = new Role(id, name, d);
        //    return _roleService.Update(r);
        //}
    }
}

