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
    public partial class FormularioListaReservas : Form
    {
        private DbContext dbContext;
        public FormularioListaReservas(DbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private void FormularioListaReservas_Load(object sender, EventArgs e)
        {
            // Obtener las reservas de la base de datos
            var reservas = dbContext.Set<Reserva>().ToList();

            // Asignar los datos al DataGridView
            ListadoReservas.DataSource = reservas;
        }

        private void ListadoReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
