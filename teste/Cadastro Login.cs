using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Cadastro_Login : Form
    {
        Thread t1;
        public Cadastro_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Login_Load(object sender, EventArgs e)
        {

        }
        private void abrirJanela(object obj)
        {
            Application.Run(new Adicionar_Login());
        }

        //Método para verificar usuario e senha do adm
        private void button1_Click(object sender, EventArgs e)
        {

            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            if (textBox1.Text == "Heron" && textBox2.Text == "1234")
            {

                t1.Start();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário ou senha Inválida");
            }

        }
    }
}
