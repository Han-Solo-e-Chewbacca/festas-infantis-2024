namespace FestasInfantis.WinApp.ModuloDeAlugueisDeTemas
{
    partial class AlugueisDeTemasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlugueisDeTemasForm));
            Dados = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            DataDaFestaPicker = new DateTimePicker();
            HorarioDeInicioPicker = new DateTimePicker();
            HorarioDeTerminoPicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtCidade = new TextBox();
            txtRua = new TextBox();
            txtEstado = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox3 = new GroupBox();
            txtPorcentagemDeDesconto = new TextBox();
            txtValorDoTema = new TextBox();
            txtValorDoSinal = new TextBox();
            txtValorDoTemaComDesconto = new TextBox();
            txtValorPendente = new TextBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            Dados.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Dados
            // 
            Dados.Controls.Add(tabPage1);
            Dados.Controls.Add(tabPage2);
            Dados.Location = new Point(4, 89);
            Dados.Name = "Dados";
            Dados.SelectedIndex = 0;
            Dados.Size = new Size(739, 522);
            Dados.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 489);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Festa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 489);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Aluguel";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(HorarioDeTerminoPicker);
            groupBox1.Controls.Add(HorarioDeInicioPicker);
            groupBox1.Controls.Add(DataDaFestaPicker);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora:";
            // 
            // DataDaFestaPicker
            // 
            DataDaFestaPicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataDaFestaPicker.Format = DateTimePickerFormat.Short;
            DataDaFestaPicker.Location = new Point(187, 54);
            DataDaFestaPicker.Name = "DataDaFestaPicker";
            DataDaFestaPicker.Size = new Size(122, 27);
            DataDaFestaPicker.TabIndex = 0;
            // 
            // HorarioDeInicioPicker
            // 
            HorarioDeInicioPicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HorarioDeInicioPicker.Format = DateTimePickerFormat.Time;
            HorarioDeInicioPicker.Location = new Point(187, 87);
            HorarioDeInicioPicker.Name = "HorarioDeInicioPicker";
            HorarioDeInicioPicker.Size = new Size(122, 27);
            HorarioDeInicioPicker.TabIndex = 1;
            // 
            // HorarioDeTerminoPicker
            // 
            HorarioDeTerminoPicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HorarioDeTerminoPicker.Format = DateTimePickerFormat.Time;
            HorarioDeTerminoPicker.Location = new Point(187, 118);
            HorarioDeTerminoPicker.Name = "HorarioDeTerminoPicker";
            HorarioDeTerminoPicker.Size = new Size(122, 27);
            HorarioDeTerminoPicker.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 59);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Data da Festa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 92);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Horário de Inicío:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 125);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 5;
            label3.Text = "Horário de Término:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtEstado);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(683, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(101, 61);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(300, 27);
            txtCidade.TabIndex = 0;
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRua.Location = new Point(101, 94);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(554, 27);
            txtRua.TabIndex = 1;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.Location = new Point(514, 61);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(141, 27);
            txtEstado.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(101, 127);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(300, 27);
            txtBairro.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(514, 127);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(141, 27);
            txtNumero.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 64);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "Cidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 97);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 6;
            label5.Text = "Rua:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 130);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 7;
            label6.Text = "Bairro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 64);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 8;
            label7.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(442, 130);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 9;
            label8.Text = "Número:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 39);
            label9.Name = "label9";
            label9.Size = new Size(33, 28);
            label9.TabIndex = 1;
            label9.Text = "Id:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(51, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(71, 34);
            textBox6.TabIndex = 2;
            textBox6.Text = "0";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(457, 617);
            button1.Name = "button1";
            button1.Size = new Size(128, 66);
            button1.TabIndex = 6;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(591, 617);
            button2.Name = "button2";
            button2.Size = new Size(121, 66);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(76, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(402, 44);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(302, 28);
            comboBox3.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(txtValorDoTemaComDesconto);
            groupBox3.Controls.Add(txtValorPendente);
            groupBox3.Controls.Add(txtPorcentagemDeDesconto);
            groupBox3.Controls.Add(txtValorDoTema);
            groupBox3.Controls.Add(txtValorDoSinal);
            groupBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(683, 250);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados de Pagamento:";
            // 
            // txtPorcentagemDeDesconto
            // 
            txtPorcentagemDeDesconto.Enabled = false;
            txtPorcentagemDeDesconto.Font = new Font("Segoe UI", 9F);
            txtPorcentagemDeDesconto.Location = new Point(125, 139);
            txtPorcentagemDeDesconto.Name = "txtPorcentagemDeDesconto";
            txtPorcentagemDeDesconto.Size = new Size(81, 27);
            txtPorcentagemDeDesconto.TabIndex = 4;
            // 
            // txtValorDoTema
            // 
            txtValorDoTema.Enabled = false;
            txtValorDoTema.Font = new Font("Segoe UI", 9F);
            txtValorDoTema.Location = new Point(125, 172);
            txtValorDoTema.Name = "txtValorDoTema";
            txtValorDoTema.Size = new Size(138, 27);
            txtValorDoTema.TabIndex = 5;
            // 
            // txtValorDoSinal
            // 
            txtValorDoSinal.Enabled = false;
            txtValorDoSinal.Font = new Font("Segoe UI", 9F);
            txtValorDoSinal.Location = new Point(125, 205);
            txtValorDoSinal.Name = "txtValorDoSinal";
            txtValorDoSinal.Size = new Size(138, 27);
            txtValorDoSinal.TabIndex = 6;
            // 
            // txtValorDoTemaComDesconto
            // 
            txtValorDoTemaComDesconto.Enabled = false;
            txtValorDoTemaComDesconto.Font = new Font("Segoe UI", 9F);
            txtValorDoTemaComDesconto.Location = new Point(519, 139);
            txtValorDoTemaComDesconto.Name = "txtValorDoTemaComDesconto";
            txtValorDoTemaComDesconto.Size = new Size(125, 27);
            txtValorDoTemaComDesconto.TabIndex = 7;
            // 
            // txtValorPendente
            // 
            txtValorPendente.Enabled = false;
            txtValorPendente.Font = new Font("Segoe UI", 9F);
            txtValorPendente.Location = new Point(519, 205);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.Size = new Size(125, 27);
            txtValorPendente.TabIndex = 8;
            txtValorPendente.TextChanged += textBox5_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(6, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(671, 83);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(6, 142);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 10;
            label10.Text = "% de Desconto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(10, 175);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 11;
            label11.Text = "Valor do Tema:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(14, 208);
            label12.Name = "label12";
            label12.Size = new Size(104, 20);
            label12.TabIndex = 12;
            label12.Text = "Valor do Sinal:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(404, 142);
            label13.Name = "label13";
            label13.Size = new Size(110, 40);
            label13.TabIndex = 13;
            label13.Text = "Valor do Tema\r\nCom Desconto:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(403, 208);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 14;
            label14.Text = "Valor Pendente:\r\n";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 47);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 4;
            label15.Text = "Cliente:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 81);
            label16.Name = "label16";
            label16.Size = new Size(44, 20);
            label16.TabIndex = 5;
            label16.Text = "Sinal:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(348, 47);
            label17.Name = "label17";
            label17.Size = new Size(48, 20);
            label17.TabIndex = 6;
            label17.Text = "Tema:";
            // 
            // AlugueisDeTemasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 695);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(Dados);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlugueisDeTemasForm";
            ShowIcon = false;
            Text = "Aluguéis De Temas";
            Dados.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl Dados;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker HorarioDeTerminoPicker;
        private DateTimePicker HorarioDeInicioPicker;
        private DateTimePicker DataDaFestaPicker;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtEstado;
        private TextBox txtRua;
        private TextBox txtCidade;
        private Label label3;
        private Label label2;
        private Label label9;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private TextBox txtValorDoTema;
        private TextBox txtPorcentagemDeDesconto;
        private GroupBox groupBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private TextBox txtValorDoTemaComDesconto;
        private TextBox txtValorPendente;
        private TextBox txtValorDoSinal;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label17;
        private Label label16;
        private Label label15;
    }
}