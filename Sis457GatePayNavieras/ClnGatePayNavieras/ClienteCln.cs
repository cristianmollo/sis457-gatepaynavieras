using CadGatePayNavieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnGatePayNavieras
{
    public class ClienteCln
    {
        // metodo para insertar un cliente
        public static int insertar(Cliente cliente) // Cliente es la tabla de la base de datos  cliente es el objeto que se va a insertar
        {
            using (var context = new LabGatePayNavierasEntities()) // crea una instancia de la base de datos
            {
               context.Cliente.Add(cliente); // agrega el cliente a la base de datos
                context.SaveChanges(); // guarda los cambios en la base de datos
                return cliente.Id; // retorna el id del cliente
            }
        }

        // metodo para actualizar
        public static int actualizar(Cliente cliente)
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                //este es como decir select * from cliente where id = cliente.id
                var existente = context.Cliente.Find(cliente.Id); // busca el cliente por id
                // aqui se valida si el cliente existe
                if (existente != null) // si existe el cliente
                {
                    //actualiza los valores del cliente
                    existente.Nombre = cliente.Nombre;
                    existente.Telefono = cliente.Telefono;
                    existente.Email = cliente.Email;
                    existente.TipoCliente = cliente.TipoCliente;
                    existente.usuarioRegistro = cliente.usuarioRegistro;
                    existente.fechaRegistro = cliente.fechaRegistro;
                    existente.estado = cliente.estado;
                    //todo esto es lo musmo decir update cliente set nombre = cliente.nombre, telefono = cliente.telefono, email = cliente.email, tipoCliente = cliente.tipoCliente, usuarioRegistro = cliente.usuarioRegistro, fechaRegistro = cliente.fechaRegistro, estado = cliente.estado where id = cliente.id
                    
                }
                return context.SaveChanges(); // guarda los cambios en la base de datos
            }
        }

        // metodo para eliminar
        public static int eliminar(int id, string usuario) // ecibe de parametro un id
        {
            using (var context = new LabGatePayNavierasEntities())
            {
                var cliente = context.Cliente.Find(id); // busca el cliente por id
                cliente.estado = -1; // cambia el estado del cliente a -1
                cliente.usuarioRegistro = usuario; // asigna el usuario que elimina el cliente
                return context.SaveChanges(); // guarda los cambios en la base de datos
            }
        }

        // metodo para encontrar un cliente por id
    }
}
