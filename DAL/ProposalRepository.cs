using DemoDotnetCoreApp.DAL.Contract;
using DemoDotnetCoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotnetCoreApp.DAL
{
    public class ProposalRepository:IProposalRepository
    {
       
        public int AddProposal(Proposal ProposalDetails)
        {
            using (AzureConsultationDatabaseContext ctx= new AzureConsultationDatabaseContext())
            {
                ctx.Proposals.Add(new Proposal()
                {
                    SiteNo=ProposalDetails.SiteNo,
                    Title=ProposalDetails.Title,
                    Description=ProposalDetails.Description
                });
                int rowsaffected=ctx.SaveChanges();
                return rowsaffected;
            }
            
        }
    }
}
