﻿namespace Examen2
{
    partial class AltaUsuario
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
            NOM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AP = new TextBox();
            label3 = new Label();
            AM = new TextBox();
            label4 = new Label();
            TEL = new MaskedTextBox();
            label5 = new Label();
            CORREO = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // NOM
            // 
            NOM.Location = new Point(87, 21);
            NOM.Name = "NOM";
            NOM.Size = new Size(465, 27);
            NOM.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido paterno:";
            // 
            // AP
            // 
            AP.Location = new Point(145, 70);
            AP.Name = "AP";
            AP.Size = new Size(407, 27);
            AP.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 128);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido materno:";
            // 
            // AM
            // 
            AM.Location = new Point(145, 121);
            AM.Name = "AM";
            AM.Size = new Size(407, 27);
            AM.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 229);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Telefono:";
            // 
            // TEL
            // 
            TEL.Location = new Point(91, 222);
            TEL.Mask = "(999)000-0000";
            TEL.Name = "TEL";
            TEL.Size = new Size(125, 27);
            TEL.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 179);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 10;
            label5.Text = "Correo electronico:";
            // 
            // CORREO
            // 
            CORREO.Location = new Point(155, 172);
            CORREO.Name = "CORREO";
            CORREO.Size = new Size(401, 27);
            CORREO.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(458, 225);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "INSERTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 301);
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
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NOM;
        private Label label1;
        private Label label2;
        private TextBox AP;
        private Label label3;
        private TextBox AM;
        private Label label4;
        private MaskedTextBox TEL;
        private Label label5;
        private TextBox CORREO;
        private Button button1;
    }
}