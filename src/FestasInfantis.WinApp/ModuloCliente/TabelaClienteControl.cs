using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
            
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
       

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente c in clientes)
                grid.Rows.Add(c.Id, c.Nome.ToTitleCase(), c.Telefone, c.Cpf);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF" },
               
                        };
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
