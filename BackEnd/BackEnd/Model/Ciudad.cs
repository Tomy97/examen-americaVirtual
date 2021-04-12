using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Model
{
    public class Ciudad
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int PaisId { get; set; }

        public Pais Pais { get; set; }
    }
}
