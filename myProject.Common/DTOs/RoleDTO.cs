using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Common.DTOs
{
     public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public RoleDTO(global::System.Int32 id, global::System.String name, global::System.String description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public RoleDTO()
        {

        }
    }
}
