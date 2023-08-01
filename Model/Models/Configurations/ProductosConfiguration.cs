﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Models;
using System;
using System.Collections.Generic;

namespace Model.Models.Configurations
{
    public partial class ProductosConfiguration : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> entity)
        {
            entity.HasKey(e => e.IdProducto)
                .HasName("PK__Producto__FF341C0D17EB058E");

            entity.Property(e => e.IdProducto)
                .ValueGeneratedNever()
                .HasColumnName("id_producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");

            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");

            entity.Property(e => e.Producto)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("producto");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Productos> entity);
    }
}
