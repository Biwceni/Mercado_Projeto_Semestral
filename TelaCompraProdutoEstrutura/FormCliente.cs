using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaCompraProdutoEstrutura
{
    public partial class FormCliente : Form
    {
        private FormMercado Mercado = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormCliente()
        {
            InitializeComponent();
        }

        private void VerClientes(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=mercado_cliente;SslMode=none");
            string sql = $"select usuario from clientes_log";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                MySqlDataReader linhas = comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Columns.Add("Usuarios");

                while (linhas.Read())
                {
                    DataRow linha = tabela.NewRow();
                    linha[0] = linhas["Usuario"];

                    tabela.Rows.Add(linha);
                }
                dataGridViewClientes.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void FecharClientes(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = null;
        }

        private void ResponderPergunta(object sender, EventArgs e)
        {
            if (radioButtonResponderPergunta.Checked)
            {
                radioButtonFecharPerguntas.Visible = true;
                labelPergunta1.Visible = true;
                labelPergunta2.Visible = true;
                labelPergunta3.Visible = true;
                labelPergunta4.Visible = true;
                groupBoxRespostas1.Visible = true;
                groupBoxRespostas2.Visible = true;
                radioButtonResposta1.Visible = true;
                radioButtonResposta2.Visible = true;
                radioButtonResposta3.Visible = true;
                radioButtonResposta4.Visible = true;
                radioButtonResposta5.Visible = true;
                checkBoxResposta1.Visible = true;
                checkBoxResposta2.Visible = true;
                checkBoxResposta3.Visible = true;
                checkBoxResposta4.Visible = true;
                checkBoxResposta5.Visible = true;
                radioButtonOpcao1.Visible = true;
                radioButtonOpcao2.Visible = true;
                textBoxSugestoes.Visible = true;
                comboBoxOpcaoesDeAvaliacao.Visible = true;
                buttonConfirmarRespostas.Visible = true;
            }
        }

        private void FecharPerguntas(object sender, EventArgs e)
        {
            if (radioButtonFecharPerguntas.Checked)
            {
                radioButtonFecharPerguntas.Visible = false;
                labelPergunta1.Visible = false;
                labelPergunta2.Visible = false;
                labelPergunta3.Visible = false;
                labelPergunta4.Visible = false;
                groupBoxRespostas1.Visible = false;
                groupBoxRespostas2.Visible = false;
                radioButtonResposta1.Visible = false;
                radioButtonResposta2.Visible = false;
                radioButtonResposta3.Visible = false;
                radioButtonResposta4.Visible = false;
                radioButtonResposta5.Visible = false;
                checkBoxResposta1.Visible = false;
                checkBoxResposta2.Visible = false;
                checkBoxResposta3.Visible = false;
                checkBoxResposta4.Visible = false;
                checkBoxResposta5.Visible = false;
                radioButtonOpcao1.Visible = false;
                radioButtonOpcao2.Visible = false;
                textBoxSugestoes.Visible = false;
                comboBoxOpcaoesDeAvaliacao.Visible = false;
                radioButtonResposta1.Checked = false;
                radioButtonResposta2.Checked = false;
                radioButtonResposta3.Checked = false;
                radioButtonResposta4.Checked = false;
                radioButtonResposta5.Checked = false;
                checkBoxResposta1.Checked = false;
                checkBoxResposta2.Checked = false;
                checkBoxResposta3.Checked = false;
                checkBoxResposta4.Checked = false;
                checkBoxResposta5.Checked = false;
                radioButtonOpcao1.Checked = false;
                radioButtonOpcao2.Checked = false;
                textBoxSugestoes.Text = "";
                textBoxSugestoes.Enabled = false;
                comboBoxOpcaoesDeAvaliacao.SelectedIndex = -1;
                buttonConfirmarRespostas.Visible = false;
            }
        }

        private void ConfirmarRespostas(object sender, EventArgs e)
        {
            if (radioButtonResponderPergunta.Checked)
            {
                if (radioButtonResposta1.Checked == false && radioButtonResposta2.Checked == false && radioButtonResposta3.Checked == false && radioButtonResposta4.Checked == false && radioButtonResposta5.Checked == false && checkBoxResposta1.Checked == false && checkBoxResposta2.Checked == false && checkBoxResposta3.Checked == false && checkBoxResposta4.Checked == false && checkBoxResposta5.Checked == false && radioButtonOpcao1.Checked == false && radioButtonOpcao2.Checked == false && comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Por Favor, responda o Formulario");
                }
                if (radioButtonResposta1.Checked == false && radioButtonResposta2.Checked == false && radioButtonResposta3.Checked == false && radioButtonResposta4.Checked == false && radioButtonResposta5.Checked == false)
                {
                    MessageBox.Show("Por Favor, responda a 1º Pergunta");
                }
                if (checkBoxResposta1.Checked == false && checkBoxResposta2.Checked == false && checkBoxResposta3.Checked == false && checkBoxResposta4.Checked == false && checkBoxResposta5.Checked == false)
                {
                    MessageBox.Show("Por Favor, responda a 2º Pergunta");
                }
                if (radioButtonOpcao1.Checked == false && radioButtonOpcao2.Checked == false)
                {
                    MessageBox.Show("Por Favor, responda a 3º Pergunta");
                }
                if (comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Por Favor, responda a 4º Pergunta");
                }
            }

            if (radioButtonResponderPergunta.Checked)
            {
                if (radioButtonResposta1.Checked || radioButtonResposta2.Checked || radioButtonResposta3.Checked || radioButtonResposta4.Checked || radioButtonResposta5.Checked)
                {
                    if (checkBoxResposta1.Checked || checkBoxResposta2.Checked || checkBoxResposta3.Checked || checkBoxResposta4.Checked || checkBoxResposta5.Checked)
                    {
                        if (radioButtonOpcao1.Checked || radioButtonOpcao2.Checked && textBoxSugestoes.Text != "")
                        {
                            if (comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(0) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(1) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(2) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(3) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(4) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(5) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(6) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(7) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(8) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(9) || comboBoxOpcaoesDeAvaliacao.SelectedIndex.Equals(10))
                            {
                                MessageBox.Show("Respostas enviadas, obrigado pela atenção");
                                radioButtonResposta1.Checked = false;
                                radioButtonResposta2.Checked = false;
                                radioButtonResposta3.Checked = false;
                                radioButtonResposta4.Checked = false;
                                radioButtonResposta5.Checked = false;
                                checkBoxResposta1.Checked = false;
                                checkBoxResposta2.Checked = false;
                                checkBoxResposta3.Checked = false;
                                checkBoxResposta4.Checked = false;
                                checkBoxResposta5.Checked = false;
                                radioButtonOpcao1.Checked = false;
                                radioButtonOpcao2.Checked = false;
                                textBoxSugestoes.Text = "";
                                textBoxSugestoes.Enabled = false;
                                comboBoxOpcaoesDeAvaliacao.SelectedIndex = -1;
                            }
                        }
                        else if (radioButtonOpcao2.Checked && textBoxSugestoes.Text == "")
                        {
                            MessageBox.Show("Por favor, responda o campo de Sugestões caso tenha marcado a segunda opção");
                        }
                    }
                }
            }    
        }

        private void CheckOpcao2(object sender, EventArgs e)
        {
            textBoxSugestoes.Enabled = radioButtonOpcao2.Checked;
        }

        private void CheckOpcao1(object sender, EventArgs e)
        {
            textBoxSugestoes.Enabled = false;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setCliente(this);
            this.Hide();
            dataGridViewClientes.DataSource = null;
            radioButtonResponderPergunta.Checked = false;
            radioButtonFecharPerguntas.Visible = false;
            labelPergunta1.Visible = false;
            labelPergunta2.Visible = false;
            labelPergunta3.Visible = false;
            labelPergunta4.Visible = false;
            groupBoxRespostas1.Visible = false;
            groupBoxRespostas2.Visible = false;
            radioButtonResposta1.Visible = false;
            radioButtonResposta2.Visible = false;
            radioButtonResposta3.Visible = false;
            radioButtonResposta4.Visible = false;
            radioButtonResposta5.Visible = false;
            checkBoxResposta1.Visible = false;
            checkBoxResposta2.Visible = false;
            checkBoxResposta3.Visible = false;
            checkBoxResposta4.Visible = false;
            checkBoxResposta5.Visible = false;
            radioButtonOpcao1.Visible = false;
            radioButtonOpcao2.Visible = false;
            textBoxSugestoes.Visible = false;
            comboBoxOpcaoesDeAvaliacao.Visible = false;
            radioButtonResposta1.Checked = false;
            radioButtonResposta2.Checked = false;
            radioButtonResposta3.Checked = false;
            radioButtonResposta4.Checked = false;
            radioButtonResposta5.Checked = false;
            checkBoxResposta1.Checked = false;
            checkBoxResposta2.Checked = false;
            checkBoxResposta3.Checked = false;
            checkBoxResposta4.Checked = false;
            checkBoxResposta5.Checked = false;
            radioButtonOpcao1.Checked = false;
            radioButtonOpcao2.Checked = false;
            textBoxSugestoes.Text = "";
            textBoxSugestoes.Enabled = false;
            comboBoxOpcaoesDeAvaliacao.SelectedIndex = -1;
            buttonConfirmarRespostas.Visible = false;
        }
    }
}
