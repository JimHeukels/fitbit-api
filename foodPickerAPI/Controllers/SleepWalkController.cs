using foodPicker.Model;
using foodPicker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foodPickerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SleepWalkController : ControllerBase
    {

        private readonly FitbitService _service;
        public SleepWalkController(FitbitService service)
        {
            _service = service;
        }

        [HttpGet]
        public FitbitDataEntry[] Get()
        {
            return _service.GetBolongo();
        }

        [HttpPost]
        public void Post([FromBody] FitbitDataEntry fitbitDataEntry)
        {
            _service.addFitbitRecordToDB(fitbitDataEntry);
        }
    }
}
