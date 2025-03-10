using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.Bussines;

namespace ControlEscolar.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace(txtUsuario.Text))
            //{
            //    MessageBox.Show("El campo de usuario no puede estar vacio.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            //{
            //    MessageBox.Show("El campo de contraseña no puede estar vacio.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if(!UsuarioNegocio.EsFormatoValido(txtUsuario.Text))
            //{
            //    MessageBox.Show("El nombre del usuario no tiene el formato correcto", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            // MessageBox.Show("Listo para iniciar sesion", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Estamos listos para inicar sesion 
            //this.Hide();
            //MDI_Cotrol_escolar mdi = new MDI_Cotrol_escolar();
            //mdi.Show();

           this.DialogResult = DialogResult.OK;
           this.Close();
            
        }
    }
}
