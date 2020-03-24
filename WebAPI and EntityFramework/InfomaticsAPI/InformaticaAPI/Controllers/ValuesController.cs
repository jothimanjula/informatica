using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InfomaticsDataLayer;
using InfomaticsDataLayer.Models;


namespace InformaticaAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Useraccounts>> GetUsers()
        {
            using (var context = new INFOMATICSMEETINGContext())
            {
                var users = InfomaticsDataLayer.DBOperations.GetUsers();
                return users;
            }

        }
        // GET api/values
        
    }
}
