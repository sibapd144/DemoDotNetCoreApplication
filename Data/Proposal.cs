using System;
using System.Collections.Generic;

#nullable disable

namespace DemoDotnetCoreApp.Data
{
    public partial class Proposal
    {
        public string Title { get; set; }
        public int? SiteNo { get; set; }
        public string Description { get; set; }
        public int ProposalId { get; set; }

        public static explicit operator Proposal(Models.Proposal v)
        {
            throw new NotImplementedException();
        }
    }
}
