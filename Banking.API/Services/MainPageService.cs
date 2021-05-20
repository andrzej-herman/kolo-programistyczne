using Banking.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.API.Database;
using Banking.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Banking.API.Services
{
    public class MainPageService : IMainPageService
    {
        private readonly BankContext _db;

        public MainPageService(BankContext context)
        {
            _db = context;
        }

        public async Task<List<MainPageInfo>> GetMainPageData()
        {
            return await _db.MainPageData.OrderByDescending(info => info.Date).Take(3).ToListAsync();
        }
    }
}





// Transaction

//public async Task AddInfos(List<MainPageInfo> infos)
//{
//    _db.ClearErrors();
//    using (var transaction = _db.Database.BeginTransaction())
//    {
//        try
//        {
//            foreach (var info in infos)
//            {
//                await _db.MainPageData.AddAsync(info);
//                await _db.SaveChangesAsync();
//            }
//            await transaction.CommitAsync();
//        }
//        catch (Exception ex)
//        {
//            _db.AddError(ex.ToString());
//            await transaction.RollbackAsync();
//        }
//    }
//}
