using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DemoDotnetCoreApp.Models
{
    public class Proposal
    {

        public int ProposalId { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Site No")] 
        public int? SiteNo { get; set; }
        [Display(Name="Details")]
        public string Description { get; set; }
    }
}
