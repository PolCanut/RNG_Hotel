using RNG.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RNG.Controllers
{
    public class ClienteController
    {
        private readonly ApplicationDbContext _dbContext;

        public ClienteController()
        {
            _dbContext = new ApplicationDbContext(); // Crea una instancia del DbContext
        }

        // Método para registrar un nuevo cliente
        public void RegistrarCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                _dbContext.Clientes.Add(cliente);
                _dbContext.SaveChanges();
                MessageBox.Show("Cliente registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente. Por favor, revise los datos ingresados.");
            }
        }

        // Método para consultar la lista de clientes
        public IQueryable<Cliente> ConsultarClientes()
        {
            return _dbContext.Clientes;
        }

        // Método para actualizar los datos de un cliente
        public void ActualizarCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                _dbContext.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                MessageBox.Show("Cliente actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente. Por favor, revise los datos ingresados.");
            }
        }

        // Método para eliminar un cliente
        //public void EliminarCliente(int idCliente)
        //{
        //    var cliente = _dbContext.Clientes.FirstOrDefault(c => c.idCliente == idCliente);
        //    if (cliente != null)
        //    {
        //        _dbContext.Clientes.Remove(cliente);
        //        _dbContext.SaveChanges();
        //        MessageBox.Show("Cliente eliminado correctamente.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error al eliminar el cliente. Cliente no encontrado.");
        //    }
        //}
        }
}