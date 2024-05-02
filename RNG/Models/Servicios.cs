using System;
using System.Collections.Generic;
using System.Linq;
using RNG.Models;

namespace RNG.Models
{
    public class Servicios
    {
        private readonly ApplicationDbContext _dbContext;

        public Servicios(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Métodos relacionados con la gestión de clientes
        public List<Cliente> ObtenerClientes()
        {
            return _dbContext.Clientes.ToList();
        }

        public void RegistrarCliente(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();
        }

        // Métodos relacionados con la gestión de empleados
        public List<Empleado> ObtenerEmpleados()
        {
            return _dbContext.Empleados.ToList();
        }

        public void RegistrarEmpleado(Empleado empleado)
        {
            _dbContext.Empleados.Add(empleado);
            _dbContext.SaveChanges();
        }

        // Métodos relacionados con la gestión de reservas
        public List<Reserva> ObtenerReservas()
        {
            return _dbContext.Reservas.ToList();
        }

        public void CrearReserva(Reserva reserva)
        {
            _dbContext.Reservas.Add(reserva);
            _dbContext.SaveChanges();
        }

    }
}
