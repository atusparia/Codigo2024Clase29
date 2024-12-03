namespace Codigo2024Clase29
{
    partial class frmListadoFactura
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
            fileSystemWatcher1 = new FileSystemWatcher();
            btnBuscar = new Button();
            txtCliente = new TextBox();
            label1 = new Label();
            dgvCabecera = new DataGridView();
            dgvDetalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCabecera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(281, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(79, 21);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(196, 23);
            txtCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // dgvCabecera
            // 
            dgvCabecera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCabecera.Location = new Point(21, 59);
            dgvCabecera.Name = "dgvCabecera";
            dgvCabecera.Size = new Size(658, 151);
            dgvCabecera.TabIndex = 3;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(23, 255);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(656, 169);
            dgvDetalle.TabIndex = 4;
            // 
            // frmListadoFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvCabecera);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Controls.Add(btnBuscar);
            Name = "frmListadoFactura";
            Text = "frmListadoFactura";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCabecera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private DataGridView dgvCabecera;
        private Label label1;
        private TextBox txtCliente;
        private Button btnBuscar;
        private DataGridView dgvDetalle;
    }
}