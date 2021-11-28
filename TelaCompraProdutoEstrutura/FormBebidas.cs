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
    public partial class FormBebidas : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormBebidas()
        {
            InitializeComponent();
        }

        private void ComprarVodkaAbsolut(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/6141-vodka-absolut-natural-1.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAbsolut.Text;
            CompraProduto.labelValor.Text = labelValor13180.Text;
        }

        private void ComprarVodkaAskov(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/11247-vodka-askov-1-75l.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAskov.Text;
            CompraProduto.labelValor.Text = labelValor14.Text;
        }

        private void ComprarVodkaAskovMaracuja(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/vodka maracujá 900ml.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAskovMaracuja.Text;
            CompraProduto.labelValor.Text = labelValor1480.Text;
        }

        private void ComprarVodkaAskovKiwi(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/vodka Kiwi 900ml.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAskovKiwi.Text;
            CompraProduto.labelValor.Text = labelValor14800.Text;
        }

        private void ComprarAskovFrutasVermelhas(object sender, EventArgs e)
        {

        }

        private void ComprarVodkaAskovFrutasRoxas(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/vodka frutas roxas 900ml.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAskovFrutasRoxas.Text;
            CompraProduto.labelValor.Text = labelValor1480000.Text;
        }

        private void ComprarVodkaAskovFrutasVermelhas(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/vodka frutas vermelhas 900ml.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAskovFrutasVermelhas.Text;
            CompraProduto.labelValor.Text = labelValor148000.Text;
        }

        private void ComprarVodkaAskovBlueberry(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/vodka Blueberry 900 ml.jpg";
            CompraProduto.labelProduto.Text = labelVodkaAskovBlueberry.Text;
            CompraProduto.labelValor.Text = labelValor14800000.Text;
        }

        private void ComprarEnergeticoRedBull(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/energetico lata.jpg";
            CompraProduto.labelProduto.Text = labelEnergeticoRedBull.Text;
            CompraProduto.labelValor.Text = labelValor3560.Text;
        }

        private void ComprarEnergeticoVibe(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/energetico vibe 2l.png";
            CompraProduto.labelProduto.Text = labelEnergeticoVibe.Text;
            CompraProduto.labelValor.Text = labelValor1168.Text;
        }

        private void ComprarCervejaCaixa(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cerveja.jpg";
            CompraProduto.labelProduto.Text = labelCervejaCaixa.Text;
            CompraProduto.labelValor.Text = labelValor5210.Text;
        }

        private void ComprarSucoDafruta(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/1083737_suco-nectar-de-laranja-dafruta-cx-1l_m1_637521920900390117.jpg";
            CompraProduto.labelProduto.Text = labelSucoDafruta.Text;
            CompraProduto.labelValor.Text = labelValor560.Text;
        }

        private void ComprarFardoDollyLimao(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fardo dolly 2l limao.jpg";
            CompraProduto.labelProduto.Text = labelFardoDollyLimao.Text;
            CompraProduto.labelValor.Text = labelValor4450.Text;
        }

        private void ComprarFardoCocaCola(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fardo coca 2l.png";
            CompraProduto.labelProduto.Text = labelFardoCocaCola.Text;
            CompraProduto.labelValor.Text = labelValor5890.Text;
        }

        private void ComprarFardoDollyGuarana(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fardo dolly 2l.jpg";
            CompraProduto.labelProduto.Text = labelFardoDollyGuarana.Text;
            CompraProduto.labelValor.Text = labelValor44500.Text;
        }

        private void ComprarFardoGatorade(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/gatorade.jpg";
            CompraProduto.labelProduto.Text = labelFardoGatorade.Text;
            CompraProduto.labelValor.Text = labelValor2460.Text;
        }

        private void ComprarKit(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/kit-2-refrigerantes-coca-cola-2-sprite-garrafa-2l-cada-leve-mais-pague-menos_5830.jpg";
            CompraProduto.labelProduto.Text = labelKitCocaColaMaisSprite.Text;
            CompraProduto.labelValor.Text = labelValor1050.Text;
        }

        private void ComprarSucoDelValle(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/suco-dell-valle-manga-926x926.jpg";
            CompraProduto.labelProduto.Text = labelSucoDelValle.Text;
            CompraProduto.labelValor.Text = labelValor720.Text;
        }

        private void ComprarIsotonico(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/isotonico.jpeg";
            CompraProduto.labelProduto.Text = labelIsotonicoPowerade.Text;
            CompraProduto.labelValor.Text = labelValor690.Text;
        }

        private void ComprarFardoFanta(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fanta 2L.jpg";
            CompraProduto.labelProduto.Text = labelFardoFanta.Text;
            CompraProduto.labelValor.Text = labelValor3220.Text;
        }

        private void ComprarFardoGuaranaAntarctica(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setBebidas(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fardo guarana pequeno.jpg";
            CompraProduto.labelProduto.Text = labelFardoGuaranaAntartica.Text;
            CompraProduto.labelValor.Text = labelValor1975.Text;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setBebidas(this);
            this.Hide();
        }

        private void labelVodkaAskovFrutasRoxas_Click(object sender, EventArgs e)
        {

        }
    }
}
