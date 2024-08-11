using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCEmpleados.Models.Seeds
{
    public class DepartamentoSeed: IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                new Departamento { ID = 1, Nombre = "Recursos Humanos", Descripcion = "" },
                new Departamento { ID = 2, Nombre = "Tecnologia", Descripcion = "" },
                new Departamento { ID = 3, Nombre = "Ventas", Descripcion = "" }
                );

        }
    }
}
