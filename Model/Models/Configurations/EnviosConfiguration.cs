﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Models;
using System;
using System.Collections.Generic;

namespace Model.Models.Configurations
{
    public partial class EnviosConfiguration : IEntityTypeConfiguration<Envios>
    {
        public void Configure(EntityTypeBuilder<Envios> entity)
        {
            entity.HasKey(e => e.IdEnvio)
                .HasName("PK__Envios__8C48C8CAB335D2C2");

            entity.Property(e => e.IdEnvio)
                .ValueGeneratedNever()
                .HasColumnName("id_envio");

            entity.Property(e => e.Destino)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("destino");

            entity.Property(e => e.EstadoEnvio)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("estado_envio");

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");

            entity.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.Envios)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Envios__id_produ__39237A9A");

            entity.HasOne(d => d.IdVentaNavigation)
                .WithMany(p => p.Envios)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Envios__id_venta__3A179ED3");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Envios> entity);
    }
}
