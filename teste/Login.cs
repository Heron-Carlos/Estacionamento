using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace teste
{
    public partial class Login : Form
    {
        MySqlConnection Conexao;
        Thread t1;
       

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Metodo para validar usuario e senha e carregar o progress bar
        private async void buscar()
        {
            
            try
            {
                label3.Visible = true;
                progressBar1.Visible = true;
                
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "SELECT * FROM login WHERE Usuario = '" + textBox1.Text + "'AND Senha = '" + textBox2.Text + "'";
                MySqlDataAdapter comando = new MySqlDataAdapter(sql, Conexao);
                Conexao.Open();
                DataTable dt = new DataTable();
                comando.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    
                    progressBar1.Maximum = 100;
                    progressBar1.Value = 100;
                    await Task.Delay(1000);
                    bool valor = Convert.ToBoolean(progressBar1.Value);
                    if (valor = valor)
                    {
                        this.Abrir();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou senha Inválida");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void Abrir()
        {

            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            this.Close();
        }
        //Método para verificar usuario e senha no bd
        private void button1_Click(object sender, EventArgs e)
        {

            
            this.buscar();




        }

        private void abrirJanela(object obj)
        {
            Application.Run(new inicio());
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
