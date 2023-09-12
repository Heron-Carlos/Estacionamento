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
    public partial class Saída_de_Mensalidade : Form
    {

        MySqlConnection Conexao;
        public Saída_de_Mensalidade()
        {
            InitializeComponent();
        }

        //Método para carregar datagriew com dados do usuario de acordo com a placa
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT MensalidadeID,Nome, CPF, Nome_Veiculo, Tipo_Veiculo, Placa, Vaga from cadastromensalidade where Placa = '"+textBox1.Text+"'";
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


        //Método para atualzar stts da vaga pra 0(desocupado)
        private void UpgradeVaga0()
        {
            string nomeVaga = "";
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from cadastromensalidade WHERE Placa = '" + textBox1.Text + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            while (dados.Read())
            {
                nomeVaga = dados["Vaga"].ToString();

            }
            con.Close();
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand("UPDATE vagas SET status = 0 WHERE Nome = '" + nomeVaga + "'", con);
            MySqlDataReader dados2 = cmd2.ExecuteReader();
            con.Close();

        }

        //Método para trocar o stts que define se o cliente da mensalidade esta ativo ou nao ativo no estacionamento para 0(nao ativo)
        private void UpgradeSTTS0()
        {
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = " UPDATE cadastromensalidade SET STTS = '0' WHERE Placa = '" + textBox1.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Saída Liberada!");



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

        //Método para deletar a vaga do cadastro
        private void DeletVaga()
        {
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = " UPDATE cadastromensalidade SET Vaga = '' WHERE Placa = '" + textBox1.Text + "'";
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.UpgradeVaga0();
            this.DeletVaga();
            this.UpgradeSTTS0();


        }

        private void Saída_de_Mensalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
