using Cars.Models;
using Newtonsoft.Json;

namespace CarUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeDataSet(); 
            

        }

        private void MakeDataSet()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7018/api/TiposVehiculos");
            var x = response.Result.Content.ReadAsStringAsync().Result;

            List<TiposVehiculos>? ls = JsonConvert.DeserializeObject<List<TiposVehiculos>>(x);
           dataGridView1.DataSource = ls;
        }


    }
}