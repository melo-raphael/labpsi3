using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace labpsi.gerenciadora.frota.infra.data.Mapping
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");
            builder.HasKey(veiculo => veiculo.Id);

            builder.Property(veiculo => veiculo.Id)
             .HasDefaultValue(Guid.NewGuid());

            builder.Property("Placa")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Placa")
                   .IsRequired();

            builder.Property("Modelo")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Modelo")
                   .IsRequired();

            builder.Property("Ano")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Ano")
                   .IsRequired();

            builder.Property("Chassi")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Chassi")
                   .IsRequired();

            builder.Property("Renavam")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Renavam")
                   .IsRequired();

            builder.Property("Marca")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Marca")
                   .IsRequired();

            builder.Property("Cor")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Cor")
                   .IsRequired();

            builder.Property("ValorPago")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("ValorPago")
                   .IsRequired();

            builder.Property("MesIpva")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("MesIpva")
                   .IsRequired();

            builder.Property("KmAtual")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("KmAtual")
                   .IsRequired();

            var navigation = builder.Metadata.FindNavigation(nameof(Veiculo._km));

            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            //builder.Property("_combustivelId")
            //       .UsePropertyAccessMode(PropertyAccessMode.Field)
            //       .HasColumnName("Placa")
            //       .IsRequired();

        }
    }
}
