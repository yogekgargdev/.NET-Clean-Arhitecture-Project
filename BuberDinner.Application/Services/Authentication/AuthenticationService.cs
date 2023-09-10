using BuberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public readonly IJwtTokenGenerator _jwtTokenGenerator;
        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "first", "last", "email", "token");
        }

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator) { 
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {

            // Check if User Already exists

            // Create User (Genertae unique Id)

            // Create JWT Token
            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId,FirstName,LastName);

            return new AuthenticationResult(userId, FirstName, LastName, Email, token);
        }
    }
}
