using ConsoleApp2.Infra.Entities;
using ConsoleApp2.Infra.Repositories;

namespace ConsoleApp2.Usecases
{
    public class PublicUserProductCalc : IProductCalc
    {
        private readonly IProductRepository _productRepository;

        public PublicUserProductCalc(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product CalculatePrice(int productId, int? userId=null)
        {
            return _productRepository.findById(productId);
        }
    }
}
