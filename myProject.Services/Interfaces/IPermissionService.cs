using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myProject.Common.DTOs;
using myProject.Repositories.Entities;

namespace myProject.Services.Interfaces
{
  public  interface IPermissionService
    {
        List<PermissionDTO> GetAll();

        PermissionDTO GetById(int id);

        PermissionDTO Add(int id, string name, string description);

        PermissionDTO Update(PermissionDTO Permission);

        void Delete(int id);
    }
}
