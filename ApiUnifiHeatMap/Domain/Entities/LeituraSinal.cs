using System;

namespace ApiUnifiHeatMap.Domain.Entities;

public class LeituraSinal
{
    public int Id { get; set; }
    public DateTime DataLeitura { get; set; }
    public int Sinal { get; set; }
    
    public int AntenaId { get; set; }
    public Antena Antena { get; set; }
}