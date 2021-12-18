using Microsoft.AspNetCore.Mvc;
using Sample.Models.RequestModel;
using Sample.Models.ResponceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly Response _objresponse;
        public AuthenticationController(Response response)
        {
            _objresponse = response;
        }

        //Post:For Login
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginRequest loginRequest)
        {
           
            try
            {
                if (loginRequest != null)
                {
                    _objresponse.status = "Success";
                    _objresponse.payload = loginRequest;
                    _objresponse.message = "User Login Success";
                    return Ok(_objresponse);
                }
                else
                {
                    _objresponse.status = "Fail";
                    _objresponse.payload = null;
                    _objresponse.message = "Invalid Credentials";
                    return Ok(_objresponse);
                }
            }
            catch (Exception ex)
            {
                _objresponse.status = "Expection";
                _objresponse.payload = null;
                _objresponse.message = "Oop! Something went wrong";
                return StatusCode(500, _objresponse);
            }


        }

        //Post:For Register
        [HttpPost("register")]
        public ActionResult Signup([FromBody] RequestSignup SignupRequest)
        {
            try
            {
                if (SignupRequest != null)
                {
                    _objresponse.status = "Success";
                    _objresponse.payload = SignupRequest;
                    _objresponse.message = "User Login Success";
                    return Ok(_objresponse);
                }
                else
                {
                    _objresponse.status = "Fail";
                    _objresponse.payload = null;
                    _objresponse.message = "Invalid Credentials";
                    return Ok(_objresponse);
                }
            }
            catch (Exception ex)
            {
                _objresponse.status = "Expection";
                _objresponse.payload = null;
                _objresponse.message = "Oop! Something went wrong";
                return StatusCode(500, _objresponse);
            }
        }
    }
}
