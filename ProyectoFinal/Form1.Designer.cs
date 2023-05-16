namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrarHuesped = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarHuspedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bahía de Cristal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.reporteDeHotelToolStripMenuItem,
            this.habitacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrarHuesped,
            this.eliminarHuspedToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // RegistrarHuesped
            // 
            this.RegistrarHuesped.Name = "RegistrarHuesped";
            this.RegistrarHuesped.Size = new System.Drawing.Size(224, 26);
            this.RegistrarHuesped.Text = "Registrar Huesped";
            this.RegistrarHuesped.Click += new System.EventHandler(this.RegistrarHuesped_Click);
            // 
            // eliminarHuspedToolStripMenuItem
            // 
            this.eliminarHuspedToolStripMenuItem.Name = "eliminarHuspedToolStripMenuItem";
            this.eliminarHuspedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarHuspedToolStripMenuItem.Text = "Eliminar Husped ";
            // 
            // reporteDeHotelToolStripMenuItem
            // 
            this.reporteDeHotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReporteToolStripMenuItem});
            this.reporteDeHotelToolStripMenuItem.Name = "reporteDeHotelToolStripMenuItem";
            this.reporteDeHotelToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.reporteDeHotelToolStripMenuItem.Text = "Reporte de Hotel";
            // 
            // verReporteToolStripMenuItem
            // 
            this.verReporteToolStripMenuItem.Name = "verReporteToolStripMenuItem";
            this.verReporteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verReporteToolStripMenuItem.Text = "Ver Reporte";
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionSimpleToolStripMenuItem,
            this.habitacionDoblesToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // habitacionSimpleToolStripMenuItem
            // 
            this.habitacionSimpleToolStripMenuItem.Name = "habitacionSimpleToolStripMenuItem";
            this.habitacionSimpleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.habitacionSimpleToolStripMenuItem.Text = "Habitacion Simple";
            // 
            // habitacionDoblesToolStripMenuItem
            // 
            this.habitacionDoblesToolStripMenuItem.Name = "habitacionDoblesToolStripMenuItem";
            this.habitacionDoblesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.habitacionDoblesToolStripMenuItem.Text = "Habitacion Dobles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem RegistrarHuesped;
        private ToolStripMenuItem eliminarHuspedToolStripMenuItem;
        private ToolStripMenuItem reporteDeHotelToolStripMenuItem;
        private ToolStripMenuItem verReporteToolStripMenuItem;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem habitacionSimpleToolStripMenuItem;
        private ToolStripMenuItem habitacionDoblesToolStripMenuItem;
    }
}