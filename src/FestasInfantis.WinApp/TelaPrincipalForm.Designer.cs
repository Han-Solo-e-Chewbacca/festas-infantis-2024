﻿namespace FestasInfantis.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesMenuItem = new ToolStripMenuItem();
            temasMenuItem = new ToolStripMenuItem();
            itensToolStripMenuItem = new ToolStripMenuItem();
            alugueisMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnAdicionarItens = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnVisualizarAlugueis = new ToolStripButton();
            btnConcluirAluguel = new ToolStripButton();
            btnConfigurarDescontos = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem, temasMenuItem, alugueisMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(109, 29);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.Name = "clientesMenuItem";
            clientesMenuItem.Size = new Size(224, 30);
            clientesMenuItem.Text = "Clientes";
            clientesMenuItem.Click += clientesMenuItem_Click;
            // 
            // temasMenuItem
            // 
            temasMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itensToolStripMenuItem });
            temasMenuItem.Name = "temasMenuItem";
            temasMenuItem.Size = new Size(224, 30);
            temasMenuItem.Text = "Temas";
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(138, 30);
            itensToolStripMenuItem.Text = "Itens";
            // 
            // alugueisMenuItem
            // 
            alugueisMenuItem.Name = "alugueisMenuItem";
            alugueisMenuItem.Size = new Size(224, 30);
            alugueisMenuItem.Text = "Aluguéis";
            alugueisMenuItem.Click += alugueisMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 569);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 31);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(237, 25);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator3, btnAdicionarItens, toolStripSeparator2, btnVisualizarAlugueis, btnConcluirAluguel, btnConfigurarDescontos, toolStripSeparator4, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = Properties.Resources.btnFiltrar;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(5);
            btnFiltrar.Size = new Size(38, 38);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled = false;
            btnAdicionarItens.Image = Properties.Resources.btnAdicionarItens;
            btnAdicionarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(5);
            btnAdicionarItens.Size = new Size(38, 38);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnVisualizarAlugueis
            // 
            btnVisualizarAlugueis.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarAlugueis.Enabled = false;
            btnVisualizarAlugueis.Image = Properties.Resources.btnVisualizarAlugueis;
            btnVisualizarAlugueis.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarAlugueis.ImageTransparentColor = Color.Magenta;
            btnVisualizarAlugueis.Name = "btnVisualizarAlugueis";
            btnVisualizarAlugueis.Padding = new Padding(5);
            btnVisualizarAlugueis.Size = new Size(38, 38);
            // 
            // btnConcluirAluguel
            // 
            btnConcluirAluguel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirAluguel.Enabled = false;
            btnConcluirAluguel.Image = Properties.Resources.btnConcluirAluguel;
            btnConcluirAluguel.ImageScaling = ToolStripItemImageScaling.None;
            btnConcluirAluguel.ImageTransparentColor = Color.Magenta;
            btnConcluirAluguel.Name = "btnConcluirAluguel";
            btnConcluirAluguel.Padding = new Padding(5);
            btnConcluirAluguel.Size = new Size(38, 38);
            // 
            // btnConfigurarDescontos
            // 
            btnConfigurarDescontos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfigurarDescontos.Enabled = false;
            btnConfigurarDescontos.Image = Properties.Resources.btnConfigurarDescontos;
            btnConfigurarDescontos.ImageScaling = ToolStripItemImageScaling.None;
            btnConfigurarDescontos.ImageTransparentColor = Color.Magenta;
            btnConfigurarDescontos.Name = "btnConfigurarDescontos";
            btnConfigurarDescontos.Padding = new Padding(5);
            btnConfigurarDescontos.Size = new Size(38, 38);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(155, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 76);
            pnlRegistros.Margin = new Padding(3, 4, 3, 4);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(914, 493);
            pnlRegistros.TabIndex = 3;
            pnlRegistros.Paint += pnlRegistros_Paint;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festas Infantis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnVisualizarAlugueis;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAdicionarItens;
        private ToolStripButton btnConcluirAluguel;
        private ToolStripButton btnConfigurarDescontos;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStripMenuItem temasMenuItem;
        private ToolStripMenuItem itensToolStripMenuItem;
        private ToolStripMenuItem alugueisMenuItem;
    }
}
