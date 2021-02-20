using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDotnetCoreApp.Models;
using DemoDotnetCoreApp.Data;
using AutoMapper;

namespace DemoDotnetCoreApp
{
    public class AutoMapping :Profile
    {
        public AutoMapping()
        {
            CreateMap<DemoDotnetCoreApp.Models.Proposal, DemoDotnetCoreApp.Data.Proposal>();
        }
    }
}
