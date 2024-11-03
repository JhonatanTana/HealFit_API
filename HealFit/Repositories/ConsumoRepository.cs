using HealFit.Context;
using HealFit.DTO.Response;
using HealFit.Models;
using HealFit.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealFit.Repositories; 
public class ConsumoRepository : Repository<Consumo>, IConsumoRepository {

    public ConsumoRepository(AppDbContext context) : base(context) {
    }

    public async Task<ConsumoDTOResponse> ConsultaTotalConsumo(int id, DateTime dataInicio, DateTime dataFinal) {

        var resultado = await _context.DadosPessoais.GroupJoin(
            _context.Consumo.Where(c => c.Data.Date >= dataInicio.Date && c.Data <= dataFinal.Date)
            .Where(c => c.UsuarioId == id),
            dp => dp.UsuarioId,
            c => c.UsuarioId,
            (dp, total) => new {
                dp.UsuarioId,
                Calories = total.Sum(c => c.Calories),
                Carbohydrate = total.Sum(c => c.Carbohydrate),
                Protein = total.Sum(c => c.Protein),
                Fat = total.Sum(c => c.Fat),
                SaturatedFat = total.Sum(c => c.SaturatedFat),
                PolyunsaturatedFat = total.Sum(c => c.PolyunsaturatedFat),
                MonounsaturatedFat = total.Sum(c => c.MonounsaturatedFat),
                Cholesterol = total.Sum(c => c.Cholesterol),
                Sodium = total.Sum(c => c.Sodium),
                Potassium = total.Sum(c => c.Potassium),
                Fiber = total.Sum(c => c.Fiber),
                Sugar = total.Sum(c => c.Sugar),
                VitaminA = total.Sum(c => c.VitaminA),
                VitaminC = total.Sum(c => c.VitaminC),
                VitaminD = total.Sum(c => c.VitaminD),
                Iron = total.Sum(c => c.Iron),
                TransFat = total.Sum(c => c.TransFat),
                AddedSugars = total.Sum(c => c.AddedSugars)
            }).ToListAsync();

        // Transformar o resultado em ConsumoDTOResponse
        var consumoDTOResponse = new ConsumoDTOResponse {

            Calories = Convert.ToDecimal(resultado.Sum(r => r.Calories)),
            Carbohydrate = Convert.ToDecimal(resultado.Sum(r => r.Carbohydrate)),
            Protein = Convert.ToDecimal(resultado.Sum(r => r.Protein)),
            Fat = Convert.ToDecimal(resultado.Sum(r => r.Fat)),
            SaturatedFat = Convert.ToDecimal(resultado.Sum(r => r.SaturatedFat)),
            PolyunsaturatedFat = Convert.ToDecimal(resultado.Sum(r => r.PolyunsaturatedFat)),
            MonounsaturatedFat = Convert.ToDecimal(resultado.Sum(r => r.MonounsaturatedFat)),
            Cholesterol = Convert.ToDecimal(resultado.Sum(r => r.Cholesterol)),
            Sodium = Convert.ToDecimal(resultado.Sum(r => r.Sodium)),
            Potassium = Convert.ToDecimal(resultado.Sum(r => r.Potassium)),
            Fiber = Convert.ToDecimal(resultado.Sum(r => r.Fiber)),
            Sugar = Convert.ToDecimal(resultado.Sum(r => r.Sugar)),
            VitaminA = Convert.ToDecimal(resultado.Sum(r => r.VitaminA)),
            VitaminC = Convert.ToDecimal(resultado.Sum(r => r.VitaminC)),
            VitaminD = Convert.ToDecimal(resultado.Sum(r => r.VitaminD)),
            Iron = Convert.ToDecimal(resultado.Sum(r => r.Iron)),
            TransFat = Convert.ToDecimal(resultado.Sum(r => r.TransFat)),
            AddedSugars = Convert.ToDecimal(resultado.Sum(r => r.AddedSugars))
        };

        return consumoDTOResponse;
    }


}
