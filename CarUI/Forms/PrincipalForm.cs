using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cars.Models;
using CarUI.Forms;

namespace CarUI
{
    public partial class PrincipalForm : Form
    {
        private BaseForm<TiposVehiculos> TiposVehiculosForm;
        public BaseForm<TiposCombustibles> TiposCombustiblesForm;
        private BaseForm<Marcas> MarcasForm;
        private BaseForm<Modelos> ModelosForm;
        private BaseForm<Empleados> EmpleadosForm;
        private Form activeForm;
        private LoginForm loginForm; 

        private Form _formularioReciente; 

        public Form FormularioReciente
        {
            get => _formularioReciente;
            set
            {
                if (_formularioReciente is not null)  _formularioReciente.Hide();
                _formularioReciente = value;
                _formularioReciente.Show(); 
            }
                
        }



        public PrincipalForm()
        {
            InitializeComponent();

            TiposVehiculosForm = new BaseForm<TiposVehiculos>(apiUrl: "https://localhost:7018/api/TiposVehiculos", title: "Tipos de Vehiculos",createRecordForm: new CrearTiposVehiculosForm());
            TiposCombustiblesForm = new BaseForm<TiposCombustibles>(apiUrl: "https://localhost:7018/api/TiposCombustibles", title: "Tipos de Combustibles", createRecordForm: new CrearTiposCombustiblesForm());
            MarcasForm = new BaseForm<Marcas>(apiUrl: "https://localhost:7018/api/Marcas", title: "Marcas de los vehiculos", createRecordForm: new CrearMarcasForm());
            ModelosForm = new BaseForm<Modelos>(apiUrl: "https://localhost:7018/api/Modelos", title: "Modelos de los vehiculos", createRecordForm: new CrearModelosForm());
          //  EmpleadosForm = new BaseForm<Empleados>(apiUrl: "https://localhost:7018/api/Empleados", title: "Empleados");
            loginForm = new LoginForm();
            OpenChildForm(loginForm);
           OpenChildForm(TiposVehiculosForm);
            OpenChildForm(TiposCombustiblesForm);
            OpenChildForm(MarcasForm);
            OpenChildForm(ModelosForm);
          //  OpenChildForm(EmpleadosForm);
                }

       

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            /*if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;*/


            childForm.TopLevel = false;
            Controls.Add(childForm);
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();



        }

        private void btnVehicleType_Click(object sender, EventArgs e)
        {
            FormularioReciente = TiposVehiculosForm;


        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormularioReciente= MarcasForm;
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            FormularioReciente= ModelosForm;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormularioReciente = EmpleadosForm;
        }

        private void btnTipoCombustible_Click(object sender, EventArgs e)
        {
            FormularioReciente = TiposCombustiblesForm;

        }
    }
}
