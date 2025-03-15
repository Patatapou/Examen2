namespace Examen2
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem1 = new ToolStripMenuItem();
            cerrarTablaToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dgv = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            opcionesToolStripMenuItem.Click += opcionesToolStripMenuItem_Click;
            opcionesToolStripMenuItem.MouseHover += opcionesToolStripMenuItem_MouseHover;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem1, cerrarTablaToolStripMenuItem1 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(224, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            usuariosToolStripMenuItem.MouseHover += usuariosToolStripMenuItem_MouseHover;
            // 
            // altaToolStripMenuItem1
            // 
            altaToolStripMenuItem1.BackColor = SystemColors.ControlLight;
            altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            altaToolStripMenuItem1.Size = new Size(224, 26);
            altaToolStripMenuItem1.Text = "Alta";
            altaToolStripMenuItem1.Click += altaToolStripMenuItem1_Click;
            // 
            // cerrarTablaToolStripMenuItem1
            // 
            cerrarTablaToolStripMenuItem1.BackColor = SystemColors.ControlLight;
            cerrarTablaToolStripMenuItem1.Name = "cerrarTablaToolStripMenuItem1";
            cerrarTablaToolStripMenuItem1.Size = new Size(224, 26);
            cerrarTablaToolStripMenuItem1.Text = "Cerrar Tabla";
            cerrarTablaToolStripMenuItem1.Click += cerrarTablaToolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 28);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(853, 422);
            dgv.StandardTab = true;
            dgv.TabIndex = 1;
            dgv.CellContentDoubleClick += dgv_CellContentDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.database_icon;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(853, 450);
            Controls.Add(dgv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgv;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem1;
        private ToolStripMenuItem cerrarTablaToolStripMenuItem1;
    }
}
