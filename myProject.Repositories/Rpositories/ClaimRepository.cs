using myProject.Repositories.Entities;
using myProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Repositories.Rpositories
{
    public class ClaimRepository : IClaimRepository
    {
        
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claim Add(int id, int roleID, int permissionId, EPolicy policy)
        {
            Claim c1 = new Claim(id,roleID,permissionId,policy);
            _context.Claims.Add(c1);
            return c1;
        }

        public void Delete(int id)
        {
            _context.Claims.Remove(_context.Claims.Find(r => r.Id == id));
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.Find(r => r.Id == id);
        }

        public Claim Update(Claim claim)
        {
            var updated = _context.Claims.Find(c => c.Id == claim.Id);
            updated.RoleID = claim.RoleID;
            updated.PermissionId = claim.PermissionId;
            updated.Policy = claim.Policy;
            return updated;
        }
    }
}
