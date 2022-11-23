using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo descricao é Obrigaório")]
        [Display(Name = "Descricao: ")]
        public string descricao { get; set; }


        [Required(ErrorMessage = "Campo quantidade é Obrigatório")]
        [Display(Name = "Quantidade: ")]
        public int quantidade { get; set; }

    
        [Required(ErrorMessage = "Campo cidade é Obrigatório")]
        [Display(Name = "Id Produto: ")]
        public int idproduto { get; set; }
    }
}
