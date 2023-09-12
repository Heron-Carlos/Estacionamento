using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teste
{
    public partial class controle_de_vagas : Form
    {
        public controle_de_vagas()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void controle_de_vagas_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //Definindo botao 1 para mostrar todas as vagas 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM vagas";
                using (MySqlDataAdapter da = new MySqlDataAdapter(exibirVagas, Cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Definindo botao 2 para mostrar vagas ocupadas
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM vagas WHERE status = 1 ";
                using (MySqlDataAdapter da = new MySqlDataAdapter(exibirVagas, Cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Definindo botao 3 para mostrar as vagas desocupadas
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM vagas WHERE status = 0 ";
                using (MySqlDataAdapter da = new MySqlDataAdapter(exibirVagas, Cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
