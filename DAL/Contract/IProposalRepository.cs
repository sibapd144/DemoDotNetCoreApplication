using DemoDotnetCoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreApp.DAL.Contract
{
    public interface IProposalRepository
    {
        int AddProposal(Proposal ProposalDetails);
    }
}
