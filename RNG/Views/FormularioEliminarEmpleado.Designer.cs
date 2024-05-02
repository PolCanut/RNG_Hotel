namespace RNG.Views
{
    partial class FormularioEliminarEmpleado
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
            IdEmpleado = new Label();
            IdEmpleadoText = new TextBox();
            Confirmar = new Button();
            SuspendLayout();
            // 
            // IdEmpleado
            // 
            IdEmpleado.AutoSize = true;
            IdEmpleado.Location = new Point(317, 161);
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Size = new Size(92, 15);
            IdEmpleado.TabIndex = 0;
            IdEmpleado.Text = "Id del Empleado";
            IdEmpleado.Click += IdEmpleado_Click;
            // 
            // IdEmpleadoText
            // 
            IdEmpleadoText.Location = new Point(295, 189);
            IdEmpleadoText.Name = "IdEmpleadoText";
            IdEmpleadoText.Size = new Size(139, 23);
            IdEmpleadoText.TabIndex = 1;
            IdEmpleadoText.TextChanged += IdEmpleadoText_TextChanged;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(317, 295);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(75, 23);
            Confirmar.TabIndex = 2;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // FormularioEliminarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Confirmar);
            Controls.Add(IdEmpleadoText);
            Controls.Add(IdEmpleado);
            Name = "FormularioEliminarEmpleado";
            Text = "FormularioEliminarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdEmpleado;
        private TextBox IdEmpleadoText;
        private Button Confirmar;
    }
}