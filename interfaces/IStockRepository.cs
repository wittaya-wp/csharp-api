using api.Dtos.Stock;
using api.Helpers;
using api.Models;

namespace api.interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllASync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}
