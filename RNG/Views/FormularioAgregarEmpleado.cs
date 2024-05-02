using RNG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNG.Views
{
    public partial class FormularioAgregarEmpleado : Form
    {
        private DbContext dbContext;
        public FormularioAgregarEmpleado(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private void NombreEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void NombreEmpleadoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoEmpleadoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = NombreEmpleadoText.Text;
                string Apellido = ApellidoEmpleadoText.Text;

                Empleado nuevoEmpleado = new Empleado
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                };

                // Agregar empleado a la base de datos
                dbContext.Set<Empleado>().Add(nuevoEmpleado);
                dbContext.SaveChanges();

                // Cerrar el formulario
                this.Close();
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
