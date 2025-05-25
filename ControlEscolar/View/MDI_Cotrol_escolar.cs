using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar.View
{
    public partial class MDI_Cotrol_escolar : Form
    {
        public MDI_Cotrol_escolar()
        {
            InitializeComponent();
        }

        private void MDI_Cotrol_escolar_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiantes forma_estudiantes = new frmEstudiantes(this);
            forma_estudiantes.Show(); // solo muestra la pantalla y no muestra una respuesta 
        }

        private void reporte111ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte111 forma_reporte111 = new frmReporte111(this);
            forma_reporte111.Show();
        }

        private void reporte12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte12 forma_reporte12 = new frmReporte12(this);
            forma_reporte12.Show();

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles forma_roles = new frmRoles(this);
            forma_roles.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios forma_usuarios = new frmUsuarios(this);
            forma_usuarios.Show();

        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void AbreVentanaHija (String nombre_forma)
        {
            foreach(Form form in this.MdiChildren)
            {
                if(form.Name.ToLower() == nombre_forma)
                {
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;

                }
            }

            Form childForm;
            switch(nombre_forma.ToLower())
            {
                case "frmestudiantes":
                    childForm = new frmEstudiantes(this);
                    break;

                case"frmreporte111":
                    childForm = new frmReporte111(this);
                    break;
                case "frmreporte12":
                    childForm = new frmReporte12(this);
                    break;
                case "frmroles":
                    childForm = new frmRoles(this);
                    break;

                case "frmrusuarios":
                    childForm = new frmUsuarios(this);
                    break;
                default:
                    return;
            }
            childForm.Show();
        }
    }
}
