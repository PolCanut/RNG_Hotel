namespace RNG.Views
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GestionarReservas = new Button();
            ListadoReservas = new Button();
            GestionarPersonal = new Button();
            panelContenedor = new Panel();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // GestionarReservas
            // 
            GestionarReservas.Location = new Point(207, 155);
            GestionarReservas.Margin = new Padding(5);
            GestionarReservas.MaximumSize = new Size(1000, 1000);
            GestionarReservas.Name = "GestionarReservas";
            GestionarReservas.Size = new Size(100, 100);
            GestionarReservas.TabIndex = 2;
            GestionarReservas.Text = "Gestionar Reservas";
            GestionarReservas.UseVisualStyleBackColor = true;
            GestionarReservas.Click += Reserva_Click;
            // 
            // ListadoReservas
            // 
            ListadoReservas.Location = new Point(449, 155);
            ListadoReservas.Margin = new Padding(5);
            ListadoReservas.MaximumSize = new Size(1000, 1000);
            ListadoReservas.Name = "ListadoReservas";
            ListadoReservas.Size = new Size(100, 100);
            ListadoReservas.TabIndex = 6;
            ListadoReservas.Text = "Listado Reservas";
            ListadoReservas.UseVisualStyleBackColor = true;
            ListadoReservas.Click += ListadoReservas_Click;
            // 
            // GestionarPersonal
            // 
            GestionarPersonal.Location = new Point(329, 155);
            GestionarPersonal.Margin = new Padding(5);
            GestionarPersonal.MaximumSize = new Size(1000, 1000);
            GestionarPersonal.Name = "GestionarPersonal";
            GestionarPersonal.Size = new Size(100, 100);
            GestionarPersonal.TabIndex = 5;
            GestionarPersonal.Text = "Gestionar Personal";
            GestionarPersonal.UseVisualStyleBackColor = true;
            GestionarPersonal.Click += GestionPersonal_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(ListadoReservas);
            panelContenedor.Controls.Add(GestionarReservas);
            panelContenedor.Controls.Add(GestionarPersonal);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(800, 450);
            panelContenedor.TabIndex = 7;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Name = "FormularioPrincipal";
            Text = "Panel de Control";
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button GestionarReservas;
        private Button ListadoReservas;
        private Button GestionarPersonal;
        private Panel panelContenedor;
    }
}