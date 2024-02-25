namespace P122310540TV
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBoxSalir = new PictureBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 30);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(440, 300);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            chart1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 116, 157);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxSalir);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(0, 0, 0, 0);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 30);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.salir;
            pictureBox1.Location = new Point(410, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBoxSalir
            // 
            pictureBoxSalir.Image = Properties.Resources.salir;
            pictureBoxSalir.Location = new Point(1096, 0);
            pictureBoxSalir.Margin = new Padding(4);
            pictureBoxSalir.Name = "pictureBoxSalir";
            pictureBoxSalir.Size = new Size(43, 40);
            pictureBoxSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSalir.TabIndex = 2;
            pictureBoxSalir.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 274);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(416, 44);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 241);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 4;
            label1.Text = "cargando...";
            // 
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 330);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "-";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private PictureBox pictureBoxSalir;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label1;
    }
}