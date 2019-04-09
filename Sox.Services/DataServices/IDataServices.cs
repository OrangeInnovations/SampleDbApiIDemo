using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sox.Services.Models;

namespace Sox.Services.DataServices
{
    public interface IDataServices
    {
        Task<List<CustomerMaster>> FindAllCustomerMasters();
        Task<List<FrequencyMaster>> FindAllFrequencyMasters();
        Task<List<UsecaseMaster>> FindAllUsecaseMasters();
    }
}
