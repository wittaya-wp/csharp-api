using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.interfaces
{
    public interface IStockRepository
    {
        Task<List<StockDto>> GetAllASync();
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
    }
}