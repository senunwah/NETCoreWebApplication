using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonShoeLib.Domain;
using PersonShoeLib.Services;

namespace NETCoreWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public readonly IPersonService _personservice;

        public DefaultController(IPersonService personservice)
        {
            this._personservice = personservice;
        }
        public Task<IList<Person>> GetPersons(string name)
        {
            return _personservice.GetPersons(name);
        }

    }
}