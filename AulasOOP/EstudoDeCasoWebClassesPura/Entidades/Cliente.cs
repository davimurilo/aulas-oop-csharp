using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudoDeCasoWebClassesPura.Entidades {

    [Table("TBL_Cliente")]
    public class Cliente {

        [Key]
        public int IdCliente { get; set; }
        public string? NomeCliente { get; set; }
        public string? RG_Cliente { get; set; }
        public string? CPF_Cliente { get; set; }
        public string? SexoCliente { get; set; }
        public DateTime? DataInclusao { get; set; }
        
    }
}
