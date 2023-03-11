using ProductsApi.Modules.Dto;
using ProductsApi.Modules.Users.Models;

namespace ProductsApi.Modules.Users.Interfaces
{
    public interface IUserRepository
    {
        Task<List<RetrieveUser>> ListUsers(RetrieveUser retrieveUser);
    }
}
