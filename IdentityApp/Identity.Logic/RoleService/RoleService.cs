using IdentityApp.Core.Exceptions;
using IdentityApp.Core.Utilities;
using IdentityApp.WebDb.RoleRepository;
using IdentityApp.WebDb.UserRepository;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        private readonly IUserRepository _userRepository;

        public RoleService(IRoleRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<IdentityRole>> GetRolesAsync()
        {
            return await _repository.GetRolesAsync();
        }

        public async Task<Role> GetRoleAsync(string userId)
        {
            var user = await _userRepository.GetUserAsync(userId);

            if (user is null)
            {
                throw new UserNotFoundException("User not found");
            }

            var userRoles = await _userRepository.GetUserRolesAsync(user);

            var allRoles = await _repository.GetRolesAsync();

            return new Role
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserRoles = userRoles.ToList(),
                AllRoles = allRoles.ToList()
            };
        }

        public async Task<IdentityResult> CreateRoleAsync(IdentityRole role)
        {
            return await _repository.CreateRoleAsync(role);
        }

        public async Task UpdateRoleAsync(string userId, List<string> roles)
        {
            var user = await _userRepository.GetUserAsync(userId);

            if (user is null)
            {
                throw new UserNotFoundException("User not found");
            }

            var userRoles = await _userRepository.GetUserRolesAsync(user);

            var allRoles = await _repository.GetRolesAsync();

            var addedRoles = roles.Except(userRoles);
            
            var removedRoles = userRoles.Except(roles);

            await _userRepository.AddToRolesAsync(user, addedRoles);

            await _userRepository.RemoveFromRolesAsync(user, removedRoles);
        }

        public async Task<IdentityResult> DeleteRoleAsync(string id)
        {
            var roleToDelete = await _repository.GetRoleAsync(id);

            if (roleToDelete is null)
            {
                throw new RoleNotFoundException("Role not found");
            }

            return await _repository.DeleteRoleAsync(roleToDelete);
        }
    }
}
