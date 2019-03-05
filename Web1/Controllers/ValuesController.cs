using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Common;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<DataObjectCollection> Get()
        {
            var items = new DataObjectCollection
            {
                new DataObject{ Id = 1, Name = "bnaya"},
                new DataObject{ Id = 2, Name = "aline"}
            };
            return items;
        }

        [HttpPost]
        public ActionResult<DataObjectCollection> Post([FromBody]DataObjectCollection data)
        { 
            if(data is SysParamCollection s)
                    s[0].Score++;
            data[0].Name += "_modified";
            return data;
        }

    }
}
