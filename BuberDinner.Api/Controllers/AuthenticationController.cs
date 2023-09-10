
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _IAuthenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _IAuthenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest registerRequest)
        {
            var authResult = _IAuthenticationService.Register(
                registerRequest.FirstName, 
                registerRequest.LastName, 
                registerRequest.Email, 
                registerRequest.Password);

            AuthenticationResponse authenticationResponse = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token);

            return Ok(authenticationResponse);
        }
        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            var authResult = _IAuthenticationService.Login(
            loginRequest.Email,
            loginRequest.Password);

            AuthenticationResponse authenticationResponse = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token);

            return Ok(authenticationResponse);
        }
    }
}
