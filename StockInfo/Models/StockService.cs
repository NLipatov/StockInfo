using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockInfo.Models
{
    public class StockService
    {
        private readonly AppDBContext _appDBContext;
        public StockService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<List<Stock>> GetAllStocksAsync()
        {
            return await _appDBContext.Stocks.ToListAsync();
        }
        public async Task<bool> InsertStockAsync(Stock stock)
        {
            await _appDBContext.Stocks.AddAsync(stock);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<Stock> GetStockAsync(string ticket)
        {
            Stock stock = await _appDBContext.Stocks.FirstOrDefaultAsync(x => x.Ticket == ticket);
            return stock;
        }
        public async Task<bool> UpdateStockAsync(Stock stock)
        {
            _appDBContext.Stocks.Update(stock);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteStockAsync(Stock stock)
        {
            _appDBContext.Remove(stock);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
