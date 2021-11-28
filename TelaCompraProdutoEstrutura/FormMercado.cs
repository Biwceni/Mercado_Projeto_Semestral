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
    public partial class FormMercado : Form
    {
        private FormTelaCompra CompraProduto = null;
        private FormHortifruti TelaHortfruit = null;
        private FormBebidas TelaBebidas = null;
        private FormLimpeza TelaLimpeza = null;
        private FormHigienePessoal TelaHigienePessoal = null;
        private FormSalgadinhosBolacha TelaSalgadinhoBolacha = null;
        private FormCongeladosResfriados TelaCongeladosResfriados = null;
        private FormDoce TelaDoce = null;
        private FormCliente TelaCliente = null;
        private FormLogin TelaLogin = null;
        public void setCompra(FormTelaCompra CompraProduto)
        {
            this.CompraProduto = CompraProduto;
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
        public void setCliente(FormCliente TelaCliente)
        {
            this.TelaCliente = TelaCliente;
        }
        public void setLogin(FormLogin TelaLogin)
        {
            this.TelaLogin = TelaLogin;
        }
        public FormMercado()
        {
            InitializeComponent();
        }

        private void ComprarCafePilao(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cafe.png";
            CompraProduto.labelProduto.Text = labelCafePilao.Text;
            CompraProduto.labelValor.Text = labelValor770.Text;
        }

        private void ComprarLeiteIntegral(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Leite.jpg";
            CompraProduto.labelProduto.Text = labelLeiteIntegral.Text;
            CompraProduto.labelValor.Text = labelValor445.Text;
        }

        private void ComprarIorguteDanone(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/danone.jpg";
            CompraProduto.labelProduto.Text = labelIorguteDanone.Text;
            CompraProduto.labelValor.Text = labelValor514.Text;
        }

        private void ComprarLeiteCondensado(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Leite condensado.jpg";
            CompraProduto.labelProduto.Text = labelLeiteCondensado.Text;
            CompraProduto.labelValor.Text = labelValor554.Text;
        }

        private void ComprarSabaoEmPo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em po omo.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPo.Text;
            CompraProduto.labelValor.Text = labelValor1880.Text;
        }

        private void ComprarArrozTipo1(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setMercado(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/arroz-namorado-tipo-1-1kg_75400.jpg";
            CompraProduto.labelProduto.Text = labelArrozTipo1.Text;
            CompraProduto.labelValor.Text = labelValor2274.Text;
        }

        private void IrParaHortfruit(object sender, EventArgs e)
        {
            if (TelaHortfruit == null)
            {
                TelaHortfruit = new FormHortifruti();
            }
            TelaHortfruit.Show();
            TelaHortfruit.setMercado(this);
            this.Hide();
        }

        private void IrParaBebidas(object sender, EventArgs e)
        {
            if (TelaBebidas == null)
            {
                TelaBebidas = new FormBebidas();
            }
            TelaBebidas.Show();
            TelaBebidas.setMercado(this);
            this.Hide();
        }

        private void IrParaLimpeza(object sender, EventArgs e)
        {
            if (TelaLimpeza == null)
            {
                TelaLimpeza = new FormLimpeza();
            }
            TelaLimpeza.Show();
            TelaLimpeza.setMercado(this);
            this.Hide();
        }

        private void IrParaHigienePessoal(object sender, EventArgs e)
        {
            if (TelaHigienePessoal == null)
            {
                TelaHigienePessoal = new FormHigienePessoal();
            }
            TelaHigienePessoal.Show();
            TelaHigienePessoal.setMercado(this);
            this.Hide();
        }

        private void IrParaSalgadinhosBolacha(object sender, EventArgs e)
        {
            if (TelaSalgadinhoBolacha == null)
            {
                TelaSalgadinhoBolacha = new FormSalgadinhosBolacha();
            }
            TelaSalgadinhoBolacha.Show();
            TelaSalgadinhoBolacha.setMercado(this);
            this.Hide();
        }

        private void IrParaCongeladosResfriados(object sender, EventArgs e)
        {
            if (TelaCongeladosResfriados == null)
            {
                TelaCongeladosResfriados = new FormCongeladosResfriados();
            }
            TelaCongeladosResfriados.Show();
            TelaCongeladosResfriados.setMercado(this);
            this.Hide();
        }

        private void IrParaDoce(object sender, EventArgs e)
        {
            if (TelaDoce == null)
            {
                TelaDoce = new FormDoce();
            }
            TelaDoce.Show();
            TelaDoce.setMercado(this);
            this.Hide();
        }

        private void IrParaCliente(object sender, EventArgs e)
        {
            if (TelaCliente == null)
            {
                TelaCliente = new FormCliente();
            }
            TelaCliente.Show();
            TelaCliente.setMercado(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TelaLogin == null)
            {
                TelaLogin = new FormLogin();
            }
            TelaLogin.Show();
            TelaLogin.setMercado(this);
            this.Hide();
        }
    }
}
