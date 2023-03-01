using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiBaseReserva.Controllers.Common
{
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult Execute(Func<object> func)
        {
            try
            {
                return Ok(func());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
