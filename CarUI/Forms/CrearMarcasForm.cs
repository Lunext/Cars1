using Cars.Models;
using CarUI.Extra_Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarUI.Forms
{
    public partial class CrearMarcasForm : Form
    {
        public CrearMarcasForm()
        {
            InitializeComponent();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            var marcas = new Marcas();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenStore.Token);

            marcas.Descripcion = txtDescripcion.Text;
            marcas.Estado = chkbEstado.Checked;
            string json = JsonConvert.SerializeObject(marcas, Formatting.Indented);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://localhost:7018/api/Marcas", content);
            var result = response.Result;
            MessageBox.Show(result.StatusCode.ToString());
            Close();
        }
    }
}
