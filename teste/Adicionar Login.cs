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
    public partial class Adicionar_Login : Form
    {

        MySqlConnection Conexao;
        public Adicionar_Login()
        {
            InitializeComponent();
        }

        private void Adicionar_Login_Load(object sender, EventArgs e)
        {

        }


        //Método para cadasstrar um nomvo usuario e senha 
        private void Cadastrar()
        {
            {
                try
                {
                    string data_source = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
                    Conexao = new MySqlConnection(data_source);
                    string sql = "INSERT INTO login (LoginID, Usuario, Senha) VALUES ( null,'" + textBox1.Text + "','" + textBox2.Text + "' )";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    Conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Usuário Cadastrado!");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cadastrar();
            this.Close();
        }
    }
}
