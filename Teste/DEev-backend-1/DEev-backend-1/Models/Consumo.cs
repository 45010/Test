using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEev_backend_1.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição")]
        [Display(Name="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        public  DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int Km { get; set; }
        [Display(Name ="Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        public int VeiculoId { get; set; }
       
        [ForeignKey("VeiculoId")]
        public Veiculo veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina = 1,
        Etanol = 2,
        Diesel = 3,
        GNV = 4
    }

}
