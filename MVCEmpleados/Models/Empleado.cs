using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace MVCEmpleados.Models
{
    public class Empleado
    {
        public int ID { get; set; }

        [Display(Name = "Nombre empleado")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener minimo 2 y maximo 100 caracteres")]
        [Required(ErrorMessage = "El nombre del empleado es obligatorio")]
        public string Nombre { get; set; }


        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime FechaNacimiento { get; set; }


        [Display(Name = "Fecha de contratacion")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de contratacion es obligatoria")]
        public DateTime FechaContratacion { get; set; }


        [Display(Name = "Departamento asignado")]
        //Propiedad para la llave foranea
        [Required]
        [ForeignKey("Departamento")]
        public int? DepartamentoId { get; set; }

        //Propiedad de navegacion
        public Departamento Departamento { get; set; }



        [Display(Name = "Salario del empleado")]
        [Range(1,1000000, ErrorMessage = "El precio debe ser un valor positivo mayor a 1")]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "El salario del empleado es obligatorio")]
        public decimal Salario { get; set; }


        public string? Descripcion { get; set; }
    }
}
