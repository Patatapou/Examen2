using AccesoDatos;
using System.Data;

namespace Examen2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            dgv.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select ID as ID, APATERNO as [Apellido Paterno], AMATERNO as [Apellido Materno], NOMBRE as Nombre, TELEFONO as Telefono, CORREO as Correo From Usuarios");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }

        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaUsuario alta = new AltaUsuario();
            alta.Show();
            opcionesToolStripMenuItem.HideDropDown();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.Visible = true;
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select ID as ID, APATERNO as [Apellido Paterno], AMATERNO as [Apellido Materno], NOMBRE as Nombre, TELEFONO as Telefono, CORREO as Correo From Usuarios");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }
            opcionesToolStripMenuItem.HideDropDown();
        }

        private void cerrarTablaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgv.Visible = false;
            opcionesToolStripMenuItem.HideDropDown();
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CambiosUsuario cambios = new CambiosUsuario(
                dgv[0, e.RowIndex].Value.ToString(),
                dgv[3, e.RowIndex].Value.ToString(),
                dgv[1, e.RowIndex].Value.ToString(),
                dgv[2, e.RowIndex].Value.ToString(),
                dgv[4, e.RowIndex].Value.ToString(),
                dgv[5, e.RowIndex].Value.ToString()
                );
            cambios.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            usuariosToolStripMenuItem.ShowDropDown();
        }

        private void opcionesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            opcionesToolStripMenuItem.ShowDropDown();
        }
    }
}
