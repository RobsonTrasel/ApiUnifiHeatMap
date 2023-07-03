using System.Collections.Generic;
using System.Threading.Tasks;
using ApiUnifiHeatMap.Domain.Entities;

namespace ApiUnifiHeatMap.Domain.Interfaces.Service;

public interface ISinalService
{
    Task<IEnumerable<Antena>> GetAllAntenasAsync();
    Task<IEnumerable<LeituraSinal>> GetLeiturasSinalByAntenaIdAsync(int antenaId);
    Task AddLeituraSinalAsync(int antenaId, int sinal);   
}