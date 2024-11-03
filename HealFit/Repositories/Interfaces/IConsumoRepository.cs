using HealFit.DTO.Response;
using HealFit.Models;

namespace HealFit.Repositories.Interfaces; 
public interface IConsumoRepository : IRepository<Consumo>{

    Task<ConsumoDTOResponse> ConsultaTotalConsumo(int id, DateTime dataInicio, DateTime dataFinal);
}
