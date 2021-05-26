using System;
using System.Linq;
using ConsoleApp2.Infra.Entities;
using ConsoleApp2.Infra.Repositories;

namespace ConsoleApp2.Usecases
{
    public class RegisteredUserProductCalc : IProductCalc
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        private readonly IHistoryRepository _historyRepository;
       
        public RegisteredUserProductCalc(IUserRepository userRepository, IProductRepository productRepository, IHistoryRepository historyRepository)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
            _historyRepository = historyRepository;
        }


        public Product CalculatePrice(int productId, int? userId)
        {
            var rate = 0;

            var product = _productRepository.findById(productId);

            var historyList = _historyRepository.GetSellHistoryByUserId(userId);

            var lastSixMonthsProducts = historyList.Where(x => x.SellDate > DateTime.Now.AddMonths(-6)).ToList();
            if (lastSixMonthsProducts.Count >= 3)
            {
                rate -= 10;
            }

            var lastYearMonthsProducts = historyList
                .Where(x => x.SellDate > DateTime.Now.AddYears(-1))
                .GroupBy(x => x.Product.ProductId)
                .Where(x => x.Count() > 5)
                .ToList();

            if (lastYearMonthsProducts.Count > 0)
            {
                rate += 5;
            }

            product.Price.Price *= (rate / 100);
            product.Price.UpdateDate = DateTime.Now;

            return product;
        }
    }
}