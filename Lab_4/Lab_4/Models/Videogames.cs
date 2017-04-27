using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_4.Models
{
    public class Videogames
    {
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Fecha de estreno")]
        public DateTime RealeseDAte { get; set; }

        [Display(Name = "Genero")]
        public string Gender { get; set; }

        [Display(Name = "Puesto")]
        public int Ranking { get; set; }

        [Display(Name = "Plataformas disponibles")]
        public string platform { get; set; }

    }
}