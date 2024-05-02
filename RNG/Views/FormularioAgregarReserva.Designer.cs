namespace RNG.Views
{
    partial class FormularioAgregarReserva
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
            NombreCliente = new Label();
            NombreText = new TextBox();
            FechaEntrada = new Label();
            FechaEntradaText = new TextBox();
            FechaSalida = new Label();
            FechaSalidaText = new TextBox();
            Confirmar = new Button();
            ApellidoCliente = new Label();
            ApellidoClienteText = new TextBox();
            EmailCliente = new Label();
            EmailClienteText = new TextBox();
            TelefonoCliente = new Label();
            TelefonoClienteText = new TextBox();
            SuspendLayout();
            // 
            // NombreCliente
            // 
            NombreCliente.AutoSize = true;
            NombreCliente.Location = new Point(240, 104);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(51, 15);
            NombreCliente.TabIndex = 0;
            NombreCliente.Text = "Nombre";
            NombreCliente.Click += NombreCliente_Click;
            // 
            // NombreText
            // 
            NombreText.Location = new Point(240, 122);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(128, 23);
            NombreText.TabIndex = 1;
            NombreText.TextChanged += NombreText_TextChanged;
            // 
            // FechaEntrada
            // 
            FechaEntrada.AutoSize = true;
            FechaEntrada.Location = new Point(441, 148);
            FechaEntrada.Name = "FechaEntrada";
            FechaEntrada.Size = new Size(81, 15);
            FechaEntrada.TabIndex = 2;
            FechaEntrada.Text = "Fecha Entrada";
            FechaEntrada.Click += FechaEntrada_Click;
            // 
            // FechaEntradaText
            // 
            FechaEntradaText.Location = new Point(441, 166);
            FechaEntradaText.Name = "FechaEntradaText";
            FechaEntradaText.Size = new Size(128, 23);
            FechaEntradaText.TabIndex = 3;
            FechaEntradaText.TextChanged += FechaEntradaText_TextChanged;
            // 
            // FechaSalida
            // 
            FechaSalida.AutoSize = true;
            FechaSalida.Location = new Point(441, 199);
            FechaSalida.Name = "FechaSalida";
            FechaSalida.Size = new Size(72, 15);
            FechaSalida.TabIndex = 4;
            FechaSalida.Text = "Fecha Salida";
            FechaSalida.Click += FechaSalida_Click;
            // 
            // FechaSalidaText
            // 
            FechaSalidaText.Location = new Point(441, 217);
            FechaSalidaText.Name = "FechaSalidaText";
            FechaSalidaText.Size = new Size(128, 23);
            FechaSalidaText.TabIndex = 5;
            FechaSalidaText.TextChanged += FechaSalidaText_TextChanged;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(344, 354);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(75, 23);
            Confirmar.TabIndex = 6;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // ApellidoCliente
            // 
            ApellidoCliente.AutoSize = true;
            ApellidoCliente.Location = new Point(240, 148);
            ApellidoCliente.Name = "ApellidoCliente";
            ApellidoCliente.Size = new Size(51, 15);
            ApellidoCliente.TabIndex = 7;
            ApellidoCliente.Text = "Apellido";
            ApellidoCliente.Click += ApellidoCliente_Click;
            // 
            // ApellidoClienteText
            // 
            ApellidoClienteText.Location = new Point(240, 166);
            ApellidoClienteText.Name = "ApellidoClienteText";
            ApellidoClienteText.Size = new Size(128, 23);
            ApellidoClienteText.TabIndex = 8;
            ApellidoClienteText.TextChanged += ApellidoClienteText_TextChanged;
            // 
            // EmailCliente
            // 
            EmailCliente.AutoSize = true;
            EmailCliente.Location = new Point(240, 192);
            EmailCliente.Name = "EmailCliente";
            EmailCliente.Size = new Size(36, 15);
            EmailCliente.TabIndex = 9;
            EmailCliente.Text = "Email";
            EmailCliente.Click += EmailCliente_Click;
            // 
            // EmailClienteText
            // 
            EmailClienteText.Location = new Point(240, 210);
            EmailClienteText.Name = "EmailClienteText";
            EmailClienteText.Size = new Size(128, 23);
            EmailClienteText.TabIndex = 10;
            EmailClienteText.TextChanged += EmailClienteText_TextChanged;
            // 
            // TelefonoCliente
            // 
            TelefonoCliente.AutoSize = true;
            TelefonoCliente.Location = new Point(240, 237);
            TelefonoCliente.Name = "TelefonoCliente";
            TelefonoCliente.Size = new Size(52, 15);
            TelefonoCliente.TabIndex = 11;
            TelefonoCliente.Text = "Telefono";
            TelefonoCliente.Click += TelefonoCliente_Click;
            // 
            // TelefonoClienteText
            // 
            TelefonoClienteText.Location = new Point(240, 255);
            TelefonoClienteText.Name = "TelefonoClienteText";
            TelefonoClienteText.Size = new Size(128, 23);
            TelefonoClienteText.TabIndex = 12;
            TelefonoClienteText.TextChanged += TelefonoClienteText_TextChanged;
            // 
            // FormularioAgregarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TelefonoClienteText);
            Controls.Add(TelefonoCliente);
            Controls.Add(EmailClienteText);
            Controls.Add(EmailCliente);
            Controls.Add(ApellidoClienteText);
            Controls.Add(ApellidoCliente);
            Controls.Add(Confirmar);
            Controls.Add(FechaSalidaText);
            Controls.Add(FechaSalida);
            Controls.Add(FechaEntradaText);
            Controls.Add(FechaEntrada);
            Controls.Add(NombreText);
            Controls.Add(NombreCliente);
            Name = "FormularioAgregarReserva";
            Text = "Agregar Reserva";
            Load += FormularioAgregarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreCliente;
        private TextBox NombreText;
        private Label FechaEntrada;
        private TextBox FechaEntradaText;
        private Label FechaSalida;
        private TextBox FechaSalidaText;
        private Button Confirmar;
        private Label ApellidoCliente;
        private TextBox ApellidoClienteText;
        private Label EmailCliente;
        private TextBox EmailClienteText;
        private Label TelefonoCliente;
        private TextBox TelefonoClienteText;
    }
}