using System.Collections.Generic;
using System.Threading.Tasks;
using ApiUnifiHeatMap.Domain.Entities;

namespace ApiUnifiHeatMap.Domain.Interfaces.Repositories;

public interface ILeituraDeSinalRepository
{
    Task<IEnumerable<LeituraSinal>> GetAllLeiturasSinalAsync();
    Task<IEnumerable<LeituraSinal>> GetLeiturasSinalByAntenaIdAsync(int antenaId);
    Task CreateLeituraSinalAsync(LeituraSinal leituraSinal);
}