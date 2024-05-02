namespace RNG.Views
{
    partial class FormularioListaReservas
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
            ListadoReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ListadoReservas).BeginInit();
            SuspendLayout();
            // 
            // ListadoReservas
            // 
            ListadoReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoReservas.Location = new Point(12, 12);
            ListadoReservas.Name = "ListadoReservas";
            ListadoReservas.Size = new Size(776, 426);
            ListadoReservas.TabIndex = 0;
            ListadoReservas.CellContentClick += ListadoReservas_CellContentClick;
            // 
            // FormularioListaReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListadoReservas);
            Name = "FormularioListaReservas";
            Text = "Lista Reservas";
            Load += FormularioListaReservas_Load;
            ((System.ComponentModel.ISupportInitialize)ListadoReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListadoReservas;
    }
}