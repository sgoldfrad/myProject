using AutoMapper;
using myProject.Common.DTOs;
using myProject.Repositories.Entities;
using myProject.Repositories.Interfaces;
using myProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject.Services.services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionReporitory _permissionRepository;
        private readonly IMapper _mapper;

        public PermissionService(IPermissionReporitory permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }
        public PermissionDTO Add(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.Add(id, name, description));
        }

        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }

        public List<PermissionDTO> GetAll()
        {
            return _mapper.Map<List<PermissionDTO>>(_permissionRepository.GetAll());
        }

        public PermissionDTO GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.GetById(id));
        }

        public PermissionDTO Update(PermissionDTO Permission)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.Update(_mapper.Map<Permission>(Permission)));
        }
    }
}
