using myProject.Repositories.Entities;
using myProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace myProject.Repositories.Rpositories
{
   public  class PermissionRepository : IPermissionReporitory
    {
        private readonly IContext _context;

        public PermissionRepository(IContext context)
        {
            _context = context;
        }

        public Permission Add(int id, string name, string description)
        {
            Permission p = new Permission(id, name, description);
            _context.Permissions.Add(p);
            return p;
        }

        public void Delete(int id)
        {          
            _context.Permissions.Remove(_context.Permissions.Find(p => p.Id == id));
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            return _context.Permissions.Find(r => r.Id == id);
        }

        public Permission Update(Permission permission)
        {

            var p1 = _context.Permissions.Find(r => r.Id == permission.Id);
            p1.Name = permission.Name;
            p1.Description = permission.Description;
            return p1;
        }

      
    }
}