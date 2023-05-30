namespace ProyectoFinal
{
    partial class Intento
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
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Domingo = new DataGridViewTextBoxColumn();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miercoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            Sabado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Domingo, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado });
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(939, 438);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Domingo
            // 
            Domingo.HeaderText = "Domingo";
            Domingo.MinimumWidth = 6;
            Domingo.Name = "Domingo";
            Domingo.Width = 125;
            // 
            // Lunes
            // 
            Lunes.HeaderText = "Lunes";
            Lunes.MinimumWidth = 6;
            Lunes.Name = "Lunes";
            Lunes.Width = 125;
            // 
            // Martes
            // 
            Martes.HeaderText = "Martes";
            Martes.MinimumWidth = 6;
            Martes.Name = "Martes";
            Martes.Width = 125;
            // 
            // Miercoles
            // 
            Miercoles.HeaderText = "Miercoles";
            Miercoles.MinimumWidth = 6;
            Miercoles.Name = "Miercoles";
            Miercoles.Width = 125;
            // 
            // Jueves
            // 
            Jueves.HeaderText = "Jueves";
            Jueves.MinimumWidth = 6;
            Jueves.Name = "Jueves";
            Jueves.Width = 125;
            // 
            // Viernes
            // 
            Viernes.HeaderText = "Viernes";
            Viernes.MinimumWidth = 6;
            Viernes.Name = "Viernes";
            Viernes.Width = 125;
            // 
            // Sabado
            // 
            Sabado.HeaderText = "Sabado";
            Sabado.MinimumWidth = 6;
            Sabado.Name = "Sabado";
            Sabado.Width = 125;
            // 
            // Intento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 450);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MaximumSize = new Size(979, 497);
            MinimizeBox = false;
            MinimumSize = new Size(979, 497);
            Name = "Intento";
            Text = "Intento";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Domingo;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miercoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
        private DataGridViewTextBoxColumn Sabado;
    }
}