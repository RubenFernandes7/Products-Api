using ProductsApi.Modules.Dto;
using ProductsApi.Modules.Users.Interfaces;

namespace ProductsApi.Modules.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<List<RetrieveUser>> ListUsers(RetrieveUser retrieveUser)
        {
            throw new NotImplementedException();
        }
    }
}
