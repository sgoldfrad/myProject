using myProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Repositories.Interfaces
{
      public interface IClaimRepository
    {
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id, int roleID, int permissionId, EPolicy policy);

        Claim Update(Claim claim);

        void Delete(int id);
    }
}
