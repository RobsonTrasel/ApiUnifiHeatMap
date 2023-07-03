using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiUnifiHeatMap.Domain.Entities;
using ApiUnifiHeatMap.Domain.Interfaces.Repositories;
using ApiUnifiHeatMap.Domain.Interfaces.Service;

namespace ApiUnifiHeatMap.Domain.Services;

public class SinalService : ISinalService
{
    private readonly IAntenaRepository _antenaRepository;
    private readonly ILeituraDeSinalRepository _leituraDeSinalRepository;

    public SinalService(IAntenaRepository antenaRepository, ILeituraDeSinalRepository leituraSinalRepository)
    {
        _antenaRepository = antenaRepository;
        _leituraDeSinalRepository = leituraSinalRepository;
    }

    public async Task<IEnumerable<Antena>> GetAllAntenasAsync()
    {
        return await _antenaRepository.GetAllAntenasAsync();
    }

    public async Task<IEnumerable<LeituraSinal>> GetLeiturasSinalByAntenaIdAsync(int antenaId)
    {
        return await _leituraDeSinalRepository.GetLeiturasSinalByAntenaIdAsync(antenaId);
    }

    public async Task AddLeituraSinalAsync(int antenaId, int sinal)
    {
        var antena = await _antenaRepository.GetAntenaByIdAsync(antenaId);
        if (antena == null)
        {
            throw new Exception($"Antena with ID {antenaId} not found.");
        }
        
        var leituraSinal = new LeituraSinal
        {
            AntenaId = antenaId,
            Sinal = sinal,
            DataLeitura = DateTime.UtcNow
        };

        await _leituraDeSinalRepository.CreateLeituraSinalAsync(leituraSinal);
    }
}

