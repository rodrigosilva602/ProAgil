using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.API.Dtos
{
    public class RedeSocialDto
    {
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatorio")]
        public string URL { get; set; }
    }
}
