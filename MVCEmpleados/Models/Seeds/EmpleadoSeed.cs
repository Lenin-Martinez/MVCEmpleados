using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCEmpleados.Models.Seeds
{
    public class EmpleadoSeed: IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado
                {
                    ID = 1,
                    Nombre = "John DOE",
                    FechaNacimiento = DateTime.Parse("1985-05-20"),
                    FechaContratacion = DateTime.Parse("2010-08-15"),
                    Salario = 50000,
                    DepartamentoId = 1,
                    Descripcion = ""
                },
                new Empleado
                {
                    ID = 2,
                    Nombre = "Jane Smith",
                    FechaNacimiento = DateTime.Parse("1990-03-10"),
                    FechaContratacion = DateTime.Parse("2015-01-25"),
                    Salario = 70000,
                    DepartamentoId = 2,
                    Descripcion = ""

                },
                new Empleado
                {
                    ID = 3,
                    Nombre = "Mark Johnson",
                    FechaNacimiento = DateTime.Parse("1982-11-22"),
                    FechaContratacion = DateTime.Parse("2012-06-18"),
                    Salario = 55000,
                    DepartamentoId = 3,
                    Descripcion = ""

                },
                new Empleado
                {
                    ID = 4,
                    Nombre = "Emily Davis",
                    FechaNacimiento = DateTime.Parse("1978-07-30"),
                    FechaContratacion = DateTime.Parse("2005-10-12"),
                    Salario = 75000,
                    DepartamentoId = 1,
                    Descripcion = ""

                },
                new Empleado
                {
                    ID = 5,
                    Nombre = "Michael Brown",
                    FechaNacimiento = DateTime.Parse("1995-12-05"),
                    FechaContratacion = DateTime.Parse("2020-04-15"),
                    Salario = 60000,
                    DepartamentoId = 2,
                    Descripcion = ""

                }
                );
        }

    }
}
