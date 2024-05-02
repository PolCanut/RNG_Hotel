using System;
using System.Collections.Generic;
using System.Linq;
using RNG.Models;

namespace RNG.Controllers
{
    public class Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public Controller(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Método para obtener todos los clientes
        public List<Cliente> ObtenerClientes()
        {
            return _dbContext.Clientes.ToList();
        }

        // Método para obtener todas las reservas
        public List<Reserva> ObtenerReservas()
        {
            return _dbContext.Reservas.ToList();
        }
    }
}

