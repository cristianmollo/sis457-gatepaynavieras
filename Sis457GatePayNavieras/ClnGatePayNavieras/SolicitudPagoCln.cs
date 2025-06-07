using CadGatePayNavieras;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClnGatePayNavieras
{
    public class SolicitudPagoCln
    {
        // Método para insertar una solicitud de pago
        public static int insertar(SolicitudPago solicitud)
        {
            try
            {
                using (var context = new LabGatePayNavierasEntities())
                {
                    context.SolicitudPago.Add(solicitud);
                    context.SaveChanges();
                    return solicitud.Id;
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var innerMessage = ex.InnerException?.InnerException?.Message;
                throw new Exception("Error al guardar la solicitud: " + innerMessage, ex);
            }
        }

        //public static int insertar(SolicitudPago solicitud)
        //{
        //    using (var context = new LabGatePayNavierasEntities())
        //    {
        //        try
        //        {
        //            context.SolicitudPago.Add(solicitud);
        //            context.SaveChanges();
        //            return solicitud.Id;
        //        }
        //        catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
        //        {
        //            var innerMessage = ex.InnerException?.InnerException?.Message;
        //            throw new Exception("Error al guardar la solicitud: " + innerMessage, ex);
        //        }
        //    }
        //}

        // Método para actualizar una solicitud de pago
        public static int actualizar(SolicitudPago solicitud)
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                // Busca la solicitud de pago por id
                var existente = context.SolicitudPago.Find(solicitud.Id);
                // Valida si la solicitud existe
                if (existente != null)
                {
                    // Actualiza los valores de la solicitud
                    existente.IdCliente = solicitud.IdCliente;
                    existente.IdNaviera = solicitud.IdNaviera;
                    existente.NumeroBL = solicitud.NumeroBL;
                    existente.Contenedor = solicitud.Contenedor;
                    existente.MontoEstimado = solicitud.MontoEstimado;
                    existente.TipoCambio = solicitud.TipoCambio;
                    existente.Comision = solicitud.Comision;
                    existente.EstadoG = solicitud.EstadoG;
                    // Si quieres agregar más campos, actualiza aquí
                }
                return context.SaveChanges(); // Guarda los cambios en la base de datos
            }
        }

        // Método para eliminar una solicitud de pago (se puede cambiar el estado a "eliminado")
        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                var solicitud = context.SolicitudPago.Find(id); // Busca la solicitud de pago por id
                solicitud.EstadoG = "Eliminado"; // Cambia el estado a "Eliminado"
                solicitud.usuarioRegistro = usuario; // Asigna el usuario que elimina la solicitud
                return context.SaveChanges(); // Guarda los cambios en la base de datos
            }
        }

        // Método para obtener una solicitud de pago por id
        public static SolicitudPago obtenerUno(int id)
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                return context.SolicitudPago.Find(id); // Busca la solicitud de pago por id
            }
        }

        // Método para listar todas las solicitudes de pago
        public static List<SolicitudPago> listar()
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                return context.SolicitudPago.Where(x => x.EstadoG != "Eliminado").ToList(); // Lista todas las solicitudes activas
            }
        }

        // Método con procedimiento almacenado para listar solicitudes de pago
        public static List<paSolicitudPagoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                var result = context.paSolicitudPagoListar(parametro).ToList(); // Llama al procedimiento almacenado
                return result;
            }
        }
    }
}
