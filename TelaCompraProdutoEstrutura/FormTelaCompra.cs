using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCompraProdutoEstrutura
{
    public partial class FormTelaCompra : Form
    {
        private FormMercado Mercado = null;
        private FormHortifruti TelaHortfruit = null;
        private FormBebidas TelaBebidas = null;
        private FormLimpeza TelaLimpeza = null;
        private FormHigienePessoal TelaHigienePessoal = null;
        private FormSalgadinhosBolacha TelaSalgadinhoBolacha = null;
        private FormCongeladosResfriados TelaCongeladosResfriados = null;
        private FormDoce TelaDoce = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public void setHortfruit(FormHortifruti TelaHortfruit)
        {
            this.TelaHortfruit = TelaHortfruit;
        }
        public void setBebidas(FormBebidas TelaBebidas)
        {
            this.TelaBebidas = TelaBebidas;
        }
        public void setLimpeza(FormLimpeza TelaLimpeza)
        {
            this.TelaLimpeza = TelaLimpeza;
        }
        public void setHigiene(FormHigienePessoal TelaHigienePessoal)
        {
            this.TelaHigienePessoal = TelaHigienePessoal;
        }
        public void setSalgadinhoBolacha(FormSalgadinhosBolacha TelaSalgadinhoBolacha)
        {
            this.TelaSalgadinhoBolacha = TelaSalgadinhoBolacha;
        }
        public void setCongeladosResfriados(FormCongeladosResfriados TelaCongeladosResfriados)
        {
            this.TelaCongeladosResfriados = TelaCongeladosResfriados;
        }
        public void setDoce(FormDoce TelaDoce)
        {
            this.TelaDoce = TelaDoce;
        }
        public FormTelaCompra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckCartaoDeCredito(object sender, EventArgs e)
        {
            maskedTextBoxNumeroDoCartao.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxValidade.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxCvv.Enabled = radioButtonCartaoDeCredito.Checked;
            textBoxNomeDoTitular.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = radioButtonCartaoDeCredito.Checked;
            maskedTextBoxNumeroDoCartao2.Enabled = false;
            maskedTextBoxValidade2.Enabled = false;
            maskedTextBoxCvv2.Enabled = false;
            textBoxNomeDoTitular2.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
            maskedTextBoxNumeroDoCartao2.Text = "";
            maskedTextBoxValidade2.Text = "";
            maskedTextBoxCvv2.Text = "";
            textBoxNomeDoTitular2.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
            maskedTextBoxNumeroDoCartao2.Mask = "";
            maskedTextBoxValidade2.Mask = "";
            maskedTextBoxCvv2.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
            labelCodigoDoPix.Visible = false;
        }

        private void CheckCartaoDeDebito(object sender, EventArgs e)
        {
            maskedTextBoxNumeroDoCartao2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxValidade2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxCvv2.Enabled = radioButtonCartaoDeDebito.Checked;
            textBoxNomeDoTitular2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = radioButtonCartaoDeDebito.Checked;
            maskedTextBoxNumeroDoCartao.Enabled = false;
            maskedTextBoxValidade.Enabled = false;
            maskedTextBoxCvv.Enabled = false;
            textBoxNomeDoTitular.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
            maskedTextBoxNumeroDoCartao.Text = "";
            maskedTextBoxValidade.Text = "";
            maskedTextBoxCvv.Text = "";
            textBoxNomeDoTitular.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
            maskedTextBoxNumeroDoCartao.Mask = "";
            maskedTextBoxValidade.Mask = "";
            maskedTextBoxCvv.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            labelCodigoDoPix.Visible = false;
        }

        private void CheckPix(object sender, EventArgs e)
        {
            labelCodigoDoPix.Visible = radioButtonPix.Checked;
            maskedTextBoxNumeroDoCartao.Enabled = false;
            maskedTextBoxValidade.Enabled = false;
            maskedTextBoxCvv.Enabled = false;
            textBoxNomeDoTitular.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
            maskedTextBoxNumeroDoCartao.Text = "";
            maskedTextBoxValidade.Text = "";
            maskedTextBoxCvv.Text = "";
            textBoxNomeDoTitular.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
            maskedTextBoxNumeroDoCartao.Mask = "";
            maskedTextBoxValidade.Mask = "";
            maskedTextBoxCvv.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            maskedTextBoxNumeroDoCartao2.Enabled = false;
            maskedTextBoxValidade2.Enabled = false;
            maskedTextBoxCvv2.Enabled = false;
            textBoxNomeDoTitular2.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
            maskedTextBoxNumeroDoCartao2.Text = "";
            maskedTextBoxValidade2.Text = "";
            maskedTextBoxCvv2.Text = "";
            textBoxNomeDoTitular2.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
            maskedTextBoxNumeroDoCartao2.Mask = "";
            maskedTextBoxValidade2.Mask = "";
            maskedTextBoxCvv2.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
        }

        private void CheckSim(object sender, EventArgs e)
        {
            textBoxRua.Enabled = radioButtonSim.Checked;
            textBoxNumero.Enabled = radioButtonSim.Checked;
            textBoxBairro.Enabled = radioButtonSim.Checked;
            maskedTextBoxCep.Enabled = radioButtonSim.Checked;
        }

        private void CheckNao(object sender, EventArgs e)
        {
            textBoxRua.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            maskedTextBoxCep.Enabled = false;
            textBoxRua.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            maskedTextBoxCep.Text = "";
            maskedTextBoxCep.Mask = "";
        }

        private void ConfirmarCompra(object sender, EventArgs e)
        {
            if (radioButtonCartaoDeCredito.Checked == false && radioButtonCartaoDeDebito.Checked == false && radioButtonPix.Checked == false && radioButtonSim.Checked == false && radioButtonNao.Checked == false)
            {
                MessageBox.Show("Escolha uma das Formas de Pagamento e se deseja Entrega Domiciliar para poder efetivar a compra");
            }
            if (radioButtonSim.Checked == false && radioButtonNao.Checked == false)
            {
                if (radioButtonCartaoDeCredito.Checked || radioButtonCartaoDeDebito.Checked || radioButtonPix.Checked)
                {
                    MessageBox.Show("Escolha se deseja Entrega Domiciliar para poder efetivar a compra");
                }
            }
            if (radioButtonCartaoDeCredito.Checked == false && radioButtonCartaoDeDebito.Checked == false && radioButtonPix.Checked == false)
            {
                if (radioButtonSim.Checked || radioButtonNao.Checked)
                {
                    MessageBox.Show("Escolha uma das Formas de Pagamento para poder efetivar a compra");
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao.Text == "" || maskedTextBoxValidade.Text == "" || maskedTextBoxCvv.Text == "" || textBoxNomeDoTitular.Text == "" || maskedTextBoxCpfOuCnpjDoTitular.Text == "")
                {
                    MessageBox.Show("Faltam Dados para Serem Preenchidos do Cartão de Crédito");
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao2.Text == "" || maskedTextBoxValidade2.Text == "" || maskedTextBoxCvv2.Text == "" || textBoxNomeDoTitular2.Text == "" || maskedTextBoxCpfOuCnpjDoTitular2.Text == "")
                {
                    MessageBox.Show("Faltam Dados para Serem Preenchidos do Cartão de Débito");
                }
            }
            if (radioButtonSim.Checked)
            {
                if (textBoxRua.Text == "" || textBoxNumero.Text == "" || textBoxBairro.Text == "" || maskedTextBoxCep.Text == "")
                {
                    MessageBox.Show("Faltam Dados para Serem Preenchidos da Entrega Domiciliar");
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if(maskedTextBoxNumeroDoCartao.Text != "")
                {
                    if (maskedTextBoxNumeroDoCartao.Text.Length == 16)
                    {
                        maskedTextBoxNumeroDoCartao.Mask = "0000 0000 0000 0000";
                    }
                    if(maskedTextBoxNumeroDoCartao.Text.Length == 19)
                    {
                        MessageBox.Show("Numero do Cartão Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("Número do Cartão Preenchido Incorretamente");
                        maskedTextBoxNumeroDoCartao.Text = "";
                        maskedTextBoxNumeroDoCartao.Mask = "";
                    }
                }
                if (maskedTextBoxValidade.Text != "")
                {
                    if (maskedTextBoxValidade.Text.Length == 4)
                    {
                        maskedTextBoxValidade.Mask = "00/00";
                    }
                    if(maskedTextBoxValidade.Text.Length == 5)
                    {
                        MessageBox.Show("Validade Preenchida Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("Validade Preenchida Incorretamente");
                        maskedTextBoxValidade.Text = "";
                        maskedTextBoxValidade.Mask = "";
                    }
                }
                if (maskedTextBoxCvv.Text != "")
                {
                    if (maskedTextBoxCvv.Text.Length == 4)
                    {
                        maskedTextBoxCvv.Mask = "0000";
                        MessageBox.Show("CVV Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("CVV Preenchido Incorretamente");
                        maskedTextBoxCvv.Text = "";
                        maskedTextBoxCvv.Mask = "";
                    }
                }
                if (maskedTextBoxCpfOuCnpjDoTitular.Text != "")
                {
                    if (maskedTextBoxCpfOuCnpjDoTitular.Text.Length == 11)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "000,000,000-00";
                        MessageBox.Show("CPF/CNPJ Preenchido Corretamente");
                    }
                    else if (maskedTextBoxCpfOuCnpjDoTitular.Text.Length == 14)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "00,000,000/0000-00";
                        MessageBox.Show("CPF/CNPJ Preenchido Corretamente");
                    }
                    else if (maskedTextBoxCpfOuCnpjDoTitular.Text.Length == 18)
                    {
                        MessageBox.Show("CPF/CNPJ Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("CPF/CNPJ Preenchido Incorretamente");
                        maskedTextBoxCpfOuCnpjDoTitular.Text = "";
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao2.Text != "")
                {
                    if (maskedTextBoxNumeroDoCartao2.Text.Length == 16)
                    {
                        maskedTextBoxNumeroDoCartao2.Mask = "0000,0000,0000,0000";
                    }
                    if (maskedTextBoxNumeroDoCartao2.Text.Length == 19)
                    {
                        MessageBox.Show("Numero do Cartão Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("Número do Cartão Preenchido Incorretamente");
                        maskedTextBoxNumeroDoCartao2.Text = "";
                        maskedTextBoxNumeroDoCartao2.Mask = "";
                    }
                }
                if (maskedTextBoxValidade2.Text != "")
                {
                    if (maskedTextBoxValidade2.Text.Length == 4)
                    {
                        maskedTextBoxValidade2.Mask = "00/00";
                    }
                    if (maskedTextBoxValidade2.Text.Length == 5)
                    {
                        MessageBox.Show("Validade Preenchida Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("Validade Preenchida Incorretamente");
                        maskedTextBoxValidade2.Text = "";
                        maskedTextBoxValidade2.Mask = "";
                    }
                }
                if (maskedTextBoxCvv2.Text != "")
                {
                    if (maskedTextBoxCvv2.Text.Length == 4)
                    {
                        maskedTextBoxCvv2.Mask = "0000";
                        MessageBox.Show("CVV Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("CVV Preenchido Incorretamente");
                        maskedTextBoxCvv2.Text = "";
                        maskedTextBoxCvv2.Mask = "";
                    }
                }
                if (maskedTextBoxCpfOuCnpjDoTitular2.Text != "")
                {
                    if (maskedTextBoxCpfOuCnpjDoTitular2.Text.Length == 11)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular2.Mask = "000,000,000-00";
                        MessageBox.Show("CPF/CNPJ Preenchido Corretamente");
                    }
                    else if (maskedTextBoxCpfOuCnpjDoTitular2.Text.Length == 14)
                    {
                        maskedTextBoxCpfOuCnpjDoTitular2.Mask = "00,000,000/0000-00";
                        MessageBox.Show("CPF/CNPJ Preenchido Corretamente");
                    }
                    else if (maskedTextBoxCpfOuCnpjDoTitular2.Text.Length == 18)
                    {
                        MessageBox.Show("CPF/CNPJ Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("CPF/CNPJ Preenchido Incorretamente");
                        maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
                        maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
                    }
                }
            }
            if (radioButtonSim.Checked)
            {
                if (maskedTextBoxCep.Text != "")
                {
                    if (maskedTextBoxCep.Text.Length == 8)
                    {
                        maskedTextBoxCep.Mask = "00000-000";
                    }
                    if (maskedTextBoxCep.Text.Length == 9)
                    {
                        MessageBox.Show("CEP Preenchido Corretamente");
                    }
                    else
                    {
                        MessageBox.Show("CEP Preenchido Incorretamente");
                        maskedTextBoxCep.Text = "";
                        maskedTextBoxCep.Mask = "";
                    }
                }
            }
            if (radioButtonCartaoDeCredito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao.Text != "" && maskedTextBoxValidade.Text != "" && maskedTextBoxCvv.Text != "" && textBoxNomeDoTitular.Text != "" && maskedTextBoxCpfOuCnpjDoTitular.Text != "")
                {
                    if (radioButtonSim.Checked)
                    {
                        if (textBoxRua.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && maskedTextBoxCep.Text != "")
                        {
                            MessageBox.Show("Compra efetivada com Sucesso");
                            if (Mercado == null)
                            {
                                Mercado = new FormMercado();
                            }
                            Mercado.Show();
                            Mercado.setCompra(this);
                            this.Hide();
                            pictureBoxProduto.Image = null;
                            labelProduto.Text = "-";
                            labelValor.Text = "-";
                            labelNovoValor.Text = "-";
                            textBoxQtdCompra.Text = "1";
                            maskedTextBoxNumeroDoCartao.Text = "";
                            maskedTextBoxValidade.Text = "";
                            maskedTextBoxCvv.Text = "";
                            textBoxNomeDoTitular.Text = "";
                            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
                            maskedTextBoxNumeroDoCartao.Mask = "";
                            maskedTextBoxValidade.Mask = "";
                            maskedTextBoxCvv.Mask = "";
                            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
                            textBoxRua.Text = "";
                            textBoxNumero.Text = "";
                            textBoxBairro.Text = "";
                            maskedTextBoxCep.Text = "";
                            maskedTextBoxCep.Mask = "";
                            radioButtonCartaoDeCredito.Checked = false;
                            radioButtonSim.Checked = false;
                            maskedTextBoxNumeroDoCartao.Enabled = false;
                            maskedTextBoxValidade.Enabled = false;
                            maskedTextBoxCvv.Enabled = false;
                            textBoxNomeDoTitular.Enabled = false;
                            maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
                            textBoxRua.Enabled = false;
                            textBoxNumero.Enabled = false;
                            textBoxBairro.Enabled = false;
                            maskedTextBoxCep.Enabled = false;
                        }
                    }
                    if (radioButtonNao.Checked)
                    {
                        MessageBox.Show("Compra efetivada com Sucesso");
                        if (Mercado == null)
                        {
                            Mercado = new FormMercado();
                        }
                        Mercado.Show();
                        Mercado.setCompra(this);
                        this.Hide();
                        pictureBoxProduto.Image = null;
                        labelProduto.Text = "-";
                        labelValor.Text = "-";
                        labelNovoValor.Text = "-";
                        textBoxQtdCompra.Text = "1";
                        maskedTextBoxNumeroDoCartao.Text = "";
                        maskedTextBoxValidade.Text = "";
                        maskedTextBoxCvv.Text = "";
                        textBoxNomeDoTitular.Text = "";
                        maskedTextBoxCpfOuCnpjDoTitular.Text = "";
                        maskedTextBoxNumeroDoCartao.Mask = "";
                        maskedTextBoxValidade.Mask = "";
                        maskedTextBoxCvv.Mask = "";
                        maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
                        radioButtonCartaoDeCredito.Checked = false;
                        radioButtonNao.Checked = false;
                        maskedTextBoxNumeroDoCartao.Enabled = false;
                        maskedTextBoxValidade.Enabled = false;
                        maskedTextBoxCvv.Enabled = false;
                        textBoxNomeDoTitular.Enabled = false;
                        maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
                    }
                }
            }
            if (radioButtonCartaoDeDebito.Checked)
            {
                if (maskedTextBoxNumeroDoCartao2.Text != "" && maskedTextBoxValidade2.Text != "" && maskedTextBoxCvv2.Text != "" && textBoxNomeDoTitular2.Text != "" && maskedTextBoxCpfOuCnpjDoTitular2.Text != "")
                {
                    if (radioButtonSim.Checked)
                    {
                        if (textBoxRua.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && maskedTextBoxCep.Text != "")
                        {
                            MessageBox.Show("Compra efetivada com Sucesso");
                            if (Mercado == null)
                            {
                                Mercado = new FormMercado();
                            }
                            Mercado.Show();
                            Mercado.setCompra(this);
                            this.Hide();
                            pictureBoxProduto.Image = null;
                            labelProduto.Text = "-";
                            labelValor.Text = "-";
                            labelNovoValor.Text = "-";
                            textBoxQtdCompra.Text = "1";
                            maskedTextBoxNumeroDoCartao2.Text = "";
                            maskedTextBoxValidade2.Text = "";
                            maskedTextBoxCvv2.Text = "";
                            textBoxNomeDoTitular2.Text = "";
                            maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
                            maskedTextBoxNumeroDoCartao2.Mask = "";
                            maskedTextBoxValidade2.Mask = "";
                            maskedTextBoxCvv2.Mask = "";
                            maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
                            textBoxRua.Text = "";
                            textBoxNumero.Text = "";
                            textBoxBairro.Text = "";
                            maskedTextBoxCep.Text = "";
                            maskedTextBoxCep.Mask = "";
                            radioButtonCartaoDeDebito.Checked = false;
                            radioButtonSim.Checked = false;
                            maskedTextBoxNumeroDoCartao2.Enabled = false;
                            maskedTextBoxValidade2.Enabled = false;
                            maskedTextBoxCvv2.Enabled = false;
                            textBoxNomeDoTitular2.Enabled = false;
                            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
                            textBoxRua.Enabled = false;
                            textBoxNumero.Enabled = false;
                            textBoxBairro.Enabled = false;
                            maskedTextBoxCep.Enabled = false;
                        }
                    }
                    if (radioButtonNao.Checked)
                    {
                        MessageBox.Show("Compra efetivada com Sucesso");
                        if (Mercado == null)
                        {
                            Mercado = new FormMercado();
                        }
                        Mercado.Show();
                        Mercado.setCompra(this);
                        this.Hide();
                        pictureBoxProduto.Image = null;
                        labelProduto.Text = "-";
                        labelValor.Text = "-";
                        labelNovoValor.Text = "-";
                        textBoxQtdCompra.Text = "1";
                        maskedTextBoxNumeroDoCartao2.Text = "";
                        maskedTextBoxValidade2.Text = "";
                        maskedTextBoxCvv2.Text = "";
                        textBoxNomeDoTitular2.Text = "";
                        maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
                        maskedTextBoxNumeroDoCartao2.Mask = "";
                        maskedTextBoxValidade2.Mask = "";
                        maskedTextBoxCvv2.Mask = "";
                        maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
                        radioButtonCartaoDeDebito.Checked = false;
                        radioButtonNao.Checked = false;
                        maskedTextBoxNumeroDoCartao2.Enabled = false;
                        maskedTextBoxValidade2.Enabled = false;
                        maskedTextBoxCvv2.Enabled = false;
                        textBoxNomeDoTitular2.Enabled = false;
                        maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
                    }
                }
            }
            if (radioButtonPix.Checked)
            {
                    if (radioButtonSim.Checked)
                    {
                        if (textBoxRua.Text != "" && textBoxNumero.Text != "" && textBoxBairro.Text != "" && maskedTextBoxCep.Text != "")
                        {
                            MessageBox.Show("Compra efetivada com Sucesso");
                        if (Mercado == null)
                        {
                            Mercado = new FormMercado();
                        }
                        Mercado.Show();
                        Mercado.setCompra(this);
                        this.Hide();
                        pictureBoxProduto.Image = null;
                        labelProduto.Text = "-";
                        labelValor.Text = "-";
                        labelNovoValor.Text = "-";
                        textBoxQtdCompra.Text = "1";
                        radioButtonPix.Checked = false;
                        radioButtonSim.Checked = false;
                        labelCodigoDoPix.Visible = false;
                        textBoxRua.Enabled = false;
                        textBoxNumero.Enabled = false;
                        textBoxBairro.Enabled = false;
                        maskedTextBoxCep.Enabled = false;
                    }
                    }
                    if (radioButtonNao.Checked)
                    {
                        MessageBox.Show("Compra efetivada com Sucesso");
                    if (Mercado == null)
                    {
                        Mercado = new FormMercado();
                    }
                    Mercado.Show();
                    Mercado.setCompra(this);
                    this.Hide();
                    pictureBoxProduto.Image = null;
                    labelProduto.Text = "-";
                    labelValor.Text = "-";
                    labelNovoValor.Text = "-";
                    textBoxQtdCompra.Text = "1";
                    radioButtonPix.Checked = false;
                    radioButtonNao.Checked = false;
                    labelCodigoDoPix.Visible = false;
                }     
            }
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_MaskChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBoxNumeroDoCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxNomeDoTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxNumeroDoCartao2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxValidade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxCvv2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxNomeDoTitular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void maskedTextBoxCpfOuCnpjDoTitular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void textBoxBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CharWord(e);
        }

        private void maskedTextBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBoxQtdCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void maskedTextBoxNumeroDoCartao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxNumeroDoCartao.Mask = "";
            }
        }

        private void maskedTextBoxNumeroDoCartao_Click(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBoxValidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxValidade.Mask = "";
            }
        }

        private void maskedTextBoxCvv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCvv.Mask = "";
            }
        }

        private void maskedTextBoxCpfOuCnpjDoTitular_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setCompra(this);
            this.Hide();
            pictureBoxProduto.Image = null;
            labelProduto.Text = "-";
            labelValor.Text = "-";
            labelNovoValor.Text = "-";
            textBoxQtdCompra.Text = "1";
            maskedTextBoxNumeroDoCartao.Text = "";
            maskedTextBoxValidade.Text = "";
            maskedTextBoxCvv.Text = "";
            textBoxNomeDoTitular.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular.Text = "";
            maskedTextBoxNumeroDoCartao.Mask = "";
            maskedTextBoxValidade.Mask = "";
            maskedTextBoxCvv.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular.Mask = "";
            maskedTextBoxNumeroDoCartao2.Text = "";
            maskedTextBoxValidade2.Text = "";
            maskedTextBoxCvv2.Text = "";
            textBoxNomeDoTitular2.Text = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Text = "";
            maskedTextBoxNumeroDoCartao2.Mask = "";
            maskedTextBoxValidade2.Mask = "";
            maskedTextBoxCvv2.Mask = "";
            maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
            textBoxRua.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            maskedTextBoxCep.Text = "";
            maskedTextBoxCep.Mask = "";
            radioButtonCartaoDeCredito.Checked = false;
            radioButtonCartaoDeDebito.Checked = false;
            radioButtonPix.Checked = false;
            radioButtonSim.Checked = false;
            radioButtonNao.Checked = false;
            maskedTextBoxNumeroDoCartao.Enabled = false;
            maskedTextBoxValidade.Enabled = false;
            maskedTextBoxCvv.Enabled = false;
            textBoxNomeDoTitular.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular.Enabled = false;
            maskedTextBoxNumeroDoCartao2.Enabled = false;
            maskedTextBoxValidade2.Enabled = false;
            maskedTextBoxCvv2.Enabled = false;
            textBoxNomeDoTitular2.Enabled = false;
            maskedTextBoxCpfOuCnpjDoTitular2.Enabled = false;
            textBoxRua.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            maskedTextBoxCep.Enabled = false;
            labelCodigoDoPix.Visible = false;
        }

        private void QtdCompra(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxNumeroDoCartao2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxNumeroDoCartao2.Mask = "";
            }
        }

        private void maskedTextBoxValidade2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxValidade2.Mask = "";
            }
        }

        private void maskedTextBoxCvv2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCvv2.Mask = "";
            }
        }

        private void maskedTextBoxCpfOuCnpjDoTitular2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCpfOuCnpjDoTitular2.Mask = "";
            }
        }

        private void maskedTextBoxCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                maskedTextBoxCep.Mask = "";
            }
        }

        private void QtdProdutoCompra(object sender, EventArgs e)
        {
            if (textBoxQtdCompra.Text == "0")
            {
                textBoxQtdCompra.Text = "1";
                double valorAtual = Convert.ToDouble(labelValor.Text);
                int qtdNova = int.Parse(textBoxQtdCompra.Text);
                double novoValor = (valorAtual * qtdNova);
                labelNovoValor.Text = Convert.ToString(novoValor);
            }
            else
            {
                double valorAtual = Convert.ToDouble(labelValor.Text);
                int qtdNova = int.Parse(textBoxQtdCompra.Text);
                double novoValor = (valorAtual * qtdNova);
                labelNovoValor.Text = Convert.ToString(novoValor);
            }
        }

        private void textBoxQtdCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                labelNovoValor.Text = "";
            }
        }

        private void labelNovoValor_Click(object sender, EventArgs e)
        {
            labelNovoValor.Text = labelValor.Text;
        }
    }
}
