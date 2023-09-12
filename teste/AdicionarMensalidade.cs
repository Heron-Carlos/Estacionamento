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
    public partial class AdicionarMensalidade : Form
    {
        MySqlConnection Conexao;
        public AdicionarMensalidade()
        {
            InitializeComponent();
        }

        private void AdicionarMensalidade_Load(object sender, EventArgs e)
        {

        }


        //Método para carregar vaga caso o tipo do veículo for pequeno
        private void Pequeno()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'Pequeno'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }


        //Método para carregar vaga caso o tipo do veículo for medio
        private void Medio()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'Medio'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }


        //Método para carregar vaga caso o tipo do veículo for Grande
        private void Grande()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'Grande'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }

        //Método para carregar vaga caso o tipo do veículo for Moto
        private void Moto()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'Moto'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }

        //Método para carregar datagriewd
        private void Acessar()
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT MensalidadeID, Nome, CPF, Nome_Veiculo, Tipo_Veiculo, Placa FROM cadastromensalidade WHERE Placa = '" + textBox1.Text + "'";
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

        //Método para definir vaga 
        private void Vagas()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from cadastromensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {

                string vaga = dados["Tipo_Veiculo"].ToString();
                if (vaga == "Pequeno")
                {
                    this.Pequeno();
                }
                else if (vaga == "Médio")
                {
                    this.Medio();

                }
                else if (vaga == "Grande")
                {
                    this.Grande();
                }
                else if (vaga == "Moto")
                {
                    this.Moto();
                }


            }
        }


        //Método para trocar vaga para status 1(ocupado)
        private void updatevaga()
        {
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "UPDATE vagas SET status = 1 WHERE Nome = '" + comboBox1.Text + "'; UPDATE cadastromensalidade SET STTS = '1' WHERE Placa = '" + textBox1.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Registrado!");



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

        //Método para adicionar a vaga no cadastro do cliente
        private void adicionarVaga()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Update cadastromensalidade SET Vaga = '"+comboBox1.Text+"' where placa = '"+textBox1.Text+"'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            con.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Acessar();
            this.Vagas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.updatevaga();
            this.adicionarVaga();
        }
    
}
    }
