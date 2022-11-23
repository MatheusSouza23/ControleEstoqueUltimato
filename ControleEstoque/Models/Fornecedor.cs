﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.Models
{
    public enum Estado { AC, AL, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO }

    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo CNPJ é Obrigaório")]
        [Display(Name = "CNPJ: ")]
        public int CNPJ { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo nome é Obrigatório")]
        [Display(Name = "Nome da Empresa: ")]
        public string nome { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Campo cidade é Obrigatório")]
        [Display(Name = "Cidade: ")]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Campo estado é Obrigatório")]
        [Display(Name = "Estado: ")]
        public Estado estado { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
