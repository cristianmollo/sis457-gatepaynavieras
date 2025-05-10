using CadGatePayNavieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClnGatePayNavieras
{
    public class NavieraCln
    {
        public static int insertar(Naviera naviera)
        {
            using (var db = new LabGatePayNavierasEntities())
            {
                naviera.estado = 1; // Asigna estado activo
                naviera.fechaRegistro = DateTime.Now; // Asigna fecha de registro
                db.Naviera.Add(naviera); // Agrega la naviera a la base de datos
                db.SaveChanges(); // Guarda los cambios
                return naviera.Id; // Retorna el ID de la naviera insertada

            }
        }

        public static int actualizar(Naviera naviera)
        {
            using (var db = new LabGatePayNavierasEntities())
            {
                var existente = db.Naviera.Find(naviera.Id); // Busca la naviera por ID
                if (existente != null) // Si existe la naviera
                {
                    existente.Nombre = naviera.Nombre; // Actualiza el nombre
                    existente.URLPortal = naviera.URLPortal; // Actualiza la URL del portal
                    existente.usuarioRegistro = naviera.usuarioRegistro; // Actualiza el usuario que registró
                    return db.SaveChanges(); // Guarda los cambios
                }
                return 0; // Retorna 0 si no se encontró la naviera
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var db = new LabGatePayNavierasEntities())
            {
                var naviera = db.Naviera.Find(id); // Busca la naviera por ID
                if (naviera != null) // Si existe la naviera
                {
                    naviera.estado = -1; // Cambia el estado a eliminado
                    naviera.usuarioRegistro = usuarioRegistro; // Asigna el usuario que elimina
                    return db.SaveChanges(); // Guarda los cambios
                }
                return 0; // Retorna 0 si no se encontró la naviera
            }
        }

        public static Naviera obtenerPorId(int id)
        {
            using (var db = new LabGatePayNavierasEntities())
            {
                return db.Naviera.Find(id); // Busca la naviera por ID
            }
        }

        // metodo para listar toda las navieras
        public static List<Naviera> obtenerTodos()
        {
            using (var db = new LabGatePayNavierasEntities())
            {
                return db.Naviera.Where(x => x.estado == 1).ToList(); // Lista todas las navieras activas
            }
        }

        // metodo ahora listar con el procedimiento almacenado
        public static List<paNavieraListar_Result> listar(string parametro)
        {
            using (var db = new LabGatePayNavierasEntities())
            {
                return db.paNavieraListar(parametro).ToList(); // Llama al procedimiento almacenado y convierte el resultado a lista
            }
        }

    }
}
