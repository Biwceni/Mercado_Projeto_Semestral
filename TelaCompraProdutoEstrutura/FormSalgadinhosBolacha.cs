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
    public partial class FormSalgadinhosBolacha : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormSalgadinhosBolacha()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ComprarSalgadinhoDoritos(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/doritos 140g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoDoritos.Text;
            CompraProduto.labelValor.Text = labelValor789.Text;
        }

        private void ComprarSalgadinhoFofura(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/salgadinho fofura variedades.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoFofura.Text;
            CompraProduto.labelValor.Text = labelValor371.Text;
        }

        private void ComprarSalgadinhoCheetosParmesao(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cheetos parmesão 140g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoCheetosParmesao.Text;
            CompraProduto.labelValor.Text = labelValor1091.Text;
        }

        private void ComprarSalgadinhoCheetosRequeijao(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cheetos requeijão 140g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoCheetosRequeijao.Text;
            CompraProduto.labelValor.Text = labelValor1164.Text;
        }

        private void ComprarSalgadinhoBaconzitos(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/baconzitos 103 g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoBaconzitos.Text;
            CompraProduto.labelValor.Text = labelValor1532.Text;
        }

        private void ComprarSalgadinhoFandangosMilho(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fandangos de milho 140g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoFandangosMilho.Text;
            CompraProduto.labelValor.Text = labelValor1050.Text;
        }

        private void ComprarSalgadinhoFandangosPresunto(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fandangos de presunto 140g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoFandangosPresunto.Text;
            CompraProduto.labelValor.Text = labelValor1056.Text;
        }

        private void ComprarBatataRuffles(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/ruffles 140g.jpg";
            CompraProduto.labelProduto.Text = labelBatataRufflesOriginal.Text;
            CompraProduto.labelValor.Text = labelValor1574.Text;
        }

        private void ComprarBatataPringles(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/batata pingles diversos sabores 120g.jpg";
            CompraProduto.labelProduto.Text = labelBatataPringles.Text;
            CompraProduto.labelValor.Text = labelValor1540.Text;
        }

        private void ComprarSalgadinhoCebolitos(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cebolitos 190g.jpg";
            CompraProduto.labelProduto.Text = labelSalgadinhoCebolitos.Text;
            CompraProduto.labelValor.Text = labelValor1250.Text;
        }

        private void ComprarBolachaRecheadaPlugados(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/img-home-biscoitos-plugados-novo140g.png";
            CompraProduto.labelProduto.Text = labelBolachaRecheadaPlugados.Text;
            CompraProduto.labelValor.Text = labelValor249.Text;
        }

        private void ComprarBiscoitoAguaESal(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/biscoito de agua e sal marilian.jpg";
            CompraProduto.labelProduto.Text = labelBiscoitoAguaESal.Text;
            CompraProduto.labelValor.Text = labelValor310.Text;
        }

        private void ComprarBolachaRecheadaPassatempo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/passatempo recheada.jpg";
            CompraProduto.labelProduto.Text = labelBolachaRecheadaPassatempo.Text;
            CompraProduto.labelValor.Text = labelValor176.Text;
        }

        private void ComprarBolachaRecheadaTrakinas(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/trakinas.jpg";
            CompraProduto.labelProduto.Text = labelBolachaRecheadaTrakinas.Text;
            CompraProduto.labelValor.Text = labelValor159.Text;
        }

        private void ComprarBolachaRecheadaNegresco(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/negresco 40g.jpg";
            CompraProduto.labelProduto.Text = labelBolachaRecheadaNegresco.Text;
            CompraProduto.labelValor.Text = labelValor279.Text;
        }

        private void ComprarBiscoitoDeMaizena(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/biscoito de maizena marilian.jpg";
            CompraProduto.labelProduto.Text = labelBiscoitoDeMaizena.Text;
            CompraProduto.labelValor.Text = labelValor360.Text;
        }

        private void ComprarWaferSensacao(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/wafer sensasção 110g.jpg";
            CompraProduto.labelProduto.Text = labelWaferSensacao.Text;
            CompraProduto.labelValor.Text = labelValor219.Text;
        }

        private void ComprarBolachaRecheadaLacta(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/bolacha recheada lacta 90g 3 sabores.jpg";
            CompraProduto.labelProduto.Text = labelBolachaRecheadaLacta.Text;
            CompraProduto.labelValor.Text = labelValor554.Text;
        }

        private void ComprarClubSocial(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/club social pacote com seis unidades 24g.jpg";
            CompraProduto.labelProduto.Text = labelClubSocial.Text;
            CompraProduto.labelValor.Text = labelValor715.Text;
        }

        private void ComprarBiscoitoRosquinhaDeCoco(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setSalgadinhoBolacha(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/rosquinha de coco 500g.png";
            CompraProduto.labelProduto.Text = labelBiscoitoRosquinhaDeCoco.Text;
            CompraProduto.labelValor.Text = labelValor515.Text;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setSalgadinhoBolacha(this);
            this.Hide();
        }
    }
}
