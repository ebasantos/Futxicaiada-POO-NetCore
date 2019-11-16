using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebZoo.Models.Zoo
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [ForeignKey("Especie")]
        public int EspecieId { get; set; }
        [Required]
        [HiddenInput(DisplayValue = true)]
        [Display(Name = "Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        
        public virtual Especie Especie { get; set; }
    }
}
