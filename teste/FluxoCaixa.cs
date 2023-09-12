using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace teste
{
    public partial class FluxoCaixa : Form
    {
        public FluxoCaixa()
        {
            InitializeComponent();
        }

        public void FluxoCaixa_Load(object sender, EventArgs e)
        {
        }
        
        //Método para mostrar os valores lugrados no dia
        private void Dia()
        {
            DateTime hoje = DateTime.Now;

            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Valor FROM fluxo_caixa WHERE DataP = '" + hoje.ToString("yyyy-MM-dd") + "' ", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            var listaNumeros = new List<string>();
            while (dados.Read())
            {
                listaNumeros.Add(dados["Valor"].ToString());

            }

            decimal soma = 0;
            foreach (var valor in listaNumeros)
            {

                soma += Convert.ToDecimal(valor);


            }
            label1.Text = soma.ToString();



            var data = DateTime.Now.AddDays(-30);
        }

        //Método para mostrar os valores lucrados nos ultimoss 15 dias
        private void Dia15 ()
        {
            DateTime hoje = DateTime.Now;

            var data = DateTime.Now.AddDays(-15);
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Valor FROM fluxo_caixa WHERE DataP BETWEEN  '" + data.ToString("yyyy-MM-dd 00:00:00") + "' AND  '" + hoje.ToString("yyyy-MM-dd 00:00:00") + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            var listaNumeros = new List<string>();
            while (dados.Read())
            {
                listaNumeros.Add(dados["Valor"].ToString());

            }

            decimal soma = 0;
            foreach (var valor in listaNumeros)
            {

                soma += Convert.ToDecimal(valor);


            }
            label2.Text = soma.ToString(); 
        }


        //Método para mostrar os valores lucrados nos ultimoss 30 dias
        private void Dia30()
        {
            DateTime hoje = DateTime.Now;
            var data = DateTime.Now.AddDays(-30);
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Valor FROM fluxo_caixa WHERE DataP BETWEEN '" + data.ToString("yyyy-MM-dd 00:00:00") + "' AND  '" + hoje.ToString("yyyy-MM-dd 00:00:00") + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            var listaNumeros = new List<string>();
            while (dados.Read())
            {
                listaNumeros.Add(dados["Valor"].ToString());

            }

            decimal soma = 0;
            foreach (var valor in listaNumeros)
            {

                soma += Convert.ToDecimal(valor);


            }
            label3.Text = soma.ToString();
        }


        //Método para gerar PDF
        private void PDF()
        {
            DateTime dataIni = Convert.ToDateTime(dateTimePicker1.Text).Date;
            DateTime dataFinal = Convert.ToDateTime(dateTimePicker2.Text).Date;
            DateTime hoje = DateTime.Now;
            var data = DateTime.Now.AddDays(-30);
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($@"SELECT Nome, Tipo_Veiculo, Placa, DataP , Valor, forma_Pagamento
              FROM fluxo_caixa WHERE DataP BETWEEN '{dataIni.ToString("yyy-MM-dd")}' AND '{dataFinal.ToString("yyy-MM-dd")}'", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            var ListaFluxoCaixa = new List<FluxoDeCaixa>();
            while (dados.Read())
            {
                ListaFluxoCaixa.Add(new FluxoDeCaixa
                {
                    
                    Cliente = dados["Nome"].ToString(),
                    DataPagamento = dados["DataP"].ToString(),
                    PlacaVeiculo = dados["Placa"].ToString(),
                    Tipo = dados["Tipo_Veiculo"].ToString(),
                    ValorPago = dados["Valor"].ToString(),
                    FormaPagamento = dados["forma_pagamento"].ToString()
                    
                });

                
            }

            Console.WriteLine(ListaFluxoCaixa);
            DateTime dataHoje = DateTime.Now;
            string agora = dataHoje.ToString("yyyy-MM-dd  HH-mm-ss");
            string nomeArquivo = $@"C:\Users\Heron\Desktop\PDF\Relatorio{agora.ToString()}.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance($@"C:\Users\Heron\Desktop\PDF\\HD.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;

            string dados1 = "";
            Paragraph paragrafo1 = new Paragraph(dados1, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatorio de fluxo \n\n");

           
            

            PdfPTable tabela = new PdfPTable(6);
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("Cliente");
            tabela.AddCell("Tipo");
            tabela.AddCell("Placa");
            tabela.AddCell("Data Pagamento");
            tabela.AddCell("Forma");
            tabela.AddCell("Valor Pago");


            decimal soma2 = 0;
            foreach (var fluxo in ListaFluxoCaixa)
            {

                tabela.AddCell(fluxo.Cliente);
                tabela.AddCell(fluxo.Tipo);
                tabela.AddCell(fluxo.PlacaVeiculo);
                tabela.AddCell(fluxo.DataPagamento);
                tabela.AddCell(fluxo.FormaPagamento);
                tabela.AddCell(fluxo.ValorPago);
                soma2 += Convert.ToDecimal(fluxo.ValorPago);


            }
            string teste = "";
            string total = soma2.ToString();
            Paragraph paragrafo2 = new Paragraph(teste, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add($@" Total...........................................{total}");

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();
            MessageBox.Show("Exportado com sucesso!");
            
        }

        //Método para gerar EXCEL
        private void Excel()
        {
            DateTime dataIni = Convert.ToDateTime(dateTimePicker1.Text).Date;
            DateTime dataFinal = Convert.ToDateTime(dateTimePicker2.Text).Date;
            DateTime hoje = DateTime.Now;
            var data = DateTime.Now.AddDays(-30);
            string strConexao = "server=us-cdbr-east-06.cleardb.net;database=heroku_be9399613bff43a;uid=be05cf50fb0ba2;pwd=ab3c0667;port=3306";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($@"SELECT Nome, Tipo_Veiculo, Placa, DataP , Valor, forma_Pagamento
              FROM fluxo_caixa WHERE DataP BETWEEN '{dataIni.ToString("yyy-MM-dd")}' AND '{dataFinal.ToString("yyy-MM-dd")}'", con);
            MySqlDataReader dados = cmd.ExecuteReader();

            var ListaFluxoCaixa = new List<FluxoDeCaixa>();
            while (dados.Read())
            {
                ListaFluxoCaixa.Add(new FluxoDeCaixa
                {

                    Cliente = dados["Nome"].ToString(),
                    DataPagamento = dados["DataP"].ToString(),
                    PlacaVeiculo = dados["Placa"].ToString(),
                    Tipo = dados["Tipo_Veiculo"].ToString(),
                    ValorPago = dados["Valor"].ToString(),
                    FormaPagamento = dados["forma_pagamento"].ToString()

                });


            }

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            ws.Cells[1, 1] = "Cliente";
            ws.Cells[1, 2] = "Data Pagamento";
            ws.Cells[1, 3] = "Placa";
            ws.Cells[1, 4] = "Tipo";
            ws.Cells[1, 5] = "Forma Pagamento";
            ws.Cells[1, 6] = "Valor Pago";
           

            int linha = 2;
            decimal soma2 = 0;
            foreach (var fluxo in ListaFluxoCaixa)
            {

                ws.Cells[linha, 1] = fluxo.Cliente;
                ws.Cells[linha, 2] = fluxo.DataPagamento;
                ws.Cells[linha, 3] = fluxo.PlacaVeiculo;
                ws.Cells[linha, 4] = fluxo.Tipo;
                ws.Cells[linha, 5] = fluxo.FormaPagamento;
                ws.Cells[linha, 6] = fluxo.ValorPago;
                linha++;

               ws.Cells[linha, 6] = $@"Total = {soma2 += Convert.ToDecimal(fluxo.ValorPago)}";
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dia15();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dia30();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.PDF();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Excel();
        }
    }
    
}
