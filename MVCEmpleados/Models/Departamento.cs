using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System.ComponentModel.DataAnnotations;

namespace MVCEmpleados.Models
{
    public class Departamento
    {
        public int ID { get; set; }

        [Display(Name = "Nombre departamento")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener minimo 3 y maximo 100 caracteres")]
        [Required(ErrorMessage = "El nombre del departamento es obligatorio")]
        public string Nombre{ get; set; }


        public string? Descripcion { get; set; }


        //Popiedad de navegacion
        public ICollection<Empleado> Empleados { get; set;}
    }
}
