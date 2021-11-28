
namespace TelaCompraProdutoEstrutura
{
    partial class FormCliente
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonVerClientes = new System.Windows.Forms.Button();
            this.buttonFecharClientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonResponderPergunta = new System.Windows.Forms.RadioButton();
            this.labelPergunta1 = new System.Windows.Forms.Label();
            this.radioButtonResposta1 = new System.Windows.Forms.RadioButton();
            this.radioButtonResposta2 = new System.Windows.Forms.RadioButton();
            this.radioButtonResposta3 = new System.Windows.Forms.RadioButton();
            this.radioButtonResposta4 = new System.Windows.Forms.RadioButton();
            this.radioButtonResposta5 = new System.Windows.Forms.RadioButton();
            this.labelPergunta2 = new System.Windows.Forms.Label();
            this.checkBoxResposta1 = new System.Windows.Forms.CheckBox();
            this.checkBoxResposta2 = new System.Windows.Forms.CheckBox();
            this.checkBoxResposta3 = new System.Windows.Forms.CheckBox();
            this.checkBoxResposta4 = new System.Windows.Forms.CheckBox();
            this.checkBoxResposta5 = new System.Windows.Forms.CheckBox();
            this.labelPergunta3 = new System.Windows.Forms.Label();
            this.radioButtonOpcao1 = new System.Windows.Forms.RadioButton();
            this.radioButtonOpcao2 = new System.Windows.Forms.RadioButton();
            this.textBoxSugestoes = new System.Windows.Forms.TextBox();
            this.labelPergunta4 = new System.Windows.Forms.Label();
            this.comboBoxOpcaoesDeAvaliacao = new System.Windows.Forms.ComboBox();
            this.radioButtonFecharPerguntas = new System.Windows.Forms.RadioButton();
            this.groupBoxRespostas1 = new System.Windows.Forms.GroupBox();
            this.groupBoxRespostas2 = new System.Windows.Forms.GroupBox();
            this.buttonConfirmarRespostas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.groupBoxRespostas1.SuspendLayout();
            this.groupBoxRespostas2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(90, 158);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(143, 450);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // buttonVerClientes
            // 
            this.buttonVerClientes.Location = new System.Drawing.Point(42, 91);
            this.buttonVerClientes.Name = "buttonVerClientes";
            this.buttonVerClientes.Size = new System.Drawing.Size(89, 32);
            this.buttonVerClientes.TabIndex = 1;
            this.buttonVerClientes.Text = "Ver Clientes";
            this.buttonVerClientes.UseVisualStyleBackColor = true;
            this.buttonVerClientes.Click += new System.EventHandler(this.VerClientes);
            // 
            // buttonFecharClientes
            // 
            this.buttonFecharClientes.Location = new System.Drawing.Point(205, 91);
            this.buttonFecharClientes.Name = "buttonFecharClientes";
            this.buttonFecharClientes.Size = new System.Drawing.Size(137, 32);
            this.buttonFecharClientes.TabIndex = 2;
            this.buttonFecharClientes.Text = "Fechar Lista de Clientes";
            this.buttonFecharClientes.UseVisualStyleBackColor = true;
            this.buttonFecharClientes.Click += new System.EventHandler(this.FecharClientes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 157;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 60);
            this.label1.TabIndex = 158;
            this.label1.Text = "Queremos saber a sua opinião! Por favor, responda as seguintes perguntas, para sa" +
    "bermos como se encontra nosso cliente em relação ao sistema de compras";
            // 
            // radioButtonResponderPergunta
            // 
            this.radioButtonResponderPergunta.AutoSize = true;
            this.radioButtonResponderPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResponderPergunta.Location = new System.Drawing.Point(428, 89);
            this.radioButtonResponderPergunta.Name = "radioButtonResponderPergunta";
            this.radioButtonResponderPergunta.Size = new System.Drawing.Size(145, 19);
            this.radioButtonResponderPergunta.TabIndex = 159;
            this.radioButtonResponderPergunta.TabStop = true;
            this.radioButtonResponderPergunta.Text = "Responder Perguntas";
            this.radioButtonResponderPergunta.UseVisualStyleBackColor = true;
            this.radioButtonResponderPergunta.Click += new System.EventHandler(this.ResponderPergunta);
            // 
            // labelPergunta1
            // 
            this.labelPergunta1.AutoSize = true;
            this.labelPergunta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta1.Location = new System.Drawing.Point(428, 130);
            this.labelPergunta1.Name = "labelPergunta1";
            this.labelPergunta1.Size = new System.Drawing.Size(230, 15);
            this.labelPergunta1.TabIndex = 160;
            this.labelPergunta1.Text = "Você considera a navegação do sistema:";
            this.labelPergunta1.Visible = false;
            // 
            // radioButtonResposta1
            // 
            this.radioButtonResposta1.AutoSize = true;
            this.radioButtonResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta1.Location = new System.Drawing.Point(6, 11);
            this.radioButtonResposta1.Name = "radioButtonResposta1";
            this.radioButtonResposta1.Size = new System.Drawing.Size(58, 19);
            this.radioButtonResposta1.TabIndex = 161;
            this.radioButtonResposta1.TabStop = true;
            this.radioButtonResposta1.Text = "Ótima";
            this.radioButtonResposta1.UseVisualStyleBackColor = true;
            this.radioButtonResposta1.Visible = false;
            // 
            // radioButtonResposta2
            // 
            this.radioButtonResposta2.AutoSize = true;
            this.radioButtonResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta2.Location = new System.Drawing.Point(6, 35);
            this.radioButtonResposta2.Name = "radioButtonResposta2";
            this.radioButtonResposta2.Size = new System.Drawing.Size(47, 19);
            this.radioButtonResposta2.TabIndex = 162;
            this.radioButtonResposta2.TabStop = true;
            this.radioButtonResposta2.Text = "Boa";
            this.radioButtonResposta2.UseVisualStyleBackColor = true;
            this.radioButtonResposta2.Visible = false;
            // 
            // radioButtonResposta3
            // 
            this.radioButtonResposta3.AutoSize = true;
            this.radioButtonResposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta3.Location = new System.Drawing.Point(6, 59);
            this.radioButtonResposta3.Name = "radioButtonResposta3";
            this.radioButtonResposta3.Size = new System.Drawing.Size(69, 19);
            this.radioButtonResposta3.TabIndex = 163;
            this.radioButtonResposta3.TabStop = true;
            this.radioButtonResposta3.Text = "Regular";
            this.radioButtonResposta3.UseVisualStyleBackColor = true;
            this.radioButtonResposta3.Visible = false;
            // 
            // radioButtonResposta4
            // 
            this.radioButtonResposta4.AutoSize = true;
            this.radioButtonResposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta4.Location = new System.Drawing.Point(6, 83);
            this.radioButtonResposta4.Name = "radioButtonResposta4";
            this.radioButtonResposta4.Size = new System.Drawing.Size(55, 19);
            this.radioButtonResposta4.TabIndex = 164;
            this.radioButtonResposta4.TabStop = true;
            this.radioButtonResposta4.Text = "Ruim";
            this.radioButtonResposta4.UseVisualStyleBackColor = true;
            this.radioButtonResposta4.Visible = false;
            // 
            // radioButtonResposta5
            // 
            this.radioButtonResposta5.AutoSize = true;
            this.radioButtonResposta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta5.Location = new System.Drawing.Point(6, 107);
            this.radioButtonResposta5.Name = "radioButtonResposta5";
            this.radioButtonResposta5.Size = new System.Drawing.Size(73, 19);
            this.radioButtonResposta5.TabIndex = 165;
            this.radioButtonResposta5.TabStop = true;
            this.radioButtonResposta5.Text = "Péssima";
            this.radioButtonResposta5.UseVisualStyleBackColor = true;
            this.radioButtonResposta5.Visible = false;
            // 
            // labelPergunta2
            // 
            this.labelPergunta2.AutoSize = true;
            this.labelPergunta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta2.Location = new System.Drawing.Point(428, 284);
            this.labelPergunta2.Name = "labelPergunta2";
            this.labelPergunta2.Size = new System.Drawing.Size(365, 15);
            this.labelPergunta2.TabIndex = 166;
            this.labelPergunta2.Text = "Sobre os nossos Produtos (Pode selecionar mais de uma opção):";
            this.labelPergunta2.Visible = false;
            // 
            // checkBoxResposta1
            // 
            this.checkBoxResposta1.AutoSize = true;
            this.checkBoxResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxResposta1.Location = new System.Drawing.Point(431, 315);
            this.checkBoxResposta1.Name = "checkBoxResposta1";
            this.checkBoxResposta1.Size = new System.Drawing.Size(194, 19);
            this.checkBoxResposta1.TabIndex = 167;
            this.checkBoxResposta1.Text = "Encontrei tudo o que precisava";
            this.checkBoxResposta1.UseVisualStyleBackColor = true;
            this.checkBoxResposta1.Visible = false;
            // 
            // checkBoxResposta2
            // 
            this.checkBoxResposta2.AutoSize = true;
            this.checkBoxResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxResposta2.Location = new System.Drawing.Point(431, 339);
            this.checkBoxResposta2.Name = "checkBoxResposta2";
            this.checkBoxResposta2.Size = new System.Drawing.Size(145, 19);
            this.checkBoxResposta2.TabIndex = 168;
            this.checkBoxResposta2.Text = "Faltam mais produtos";
            this.checkBoxResposta2.UseVisualStyleBackColor = true;
            this.checkBoxResposta2.Visible = false;
            // 
            // checkBoxResposta3
            // 
            this.checkBoxResposta3.AutoSize = true;
            this.checkBoxResposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxResposta3.Location = new System.Drawing.Point(431, 363);
            this.checkBoxResposta3.Name = "checkBoxResposta3";
            this.checkBoxResposta3.Size = new System.Drawing.Size(152, 19);
            this.checkBoxResposta3.TabIndex = 169;
            this.checkBoxResposta3.Text = "O preço está muito alto";
            this.checkBoxResposta3.UseVisualStyleBackColor = true;
            this.checkBoxResposta3.Visible = false;
            // 
            // checkBoxResposta4
            // 
            this.checkBoxResposta4.AutoSize = true;
            this.checkBoxResposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxResposta4.Location = new System.Drawing.Point(431, 387);
            this.checkBoxResposta4.Name = "checkBoxResposta4";
            this.checkBoxResposta4.Size = new System.Drawing.Size(222, 19);
            this.checkBoxResposta4.TabIndex = 170;
            this.checkBoxResposta4.Text = "Faltam mais categorias de produtos";
            this.checkBoxResposta4.UseVisualStyleBackColor = true;
            this.checkBoxResposta4.Visible = false;
            // 
            // checkBoxResposta5
            // 
            this.checkBoxResposta5.AutoSize = true;
            this.checkBoxResposta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxResposta5.Location = new System.Drawing.Point(431, 410);
            this.checkBoxResposta5.Name = "checkBoxResposta5";
            this.checkBoxResposta5.Size = new System.Drawing.Size(176, 19);
            this.checkBoxResposta5.TabIndex = 171;
            this.checkBoxResposta5.Text = "O preço está bem acessível";
            this.checkBoxResposta5.UseVisualStyleBackColor = true;
            this.checkBoxResposta5.Visible = false;
            // 
            // labelPergunta3
            // 
            this.labelPergunta3.AutoSize = true;
            this.labelPergunta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta3.Location = new System.Drawing.Point(428, 440);
            this.labelPergunta3.Name = "labelPergunta3";
            this.labelPergunta3.Size = new System.Drawing.Size(292, 15);
            this.labelPergunta3.TabIndex = 172;
            this.labelPergunta3.Text = "Sobre as Formas de Pagamento, você as considera:";
            this.labelPergunta3.Visible = false;
            // 
            // radioButtonOpcao1
            // 
            this.radioButtonOpcao1.AutoSize = true;
            this.radioButtonOpcao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOpcao1.Location = new System.Drawing.Point(6, 9);
            this.radioButtonOpcao1.Name = "radioButtonOpcao1";
            this.radioButtonOpcao1.Size = new System.Drawing.Size(118, 19);
            this.radioButtonOpcao1.TabIndex = 173;
            this.radioButtonOpcao1.TabStop = true;
            this.radioButtonOpcao1.Text = "Acessível a todos";
            this.radioButtonOpcao1.UseVisualStyleBackColor = true;
            this.radioButtonOpcao1.Visible = false;
            this.radioButtonOpcao1.Click += new System.EventHandler(this.CheckOpcao1);
            // 
            // radioButtonOpcao2
            // 
            this.radioButtonOpcao2.AutoSize = true;
            this.radioButtonOpcao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOpcao2.Location = new System.Drawing.Point(6, 32);
            this.radioButtonOpcao2.Name = "radioButtonOpcao2";
            this.radioButtonOpcao2.Size = new System.Drawing.Size(222, 19);
            this.radioButtonOpcao2.TabIndex = 174;
            this.radioButtonOpcao2.TabStop = true;
            this.radioButtonOpcao2.Text = "Faltam mais opções. Sugerir outras:";
            this.radioButtonOpcao2.UseVisualStyleBackColor = true;
            this.radioButtonOpcao2.Visible = false;
            this.radioButtonOpcao2.Click += new System.EventHandler(this.CheckOpcao2);
            // 
            // textBoxSugestoes
            // 
            this.textBoxSugestoes.Enabled = false;
            this.textBoxSugestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSugestoes.Location = new System.Drawing.Point(234, 30);
            this.textBoxSugestoes.Name = "textBoxSugestoes";
            this.textBoxSugestoes.Size = new System.Drawing.Size(100, 21);
            this.textBoxSugestoes.TabIndex = 175;
            this.textBoxSugestoes.Visible = false;
            // 
            // labelPergunta4
            // 
            this.labelPergunta4.AutoSize = true;
            this.labelPergunta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta4.Location = new System.Drawing.Point(428, 517);
            this.labelPergunta4.Name = "labelPergunta4";
            this.labelPergunta4.Size = new System.Drawing.Size(152, 15);
            this.labelPergunta4.TabIndex = 176;
            this.labelPergunta4.Text = "Avalie o sistema de 0 a 10:";
            this.labelPergunta4.Visible = false;
            // 
            // comboBoxOpcaoesDeAvaliacao
            // 
            this.comboBoxOpcaoesDeAvaliacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcaoesDeAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpcaoesDeAvaliacao.FormattingEnabled = true;
            this.comboBoxOpcaoesDeAvaliacao.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxOpcaoesDeAvaliacao.Location = new System.Drawing.Point(431, 542);
            this.comboBoxOpcaoesDeAvaliacao.Name = "comboBoxOpcaoesDeAvaliacao";
            this.comboBoxOpcaoesDeAvaliacao.Size = new System.Drawing.Size(176, 23);
            this.comboBoxOpcaoesDeAvaliacao.TabIndex = 177;
            this.comboBoxOpcaoesDeAvaliacao.Visible = false;
            // 
            // radioButtonFecharPerguntas
            // 
            this.radioButtonFecharPerguntas.AutoSize = true;
            this.radioButtonFecharPerguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFecharPerguntas.Location = new System.Drawing.Point(629, 89);
            this.radioButtonFecharPerguntas.Name = "radioButtonFecharPerguntas";
            this.radioButtonFecharPerguntas.Size = new System.Drawing.Size(122, 19);
            this.radioButtonFecharPerguntas.TabIndex = 178;
            this.radioButtonFecharPerguntas.TabStop = true;
            this.radioButtonFecharPerguntas.Text = "Fechar Perguntas";
            this.radioButtonFecharPerguntas.UseVisualStyleBackColor = true;
            this.radioButtonFecharPerguntas.Visible = false;
            this.radioButtonFecharPerguntas.Click += new System.EventHandler(this.FecharPerguntas);
            // 
            // groupBoxRespostas1
            // 
            this.groupBoxRespostas1.Controls.Add(this.radioButtonResposta3);
            this.groupBoxRespostas1.Controls.Add(this.radioButtonResposta1);
            this.groupBoxRespostas1.Controls.Add(this.radioButtonResposta2);
            this.groupBoxRespostas1.Controls.Add(this.radioButtonResposta4);
            this.groupBoxRespostas1.Controls.Add(this.radioButtonResposta5);
            this.groupBoxRespostas1.Location = new System.Drawing.Point(431, 148);
            this.groupBoxRespostas1.Name = "groupBoxRespostas1";
            this.groupBoxRespostas1.Size = new System.Drawing.Size(86, 133);
            this.groupBoxRespostas1.TabIndex = 179;
            this.groupBoxRespostas1.TabStop = false;
            this.groupBoxRespostas1.Visible = false;
            // 
            // groupBoxRespostas2
            // 
            this.groupBoxRespostas2.Controls.Add(this.radioButtonOpcao1);
            this.groupBoxRespostas2.Controls.Add(this.radioButtonOpcao2);
            this.groupBoxRespostas2.Controls.Add(this.textBoxSugestoes);
            this.groupBoxRespostas2.Location = new System.Drawing.Point(431, 458);
            this.groupBoxRespostas2.Name = "groupBoxRespostas2";
            this.groupBoxRespostas2.Size = new System.Drawing.Size(343, 56);
            this.groupBoxRespostas2.TabIndex = 180;
            this.groupBoxRespostas2.TabStop = false;
            this.groupBoxRespostas2.Visible = false;
            // 
            // buttonConfirmarRespostas
            // 
            this.buttonConfirmarRespostas.Location = new System.Drawing.Point(431, 574);
            this.buttonConfirmarRespostas.Name = "buttonConfirmarRespostas";
            this.buttonConfirmarRespostas.Size = new System.Drawing.Size(87, 34);
            this.buttonConfirmarRespostas.TabIndex = 181;
            this.buttonConfirmarRespostas.Text = "Confirmar Respostas";
            this.buttonConfirmarRespostas.UseVisualStyleBackColor = true;
            this.buttonConfirmarRespostas.Visible = false;
            this.buttonConfirmarRespostas.Click += new System.EventHandler(this.ConfirmarRespostas);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(703, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 256;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Voltar);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 43);
            this.label3.TabIndex = 257;
            this.label3.Text = "Veja a lista de Clientes que estão fazendo parte do nosso sistema de compras";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirmarRespostas);
            this.Controls.Add(this.groupBoxRespostas2);
            this.Controls.Add(this.groupBoxRespostas1);
            this.Controls.Add(this.radioButtonFecharPerguntas);
            this.Controls.Add(this.comboBoxOpcaoesDeAvaliacao);
            this.Controls.Add(this.labelPergunta4);
            this.Controls.Add(this.labelPergunta3);
            this.Controls.Add(this.checkBoxResposta5);
            this.Controls.Add(this.checkBoxResposta4);
            this.Controls.Add(this.checkBoxResposta3);
            this.Controls.Add(this.checkBoxResposta2);
            this.Controls.Add(this.checkBoxResposta1);
            this.Controls.Add(this.labelPergunta2);
            this.Controls.Add(this.labelPergunta1);
            this.Controls.Add(this.radioButtonResponderPergunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFecharClientes);
            this.Controls.Add(this.buttonVerClientes);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.groupBoxRespostas1.ResumeLayout(false);
            this.groupBoxRespostas1.PerformLayout();
            this.groupBoxRespostas2.ResumeLayout(false);
            this.groupBoxRespostas2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonVerClientes;
        private System.Windows.Forms.Button buttonFecharClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonResponderPergunta;
        private System.Windows.Forms.Label labelPergunta1;
        private System.Windows.Forms.RadioButton radioButtonResposta1;
        private System.Windows.Forms.RadioButton radioButtonResposta2;
        private System.Windows.Forms.RadioButton radioButtonResposta3;
        private System.Windows.Forms.RadioButton radioButtonResposta4;
        private System.Windows.Forms.RadioButton radioButtonResposta5;
        private System.Windows.Forms.Label labelPergunta2;
        private System.Windows.Forms.CheckBox checkBoxResposta1;
        private System.Windows.Forms.CheckBox checkBoxResposta2;
        private System.Windows.Forms.CheckBox checkBoxResposta3;
        private System.Windows.Forms.CheckBox checkBoxResposta4;
        private System.Windows.Forms.CheckBox checkBoxResposta5;
        private System.Windows.Forms.Label labelPergunta3;
        private System.Windows.Forms.RadioButton radioButtonOpcao1;
        private System.Windows.Forms.RadioButton radioButtonOpcao2;
        private System.Windows.Forms.TextBox textBoxSugestoes;
        private System.Windows.Forms.Label labelPergunta4;
        private System.Windows.Forms.ComboBox comboBoxOpcaoesDeAvaliacao;
        private System.Windows.Forms.RadioButton radioButtonFecharPerguntas;
        private System.Windows.Forms.GroupBox groupBoxRespostas1;
        private System.Windows.Forms.GroupBox groupBoxRespostas2;
        private System.Windows.Forms.Button buttonConfirmarRespostas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}