using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Microsoft.VisualBasic;
using static Azure.Core.HttpHeader;

namespace Examen2
{
    public partial class CambiosUsuario : Form
    {
        public CambiosUsuario(string id, string nom, string ap, string am, string tel, string correo)
        {
            InitializeComponent();
            ID.Text = id;
            NOM.Text = nom;
            AP.Text = ap;
            AM.Text = am;
            TEL.Text = tel;
            CORREO.Text = correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update Usuarios set APATERNO='" + AP.Text + "',AMATERNO='" +
                AM.Text + "',NOMBRE='" + NOM.Text + "',TELEFONO='" + TEL.Text.Replace("(", "").Replace(")", "").Replace("-", "") + "',CORREO='" + CORREO.Text +
                "' where ID='" + ID.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("delete from Usuarios where ID='" + ID.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Registro eiminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
