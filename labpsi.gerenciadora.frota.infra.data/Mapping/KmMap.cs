using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace labpsi.gerenciadora.frota.infra.data.Mapping
{
    public class KmMap : IEntityTypeConfiguration<Km>
    {
        public void Configure(EntityTypeBuilder<Km> builder)
        {
            builder.ToTable("Km");
            builder.HasKey(veiculo => veiculo.Id);

            builder.Property(veiculo => veiculo.Id)
             .HasDefaultValue(Guid.NewGuid());

            builder.Property(km => km.KmAtual)
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .IsRequired();

            builder.Property(km => km.Destino)
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .IsRequired();

            builder.Property(km => km.DataChegada)
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .IsRequired();

            builder.Property(km => km.DateSaida)
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .IsRequired();

            //builder.Property("_combustivelId")
            //       .UsePropertyAccessMode(PropertyAccessMode.Field)
            //       .HasColumnName("Placa")
            //       .IsRequired();

        }
    }
}
