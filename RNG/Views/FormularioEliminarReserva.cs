using RNG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNG.Views
{
    // Agregar lo necesario para eliminar reservas

    public partial class FormularioEliminarReserva : Form
    {
        private DbContext dbContext;
        private Reserva reservaAEliminar;
        public FormularioEliminarReserva(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        public void SetReserva(Reserva reserva)
        {
            reservaAEliminar = reserva;
            // Mostrar los datos de la reserva en los campos del formulario (si es necesario)
        }

        private void FormularioEliminarReserva_Load(object sender, EventArgs e)
        {

        }

        private void EmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void EmailClienteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string email = EmailClienteText.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, introduzca un correo electrónico.");
                return;
            }

            // Buscar el cliente por email
            var cliente = dbContext.Set<Cliente>().FirstOrDefault(c => c.Email == email);
            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún cliente con el correo electrónico especificado.");
                return;
            }

            // Buscar la reserva por email
            var reserva = dbContext.Set<Reserva>().FirstOrDefault(r => r.Cliente.Email == email);
            if (reserva == null)
            {
                MessageBox.Show("No se encontró ninguna reserva asociada al correo electrónico especificado.");
                return;
            }

            try
            {
                // Eliminar el cliente y la reserva
                dbContext.Set<Cliente>().Remove(cliente);
                dbContext.Set<Reserva>().Remove(reserva);
                dbContext.SaveChanges();

                // Cerrar el formulario
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cliente y la reserva: {ex.Message}");
            }
        }
    }
}
