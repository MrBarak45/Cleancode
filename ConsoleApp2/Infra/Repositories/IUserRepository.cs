using ConsoleApp2.Infra.Entities;

namespace ConsoleApp2.Infra.Repositories
{
    public interface IUserRepository
    {
        User findById(int userId);
    }
}