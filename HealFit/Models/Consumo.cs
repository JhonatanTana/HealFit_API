using System.ComponentModel.DataAnnotations;

namespace HealFit.Models; 
public class Consumo {

    [Key]
    public int ConsumoId { get; set; }
    public DateTime Data { get; set; }
    public double Quantidade { get; set; }

    [StringLength(50)]
    public string Produto { get; set; }
    public int ServingId { get; set; }
    [StringLength(50)]
    public string ServingDescription { get; set; }
    [StringLength(10)]
    public string MetricServingAmount { get; set; }
    [StringLength(8)]
    public string MetricServingUnit { get; set; }
    [StringLength(8)]
    public string NumberOfUnits { get; set; }
    [StringLength(50)]
    public string MeasurementDescription { get; set; }
    [StringLength(8)]
    public double Calories { get; set; }
    [StringLength(8)]
    public double Carbohydrate { get; set; }
    [StringLength(8)]
    public double Protein { get; set; }
    [StringLength(8)]
    public double Fat { get; set; }
    [StringLength(8)]
    public double SaturatedFat { get; set; }
    [StringLength(8)]
    public double PolyunsaturatedFat { get; set; }
    [StringLength(8)]
    public double MonounsaturatedFat { get; set; }
    [StringLength(8)]
    public double Cholesterol { get; set; }
    [StringLength(8)]
    public double Sodium { get; set; }
    [StringLength(8)]
    public double Potassium { get; set; }
    [StringLength(8)]
    public double Fiber { get; set; }
    [StringLength(8)]
    public double Sugar { get; set; }
    [StringLength(8)]
    public double VitaminA { get; set; }
    [StringLength(8)]
    public double VitaminC { get; set; }
    [StringLength(8)]
    public double Calcium { get; set; }
    [StringLength(8)]
    public double Iron { get; set; }
    [StringLength(8)]
    public double TransFat { get; set; }
    [StringLength(8)]
    public double AddedSugars { get; set; }
    [StringLength(8)]
    public double VitaminD { get; set; }
    [StringLength(8)]
    public int UsuarioId { get; set; }
}
