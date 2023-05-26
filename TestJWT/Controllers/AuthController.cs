using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestJWT.Models;
using TestJWT.Services;

namespace TestJWT.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _authServices;

        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices;
        }

        
    }
}
