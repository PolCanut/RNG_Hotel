using RNG.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Windows.Forms;

namespace RNG.Views
{
    // Agregar lo necesario para modificar reservas

    public partial class FormularioModificarReserva : Form
    {
        private DbContext dbContext;
        private Reserva reservaAModificar;

        public FormularioModificarReserva(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private void FormularioModificarReserva_Load(object sender, EventArgs e)
        {
            // Llenar el ListBox con las reservas disponibles al cargar el formulario
            var reservas = dbContext.Set<Reserva>().ToList();
            foreach (var reserva in reservas)
            {
                listBoxReservas.Items.Add(reserva);
            }
        }

        private void listBoxReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la reserva seleccionada en el ListBox
            reservaAModificar = (Reserva)listBoxReservas.SelectedItem;

            // Mostrar los detalles de la reserva seleccionada en los controles del formulario
            if (reservaAModificar != null)
            {
                EmailClienteText.Text = reservaAModificar.Cliente.Email;
                FechaEntradaText.Text = reservaAModificar.Fecha_Entrada.ToString("dd-MM-yyyy");
                FechaSalidaText.Text = reservaAModificar.Fecha_Salida.ToString("dd-MM-yyyy");
            }
        }

        private void EmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void EmailClienteText_TextChanged(object sender, EventArgs e)
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
            if (reservaAModificar != null)
            {
                // Actualizar las propiedades de la reserva con los valores del formulario
                reservaAModificar.Fecha_Entrada = DateTime.ParseExact(FechaEntradaText.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                reservaAModificar.Fecha_Salida = DateTime.ParseExact(FechaSalidaText.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                // Actualizar el correo electrónico del cliente asociado si es necesario
                if (reservaAModificar.Cliente.Email != EmailClienteText.Text)
                {
                    reservaAModificar.Cliente.Email = EmailClienteText.Text;
                }

                try
                {
                    // Guardar los cambios en la base de datos
                    dbContext.SaveChanges();
                    MessageBox.Show("Cambios guardados correctamente");

                    // Cerrar el formulario
                    this.Close();
                }
                catch (DbEntityValidationException ex)
                {
                    // Manejar cualquier excepción de validación de entidad aquí
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Error de validación en la propiedad '{validationError.PropertyName}': {validationError.ErrorMessage}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier otra excepción aquí
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una reserva para modificar.");
            }
        }
    }
}