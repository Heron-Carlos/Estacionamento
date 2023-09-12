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
    public partial class Status_de_Pagamento : Form
    {
        public Status_de_Pagamento()
        {
            InitializeComponent();
        }

        private void Status_de_Pagamento_Load(object sender, EventArgs e)
        {

        }

        //Método para atualizar stts de pagamento para atrasado de acordo com a placa
        private void UpdateAtrasado()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET STTS_Pagamento = 'ATRASADO' WHERE Placa = '"+textBox1.Text+"' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            label2.Text = "Atrasado";
        }

        //Método para atualizar stts de pagamento para dia do pagamento de acordo com a placa
        private void UpdateDia()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET STTS_Pagamento = 'Pagamento Hoje' WHERE Placa = '"+textBox1.Text+"' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            label2.Text = "Pagamento Hoje";
        }


        //Método para atualizar stts de pagamento para em dia de acordo com a placa
        private void UpdateEmdia()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET STTS_Pagamento = 'EM DIA'  WHERE Placa = '"+textBox1.Text+"' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            label2.Text = "Em dia";
        }

        //Método para verificar e atualizar Status de pagamento
        private void VerificarStts()
        {
            DateTime hoje = DateTime.Now.Date;
            
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from controle_mensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
              object obj = dados["Data_Pagamento"].ToString();
              DateTime  obj2 = Convert.ToDateTime(obj);
              DateTime datapagamento = obj2;
                if (hoje < datapagamento)
                {
                    this.UpdateEmdia();
                }
                else if (hoje == datapagamento)
                {
                    this.UpdateDia();
                }
                else if (hoje > datapagamento)
                {
                    this.UpdateAtrasado();
                }

            }


        }

       //Método para carregar o datagriew
        private void DataGriew()
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT Nome, CPF, Placa, Data_Pagamento, STTS_Pagamento from controle_mensalidade where Placa = '" + textBox1.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.VerificarStts();
           this.DataGriew();

            
         }
    }
}
