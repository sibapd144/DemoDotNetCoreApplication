using DemoDotnetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDotnetCoreApp.Services.Contract;

namespace DemoDotnetCoreApp.Controllers
{
    public class ProposalController : Controller
    {
        private IProposalService _iProposalService;
        public ProposalController(IProposalService IproposalService)
        {
            _iProposalService = IproposalService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult AddProposal(Boolean iSuccess=false)
        {
            ViewBag.iSuccess = iSuccess;
            return View();
        }
        [HttpPost]
        public IActionResult AddProposal(Proposal ProposalDetails)
        {
           
           int id= _iProposalService.AddProposal(ProposalDetails);
            if(id>0)
            {
                return RedirectToAction("AddProposal",new {
                    iSuccess = true
                });
            }
           return View();
        }
    }
}
