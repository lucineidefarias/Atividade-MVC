using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace aec_mvc_entity_framework.Models
{
    [Table("tb_cliente")]

    public class Cliente
    {
        [Key]
        [Column("cod")]
        public int Codigo { get; set; }

        [Column("nome", TypeName = "varchar")]
        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }

        [Column("telefone", TypeName = "varchar")]
        [MaxLength(15)]
        [Required]
        public string Telefone { get; set; }

         public ICollection<Pedido> Pedidos { get; set; }
    }
}