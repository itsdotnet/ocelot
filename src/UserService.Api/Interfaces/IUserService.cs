using UserService.Api.Entities;

namespace UserService.Api.Interfaces;

public interface IUserService
{
    Task<User> Create(User user);
    Task<User> Update(User user);
    Task<bool> Delete(User user);
    Task<User> GetById(long id);
}