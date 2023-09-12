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

namespace teste
{
    public partial class Excluir_Mensalidade : Form
    {
        public Excluir_Mensalidade()
        {
            InitializeComponent();
        }


        //Método para carregar datagriewd com dados de acordo com a placa
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM controle_mensalidade where Placa = '" + textBox1.Text + "'";
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

        //Método para excluir Registro de mensalidade na tabela cadastromensalidade
        private void Excluir()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM cadastromensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            
            con.Close();
        }


        //Método para excluir Registro de mensalidade na tabela controle_mensalidade
        private void Excluir2()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM controle_mensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            MessageBox.Show("Fechamento concluído!");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Excluir();
            this.Excluir2();
        }

        private void Excluir_Mensalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
