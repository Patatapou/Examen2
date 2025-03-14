using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen2
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into Usuarios (APATERNO,AMATERNO,NOMBRE,TELEFONO,CORREO) values('" + AP.Text + "','" +
                AM.Text + "','" + NOM.Text + "','" + TEL.Text.Replace("(","").Replace(")","").Replace("-","") + "','" + CORREO.Text + "')");
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
