using RNG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RNG.Controllers;
using System.Data.Entity.Validation;

namespace RNG.Views
{

    public partial class FormularioAgregarReserva : Form
    {
        private DbContext dbContext;

        public FormularioAgregarReserva(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private void FormularioAgregarReserva_Load(object sender, EventArgs e)
        {

        }

        private void NombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void NombreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoCliente_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoClienteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void EmailClienteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefonoCliente_Click(object sender, EventArgs e)
        {

        }

        private void TelefonoClienteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaEntrada_Click(object sender, EventArgs e)
        {

        }

        private void FechaEntradaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaSalida_Click(object sender, EventArgs e)
        {

        }

        private void FechaSalidaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = NombreText.Text;
                string Apellido = ApellidoClienteText.Text;
                string Email = EmailClienteText.Text;
                string Telefono = TelefonoClienteText.Text;

                DateTime fechaEntrada = DateTime.ParseExact(FechaEntradaText.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                DateTime fechaSalida = DateTime.ParseExact(FechaSalidaText.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                Cliente nuevoCliente = new Cliente
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Email = Email,
                    Telefono = Telefono
                };

                // Agregar cliente a la base de datos
                dbContext.Set<Cliente>().Add(nuevoCliente);
                dbContext.SaveChanges();

                // Asignar la reserva al cliente
                Reserva nuevaReserva = new Reserva
                {
                    Email = Email,
                    Fecha_Entrada = fechaEntrada,
                    Fecha_Salida = fechaSalida,
                };

                // Agregar la reserva a la base de datos
                dbContext.Set<Reserva>().Add(nuevaReserva);
                dbContext.SaveChanges();

                // Cerrar el formulario
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato de fecha es incorrecto. Por favor, introduzca la fecha en formato dd-MM-yyyy.");
            }
            catch (DbEntityValidationException ex)
            {
                // Mostrar los mensajes de error de validación al usuario
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Error de validación en la propiedad '{validationError.PropertyName}': {validationError.ErrorMessage}");
                    }
                }
            }
        }

    }
}
