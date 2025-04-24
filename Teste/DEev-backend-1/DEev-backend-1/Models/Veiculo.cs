using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEev_backend_1.Models
{
    [Table("Veiculos")]  
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigátorio informar o Nome do Veículo!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigátorio informar a Placa do Veículo!")]
        public string Placa { get; set; }
       
        [Required(ErrorMessage = "Obrigátorio informar o Ano de Fabricação do Veículo!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
       
        [Required(ErrorMessage = "Obrigátorio informar o Ano do Modelo do Veículo!")]
        [Display(Name = "Ano do Modelo")]   
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }

    }
}
