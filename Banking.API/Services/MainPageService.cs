using Banking.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.API.Database;
using Banking.API.Entities;

namespace Banking.API.Services
{
    public class MainPageService : IMainPageService
    {
        private readonly BankContext _db;

        public MainPageService(BankContext context)
        {
            _db = context;
        }

        public List<MainPageInfo> GetMainPageData()
        {
            return _db.MainPageData.OrderByDescending(info => info.Date).Take(3).ToList();
        }
    }
}
