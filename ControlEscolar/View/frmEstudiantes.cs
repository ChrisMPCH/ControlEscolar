using System.Data;
using ControlEscolar.Bussines;
using ControlEscolar.Utilities;
using ControlEscolarCore.Controller;
using ControlEscolarCore.Model;
using ControlEscolarCore.Utilities;


namespace ControlEscolar.View
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes(Form parent)
        {
            InitializeComponent();
            InicializaVentanaEstudiantes();
            Formas.InicializaForma(this, parent);
        }


        private void InicializaVentanaEstudiantes()
        {
            PoblaComboEstatus();
            PoblaComboTipoFecha();
            scEstudiantes.Panel1Collapsed = true;
            dataAlta.Value = DateTime.Now;
            cargarEstudiantes();
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

        private void cargarEstudiantes()
        {
            try
            {
                //Mostrar el cursor de espera
                Cursor = Cursors.WaitCursor;

                //Crear una instancia de acceso al controlador
                EstudiantesController estudiantesController = new EstudiantesController();

                //Obtener la lista de estudiantes
                List<Estudiantes> estudiantes = estudiantesController.ObtnerTodosLosEstudiantes(
                    soloActivos: false,
                    tipofecha: cmbxTipoFecha.SelectedValue != null ? (int)cmbxTipoFecha.SelectedValue : 0,
                    fechaInicio: dateInicio.Enabled ? dateInicio.Value : (DateTime?)null,
                    fechaFin: dateFin.Enabled ? dateFin.Value : (DateTime?)null);

                //Limpiar el DataGridView
                //dgvEstudiantes.Rows.Clear();

                if (estudiantes.Count == 0)
                {
                    lblTotalRegister.Text = "Total: 0 registros";

                    if (!string.IsNullOrEmpty(txtBusquedaTexto.Text))
                    {
                        MessageBox.Show("No se encontraron estudiantes con el criterio de busqueda ", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //Crear y poblar el DataTable
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Matrícula", typeof(string));
                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Semestre", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Teléfono", typeof(string));
                dt.Columns.Add("CURP", typeof(string));
                dt.Columns.Add("Fecha Nacimiento", typeof(DateTime));
                dt.Columns.Add("Fecha Alta", typeof(DateTime));
                dt.Columns.Add("Estatus", typeof(string));

                foreach (Estudiantes estudiante in estudiantes)
                {
                    dt.Rows.Add(
                        estudiante.Id,
                        estudiante.Matricula,
                        estudiante.DatosPersonales.NombreCompleto,
                        estudiante.Semestre,
                        estudiante.DatosPersonales.Correo,
                        estudiante.DatosPersonales.Telefono,
                        estudiante.DatosPersonales.Curp,
                        estudiante.DatosPersonales.FechaNacimiento,
                        estudiante.FechaAlta,
                        estudiante.DescripcionEstatus
                    );
                }

                //Asignar el DataTable al DataGridView
                dgvEstudiantes.DataSource = dt;

                //Configurar el DataGridView
                ConfigurarDataGridView();

                //Actualizar el total de registros
                lblTotalRegister.Text = $"Total: {estudiantes.Count} registros";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estudiantes. Contacta al administrador del sistema.", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Restaurar el cursor
                Cursor = Cursors.Default;
            }
        }

        private void ConfigurarDataGridView()
        {
            //Ajustes generales
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dgvEstudiantes.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgvEstudiantes.Columns["Matrícula"].Width = 100;
            dgvEstudiantes.Columns["Nombre Completo"].Width = 200;
            dgvEstudiantes.Columns["Semestre"].Width = 80;
            dgvEstudiantes.Columns["Correo"].Width = 180;
            dgvEstudiantes.Columns["Teléfono"].Width = 120;
            dgvEstudiantes.Columns["CURP"].Width = 150;
            dgvEstudiantes.Columns["Fecha Nacimiento"].Width = 120;
            dgvEstudiantes.Columns["Fecha Alta"].Width = 120;
            dgvEstudiantes.Columns["Estatus"].Width = 100;

            // Ocultar columna ID si es necesario
            dgvEstudiantes.Columns["ID"].Visible = false;

            // Formato para las fechas
            dgvEstudiantes.Columns["Fecha Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEstudiantes.Columns["Fecha Alta"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Alineación
            dgvEstudiantes.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEstudiantes.Columns["Matrícula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstudiantes.Columns["Semestre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEstudiantes.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgvEstudiantes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección de fila completa
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgvEstudiantes.EnableHeadersVisualStyles = false;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.Font = new Font(dgvEstudiantes.Font, FontStyle.Bold);
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstudiantes.ColumnHeadersHeight = 35;
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
            GuardarEstudiante();
        }

        private void GuardarEstudiante()
        {
            try
            {
                // Validaciones a nivel de interfaz
                if (DatosVacios())
                {
                    MessageBox.Show("Por favor, llene todos los campos.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DatosValidos())
                {
                    return;
                }

                // Crear el objeto Persona con los datos del formulario
                Personas persona = new Personas(
                    txtNombre.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCurp.Text.Trim()
                );

                // Asignar la fecha de nacimiento
                persona.FechaNacimiento = dttFechaNacimiento.Value;

                // Crear el objeto Estudiante con los datos del formulario
                Estudiantes estudiante = new Estudiantes
                {
                    Matricula = txtBoxControl.Text.Trim(),
                    Semestre = nudSemestre.Text.Trim(),
                    FechaAlta = dataAlta.Value,
                    Estatus = 1, // Activo por defecto
                    DatosPersonales = persona
                };

                EstudiantesController estudiantesController = new EstudiantesController();

                //Llamar al método para guardar el estudiante
                var (idEstudiante, mensaje) = estudiantesController.RegistrarEstudiante(estudiante);

                // verificar el resultado
                if (idEstudiante > 0)
                {
                    MessageBox.Show(mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // metodo para limpiar el formulario despues de guardar

                    //Actualizar la lista de estudiantes
                    cargarEstudiantes();
                }
                else
                {
                    MessageBox.Show(mensaje, "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    switch (idEstudiante)
                    {
                        case -2: // error de CURP duplicada
                            txtCurp.Focus();
                            txtCurp.SelectAll();
                            break;
                        case -3: // error de Matricula duplicada
                            txtBoxControl.Focus();
                            txtBoxControl.SelectAll();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al guardar el estudiante, no se pudo completar el registro. Por favor, intente nuevamente o contacta al administrador del sistema.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCurp.Clear();
            nudSemestre.Value = 1;
            txtBoxControl.Clear();
            dttFechaNacimiento.Value = DateTime.Now;
            dataAlta.Value = DateTime.Now;
            cbEstatus.SelectedIndex = 1;
            cmbxTipoFecha.SelectedIndex = 1;
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
        private void btnActiualizar_Click(object sender, EventArgs e)
        {
            cargarEstudiantes();
        }

    }
}