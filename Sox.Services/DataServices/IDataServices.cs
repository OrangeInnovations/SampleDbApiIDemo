using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sox.Services.Models;

namespace Sox.Services.DataServices
{
    interface IDataServices
    {
        Task<List<CustomerMaster>> FindAllCustomerMasters();
        Task<List<FrequencyMaster>> FindAllFrequencyMaster();
        Task<List<UsecaseMaster>> FindAllUsecaseMaster();
    }
}
