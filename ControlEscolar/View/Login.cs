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
using ControlEscolar.Utilities;
using ControlEscolarCore.Utilities;
using NLog;

namespace ControlEscolar.View
{
    public partial class Login : Form
    {
        
        private static readonly Logger _Logger = LoggingManager.GetLogger("ControlEscolar.View.Login");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _Logger.Info("Iniciando la ventana de login");
            _Logger.Warn("Espacio en disco bajo");

            try
            {
                //Aqui provocamos una primera excepcion
                try
                {
                    int dividendo = 10;
                    int divisor = 0;
                    int resultado = dividendo / divisor; //Esto genera una excepcion DivideByZeroException
                }
                catch (DivideByZeroException ex)
                {
                    //Capturamos la primera excepcion y la envolvemos en una nueva excepcion
                    throw new ApplicationException("Error al realizar una division", ex);
                }
            }
            catch (Exception ex)
            {
                //Capturamos la excepcion y la registramos
                _Logger.Error(ex, "$Eror crítico con detalle internoprodujo un error en la operación");

                //O registramos la excepcion y la mostramos en un MessageBox
                if (ex.InnerException != null)
                {
                    _Logger.Fatal(ex, $"Se produjo un error en la operación: {ex.InnerException.Message}");
                }
            }
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
