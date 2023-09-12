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
    public partial class Deletar_Usuario : Form
    {
        MySqlConnection Conexao;
        public Deletar_Usuario()
        {
            InitializeComponent();
        }

        //Método para carregar o datagriewd com informações do usuário
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Cn;
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Cn = new MySqlConnection(data_source);
                Cn.Open();
                var exibirVagas = "SELECT * FROM login WHERE Usuario = '"+textBox1.Text+"'";
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

        //Método para deletar usuario no bd
        private void Deletar()
        {
            try
            {
                string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                Conexao = new MySqlConnection(data_source);
                string sql = "DELETE FROM login WHERE usuario = '"+textBox1.Text+"'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Usuário deletado!");
                this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Deletar();
        }

        private void Deletar_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
