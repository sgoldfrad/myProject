using myProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Repositories.Interfaces
{
    public interface IPermissionReporitory
    {
        List<Permission> GetAll();

        Permission GetById(int id);

        Permission Add(int id, string name, string description);

        Permission Update(Permission permission);

        void Delete(int id);


    }
}
