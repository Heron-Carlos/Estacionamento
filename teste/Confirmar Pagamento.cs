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
    public partial class Confirmar_Pagamento : Form
    {
        public Confirmar_Pagamento()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Método para carregar DataGriew
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
            this.LABEL();
        }

        private void Confirmar_Pagamento_Load(object sender, EventArgs e)
        {

        }

        //Método para transferir dados para tabela fluxo de caixa 
        public void Concluir()
        {
            DateTime hoje = DateTime.Now;
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fluxo_caixa (Nome, Nome_Veiculo, Tipo_Veiculo, Placa, DataP, Valor, forma_pagamento )SELECT Nome, Nome_Veiculo, Tipo_Veiculo, Placa, '"+hoje.ToString("yyyy-MM-dd 00:00:00") + "', Valor, '"+comboBox1.Text+"' FROM controle_mensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
           
            con.Close();

        }

        //Método para carregar a label com o valor a se pagar de acordo com  tipo de veículo
        private void LABEL()
        {
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from controle_mensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                string tipo = dados["Tipo_Veiculo"].ToString();

                if (tipo == "Pequeno")
                {
                    label5.Text = "50,00";
                }
                else if (tipo == "Médio")
                {
                    label5.Text = "60,00"; ;
                }
                else if (tipo == "Grande")
                {
                    label5.Text = "70,00"; ;
                }
                else if (tipo == "Moto")
                {
                    label5.Text = "40,00"; ;
                }

            }

        }
            //Método para atualizar a nova data de pagamento
            private void UpdateData ()
        {
            string datatrans = "";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from controle_mensalidade WHERE Placa = '" + textBox1.Text + "'", con);
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
            MySqlCommand cmd2 = new MySqlCommand("UPDATE controle_mensalidade SET Data_Pagamento = '" + datafinal.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados2 = cmd2.ExecuteReader();
            MessageBox.Show("Pagamento concluído!");
            con.Close();
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

                MessageBox.Show("Falha ao Calcular o troco !");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Concluir();

            this.UpdateData();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "........";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Troco();
        }
    }
}
