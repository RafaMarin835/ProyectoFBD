using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ClaseRecibirDatos
    {
        private readonly ClaseSQLManager datosService = new ClaseSQLManager();


        #region Clientes

        public DataTable ObtenerClientes() //Ver todos los clientes registrados
        {
            return datosService.RecuperarTablaCompleta(0); // índice 0 = Clientes
        }

        public DataTable BuscarClientePorIdentificacion(string identificacion) //Buscar Cliente por identificación
        {
            return datosService.RecuperarPorIdentificador(identificacion, 0); // índice 0 = Cliente
        }

        public DataTable ObtenerClientesPorMembresia() //Ver clientes y su membresía
        {
            return datosService.RecuperarVista(0); // índice 0 = vw_ClientesxMembresia
        }

        public DataTable ObtenerClientesPorCompras() //Ver clientes y sus compras
        {
            return datosService.RecuperarVista(1); // índice 1 = vw_ClientesxCompras
        }
        
        public DataTable ObtenerClientesPorUltimoPagoMembresia() //Ver clientes y su ultimo pago de membresía
        {
            return datosService.RecuperarVista(2); // índice 2 = vw_ClientesxPagoMembresia
        }

        public DataTable ObtenerClientesConPagosAtrasados() //Ver clientes con pagos de membresía atrasados
        {
            return datosService.RecuperarVista(3); // índice 3 = vw_ClientesxPagoAtrasado
        }

        #endregion

        #region Empleados

        public DataTable ObtenerEmpleados() //Ver todos los empleados registrados
        {
            return datosService.RecuperarTablaCompleta(1); // índice 1 = Empleados
        }

        public DataTable BuscarEmpleadoPorIdentificacion(string identificacion) //Buscar Empleado por identificación
        {
            return datosService.RecuperarPorIdentificador(identificacion, 1); // índice 1 = Empleado
        }

        public DataTable ObtenerAuditoriasEmpleados() //Ver todas las auditorias de los empleados 
        {
            return datosService.RecuperarVista(4); // índice 4 = vw_EmpleadosAuditorias
        }

        #endregion

        #region Proveedores

        public DataTable ObtenerProveedores() //Ver todos los proveedores
        {
            return datosService.RecuperarTablaCompleta(2); // índice 2 = Proveedores
        }

        public DataTable BuscarProveedorPorCedulaProveedor(string CedulaProveedor) //Buscar Proveedor por cedula proveedor
        {
            return datosService.RecuperarPorIdentificador(CedulaProveedor, 2); // índice 2 = Proveedor
        }
        
        public DataTable ObtenerComprasPorProveedorEspecifico(string cedulaProveedor) //Ver todas las compras a proveedor especifico
        {
            return datosService.RecuperarPorIdentificador(cedulaProveedor, 4); // índice 5 = ComprasProveedor
        }

        public DataTable ObtenerComprasPorProveedor() //Ver todas las compras a los proveedores
        {
            return datosService.RecuperarVista(5); // índice 5 = vw_CompraxProveedores
        }

        #endregion

        #region Productos //**************************///////////////////////////***********************************///////////////////////////

        public DataTable ObtenerProductos() //Ver todos los productos
        {
            return datosService.RecuperarTablaCompleta(3); // índice 3 = Productos
        }

        public DataTable BuscarProductoPorCodigo(string codigoProducto) //Buscar Producto por código
        {
            return datosService.RecuperarPorIdentificador(codigoProducto, 3); // índice 3 = Producto
        }

        public DataTable ObtenerMargenGananciaProducto(string codigoProducto) //Margen de ganancia para un producto especifico
        {
            return datosService.RecuperarMargenProductoEspecifico(codigoProducto);
        }

        public DataTable ObtenerProductosConMargen() //Margen de ganancia para todos los productos
        {
            return datosService.RecuperarVista(6); // índice 6 = vw_ProductosConMargen
        }

        public DataTable ObtenerProductosStockBajo() //Ver productos con stock bajo (menos de 10)
        {
            return datosService.RecuperarVista(7); // índice 7 = vw_ProductosStockBajo
        }

        public DataTable ObtenerRentabilidadProductos() //Ver la ganacia total de cada producto
        {
            return datosService.RecuperarVista(8); // índice 8 = vw_RentabilidadProducto
        }

        #endregion

        #region Ventas

        public DataTable ObtenerVentasPorCliente() //Ver todos los registros de ventas
        {
            return datosService.RecuperarVista(9); // índice 9 = vw_VentasClientesProducto
        }

        public DataTable ObtenerVentasPorClienteEspecifico(string Identificacion) //Ver Historial de ventas para un cliente especifico
        {
            return datosService.RecuperarPorIdentificador(Identificacion, 6); // índice 7 = VentasCliente
        }

        public DataTable ObtenerDetalleVentaConMargen() //Ver ventas con detalle del margen de ganacia
        {
            return datosService.RecuperarVista(10); // índice 10 = vw_DetalleVentaConMargen
        }

        public DataTable ObtenerResumenVentasCliente() //Ver resumen de ventas de clientes
        {
            return datosService.RecuperarVista(11); // índice 11 = vw_ResumenVentasCliente
        }

        #endregion

        #region Membresías

        public DataTable ObtenerDetallePagoMembresia() //Ver todo el historial de pagos de membresía
        {
            return datosService.RecuperarVista(12); // índice 12 = vw_PagoMembresiaDetalle
        }

        public DataTable ObtenerClientePagoMembresia(string Identificacion) //Ver cliente especifico y su ultimo pago de membresía
        {
            return datosService.RecuperarPorIdentificador(Identificacion, 7); // índice 6 = ClientePagoMembresia
        }

        #endregion


    }
}
