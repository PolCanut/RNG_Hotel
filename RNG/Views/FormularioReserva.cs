using System;
using System.Data.Entity;
using System.Windows.Forms;
using RNG.Controllers;
using RNG.Models;

namespace RNG.Views
{
    public partial class FormularioReserva : Form
    {
        private DbContext dbContext; 
        private FormularioAgregarReserva formularioAgregarReserva;
        private FormularioModificarReserva formularioModificarReserva;
        private FormularioEliminarReserva formularioEliminarReserva;

        public FormularioReserva(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
            formularioAgregarReserva = new FormularioAgregarReserva(context);
            formularioModificarReserva = new FormularioModificarReserva(context);
            formularioEliminarReserva = new FormularioEliminarReserva(context);
        }

        private void AgregarReserva_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario FormularioAgregarReserva
            formularioAgregarReserva.ShowDialog();
        }

        private void ModificarReserva_Click(object sender, EventArgs e)
        {
            formularioModificarReserva.ShowDialog();
        }

        private void EliminarReserva_Click(object sender, EventArgs e)
        {
            formularioEliminarReserva.ShowDialog();
        }

        private void FormularioReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
