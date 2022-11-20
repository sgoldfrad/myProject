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
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;
        
        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpGet]
        public List<ClaimDTO> Get()
        {
            return _claimService.GetAll();
        }

        [HttpGet("{id}")]
        public ClaimDTO Get(int id)
        {
            return _claimService.GetById(id);
        }

    }
}

