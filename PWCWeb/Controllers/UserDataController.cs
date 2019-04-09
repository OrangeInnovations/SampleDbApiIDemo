using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PWCWeb.ViewModels;
using Sox.Services.DataServices;

namespace PWCWeb.Controllers
{
    [Route("api/[controller]")]
    public class UserDataController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly IDataServices _dataServices;

        public UserDataController(IMapper mapper,IDataServices dataServices)
        {
            _mapper = mapper;
            _dataServices = dataServices;
        }


        [ProducesResponseType(typeof(IEnumerable<CustomerMasterVm>), 200)]
        [HttpGet("CustomerMasters", Name = "CustomerMasters")]
        public async Task<IActionResult> FindAllCustomerMastersAsync(string authUserId)
        {

            var list = await _dataServices.FindAllCustomerMasters();

            var finalList= _mapper.Map<List<CustomerMasterVm>>(list);

           
            return Ok(finalList);
        }


        [ProducesResponseType(typeof(IEnumerable<FrequencyMasterVm>), 200)]
        [HttpGet("FrequencyMasters", Name = "FrequencyMasters")]
        public async Task<IActionResult> FindAllFrequencyMastersAsync(string authUserId)
        {

            var list = await _dataServices.FindAllFrequencyMasters();

            var finalList = _mapper.Map<List<FrequencyMasterVm>>(list);


            return Ok(finalList);
        }

        [ProducesResponseType(typeof(IEnumerable<UsecaseMasterVm>), 200)]
        [HttpGet("UsecaseMasters", Name = "UsecaseMasters")]
        public async Task<IActionResult> FindAllUsecaseMastersAsync(string authUserId)
        {

            var list = await _dataServices.FindAllUsecaseMasters();

            var finalList = _mapper.Map<List<UsecaseMasterVm>>(list);


            return Ok(finalList);
        }


    }
}
