﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Envios
    {
        public int IdEnvio { get; set; }
        public string Destino { get; set; }
        public string EstadoEnvio { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public virtual Productos IdProductoNavigation { get; set; }
        public virtual Ventas IdVentaNavigation { get; set; }
    }
}