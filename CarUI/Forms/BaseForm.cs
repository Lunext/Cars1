using CarUI.Extra_Classes;
using CarUI.Forms;
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

namespace CarUI
{
    public partial class BaseForm<ModelType> : Form
        where ModelType: new()
    {
        
        private string ApiUrl;
        private List<ModelType> dataList;
        private Form CreateRecordForm;
        
        public BaseForm(string apiUrl, string title, Form createRecordForm)
        {
            InitializeComponent();
            Text = title; 
            ApiUrl = apiUrl;
            CreateRecordForm = createRecordForm; 

            
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

           // MakeDataSet(); 

        }

        private void MakeDataSet()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenStore.Token);
            var response = client.GetAsync(ApiUrl);
            var x = response.Result.Content.ReadAsStringAsync().Result;

           dataList = JsonConvert.DeserializeObject < List<ModelType>>(x);

            dataGridView1.DataSource = dataList; 
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new CrearTiposCombustiblesForm();
            /*  switch(c)
              {
                  case new CrearTipoCombustiblesForm():
                      c = new CrearTiposCombustiblesForm();
                      c.ShowDialog();
                      MakeDataSet();
              }*/

            CreateRecordForm.ShowDialog();
          
            MakeDataSet();
        }

        private void BaseForm_Shown(object sender, EventArgs e)
        {
            MakeDataSet();
        }
    }
}
