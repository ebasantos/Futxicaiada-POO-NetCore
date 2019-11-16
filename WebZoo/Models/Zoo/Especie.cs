using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebZoo.Models.Zoo
{
    public class Especie
    {
        [Key]
        public int EspecieId { get; set; }
        [Required]
        public string Nome { get; set; }

        public ICollection<Animal> Animais { get; set; }
    }
}
