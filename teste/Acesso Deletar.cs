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
    public partial class Acesso_Deletar : Form
    {
        Thread t1;
        public Acesso_Deletar()
        {
            InitializeComponent();
        }

        private void Acesso_Deletar_Load(object sender, EventArgs e)
        {

        }


        private void abrirJanela()
        {
            Application.Run(new Deletar_Usuario());
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
