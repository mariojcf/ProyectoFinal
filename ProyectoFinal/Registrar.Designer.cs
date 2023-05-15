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
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.chkAdultos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkNinos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNinos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(261, 57);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(238, 27);
            this.txtNombreCompleto.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(43, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(162, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(43, 117);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(173, 25);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero de telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(261, 118);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(238, 27);
            this.txtTelefono.TabIndex = 2;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Location = new System.Drawing.Point(261, 184);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(295, 27);
            this.dtFechaIngreso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Salida";
            // 
            // dtFechaSalida
            // 
            this.dtFechaSalida.Location = new System.Drawing.Point(261, 247);
            this.dtFechaSalida.Name = "dtFechaSalida";
            this.dtFechaSalida.Size = new System.Drawing.Size(295, 27);
            this.dtFechaSalida.TabIndex = 9;
            // 
            // chkAdultos
            // 
            this.chkAdultos.Location = new System.Drawing.Point(261, 307);
            this.chkAdultos.Name = "chkAdultos";
            this.chkAdultos.Size = new System.Drawing.Size(91, 27);
            this.chkAdultos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adultos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(430, 434);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(126, 40);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Niños";
            // 
            // chkNinos
            // 
            this.chkNinos.Location = new System.Drawing.Point(264, 356);
            this.chkNinos.Name = "chkNinos";
            this.chkNinos.Size = new System.Drawing.Size(91, 27);
            this.chkNinos.TabIndex = 13;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(619, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkNinos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAdultos);
            this.Controls.Add(this.dtFechaSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaIngreso);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreCompleto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registrar";
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.chkAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}