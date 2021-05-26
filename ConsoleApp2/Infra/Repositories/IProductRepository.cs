using ConsoleApp2.Infra.Entities;

namespace ConsoleApp2.Infra.Repositories
{
    public interface IProductRepository
    {
        Product findById(int userId);
    }
}