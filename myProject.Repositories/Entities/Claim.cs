using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Repositories.Entities
{
    public enum EPolicy { Allow, Deny}
    public class Claim
    {
        public int Id { get; set; }
        public int RoleID { get; set; }
        public int PermissionId { get; set; }
        public  EPolicy Policy { get; set; }

        public Claim(int id, int roleID, int permissionId, EPolicy policy)
        {
            Id = id;
            RoleID = roleID;
            PermissionId = permissionId;
            Policy = policy;
        }
        public Claim()
        {

        }
    }
}
