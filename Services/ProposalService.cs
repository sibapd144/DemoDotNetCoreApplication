using DemoDotnetCoreApp.DAL.Contract;
using DemoDotnetCoreApp.Models;
using DemoDotnetCoreApp.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace DemoDotnetCoreApp.Services
{
    public class ProposalService : IProposalService
    {
        
        private readonly IProposalRepository _iProposalRepository;
        private readonly IMapper _mapper;
        public ProposalService(IProposalRepository IProposalRepository,IMapper mapper)
        {
            _iProposalRepository = IProposalRepository;
            _mapper = mapper;
        }

        public int AddProposal(DemoDotnetCoreApp.Models.Proposal proposal)
        {
            return _iProposalRepository.AddProposal(_mapper.Map<DemoDotnetCoreApp.Data.Proposal>(proposal));
        }
    }
}
