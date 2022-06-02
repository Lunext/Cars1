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
using Cars.Data;
using Newtonsoft.Json;
using CarUI.Extra_Classes;

namespace CarUI.Forms
{
    public partial class CrearModelosForm : Form
    {
        public CrearModelosForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void FillCombo()
        {
            using var db = new CarsContext();

            List<Modelos> marcas = new List<Modelos>();

            foreach (var marcasItem in marcas)
            {
                marcasItem.Id = marcasItem.Id;
            }
            var obj = new Modelos{ Id = 0, Descripcion = "ELIJA" };
            marcas.Insert(0, obj);
            comboBox1.DataSource = marcas;
            comboBox1.DisplayMember = "Marcas";
            comboBox1.ValueMember = "MarcasId";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var modelos = new Modelos();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenStore.Token);

           modelos.Descripcion = txtDescripcion.Text;
            modelos.Estado = chkbEstado.Checked;
            modelos.MarcasId = comboBox1.SelectedIndex;
            string json = JsonConvert.SerializeObject(modelos, Formatting.Indented);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://localhost:7018/api/Modelos", content);
            var result = response.Result;
            MessageBox.Show(result.StatusCode.ToString());
            Close();

        }

        private void CrearModelosForm_Load(object sender, EventArgs e)
        {
            FillCombo(); 
        }
    }
}
