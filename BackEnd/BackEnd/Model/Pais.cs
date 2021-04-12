using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Model
{
    public class Pais
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public List<Ciudad> Ciudades { get; set; }

    }
}
