using CarUI.Extra_Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using CarUI.Forms;
using Cars.Models;


namespace CarUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtUsername.ForeColor = Color.White;
               
            }
            catch { }


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPassword.ForeColor = Color.White;

                txtPassword.PasswordChar = '*';

            }
            catch { }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

            txtPassword.SelectAll();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            

            if (username != null && password != null)
            {
                var client = new HttpClient();
                var user = new Dictionary<string, string>()
                {
                    { "username", username },
                    { "password", password }
                };
                try
                {

                    string json = JsonConvert.SerializeObject(user, Formatting.Indented);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
             
                    var response = client.PostAsync("https://localhost:7018/api/Users/authenticate", content);
                var result = response.Result;
                
                
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var x = result.Content.ReadAsStringAsync().Result;
                        dynamic y = JObject.Parse(x);
                        string token = y.token;
                        TokenStore.Token = token;
                        PrincipalForm prForm = new PrincipalForm();
                       // this.Close(); 
                        prForm.Show();

                        //Program.principalForm.FormularioReciente = Program.principalForm.TiposCombustiblesForm;


                    }
                    else 
                    {
                        MessageBox.Show("Wrong User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

            }

        } private void panel5_Paint(object sender, PaintEventArgs e)
             {

             }
        }
    }
