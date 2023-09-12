using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adicionarEntradaDoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entrada(object sender, EventArgs e)
        {
            Entrada_de_veiculos j2 = new Entrada_de_veiculos();
            j2.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saida j3 = new saida();
            j3.Show();
        }

        private void acessarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           controle_de_vagas j4 = new controle_de_vagas();
            j4.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Gerando relogio na tela inicial
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString("HH:MM:ss");

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FluxoCaixa j5 = new FluxoCaixa(); 
            j5.Show();  

        }

        private void controleDeRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleRegistros j6 = new controleRegistros();
            j6.Show(); 
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMensalidade j7 = new CadastroMensalidade();
            j7.Show();
        }

        private void adicionarMensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarMensalidade j8 = new AdicionarMensalidade();
            j8.Show();
        }

        private void controleDeMensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMensalidade j9 = new ControleMensalidade();
            j9.Show();
        }

        private void adicionarSaídaDeMensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saída_de_Mensalidade j10 = new Saída_de_Mensalidade();
            j10.Show();
        }

        private void acessarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Status_de_Pagamento j11 = new Status_de_Pagamento();    
            j11.Show();
        }

        private void confirmarPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmar_Pagamento j12 = new Confirmar_Pagamento();
            j12.Show();
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir_Mensalidade j13 = new Excluir_Mensalidade();
            j13.Show();
        }

        private void acessarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastro_Login j14 = new Cadastro_Login();
            j14.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso_Deletar J15 = new Acesso_Deletar();
            J15.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
