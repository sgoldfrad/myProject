using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myProject.Common.DTOs;
using myProject.Repositories.Entities;

namespace myProject.Services.Interfaces
{
  public  interface IClaimService
    {
        List<ClaimDTO> GetAll();

        ClaimDTO GetById(int id);

        ClaimDTO Add(int id, int roleId, int permissionId, EPolicyDTO ePolicyDTO);

        ClaimDTO Update(ClaimDTO claim);

        void Delete(int id);
    }
}
