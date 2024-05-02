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
    public partial class FormularioEliminarEmpleado : Form
    {
        private DbContext dbContext;
        private Empleado empleadoAEliminar;

        public FormularioEliminarEmpleado(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        public void SetEmpleado(Empleado empleado)
        {
            empleadoAEliminar = empleado;
        }

        private void IdEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void IdEmpleadoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha ingresado una ID válida
                if (!string.IsNullOrEmpty(IdEmpleadoText.Text))
                {
                    int idEmpleado = int.Parse(IdEmpleadoText.Text);

                    // Buscar el empleado en la base de datos por su ID
                    Empleado empleadoAEliminar = dbContext.Set<Empleado>().Find(idEmpleado);

                    if (empleadoAEliminar != null)
                    {
                        // Eliminar el empleado de la base de datos
                        dbContext.Set<Empleado>().Remove(empleadoAEliminar);
                        dbContext.SaveChanges();

                        MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún empleado con la ID proporcionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese la ID del empleado que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese una ID de empleado válida (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

    }
}
