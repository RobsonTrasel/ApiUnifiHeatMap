using ApiUnifiHeatMap.Domain.ValueObjects;

namespace ApiUnifiHeatMap.Domain.Entities;

public class Antena
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Coordenadas Coordenadas { get; set; }
    
    public ICollection<LeituraSinal> LeituraSinal { get; set; }
}