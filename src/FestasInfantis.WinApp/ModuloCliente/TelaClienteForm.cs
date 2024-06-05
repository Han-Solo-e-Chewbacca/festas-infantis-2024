using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public Cliente Cliente
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtCpf.Text = value.Cpf;
                txtTelefone.Text = value.Telefone;
            }
            get
            {
                return cliente;
            }
        }
        public TelaClienteForm()
        {
            InitializeComponent();
        }

        private void TelaClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTelefone.Text;
           

            cliente = new Cliente(nome, cpf,telefone );

            List<string> erros = cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
