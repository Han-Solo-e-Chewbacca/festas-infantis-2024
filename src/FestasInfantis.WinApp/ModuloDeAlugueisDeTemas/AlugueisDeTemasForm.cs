using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloDeAlugueisDeTemas
{
    public partial class AlugueisDeTemasForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
                clienteBox.SelectedItem = value.Cliente;
                TemaBox.SelectedItem = value.Tema;
                txtPorcentagemDeEntrada.Text = value.PorcentagemDeEntrada;
                txtPorcentagemDeDesconto.Text = value.PorcentagemDeDesconto;
                DataDaFestaPicker.MinDate = value.DataDoPagamento;
                value.StatusAluguel.Equals(true);
                Festa festa = value.Festa;

            }
            get
            {
                return aluguel;
            }
        }
        public AlugueisDeTemasForm()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)clienteBox.SelectedItem;
            Tema tema = (Tema)TemaBox.SelectedItem;
            string porcentagemDeEntrada = txtPorcentagemDeEntrada.Text;
            string porcentagemDeDesconto = txtPorcentagemDeDesconto.Text;
            DateTime dataDoPagamento = DataDaFestaPicker.MinDate;
            bool aluguado = true;

            DateTime dataFesta = DataDaFestaPicker.MinDate;
            DateTime inicio = HorarioDeInicioPicker.MinDate;
            DateTime termino = HorarioDeTerminoPicker.MinDate;
            string cidade = txtCidade.Text;
            string rua = txtRua.Text;
            string bairro = txtBairro.Text;
            string estado = txtEstado.Text;
            string numero = txtNumero.Text;

            Festa festa = new Festa(dataFesta,inicio,termino,cidade,rua,bairro,estado,numero);

            aluguel = new Aluguel(cliente, tema, porcentagemDeEntrada, porcentagemDeDesconto, dataDoPagamento, aluguado, festa);

            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AlugueisDeTemasForm_Load(object sender, EventArgs e)
        {

        }

        private void clienteBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
