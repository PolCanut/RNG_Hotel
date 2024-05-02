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
using RNG.Controllers;

namespace RNG.Views
{
    public partial class FormularioEmpleados : Form
    {
        private DbContext dbContext;

        private FormularioAgregarEmpleado formularioAgregarEmpleado;
        private FormularioEliminarEmpleado formularioEliminarEmpleado;

        public FormularioEmpleados(DbContext context)
        {
            InitializeComponent();
            dbContext = context;

            formularioAgregarEmpleado = new FormularioAgregarEmpleado(context);
            formularioEliminarEmpleado = new FormularioEliminarEmpleado(context);
        }

        private void AgregarEmpleado_Click(object sender, EventArgs e)
        {
            formularioAgregarEmpleado.ShowDialog();
        }

        private void EliminarEmpleado_Click(object sender, EventArgs e)
        {
            formularioEliminarEmpleado.ShowDialog();
        }
    }
}
