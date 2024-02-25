namespace P122310540TV
{
    partial class AgregarEstado
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
            pictureBoxSalir = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            estadoTxtBox = new TextBox();
            priTxtBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panTxtBox = new TextBox();
            label6 = new Label();
            morenaTxtBox = new TextBox();
            label7 = new Label();
            prdTxtBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxSalir
            // 
            pictureBoxSalir.Image = Properties.Resources.salir;
            pictureBoxSalir.Location = new Point(658, 0);
            pictureBoxSalir.Margin = new Padding(4);
            pictureBoxSalir.Name = "pictureBoxSalir";
            pictureBoxSalir.Size = new Size(43, 40);
            pictureBoxSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSalir.TabIndex = 2;
            pictureBoxSalir.TabStop = false;
            pictureBoxSalir.Click += pictureBoxSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 116, 157);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBoxSalir);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(0, 0, 0, 0);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 43);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 3;
            label1.Text = "Añadido de estados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 4;
            label2.Text = "Estado";
            // 
            // estadoTxtBox
            // 
            estadoTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estadoTxtBox.Location = new Point(12, 80);
            estadoTxtBox.Name = "estadoTxtBox";
            estadoTxtBox.Size = new Size(153, 29);
            estadoTxtBox.TabIndex = 5;
            // 
            // priTxtBox
            // 
            priTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priTxtBox.Location = new Point(12, 188);
            priTxtBox.Name = "priTxtBox";
            priTxtBox.Size = new Size(153, 29);
            priTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 6;
            label3.Text = "Votos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(39, 25);
            label4.TabIndex = 8;
            label4.Text = "PRI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(188, 160);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 10;
            label5.Text = "PAN";
            // 
            // panTxtBox
            // 
            panTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panTxtBox.Location = new Point(188, 188);
            panTxtBox.Name = "panTxtBox";
            panTxtBox.Size = new Size(153, 29);
            panTxtBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(364, 160);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 12;
            label6.Text = "Morena";
            // 
            // morenaTxtBox
            // 
            morenaTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            morenaTxtBox.Location = new Point(364, 188);
            morenaTxtBox.Name = "morenaTxtBox";
            morenaTxtBox.Size = new Size(153, 29);
            morenaTxtBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(540, 160);
            label7.Name = "label7";
            label7.Size = new Size(47, 25);
            label7.TabIndex = 14;
            label7.Text = "PRD";
            // 
            // prdTxtBox
            // 
            prdTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prdTxtBox.Location = new Point(540, 188);
            prdTxtBox.Name = "prdTxtBox";
            prdTxtBox.Size = new Size(153, 29);
            prdTxtBox.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(12, 223);
            button1.Name = "button1";
            button1.Size = new Size(681, 34);
            button1.TabIndex = 15;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AgregarEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(198, 212, 225);
            ClientSize = new Size(705, 270);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(prdTxtBox);
            Controls.Add(label6);
            Controls.Add(morenaTxtBox);
            Controls.Add(label5);
            Controls.Add(panTxtBox);
            Controls.Add(label4);
            Controls.Add(priTxtBox);
            Controls.Add(label3);
            Controls.Add(estadoTxtBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEstado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarEstado";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxSalir;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox estadoTxtBox;
        private TextBox priTxtBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox panTxtBox;
        private Label label6;
        private TextBox morenaTxtBox;
        private Label label7;
        private TextBox prdTxtBox;
        private Button button1;
    }
}