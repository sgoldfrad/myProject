using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Common.DTOs
{
    public enum EPolicyDTO { Allow, Deny }
    public class ClaimDTO
    {
        public int Id { get; set; }
        public int RoleID { get; set; }
        public int PermissionId { get; set; }
        public EPolicyDTO Policy { get; set; }

        public ClaimDTO(int id, int roleID, int permissionId, EPolicyDTO policy)
        {
            Id = id;
            RoleID = roleID;
            PermissionId = permissionId;
            Policy = policy;
        }
        public ClaimDTO()
        {

        }
    }
}
