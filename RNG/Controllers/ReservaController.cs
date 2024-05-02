using RNG.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RNG.Controllers
{
    public class ReservaController
    {
        private readonly ApplicationDbContext dbContext;

        public ReservaController()
        {
            dbContext = new ApplicationDbContext(); // Crea una instancia del DbContext
        }

        // Método para realizar una reserva
        public void RealizarReserva(Reserva reserva)
        {
            if (reserva != null)
            {
                dbContext.Reservas.Add(reserva);
                dbContext.SaveChanges();
                MessageBox.Show("Reserva realizada correctamente.");
            }
            else
            {
                MessageBox.Show("Error al realizar la reserva. Por favor, revise los datos ingresados.");
            }
        }

        // Método para consultar la lista de reservas
        public IQueryable<Reserva> ConsultarReservas()
        {
            return dbContext.Reservas;
        }

        // Método para buscar una reserva por su ID
        public Reserva BuscarReservaPorId(int idReserva)
        {
            return dbContext.Reservas.FirstOrDefault(r => r.idReserva == idReserva);
        }

        // Método para actualizar los datos de una reserva
        public void ActualizarReserva(Reserva reserva)
        {
            if (reserva != null)
            {
                dbContext.Entry(reserva).State = EntityState.Modified;
                dbContext.SaveChanges();
                MessageBox.Show("Reserva actualizada correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar la reserva. Por favor, revise los datos ingresados.");
            }
        }

        // Método para cancelar una reserva
        public void CancelarReserva(int idReserva)
        {
            var reserva = dbContext.Reservas.FirstOrDefault(r => r.idReserva == idReserva);
            if (reserva != null)
            {
                dbContext.Reservas.Remove(reserva);
                dbContext.SaveChanges();
                MessageBox.Show("Reserva cancelada correctamente.");
            }
            else
            {
                MessageBox.Show("Error al cancelar la reserva. Reserva no encontrada.");
            }
        }
    }
}
