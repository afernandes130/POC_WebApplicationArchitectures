using AutoMapper;
using Core.Domain;
using Core.DTO;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    class CaseServices : ICaseServices
    {
        private readonly IMapper _mapper;
        private readonly ICaseRepository _caseRepository;
        public CaseServices(IMapper mapper)
        {
            _mapper = mapper;
        }
        public void UpdateCase(CaseDTO caseDTO)
        {
            Case casedomain =  _mapper.Map<Case>(caseDTO);
            _caseRepository.Update(casedomain);
        }
    }
}
