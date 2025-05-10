using CadGatePayNavieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnGatePayNavieras
{
    public class UsuarioCln
    {
        public static int Insertar(Usuario usuario) // esto sirve para insertar un usuario
        {
            using (var context = new LabGatePayNavierasEntities()) // esto es para crear una instancia 
            {
                context.Usuario.Add(usuario); // esto es para agregar el usuario a la base de datos
                context.SaveChanges(); // esto es para guardar los cambios en la base de datos
                return usuario.Id; // suponiendo que tu campo PK se llama Id
            }
        }

        public static int Actualizar(Usuario usuario) // esto sirve para actualizar un usuario
        {
            using (var context = new LabGatePayNavierasEntities()) // esto es para crear una instancia
            {
                var existente = context.Usuario.Find(usuario.Id); // esto es para buscar el usuario en la base de datos
                existente.NombreUsuario = usuario.NombreUsuario; // esto es para actualizar el nombre de usuario
                existente.Contrasena = usuario.Contrasena; // esto es para actualizar la contraseña
                existente.Rol = usuario.Rol; // esto es para actualizar el rol
                existente.usuarioRegistro = usuario.usuarioRegistro; // esto es para actualizar el usuario que registro
                return context.SaveChanges(); // esto es para guardar los cambios en la base de datos
            }
        }

        public static int Eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                var usuario = context.Usuario.Find(id); // esto es para buscar el usuario en la base de datos
                usuario.estado = -1; // eliminación lógica
                usuario.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Usuario Validar(string nombreUsuario, string contrasena) // esto sirve para validar el usuario y la contraseña
        {
            using (var context = new LabGatePayNavierasEntities()) // esto es para crear una instancia
            {
                return context.Usuario // esto es para buscar el usuario en la base de datos
                    .Where(u => u.NombreUsuario == nombreUsuario && u.Contrasena == contrasena && u.estado == 1)
                    .FirstOrDefault(); // esto es para obtener el primer usuario que cumpla con la condición
            }
        }

        public static Usuario ObtenerPorId(int id) // esto sirve para obtener un usuario por su id
        {
            using (var context = new LabGatePayNavierasEntities()) // esto es para crear una instancia
            {
                return context.Usuario.Find(id); // esto es para buscar el usuario en la base de datos
            }
        }

        public static List<Usuario> Listar() // esto sirve para listar los usuarios
        {
            using (var context = new LabGatePayNavierasEntities()) // esto es para crear una instancia
            {
                return context.Usuario // esto es para buscar los usuarios en la base de datos
                    .Where(u => u.estado != -1) // esto es para filtrar los usuarios que no han sido eliminados
                    .OrderBy(u => u.NombreUsuario) // esto es para ordenar los usuarios por nombre
                    .ToList(); // esto es para convertir el resultado a una lista
            }
        }

    }
}
