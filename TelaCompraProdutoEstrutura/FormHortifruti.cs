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
    public partial class FormHortifruti : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;

        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormHortifruti()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setHortfruit(this);
            this.Hide();
        }

        private void ComprarAbacate(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/abacate.jpg";
            CompraProduto.labelProduto.Text = labelAbacate.Text;
            CompraProduto.labelValor.Text = labelValor890.Text;
        }

        private void ComprarAbacaxi(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/abacaxi.jpg";
            CompraProduto.labelProduto.Text = labelAbacaxi.Text;
            CompraProduto.labelValor.Text = labelValor675.Text;
        }

        private void ComprarBanana(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/banana.jpg";
            CompraProduto.labelProduto.Text = labelBanana.Text;
            CompraProduto.labelValor.Text = labelValor490.Text;
        }

        private void ComprarLaranjaLima(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/laranja lima.jpg";
            CompraProduto.labelProduto.Text = labelLaranjaLima.Text;
            CompraProduto.labelValor.Text = labelValor549.Text;
        }

        private void ComprarLaranjaPera(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/laranja pera.jpg";
            CompraProduto.labelProduto.Text = labelLaranjaPera.Text;
            CompraProduto.labelValor.Text = labelValor410.Text;
        }

        private void ComprarMacaArgentina(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/maça argentina.jpg";
            CompraProduto.labelProduto.Text = labelMacaArgentina.Text;
            CompraProduto.labelValor.Text = labelValor1090.Text;
        }

        private void ComprarMacaDePacote(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/maça pacote.jpg";
            CompraProduto.labelProduto.Text = labelMacaDePacote.Text;
            CompraProduto.labelValor.Text = labelValor849.Text;
        }

        private void ComprarMelanciaInteira(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/melancia inteira.jpg";
            CompraProduto.labelProduto.Text = labelMelanciaInteira.Text;
            CompraProduto.labelValor.Text = labelValor1390.Text;
        }

        private void ComprarMelaoAmarelo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/melao amarelo.jpg";
            CompraProduto.labelProduto.Text = labelMelaoAmarelo.Text;
            CompraProduto.labelValor.Text = labelValor1490.Text;
        }

        private void ComprarMelaoPeleDeSapo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/melao pele de sapo.jpg";
            CompraProduto.labelProduto.Text = labelMelaoPeleDeSapo.Text;
            CompraProduto.labelValor.Text = labelValor14900.Text;
        }

        private void ComprarBatata(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/batata.jpg";
            CompraProduto.labelProduto.Text = labelBatata.Text;
            CompraProduto.labelValor.Text = labelValor430.Text;
        }

        private void ComprarCenoura(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/cenoura.jpg";
            CompraProduto.labelProduto.Text = labelCenoura.Text;
            CompraProduto.labelValor.Text = labelValor340.Text;
        }

        private void ComprarBrocolis(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/brocolis.jpg";
            CompraProduto.labelProduto.Text = labelBrocolis.Text;
            CompraProduto.labelValor.Text = labelValor749.Text;
        }

        private void ComprarBeterraba(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/beterraba.jpg";
            CompraProduto.labelProduto.Text = labelBeterraba.Text;
            CompraProduto.labelValor.Text = labelValor350.Text;
        }

        private void ComprarMandioca(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/mandioca.jpg";
            CompraProduto.labelProduto.Text = labelMandioca.Text;
            CompraProduto.labelValor.Text = labelValor838.Text;
        }

        private void ComprarAlfaceAmericana(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Alface Americana.jpg";
            CompraProduto.labelProduto.Text = labelAlfaceAmericana.Text;
            CompraProduto.labelValor.Text = labelValor399.Text;
        }

        private void ComprarAlfaceCrespa(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Alface Crespa.jpg";
            CompraProduto.labelProduto.Text = labelAlfaceCrespa.Text;
            CompraProduto.labelValor.Text = labelValor319.Text;
        }

        private void ComprarAlfaceRomana(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Alface Romana.jpg";
            CompraProduto.labelProduto.Text = labelAlfaceRomana.Text;
            CompraProduto.labelValor.Text = labelValor299.Text;
        }

        private void ComprarRepolho(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/repolho.jpg";
            CompraProduto.labelProduto.Text = labelRepolho.Text;
            CompraProduto.labelValor.Text = labelValor499.Text;
        }
        private void ComprarAcelga(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHortfruit(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/acelga.jpg";
            CompraProduto.labelProduto.Text = labelAcelga.Text;
            CompraProduto.labelValor.Text = labelValor420.Text;
        }
    }
}
