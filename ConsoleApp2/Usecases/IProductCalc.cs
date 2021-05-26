using ConsoleApp2.Infra.Entities;

namespace ConsoleApp2.Usecases
{
    interface IProductCalc
    {
        Product CalculatePrice(int productId, int? userId);

    }
}