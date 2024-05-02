namespace RNG.Views
{
    partial class FormularioReserva
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
            AgregarReserva = new Button();
            ModificarReserva = new Button();
            EliminarReserva = new Button();
            SuspendLayout();
            // 
            // AgregarReserva
            // 
            AgregarReserva.Location = new Point(203, 165);
            AgregarReserva.Name = "AgregarReserva";
            AgregarReserva.Size = new Size(100, 100);
            AgregarReserva.TabIndex = 0;
            AgregarReserva.Text = "Agregar Reserva";
            AgregarReserva.UseVisualStyleBackColor = true;
            AgregarReserva.Click += AgregarReserva_Click;
            // 
            // ModificarReserva
            // 
            ModificarReserva.Location = new Point(334, 165);
            ModificarReserva.Name = "ModificarReserva";
            ModificarReserva.Size = new Size(100, 100);
            ModificarReserva.TabIndex = 1;
            ModificarReserva.Text = "Modificar Reserva";
            ModificarReserva.UseVisualStyleBackColor = true;
            ModificarReserva.Click += ModificarReserva_Click;
            // 
            // EliminarReserva
            // 
            EliminarReserva.Location = new Point(464, 165);
            EliminarReserva.Name = "EliminarReserva";
            EliminarReserva.Size = new Size(100, 100);
            EliminarReserva.TabIndex = 2;
            EliminarReserva.Text = "Eliminar Reserva";
            EliminarReserva.UseVisualStyleBackColor = true;
            EliminarReserva.Click += EliminarReserva_Click;
            // 
            // FormularioReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarReserva);
            Controls.Add(ModificarReserva);
            Controls.Add(AgregarReserva);
            Name = "FormularioReserva";
            Text = "Gestion Reservas";
            Load += FormularioReserva_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AgregarReserva;
        private Button ModificarReserva;
        private Button EliminarReserva;
    }
}