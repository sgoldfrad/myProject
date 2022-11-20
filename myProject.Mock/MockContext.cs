using myProject.Repositories.Entities;
using System;
using myProject.Repositories.Interfaces;
using System.Collections.Generic;

namespace myProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        public List<Permission> Permissions { get ; set; }
        public List<Claim> Claims { get; set ; }
        public MockContext()
        {
            Roles = new List<Role>();
            Permissions = new List<Permission>();
            Claims = new List<Claim>();
            Roles.Add(new Role { Id = 1, Name = "admin", Description = "admin with full access" });
            Roles.Add(new Role { Id = 2, Name = "student", Description = "student with limited access" });

            Permissions.Add(new Permission { Id = 1, Name = "ViewAllTests" });
            Permissions.Add(new Permission { Id = 2, Name = "UploadTest" });

            Claims.Add(new Claim { Id = 1, RoleID = 1, PermissionId = 1, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 2, RoleID = 1, PermissionId = 2, Policy = EPolicy.Allow });

            Claims.Add(new Claim { Id = 3, RoleID= 2, PermissionId = 1, Policy = EPolicy.Deny });
            Claims.Add(new Claim { Id = 4, RoleID = 2, PermissionId = 2, Policy = EPolicy.Allow });

        }
    }


}
