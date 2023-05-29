namespace ProyectoFinal
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            txtNombreCompleto = new TextBox();
            lblNombre = new Label();
            lblNumero = new Label();
            txtTelefono = new TextBox();
            dtFechaIngreso = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtFechaSalida = new DateTimePicker();
            chkAdultos = new NumericUpDown();
            label3 = new Label();
            btnRegistrar = new Button();
            label4 = new Label();
            chkNinos = new NumericUpDown();
            lblRecordatorio = new Label();
            pictureBox1 = new PictureBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chkAdultos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkNinos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(261, 22);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(238, 27);
            txtNombreCompleto.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(43, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Completo";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(43, 78);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(173, 25);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Numero de telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(261, 79);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 27);
            txtTelefono.TabIndex = 2;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // dtFechaIngreso
            // 
            dtFechaIngreso.Location = new Point(261, 184);
            dtFechaIngreso.Name = "dtFechaIngreso";
            dtFechaIngreso.Size = new Size(295, 27);
            dtFechaIngreso.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 186);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 7;
            label1.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 247);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 8;
            label2.Text = "Fecha de Salida";
            // 
            // dtFechaSalida
            // 
            dtFechaSalida.Location = new Point(261, 247);
            dtFechaSalida.Name = "dtFechaSalida";
            dtFechaSalida.Size = new Size(295, 27);
            dtFechaSalida.TabIndex = 9;
            // 
            // chkAdultos
            // 
            chkAdultos.Location = new Point(261, 307);
            chkAdultos.Name = "chkAdultos";
            chkAdultos.Size = new Size(91, 27);
            chkAdultos.TabIndex = 10;
            chkAdultos.ValueChanged += chkAdultos_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 305);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 11;
            label3.Text = "Adultos";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(430, 434);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 40);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Guardar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 354);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 14;
            label4.Text = "Niños";
            // 
            // chkNinos
            // 
            chkNinos.Location = new Point(264, 356);
            chkNinos.Name = "chkNinos";
            chkNinos.Size = new Size(91, 27);
            chkNinos.TabIndex = 13;
            // 
            // lblRecordatorio
            // 
            lblRecordatorio.AutoSize = true;
            lblRecordatorio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordatorio.Location = new Point(43, 412);
            lblRecordatorio.Name = "lblRecordatorio";
            lblRecordatorio.Size = new Size(106, 20);
            lblRecordatorio.TabIndex = 15;
            lblRecordatorio.Text = "Recordatorio";
            lblRecordatorio.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 516);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(43, 134);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(157, 25);
            lblCorreo.TabIndex = 17;
            lblCorreo.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(261, 132);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 27);
            txtCorreo.TabIndex = 18;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(619, 506);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(lblRecordatorio);
            Controls.Add(label4);
            Controls.Add(chkNinos);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(chkAdultos);
            Controls.Add(dtFechaSalida);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtFechaIngreso);
            Controls.Add(lblNumero);
            Controls.Add(txtTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtNombreCompleto);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(637, 553);
            MinimizeBox = false;
            MinimumSize = new Size(637, 553);
            Name = "Registrar";
            Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)chkAdultos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkNinos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCompleto;
        private Label lblNombre;
        private Label lblNumero;
        private TextBox txtTelefono;
        private DateTimePicker dtFechaIngreso;
        private Label label1;
        private Label label2;
        private DateTimePicker dtFechaSalida;
        private NumericUpDown chkAdultos;
        private Label label3;
        private Button btnRegistrar;
        private Label label4;
        private NumericUpDown chkNinos;
        private Label lblRecordatorio;
        private PictureBox pictureBox1;
        private Label lblCorreo;
        private TextBox txtCorreo;
    }
}