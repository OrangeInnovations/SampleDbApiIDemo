using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sox.Services.Models;

namespace Sox.Services.DataServices
{
    public class SampleDbDataServices : IDataServices
    {
        private readonly Sample_DbContext _sampleDbContext;

        public SampleDbDataServices(Sample_DbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }

        public async Task<List<CustomerMaster>> FindAllCustomerMasters()
        {
            return await _sampleDbContext.CustomerMaster.ToListAsync();
        }

        public async Task<List<FrequencyMaster>> FindAllFrequencyMaster()
        {
            return await _sampleDbContext.FrequencyMaster.ToListAsync();
        }

        public async Task<List<UsecaseMaster>> FindAllUsecaseMaster()
        {
            return await _sampleDbContext.UsecaseMaster.ToListAsync();
        }
    }
}