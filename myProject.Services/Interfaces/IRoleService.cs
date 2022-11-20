using myProject.Common.DTOs;
using myProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Services.Interfaces
{
   public interface IRoleService
    {
        List<RoleDTO> GetAll();

        RoleDTO GetById(int id);

        RoleDTO Add(int id, string name, string description);

        RoleDTO Update(RoleDTO role);

        void Delete(int id);



    }
}
