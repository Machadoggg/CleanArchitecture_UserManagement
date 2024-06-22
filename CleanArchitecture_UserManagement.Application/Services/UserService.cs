using CleanArchitecture_UserManagement.Domain.Entities;
using CleanArchitecture_UserManagement.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture_UserManagement.Application
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null || !VerifyPassword(user.PasswordHash, password))
            {
                throw new Exception("Invalid credentials.");
            }
            return user;
        }

        private bool VerifyPassword(string storedHash, string password)
        {
            // Simulación de la verificación del hash
            return storedHash == password; // NOTA: Utilizar una verificación de hash segura en un entorno real
        }
    }
}
