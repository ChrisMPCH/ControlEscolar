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

namespace ControlEscolar.View
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes(Form parent)
        {
            InitializeComponent();
            Formas.InicializaForma(this, parent);
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            InicializaVentanaEstudiantes();
        }

        private void InicializaVentanaEstudiantes()
        {
            PoblaComboEstatus();
            PoblaComboTipoFecha();
            scEstudiantes.Panel1Collapsed = true;
            dataAlta.Value = DateTime.Now;
        }

        private void PoblaComboEstatus()
        {
            //Crear un diccionario con los valores
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                { 1, "Activo" },
                { 0, "Baja" },
                { 2, "Baja Temporal" }
            };

            //Asignar los valores al comboBox
            cbEstatus.DataSource = new BindingSource(list_estatus, null);
            cbEstatus.DisplayMember = "Value";
            cbEstatus.ValueMember = "Key";

            cbEstatus.SelectedIndex = 1;
        }

        private void PoblaComboTipoFecha()
        {
            //Crear un diccionario con los valores
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                { 1, "Nacimiento" },
                { 2, "Alta" },
                { 3, "Baja" }
            };

            //Asignar los valores al comboBox
            cmbxTipoFecha.DataSource = new BindingSource(list_estatus, null);
            cmbxTipoFecha.DisplayMember = "Value";
            cmbxTipoFecha.ValueMember = "Key";

            cmbxTipoFecha.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActiualizar_Click(object sender, EventArgs e)
        {

        }

        private void scEstudiantes_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (scEstudiantes.Panel1Collapsed)
            {
                scEstudiantes.Panel1Collapsed = false;
                btnMostrar.Text = "Ocultar captura rapida";
            }
            else
            {
                scEstudiantes.Panel1Collapsed = true;
                btnMostrar.Text = "Mostrar";
            }
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            ofdArchivo.Title = "Selecciona el archivo Excel";
            ofdArchivo.Filter = "Archivos de Excel (*.xlsx; *xls)|*.xlsx;*.xls";
            ofdArchivo.FilterIndex = 1;
            ofdArchivo.RestoreDirectory = true;

            if (ofdArchivo.ShowDialog() == DialogResult.OK)
            {
                string filerPath = ofdArchivo.FileName;
                string extencion = Path.GetExtension(filerPath).ToLower();

                if (extencion == ".xlsx" || extencion == ".xls")
                {
                    MessageBox.Show("Archivo válido " + filerPath, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo válido ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarEstudiante())
            {
                MessageBox.Show("Datos guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool GuardarEstudiante()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidos())
            {
                return false;
            }
            return true;
        }

        private bool DatosValidos()
        {
            if (!EstudiantesNegocio.EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!EstudiantesNegocio.EsCURPValido(txtCurp.Text.Trim()))
            {
                MessageBox.Show("CURP inválida.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!EstudiantesNegocio.EsNoControlValido(txtBoxControl.Text.Trim()))
            {
                MessageBox.Show("Número de control inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool DatosVacios()
        {
            if (txtNombre.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == ""
                || txtCurp.Text == "" || nudSemestre.Text == "" || txtBoxControl.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
    }
    }
}