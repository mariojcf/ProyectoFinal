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
            btnGuardar = new Button();
            chkPersonas = new NumericUpDown();
            label1 = new Label();
            lblNumero = new Label();
            txtTelefono = new TextBox();
            lblNombre = new Label();
            txtNombreCompleto = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            mtCIngreso = new MonthCalendar();
            lblAnuncio = new Label();
            clbSalon = new CheckedListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chkPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(58, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 40);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkPersonas
            // 
            chkPersonas.Location = new Point(362, 140);
            chkPersonas.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            chkPersonas.Name = "chkPersonas";
            chkPersonas.Size = new Size(91, 27);
            chkPersonas.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 212);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 20;
            label1.Text = "Fecha de Ingreso";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(56, 56);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(173, 25);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Numero de telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(362, 57);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 27);
            txtTelefono.TabIndex = 17;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(56, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 25);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(362, 17);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(238, 27);
            txtNombreCompleto.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(686, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 151);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 24;
            label3.Text = "Personas a Asistir";
            // 
            // mtCIngreso
            // 
            mtCIngreso.Location = new Point(341, 200);
            mtCIngreso.Name = "mtCIngreso";
            mtCIngreso.TabIndex = 29;
            // 
            // lblAnuncio
            // 
            lblAnuncio.AutoSize = true;
            lblAnuncio.Font = new Font("Centaur", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnuncio.Location = new Point(81, 412);
            lblAnuncio.Name = "lblAnuncio";
            lblAnuncio.Size = new Size(82, 32);
            lblAnuncio.TabIndex = 30;
            lblAnuncio.Text = "label2";
            lblAnuncio.Visible = false;
            // 
            // clbSalon
            // 
            clbSalon.FormattingEnabled = true;
            clbSalon.Items.AddRange(new object[] { "Salón luna ", "Salón sol " });
            clbSalon.Location = new Point(362, 108);
            clbSalon.Name = "clbSalon";
            clbSalon.Size = new Size(146, 26);
            clbSalon.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 108);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 32;
            label2.Text = "Escoga el salon";
            // 
            // Salon_de_Eventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(label2);
            Controls.Add(clbSalon);
            Controls.Add(lblAnuncio);
            Controls.Add(mtCIngreso);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(chkPersonas);
            Controls.Add(label1);
            Controls.Add(lblNumero);
            Controls.Add(txtTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtNombreCompleto);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(708, 497);
            MinimizeBox = false;
            MinimumSize = new Size(708, 497);
            Name = "Salon_de_Eventos";
            Text = "Salon_de_Eventos";
            ((System.ComponentModel.ISupportInitialize)chkPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckedListBox clbSalon;
        private Label label2;
    }
}