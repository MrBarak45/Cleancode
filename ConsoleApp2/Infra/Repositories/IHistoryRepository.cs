using System;
using System.Collections.Generic;
using ConsoleApp2.Infra.Entities;

namespace ConsoleApp2.Infra.Repositories
{
    public interface IHistoryRepository
    {
        List<SellHistory> GetSellHistoryByUserId(int? userId);
        // List<SellHistory> GetSellHistoryByUserIdSince(int userId, TimeSpan sinceDateTime);

    }
}