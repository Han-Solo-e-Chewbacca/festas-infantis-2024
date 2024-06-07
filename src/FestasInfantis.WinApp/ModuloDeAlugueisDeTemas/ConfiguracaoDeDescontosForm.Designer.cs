namespace FestasInfantis.WinApp.ModuloDeAlugueisDeTemas
{
    partial class ConfiguracaoDeDescontosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            PorcentagemPorAluguel = new NumericUpDown();
            MaximoDePorcentagemDeDesconto = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PorcentagemPorAluguel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximoDePorcentagemDeDesconto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MaximoDePorcentagemDeDesconto);
            groupBox1.Controls.Add(PorcentagemPorAluguel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porcentagens de Desconto";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(245, 205);
            button1.Name = "button1";
            button1.Size = new Size(115, 51);
            button1.TabIndex = 7;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(366, 205);
            button2.Name = "button2";
            button2.Size = new Size(121, 51);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(37, 53);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 0;
            label1.Text = "Porcentagem por Aluguel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(216, 46);
            label2.TabIndex = 1;
            label2.Text = "            Máximo de \r\nPorcentagem de Desconto:";
            // 
            // PorcentagemPorAluguel
            // 
            PorcentagemPorAluguel.Font = new Font("Segoe UI", 10.2F);
            PorcentagemPorAluguel.Location = new Point(277, 46);
            PorcentagemPorAluguel.Name = "PorcentagemPorAluguel";
            PorcentagemPorAluguel.Size = new Size(71, 30);
            PorcentagemPorAluguel.TabIndex = 4;
            // 
            // MaximoDePorcentagemDeDesconto
            // 
            MaximoDePorcentagemDeDesconto.Font = new Font("Segoe UI", 10.2F);
            MaximoDePorcentagemDeDesconto.Location = new Point(277, 116);
            MaximoDePorcentagemDeDesconto.Name = "MaximoDePorcentagemDeDesconto";
            MaximoDePorcentagemDeDesconto.Size = new Size(71, 30);
            MaximoDePorcentagemDeDesconto.TabIndex = 5;
            // 
            // ConfiguracaoDeDescontosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 260);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfiguracaoDeDescontosForm";
            ShowIcon = false;
            Text = "Configuração De Descontos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PorcentagemPorAluguel).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximoDePorcentagemDeDesconto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button2;
        private NumericUpDown PorcentagemPorAluguel;
        private NumericUpDown MaximoDePorcentagemDeDesconto;
    }
}