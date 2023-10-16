using UserService.Api.Entities;
using UserService.Api.Interfaces;

namespace UserService.Api.Service;

public class UserService : IUserService
{
    public Task<User> Create(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> Update(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(long id)
    {
        throw new NotImplementedException();
    }
}