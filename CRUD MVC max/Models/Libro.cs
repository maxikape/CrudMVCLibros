using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC_max.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="es obligatorio")]
        [StringLength(50, ErrorMessage ="el {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength =3)]
        [Display(Name ="Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "es obligatorio")]
        [StringLength(50, ErrorMessage = "el {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }


        [Required(ErrorMessage = "es obligatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "el autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "el precio es obligatorio")]
        public int Precio { get; set; }



    }
}
