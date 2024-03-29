﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using Entidades;
using Franco_Ferro;

namespace SistemaGestionBusiness
{
    public static class ProductoVendidoBusiness
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int IdProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendido(IdProductoVendido);
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }

        public static void EliminarProductoVendido(int IdProductoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(new ProductoVendido { ID = IdProductoVendido });
        }
    }
}

