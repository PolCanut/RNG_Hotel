namespace RNG.Views
{
    partial class FormularioAgregarEmpleado
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
            NombreEmpleado = new Label();
            NombreEmpleadoText = new TextBox();
            ApellidoEmpleado = new Label();
            ApellidoEmpleadoText = new TextBox();
            Confirmar = new Button();
            SuspendLayout();
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.AutoSize = true;
            NombreEmpleado.Location = new Point(330, 141);
            NombreEmpleado.Name = "NombreEmpleado";
            NombreEmpleado.Size = new Size(51, 15);
            NombreEmpleado.TabIndex = 0;
            NombreEmpleado.Text = "Nombre";
            NombreEmpleado.Click += NombreEmpleado_Click;
            // 
            // NombreEmpleadoText
            // 
            NombreEmpleadoText.Location = new Point(318, 159);
            NombreEmpleadoText.Name = "NombreEmpleadoText";
            NombreEmpleadoText.Size = new Size(136, 23);
            NombreEmpleadoText.TabIndex = 1;
            NombreEmpleadoText.TextChanged += NombreEmpleadoText_TextChanged;
            // 
            // ApellidoEmpleado
            // 
            ApellidoEmpleado.AutoSize = true;
            ApellidoEmpleado.Location = new Point(330, 198);
            ApellidoEmpleado.Name = "ApellidoEmpleado";
            ApellidoEmpleado.Size = new Size(51, 15);
            ApellidoEmpleado.TabIndex = 2;
            ApellidoEmpleado.Text = "Apellido";
            ApellidoEmpleado.Click += ApellidoEmpleado_Click;
            // 
            // ApellidoEmpleadoText
            // 
            ApellidoEmpleadoText.Location = new Point(318, 216);
            ApellidoEmpleadoText.Name = "ApellidoEmpleadoText";
            ApellidoEmpleadoText.Size = new Size(136, 23);
            ApellidoEmpleadoText.TabIndex = 3;
            ApellidoEmpleadoText.TextChanged += ApellidoEmpleadoText_TextChanged;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(341, 308);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(75, 23);
            Confirmar.TabIndex = 4;
            Confirmar.Text = "Confimar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // FormularioAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Confirmar);
            Controls.Add(ApellidoEmpleadoText);
            Controls.Add(ApellidoEmpleado);
            Controls.Add(NombreEmpleadoText);
            Controls.Add(NombreEmpleado);
            Name = "FormularioAgregarEmpleado";
            Text = "FormularioAgregarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreEmpleado;
        private TextBox NombreEmpleadoText;
        private Label ApellidoEmpleado;
        private TextBox ApellidoEmpleadoText;
        private Button Confirmar;
    }
}