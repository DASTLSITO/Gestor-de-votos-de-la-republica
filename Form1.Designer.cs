namespace P122310540TV
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBoxSalir = new PictureBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirArchivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            graficarbarrasToolStripMenuItem = new ToolStripMenuItem();
            graficarpastelToolStripMenuItem = new ToolStripMenuItem();
            creditosToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            listView1 = new ListView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 116, 157);
            panel1.Controls.Add(pictureBoxSalir);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(0, 0, 0, 0);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 43);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
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
            pictureBoxSalir.Click += pictureBoxSalir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(68, 116, 157);
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, opcionesToolStripMenuItem, creditosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 8);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(304, 30);
            menuStrip1.TabIndex = 3;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirArchivoToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripMenuItem3 });
            archivoToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0, 0);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(91, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            abrirArchivoToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            abrirArchivoToolStripMenuItem.Size = new Size(208, 24);
            abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            abrirArchivoToolStripMenuItem.Click += abrirArchivoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            guardarToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(208, 24);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            guardarComoToolStripMenuItem.Enabled = false;
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(208, 24);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.FromArgb(68, 116, 157);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(208, 24);
            toolStripMenuItem3.Text = "Salir";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem, modificarToolStripMenuItem, graficarbarrasToolStripMenuItem, graficarpastelToolStripMenuItem });
            opcionesToolStripMenuItem.Enabled = false;
            opcionesToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0, 0);
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(101, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(248, 24);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(248, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(248, 24);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // graficarbarrasToolStripMenuItem
            // 
            graficarbarrasToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            graficarbarrasToolStripMenuItem.Name = "graficarbarrasToolStripMenuItem";
            graficarbarrasToolStripMenuItem.Size = new Size(248, 24);
            graficarbarrasToolStripMenuItem.Text = "Graficar (barras)";
            graficarbarrasToolStripMenuItem.Click += graficarbarrasToolStripMenuItem_Click;
            // 
            // graficarpastelToolStripMenuItem
            // 
            graficarpastelToolStripMenuItem.BackColor = Color.FromArgb(68, 116, 157);
            graficarpastelToolStripMenuItem.Name = "graficarpastelToolStripMenuItem";
            graficarpastelToolStripMenuItem.Size = new Size(248, 24);
            graficarpastelToolStripMenuItem.Text = "Graficar (pastel)";
            graficarpastelToolStripMenuItem.Click += graficarpastelToolStripMenuItem_Click;
            // 
            // creditosToolStripMenuItem
            // 
            creditosToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 0, 0);
            creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            creditosToolStripMenuItem.Size = new Size(101, 24);
            creditosToolStripMenuItem.Text = "Creditos";
            creditosToolStripMenuItem.Click += creditosToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "salir.png");
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.AllowColumnReorder = true;
            listView1.AllowDrop = true;
            listView1.BackColor = Color.White;
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.HotTracking = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(308, 50);
            listView1.Margin = new Padding(4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.RightToLeft = RightToLeft.No;
            listView1.Size = new Size(830, 521);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(68, 116, 157);
            statusStrip1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 578);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1143, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.FromArgb(68, 116, 157);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 23);
            label1.TabIndex = 4;
            label1.Text = "Opciones de modificación";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 116, 157);
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 76, 117);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 96, 137);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(17, 82);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(68, 116, 157);
            button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 76, 117);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 96, 137);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(17, 116);
            button2.Name = "button2";
            button2.Size = new Size(133, 29);
            button2.TabIndex = 6;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(68, 116, 157);
            button3.Enabled = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 76, 117);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 96, 137);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(17, 150);
            button3.Name = "button3";
            button3.Size = new Size(133, 29);
            button3.TabIndex = 7;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 202);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(263, 23);
            label2.TabIndex = 8;
            label2.Text = "Opciones de graficación";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(68, 116, 157);
            button4.Enabled = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 76, 117);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 96, 137);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(17, 268);
            button4.Name = "button4";
            button4.Size = new Size(133, 29);
            button4.TabIndex = 10;
            button4.Text = "Pastel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(68, 116, 157);
            button5.Enabled = false;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 76, 117);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 96, 137);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(17, 233);
            button5.Name = "button5";
            button5.Size = new Size(133, 29);
            button5.TabIndex = 9;
            button5.Text = "Barras";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 212, 225);
            ClientSize = new Size(1143, 600);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSalir).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBoxSalir;
        private ImageList imageList1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem graficarbarrasToolStripMenuItem;
        private ToolStripMenuItem graficarpastelToolStripMenuItem;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private ListView listView1;
        private StatusStrip statusStrip1;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button button5;
    }
}
