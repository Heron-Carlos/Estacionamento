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
using MySql.Data.MySqlClient;
using Microsoft.Win32;
using System.Numerics;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities.Collections;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace teste
{
    public partial class saida : Form
    {

        double X;
        public saida()
        {
            InitializeComponent();
        }

        //Criando método para gerar a conta caso o veículo for de Pequeno porte
        private void pequeno()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from registro WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string dataEntrada = dados["DataEntrada"].ToString();
                DateTime dataSaida = DateTime.Now;
                string conv = Convert.ToString(dataSaida);
                DateTime data1, data2;
                data1 = DateTime.Parse(conv);
                data2 = DateTime.Parse(dataEntrada);
                TimeSpan result = data1 - data2;
                int hora = int.Parse(result.Hours.ToString());
                int minuto = int.Parse(result.Minutes.ToString());
                int dia = int.Parse(result.Days.ToString());
                var entrada = label2;
                var saida = label3;
                entrada.Text = data2.ToString();
                saida.Text = data1.ToString();
                if (hora >= 1 || dia >= 1)
                {
                    int day = dia * 24 * 60;
                    int horat = hora * 60 - 60 + minuto;
                    X = (day + horat) * 0.05 + 5;
                    var label = label5;
                    label.Text = X.ToString();
                }
                else
                {
                    X = 5;
                    var label = label5;
                    label.Text = X.ToString();
                }
            }



        }


        //Criando método para gerar a conta caso o veículo for de medio porte
        private void medio()
        {

            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from registro WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string dataEntrada = dados["DataEntrada"].ToString();
                DateTime dataSaida = DateTime.Now;
                string conv = Convert.ToString(dataSaida);
                DateTime data1, data2;
                data1 = DateTime.Parse(conv);
                data2 = DateTime.Parse(dataEntrada);
                TimeSpan result = data1 - data2;
                int hora = int.Parse(result.Hours.ToString());
                int minuto = int.Parse(result.Minutes.ToString());
                int dia = int.Parse(result.Days.ToString());
                var entrada = label2;
                var saida = label3;
                entrada.Text = data2.ToString();
                saida.Text = data1.ToString();
                if (hora >= 1 || dia >= 1)
                {
                    int day = dia * 24 * 60;
                    int horat = hora * 60 - 60 + minuto;
                    X = (day + horat) * 0.05 + 7;
                    var label = label5;
                    label.Text = X.ToString();
                }
                else
                {
                    X = 7;
                    var label = label5;
                    label.Text = X.ToString();
                }

            }


        }


        //Criando método para gerar a conta caso o veículo for de grande porte
        private void grande()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from registro WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string dataEntrada = dados["DataEntrada"].ToString();
                DateTime dataSaida = DateTime.Now;
                string conv = Convert.ToString(dataSaida);
                DateTime data1, data2;
                data1 = DateTime.Parse(conv);
                data2 = DateTime.Parse(dataEntrada);
                TimeSpan result = data1 - data2;
                int hora = int.Parse(result.Hours.ToString());
                int minuto = int.Parse(result.Minutes.ToString());
                int dia = int.Parse(result.Days.ToString());
                var entrada = label2;
                var saida = label3;
                entrada.Text = data2.ToString();
                saida.Text = data1.ToString();
                if (hora >= 1 || dia >= 1)
                {
                    int day = dia * 24 * 60;
                    int horat = hora * 60 - 60 + minuto;
                    X = (day + horat) * 0.05 + 10;
                    var label = label5;
                    label.Text = X.ToString();
                }
                else
                {
                    X = 10;
                    var label = label5;
                    label.Text = X.ToString();
                }
            }

        }



        //Criando método para gerar a conta caso o veículo for para motos 
        public void moto()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from registro WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string dataEntrada = dados["DataEntrada"].ToString();
                DateTime dataSaida = DateTime.Now;
                string conv = Convert.ToString(dataSaida);
                DateTime data1, data2;
                data1 = DateTime.Parse(conv);
                data2 = DateTime.Parse(dataEntrada);
                TimeSpan result = data1 - data2;
                int hora = int.Parse(result.Hours.ToString());
                int minuto = int.Parse(result.Minutes.ToString());
                int dia = int.Parse(result.Days.ToString());
                var entrada = label2;
                var saida = label3;
                entrada.Text = data2.ToString();
                saida.Text = data1.ToString();
                if (hora >= 1 || dia >= 1)
                {
                    int day = dia * 24 * 60;
                    int horat = hora * 60 - 60 + minuto;
                    X = (day + horat) * 0.05 + 7;
                    var label = label5;
                    label.Text = X.ToString();
                }
                else
                {
                    X = 7;
                    var label = label5;
                    label.Text = X.ToString();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saida_Load(object sender, EventArgs e)
        {
            label2.Text = "................................";
            label3.Text = "................................";
            label5.Text = "........";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }


        //Definindo botao 1 para carregar o dataGrid com as informações do cliente referente a placa 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT RegistroId, Tipo, Nome, DataEntrada, Placa, Vagas, NomeV from registro where Placa = '" + textBox1.Text + "'";
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

        //Criando metodo para fazer o calculo de horas que o cliente ficou no estacionamento e reconhecendo qual o porte de seu veículo
        private void Calculo()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from registro WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string dataEntrada = dados["DataEntrada"].ToString();
                DateTime dataSaida = DateTime.Now;
                string conv = Convert.ToString(dataSaida);
                DateTime data1, data2;
                data1 = DateTime.Parse(conv);
                data2 = DateTime.Parse(dataEntrada);
                TimeSpan result = data1 - data2;
                int x = int.Parse(result.Hours.ToString());


                string tipo = dados["Tipo"].ToString();
                if (tipo == "Pequeno")
                {
                    this.pequeno();
                }
                else if (tipo == "Médio")
                {
                    this.medio();
                }
                else if (tipo == "Grande")
                {
                    this.grande();
                }
                else if (tipo == "Moto")
                {
                    this.moto();
                }

            }


        }


        //Metodo para salvar os dados do cliente na tabela resgistros_fechados quando o mesmo fechar a conta 
        private void confirmar()
        {
            DateTime tempo = DateTime.Now;

            float valor = float.Parse(label5.Text);

            

            try
            {
                string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                MySqlConnection con = new MySqlConnection(strConexao);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(" insert into registros_fechados(Tipo, Nome, DataEntrada, Placa, Vagas, NomeV, Valor_Total, DataSaida) select Tipo, Nome, DataEntrada, Placa, Vagas, NomeV, '" + label5.Text + "', '" + tempo.ToString("yyyy-MM-dd HH:mm:ss") + "' from registro WHERE Placa = '" + textBox1.Text + "' ", con);
                MySqlDataReader dados = cmd.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao salvar o pagamento" + ex.Message);
            }

        }


        //Método para deletar o registro da tabela registro
        private void deleteRegistro()
        {
            try
            {
                string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                MySqlConnection con = new MySqlConnection(strConexao);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM registro WHERE Placa = '" + textBox1.Text + "'", con);
                MySqlDataReader dados = cmd.ExecuteReader();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao confirmar pagamento" + ex.Message);
            }





        }


        //Método para Trocar o status da vaga do veículo que está saindo para '0'0(Vago)
        private void updateVaga0()
        {
            string nomeVaga = "";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from registro WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            while (dados.Read())
            {
                nomeVaga = dados["Vagas"].ToString();

            }
            con.Close();
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand("UPDATE vagas SET status = 0 WHERE Nome = '" + nomeVaga + "'", con);
            MySqlDataReader dados2 = cmd2.ExecuteReader();
        }


        private void Fluxo()
        {
            DateTime hoje = DateTime.Now;
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fluxo_caixa (Nome, Nome_Veiculo, Tipo_Veiculo, Placa, DataP, Valor, forma_pagamento)SELECT Nome, NomeV, Tipo, Placa, '" + hoje.ToString("yyyy-MM-dd 00:00:00") + "' , Valor_Total, '"+comboBox1.Text+"' FROM registros_fechados WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            MessageBox.Show("Fechamento concluído!");

        }

        //Método para calcular o troco 
        private void Troco()
        {
            
            try
            {
                string v = textBox2.Text;
                string v2 = label5.Text;
                var valor = double.Parse(v);
                var valor2 = double.Parse(v2);
                var troco = valor - valor2;
                label10.Text = troco.ToString();
               
            }
            catch (Exception)
            {
            MessageBox.Show("Erro ao gerar o troco");

                
            }
            
        }
    



        //Chamando metodo de calculo descrito a cima 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Calculo();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.confirmar();
            this.updateVaga0();
            this.deleteRegistro();
            this.Fluxo();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Troco();
        }
    }
}
