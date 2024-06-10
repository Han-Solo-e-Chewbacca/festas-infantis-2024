using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
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
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
     
            public void AtualizarRegistros(List<Aluguel> alugueis)
            {
                grid.Rows.Clear();

                foreach (Aluguel c in alugueis)
                    grid.Rows.Add(c.Id, c.Tema, c.Cliente.Nome, c.Festa.Cidade);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "NomeDoCliente", HeaderText = "Nome do Cliente" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cidade", HeaderText = "Cidade" },

                            };
            }
            private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
