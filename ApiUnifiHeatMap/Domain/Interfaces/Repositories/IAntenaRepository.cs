using System.Collections.Generic;
using System.Threading.Tasks;
using ApiUnifiHeatMap.Domain.Entities;

namespace ApiUnifiHeatMap.Domain.Interfaces.Repositories;

public interface IAntenaRepository
{
    Task<IEnumerable<Antena>> GetAllAntenasAsync();
    Task<Antena> GetAntenaByIdAsync(int id);
    Task CreateAntenaAsync(Antena antena);
    Task UpdateAntenaAsync(Antena antena);
    Task DeleteAntenaAsync(int id);
}