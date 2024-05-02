namespace RNG.Views
{
    partial class FormularioModificarReserva
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
            EmailCliente = new Label();
            EmailClienteText = new TextBox();
            FechaEntrada = new Label();
            FechaEntradaText = new TextBox();
            FechaSalida = new Label();
            FechaSalidaText = new TextBox();
            Confirmar = new Button();
            listBoxReservas = new ListBox();
            SuspendLayout();
            // 
            // EmailCliente
            // 
            EmailCliente.AutoSize = true;
            EmailCliente.Location = new Point(320, 162);
            EmailCliente.Name = "EmailCliente";
            EmailCliente.RightToLeft = RightToLeft.No;
            EmailCliente.Size = new Size(76, 15);
            EmailCliente.TabIndex = 0;
            EmailCliente.Text = "Email Cliente";
            EmailCliente.Click += EmailCliente_Click;
            // 
            // EmailClienteText
            // 
            EmailClienteText.Location = new Point(309, 180);
            EmailClienteText.Name = "EmailClienteText";
            EmailClienteText.Size = new Size(120, 23);
            EmailClienteText.TabIndex = 1;
            EmailClienteText.TextChanged += EmailClienteText_TextChanged;
            // 
            // FechaEntrada
            // 
            FechaEntrada.AutoSize = true;
            FechaEntrada.Location = new Point(320, 213);
            FechaEntrada.Name = "FechaEntrada";
            FechaEntrada.Size = new Size(81, 15);
            FechaEntrada.TabIndex = 2;
            FechaEntrada.Text = "Fecha Entrada";
            FechaEntrada.Click += FechaEntrada_Click;
            // 
            // FechaEntradaText
            // 
            FechaEntradaText.Location = new Point(309, 231);
            FechaEntradaText.Name = "FechaEntradaText";
            FechaEntradaText.Size = new Size(120, 23);
            FechaEntradaText.TabIndex = 3;
            FechaEntradaText.TextChanged += FechaEntradaText_TextChanged;
            // 
            // FechaSalida
            // 
            FechaSalida.AutoSize = true;
            FechaSalida.Location = new Point(320, 267);
            FechaSalida.Name = "FechaSalida";
            FechaSalida.Size = new Size(72, 15);
            FechaSalida.TabIndex = 4;
            FechaSalida.Text = "Fecha Salida";
            FechaSalida.Click += FechaSalida_Click;
            // 
            // FechaSalidaText
            // 
            FechaSalidaText.Location = new Point(309, 285);
            FechaSalidaText.Name = "FechaSalidaText";
            FechaSalidaText.Size = new Size(120, 23);
            FechaSalidaText.TabIndex = 5;
            FechaSalidaText.TextChanged += FechaSalidaText_TextChanged;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(326, 333);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(75, 23);
            Confirmar.TabIndex = 6;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // listBoxReservas
            // 
            listBoxReservas.FormattingEnabled = true;
            listBoxReservas.ItemHeight = 15;
            listBoxReservas.Location = new Point(249, 125);
            listBoxReservas.Name = "listBoxReservas";
            listBoxReservas.Size = new Size(248, 34);
            listBoxReservas.TabIndex = 7;
            listBoxReservas.SelectedIndexChanged += listBoxReservas_SelectedIndexChanged;
            // 
            // FormularioModificarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxReservas);
            Controls.Add(Confirmar);
            Controls.Add(FechaSalidaText);
            Controls.Add(FechaSalida);
            Controls.Add(FechaEntradaText);
            Controls.Add(FechaEntrada);
            Controls.Add(EmailClienteText);
            Controls.Add(EmailCliente);
            Name = "FormularioModificarReserva";
            Text = "Modificar Reserva";
            Load += FormularioModificarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label EmailCliente;
        private System.Windows.Forms.TextBox EmailClienteText;
        private System.Windows.Forms.Label FechaEntrada;
        private System.Windows.Forms.TextBox FechaEntradaText;
        private System.Windows.Forms.Label FechaSalida;
        private System.Windows.Forms.TextBox FechaSalidaText;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.ListBox listBoxReservas;
    }
}
