using AutoMapper;
using HealFit.DTO.Response;
using HealFit.Models;

namespace HealFit.DTO.Mapping;
public class ConsumoDTOMappingProfile : Profile{
    public ConsumoDTOMappingProfile() {

        CreateMap<Consumo, ConsumoDTO>().ReverseMap();
        CreateMap<ConsumoDTOResponse, ConsumoDTO>().ReverseMap();
        CreateMap<ConsumoDTOResponse, Consumo>().ReverseMap();

    }
}
