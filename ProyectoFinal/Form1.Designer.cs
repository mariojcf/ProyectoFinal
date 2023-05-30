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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            RegistrarHuesped = new ToolStripMenuItem();
            eliminarHuspedToolStripMenuItem = new ToolStripMenuItem();
            reporteDeHotelToolStripMenuItem = new ToolStripMenuItem();
            verReporteToolStripMenuItem = new ToolStripMenuItem();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            habitacionSimpleToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(208, 40);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 1;
            label1.Text = "Bahía de Cristal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, reporteDeHotelToolStripMenuItem, habitacionesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(677, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RegistrarHuesped, eliminarHuspedToolStripMenuItem });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(82, 24);
            registrarToolStripMenuItem.Text = "Registrar";
            // 
            // RegistrarHuesped
            // 
            RegistrarHuesped.Name = "RegistrarHuesped";
            RegistrarHuesped.Size = new Size(224, 26);
            RegistrarHuesped.Text = "Registrar Huesped";
            RegistrarHuesped.Click += RegistrarHuesped_Click;
            // 
            // eliminarHuspedToolStripMenuItem
            // 
            eliminarHuspedToolStripMenuItem.Name = "eliminarHuspedToolStripMenuItem";
            eliminarHuspedToolStripMenuItem.Size = new Size(224, 26);
            eliminarHuspedToolStripMenuItem.Text = "Eliminar Husped ";
            // 
            // reporteDeHotelToolStripMenuItem
            // 
            reporteDeHotelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verReporteToolStripMenuItem });
            reporteDeHotelToolStripMenuItem.Name = "reporteDeHotelToolStripMenuItem";
            reporteDeHotelToolStripMenuItem.Size = new Size(138, 24);
            reporteDeHotelToolStripMenuItem.Text = "Reporte de Hotel";
            // 
            // verReporteToolStripMenuItem
            // 
            verReporteToolStripMenuItem.Name = "verReporteToolStripMenuItem";
            verReporteToolStripMenuItem.Size = new Size(170, 26);
            verReporteToolStripMenuItem.Text = "Ver Reporte";
            verReporteToolStripMenuItem.Click += verReporteToolStripMenuItem_Click;
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { habitacionSimpleToolStripMenuItem });
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(140, 24);
            habitacionesToolStripMenuItem.Text = "Salon de Eventos ";
            // 
            // habitacionSimpleToolStripMenuItem
            // 
            habitacionSimpleToolStripMenuItem.Name = "habitacionSimpleToolStripMenuItem";
            habitacionSimpleToolStripMenuItem.Size = new Size(224, 26);
            habitacionSimpleToolStripMenuItem.Text = "Realizar reservacion";
            habitacionSimpleToolStripMenuItem.Click += habitacionSimpleToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 426);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(695, 473);
            MinimizeBox = false;
            MinimumSize = new Size(695, 473);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}