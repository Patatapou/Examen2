namespace Examen2
{
    partial class CambiosUsuario
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
            button1 = new Button();
            label5 = new Label();
            CORREO = new TextBox();
            TEL = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            AM = new TextBox();
            label2 = new Label();
            AP = new TextBox();
            label1 = new Label();
            NOM = new TextBox();
            label6 = new Label();
            ID = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(436, 15);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 22;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 226);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 21;
            label5.Text = "Correo electronico:";
            // 
            // CORREO
            // 
            CORREO.Location = new Point(157, 219);
            CORREO.Name = "CORREO";
            CORREO.Size = new Size(401, 27);
            CORREO.TabIndex = 20;
            // 
            // TEL
            // 
            TEL.Location = new Point(93, 269);
            TEL.Mask = "(999)000-0000";
            TEL.Name = "TEL";
            TEL.Size = new Size(125, 27);
            TEL.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 276);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 18;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 17;
            label3.Text = "Apellido materno:";
            // 
            // AM
            // 
            AM.Location = new Point(147, 168);
            AM.Name = "AM";
            AM.Size = new Size(407, 27);
            AM.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 124);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 15;
            label2.Text = "Apellido paterno:";
            // 
            // AP
            // 
            AP.Location = new Point(147, 117);
            AP.Name = "AP";
            AP.Size = new Size(407, 27);
            AP.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // NOM
            // 
            NOM.Location = new Point(89, 68);
            NOM.Name = "NOM";
            NOM.Size = new Size(465, 27);
            NOM.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 15);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 24;
            label6.Text = "ID:";
            // 
            // ID
            // 
            ID.Cursor = Cursors.No;
            ID.Location = new Point(47, 12);
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Size = new Size(107, 27);
            ID.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Cursor = Cursors.Help;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(312, 272);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 25;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(436, 272);
            button3.Name = "button3";
            button3.Size = new Size(118, 29);
            button3.TabIndex = 26;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CambiosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(ID);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(CORREO);
            Controls.Add(TEL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AM);
            Controls.Add(label2);
            Controls.Add(AP);
            Controls.Add(label1);
            Controls.Add(NOM);
            Name = "CambiosUsuario";
            Text = "CambiosUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox CORREO;
        private MaskedTextBox TEL;
        private Label label4;
        private Label label3;
        private TextBox AM;
        private Label label2;
        private TextBox AP;
        private Label label1;
        private TextBox NOM;
        private Label label6;
        private TextBox ID;
        private Button button2;
        private Button button3;
    }
}