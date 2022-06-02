﻿using Cars.Models;
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
    public partial class CrearTiposVehiculosForm : Form
    {
        public CrearTiposVehiculosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tipoVehiculo = new TiposVehiculos();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenStore.Token);

            tipoVehiculo.Descripcion = txtDescripcion.Text;
            tipoVehiculo.Estado = chkbEstado.Checked;
            string json = JsonConvert.SerializeObject(tipoVehiculo, Formatting.Indented);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://localhost:7018/api/TiposVehiculos", content);
            var result = response.Result;
            MessageBox.Show(result.StatusCode.ToString());
            Close();
        }
    }
}
