using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto.Agreement.JPake;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teste
{
    public partial class Entrada_de_veiculos : Form
    {
        string Tipo = "";
       
        MySqlConnection Conexao;
        public Entrada_de_veiculos()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.insertRegistro();
            this.updateVaga();
            this.Close();
            
     
            

        }
        //Criando metodo para salvar o registro no banco de dados
        private void insertRegistro()
        {
            DateTime tempo = DateTime.Now;
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO registro (RegistroId, Tipo, Nome, DataEntrada,Placa, Vagas, NomeV) VALUES ( null,'" + Tipo + "','" + textBox3.Text + "' ,'" + tempo.ToString("yyyy-MM-dd HH:mm:ss") + "' ,'" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "')";
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
                Entrada_de_veiculos j1 = new Entrada_de_veiculos();
                j1.Close();
            }
        }

        //Criando metodo para trocar o status da vaga para 1 (ocupado) apos confirmação do registro
        private void updateVaga()
        {
            
            DateTime tempo = DateTime.Now;
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "UPDATE vagas SET status = 1 WHERE Nome = '" + comboBox1.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastrado Concluído !");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";



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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            

        }

        private void Entrada_de_veiculos_Load(object sender, EventArgs e)
        {
            


        }
        private void vagas ()
        {
            
        }


        //definino botao 2 para carregar o combobox com as vags destinadas a pequeno porte e com status 0(desocupada)
        private void button2_Click(object sender, EventArgs e)
        {
            Tipo = "Pequeno";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'pequeno'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }

        //definino botao 3 para carregar o combobox com as vags destinadas a medio porte e com status 0(desocupada)
        private void button3_Click(object sender, EventArgs e)
        {
            Tipo = "Médio";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'medio'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }

        //definino botao 4 para carregar o combobox com as vags destinadas a grande porte e com status 0(desocupada)
        private void button4_Click(object sender, EventArgs e)
        {
            Tipo = "Grande";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'grande'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }

        //definino botao 5 para carregar o combobox com as vags destinadas a moto e com status 0(desocupada)
        private void button5_Click(object sender, EventArgs e)
        {
            Tipo = "Moto";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vagas WHERE status = 0 AND porte = 'moto'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dados);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "VagasID";
            comboBox1.DataSource = dt;
            comboBox1.Text = "Selecione uma vaga";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
        

    


