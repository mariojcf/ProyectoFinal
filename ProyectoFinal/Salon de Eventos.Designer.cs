namespace ProyectoFinal
{
    partial class Salon_de_Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salon_de_Eventos));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkPersonas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtCIngreso = new System.Windows.Forms.MonthCalendar();
            this.lblAnuncio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chkPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(58, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 40);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkPersonas
            // 
            this.chkPersonas.Location = new System.Drawing.Point(362, 140);
            this.chkPersonas.Name = "chkPersonas";
            this.chkPersonas.Size = new System.Drawing.Size(91, 27);
            this.chkPersonas.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de Ingreso";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(56, 77);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(173, 25);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Numero de telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(362, 78);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(238, 27);
            this.txtTelefono.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(56, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(162, 25);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(362, 17);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(238, 27);
            this.txtNombreCompleto.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Personas a Asistir";
            // 
            // mtCIngreso
            // 
            this.mtCIngreso.Location = new System.Drawing.Point(341, 200);
            this.mtCIngreso.Name = "mtCIngreso";
            this.mtCIngreso.TabIndex = 29;
            // 
            // lblAnuncio
            // 
            this.lblAnuncio.AutoSize = true;
            this.lblAnuncio.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnuncio.Location = new System.Drawing.Point(81, 412);
            this.lblAnuncio.Name = "lblAnuncio";
            this.lblAnuncio.Size = new System.Drawing.Size(82, 32);
            this.lblAnuncio.TabIndex = 30;
            this.lblAnuncio.Text = "label2";
            this.lblAnuncio.Visible = false;
            // 
            // Salon_de_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.lblAnuncio);
            this.Controls.Add(this.mtCIngreso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(708, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(708, 497);
            this.Name = "Salon_de_Eventos";
            this.Text = "Salon_de_Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.chkPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnGuardar;
        private NumericUpDown chkPersonas;
        private Label label1;
        private Label lblNumero;
        private TextBox txtTelefono;
        private Label lblNombre;
        private TextBox txtNombreCompleto;
        private PictureBox pictureBox1;
        private Label label3;
        private MonthCalendar mtCIngreso;
        private Label lblAnuncio;
    }
}