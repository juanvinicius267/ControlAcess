using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Br.Sa.Scania.KD.ControlAccess.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ApiUserController : Controller
    {
        [Route("apiUser/CreateUser")]
        [HttpPost]
        public ActionResult CreateUser()
        {
            return Ok();
        }
        [Route("apiUser/DeleteUser")]
        [HttpPost]
        public ActionResult DeleteUser()
        {
            return Ok();
        }
        [Route("apiUser/ReadUser")]
        [HttpPost]
        public ActionResult ReadUser()
        {
            return Ok();
        }
        [Route("apiUser/UpdateUser")]
        [HttpPost]
        public ActionResult UpdateUser()
        {
            return Ok();
        }

    }
}