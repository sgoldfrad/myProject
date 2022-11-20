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
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _ClaimRepository;
        private readonly IMapper _mapper;

        public ClaimService(IClaimRepository ClaimRepository, IMapper mapper)
        {
            _ClaimRepository = ClaimRepository;
            _mapper = mapper;
        }
        public ClaimDTO Add(int id, int roleId, int permissionId,EPolicyDTO ePolicyDTO)
        {
            EPolicy p = (EPolicy)ePolicyDTO;

            return _mapper.Map<ClaimDTO>(_ClaimRepository.Add(id, roleId, permissionId, p));
                
        }

        public void Delete(int id)
        {
            _ClaimRepository.Delete(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _mapper.Map<List<ClaimDTO>>(_ClaimRepository.GetAll());
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_ClaimRepository.GetById(id));
        }

        public ClaimDTO Update(ClaimDTO claim)
        {
            return _mapper.Map<ClaimDTO>(_ClaimRepository.Update(_mapper.Map<Claim>(claim)));
        }
    }
}
