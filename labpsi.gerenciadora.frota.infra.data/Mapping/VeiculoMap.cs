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

            builder.Property("_placa")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Placa")
                   .IsRequired();

            builder.Property("_modelo")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Modelo")
                   .IsRequired();

            builder.Property("_ano")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Ano")
                   .IsRequired();

            builder.Property("_chassi")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Chassi")
                   .IsRequired();

            builder.Property("_renavam")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Renavam")
                   .IsRequired();

            builder.Property("_marca")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Marca")
                   .IsRequired();

            builder.Property("_cor")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("Cor")
                   .IsRequired();

            builder.Property("_valorPago")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("ValorPago")
                   .IsRequired();

            builder.Property("_mesIpva")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("MesIpva")
                   .IsRequired();

            builder.Property("_kmAtual")
                   .UsePropertyAccessMode(PropertyAccessMode.Field)
                   .HasColumnName("KmAtual")
                   .IsRequired();

            //builder.Property("_combustivelId")
            //       .UsePropertyAccessMode(PropertyAccessMode.Field)
            //       .HasColumnName("Placa")
            //       .IsRequired();

        }
    }
}
