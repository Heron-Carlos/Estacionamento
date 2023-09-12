using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class CadastroMensalidade : Form
    {

       
        MySqlConnection Conexao;
        public CadastroMensalidade()
        {
            InitializeComponent();
        }

        private void CadastroMensalidade_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            label7.Text = hoje.ToString();
        }

        //Método para salvar o cadastro de mensalidade
        private void CadastroM()
        {
            DateTime tempo = DateTime.Now;
            
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO cadastromensalidade (MensalidadeID, Nome, CPF, Nome_Veiculo, Tipo_Veiculo, Placa, Data_Pagamento, STTS) VALUES ( null,'" + textBox1.Text + "','" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" + comboBox1.Text + "','" + textBox4.Text + "','" + tempo.ToString("yyyy-MM-dd") + "', '0')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                

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

        //Método para transferir dados para a tabela controle_Mensalidade
        private void ControleMensalidade()
        {

            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO controle_mensalidade (ControleID ,Nome, CPF, Nome_Veiculo, Tipo_Veiculo, Placa, Data_Pagamento, STTS_Pagamento) select  null, Nome, CPF, Nome_Veiculo, Tipo_Veiculo, Placa, null, null FROM cadastromensalidade WHERE Placa = '" + textBox4.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                


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

        //Método para atualizar a data de pagamento para daqui 30 dias
        private void DataPagamento()
        {
            string datatrans = "";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from cadastromensalidade WHERE Placa = '" + textBox4.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string data = dados["Data_Pagamento"].ToString();
                DateTime dataentrada = Convert.ToDateTime(data);
                DateTime datapagamento = dataentrada.AddDays(30);
                 datatrans = Convert.ToString(datapagamento);
                


            }
            con.Close();
            con.Open();
           DateTime datafinal = Convert.ToDateTime(datatrans);  
            MySqlCommand cmd2 = new MySqlCommand("UPDATE controle_mensalidade SET Data_Pagamento = '" + datafinal.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Placa = '" + textBox4.Text + "'", con);
            MySqlDataReader dados2 = cmd2.ExecuteReader();
            con.Close();
        }

       
        //Método para transformar status de pagamento em dia
        private void STTS ()
        {

            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET STTS_Pagamento = 'Em Dia ' WHERE Placa = '"+textBox4.Text+"' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            con.Close();


        }

        //Méto para definir o valor a pagar caso o porte seja Pequeno
        private void Pequeno()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET Valor = '50' WHERE Placa = '" + textBox4.Text + "' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            con.Close();


        }

        //Méto para definir o valor a pagar caso o porte seja medio
        private void Medio()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET Valor = '60' WHERE Placa = '" + textBox4.Text + "' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            con.Close();

        }

        //Méto para definir o valor a pagar caso o porte seja Grande
        private void Grande()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET Valor = '70' WHERE Placa = '" + textBox4.Text + "' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            con.Close();

        }

        //Méto para definir o valor a pagar caso o porte seja Moto
        private void Moto()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE controle_mensalidade SET Valor = '40' WHERE Placa = '" + textBox4.Text + "' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            con.Close();
            
        }


        //Método para atribuir valor
        private void Valor()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from controle_mensalidade WHERE Placa = '" + textBox4.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string tipo = dados["Tipo_Veiculo"].ToString();
                if (tipo == "Pequeno" )
                {
                    this.Pequeno();
                }
                else if (tipo == "Médio")
                {
                    this.Medio();
                }
                else if (tipo == "Grande")
                {
                    this.Grande();
                }
                else if (tipo == "Moto")
                {
                    this.Moto();
                }


            }

        }


        //Método para transferir dados para tabela fluxo de caixa 
        public void Concluir()
        {
            DateTime hoje = DateTime.Now;
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fluxo_caixa (Nome, Nome_Veiculo, Tipo_Veiculo, Placa, DataP, Valor, forma_pagamento )SELECT Nome, Nome_Veiculo, Tipo_Veiculo, Placa, '" + hoje.ToString("yyyy-MM-dd 00:00:00") + "', Valor, '"+comboBox2.Text+"' FROM controle_mensalidade WHERE Placa = '" + textBox4.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            MessageBox.Show("Cadastro concluído!");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.CadastroM();
            this.ControleMensalidade();
            this.DataPagamento();
            this.STTS();
            this.Valor();
            this.Concluir();
        }
    }
}
