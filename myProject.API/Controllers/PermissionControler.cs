using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myProject.Common.DTOs;
using myProject.Mock;
using myProject.Repositories.Entities;
using myProject.Repositories.Interfaces;
using myProject.Repositories.Rpositories;
using myProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpGet]
        public List<PermissionDTO> Get()
        {
            return _permissionService.GetAll();
        }

        [HttpGet("{id}")]
        public PermissionDTO Get(int id)
        {
            return _permissionService.GetById(id);
        }
    }
}

