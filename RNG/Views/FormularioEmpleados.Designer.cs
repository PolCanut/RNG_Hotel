namespace RNG.Views
{
    partial class FormularioEmpleados
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
            AgregarEmpleado = new Button();
            EliminarEmpleado = new Button();
            SuspendLayout();
            // 
            // AgregarEmpleado
            // 
            AgregarEmpleado.Location = new Point(261, 159);
            AgregarEmpleado.Name = "AgregarEmpleado";
            AgregarEmpleado.Size = new Size(100, 100);
            AgregarEmpleado.TabIndex = 0;
            AgregarEmpleado.Text = "Agregar Empleado";
            AgregarEmpleado.UseVisualStyleBackColor = true;
            AgregarEmpleado.Click += AgregarEmpleado_Click;
            // 
            // EliminarEmpleado
            // 
            EliminarEmpleado.Location = new Point(401, 159);
            EliminarEmpleado.Name = "EliminarEmpleado";
            EliminarEmpleado.Size = new Size(100, 100);
            EliminarEmpleado.TabIndex = 1;
            EliminarEmpleado.Text = "Eliminar Empleado";
            EliminarEmpleado.UseVisualStyleBackColor = true;
            EliminarEmpleado.Click += EliminarEmpleado_Click;
            // 
            // FormularioEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarEmpleado);
            Controls.Add(AgregarEmpleado);
            Name = "FormularioEmpleados";
            Text = "Gestion Empleados";
            ResumeLayout(false);
        }

        #endregion

        private Button AgregarEmpleado;
        private Button EliminarEmpleado;
    }
}