using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PWCWeb.ViewModels;
using Sox.Services.Models;

namespace PWCWeb.Services
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMappings();
        }

        private void CreateMappings()
        {
            CreateSampleDbModelsMappings();

            
        }

        private void CreateSampleDbModelsMappings()
        {
            CreateMap<CustomerMaster, CustomerMasterVm>();

            CreateMap<FrequencyMaster, FrequencyMasterVm>();
            CreateMap<UsecaseMaster, UsecaseMasterVm>();
        }
    }
}
