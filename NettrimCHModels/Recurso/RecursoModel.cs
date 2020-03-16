using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NettrimCHModels.Recursos
{
    public class RecursoModel
    {
        [Key]
        [Required(ErrorMessage = "El Id del Recurso es necesario")]
        [StringLength(4)]
        public string IdRecurso { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [Range(4, int.MaxValue, ErrorMessage = "Introduce una clave correcta")]
        public int Clave { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
   
        public bool Baja { get; set; }

        [StringLength(50)]
        public string Apellido1 { get; set; }

        [StringLength(50)]
        public string Apellido2 { get; set; }

        [RegularExpression("^[0-9]{8,8}[A-Za-z]$"),]
        public string DNI { get; set; }
    }
}
