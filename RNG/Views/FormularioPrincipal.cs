using RNG.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNG.Views
{

    public partial class FormularioPrincipal : Form
    {
        private DbContext dbContext;
        private FormularioReserva formularioReserva;
        private FormularioEmpleados formularioEmpleados;
        private FormularioListaReservas formularioListaReservas;

        public FormularioPrincipal(DbContext context)
        {
            InitializeComponent();
            dbContext = context;

            // Inicializa los formularios secundarios
            formularioReserva = new FormularioReserva(context);
            formularioEmpleados = new FormularioEmpleados(context);
            formularioListaReservas = new FormularioListaReservas(context);
        }

        private void Reserva_Click(object sender, EventArgs e) // Check in/out
        {
            formularioReserva.ShowDialog();
        }

        private void GestionPersonal_Click(object sender, EventArgs e) // personal
        {
            formularioEmpleados.ShowDialog();
        }

        private void ListadoReservas_Click(object sender, EventArgs e) // listado clientes
        {
            formularioListaReservas.ShowDialog();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}