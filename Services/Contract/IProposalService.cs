using DemoDotnetCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreApp.Services.Contract
{
    public interface IProposalService
    {
        int AddProposal(Proposal proposal);
    }
}
