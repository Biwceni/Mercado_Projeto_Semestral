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
    public partial class FormCongeladosResfriados : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormCongeladosResfriados()
        {
            InitializeComponent();
        }

        private void FormCongeladosResfriados_Load(object sender, EventArgs e)
        {

        }

        private void ComprarFileMignon(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/File Mignon.jpg";
            CompraProduto.labelProduto.Text = labelFileMignon.Text;
            CompraProduto.labelValor.Text = labelValor3295.Text;
        }

        private void ComprarContraFile(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Contra Filé.jpg";
            CompraProduto.labelProduto.Text = labelContraFile.Text;
            CompraProduto.labelValor.Text = labelValor3216.Text;
        }

        private void ComprarAlcatra(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Alcatra.jpg";
            CompraProduto.labelProduto.Text = labelAlcatra.Text;
            CompraProduto.labelValor.Text = labelValor3995.Text;
        }

        private void ComprarPicanha(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Picanha.jpg";
            CompraProduto.labelProduto.Text = labelPicanha.Text;
            CompraProduto.labelValor.Text = labelValor5990.Text;
        }

        private void ComprarPatinho(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/patinho.jpg";
            CompraProduto.labelProduto.Text = labelPatinho.Text;
            CompraProduto.labelValor.Text = labelValor3790.Text;
        }

        private void ComprarFraldinha(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fraldinha.jpg";
            CompraProduto.labelProduto.Text = labelFraldinha.Text;
            CompraProduto.labelValor.Text = labelValor5491.Text;
        }

        private void ComprarFrangoPassarinho(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/frango passarinho.jpg";
            CompraProduto.labelProduto.Text = labelFrangoPassarinho.Text;
            CompraProduto.labelValor.Text = labelValor1539.Text;
        }

        private void ComprarAsaDeFrango(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/asa de frango.jpg";
            CompraProduto.labelProduto.Text = labelAsaDeFrango.Text;
            CompraProduto.labelValor.Text = labelValor1895.Text;
        }

        private void ComprarFrangoInteiroSeara(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/frango inteiro seara.jpg";
            CompraProduto.labelProduto.Text = labelFrangoInteiroSeara.Text;
            CompraProduto.labelValor.Text = labelValor3941.Text;
        }

        private void ComprarPacoteBatata(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Pacote batata palito Pre-Frita 2kg.jpg";
            CompraProduto.labelProduto.Text = labelPacoteBatata.Text;
            CompraProduto.labelValor.Text = labelValor1612.Text;
        }

        private void ComprarCaixaDeHamburguer(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/hamburguer texas congelado 672g.jpg";
            CompraProduto.labelProduto.Text = labelCaixaDeHamburger.Text;
            CompraProduto.labelValor.Text = labelValor1699.Text;
        }

        private void ComprarNuggetsSadia(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/nuggets sadia frango 300g.jpg";
            CompraProduto.labelProduto.Text = labelNuggetsSadia.Text;
            CompraProduto.labelValor.Text = labelValor1290.Text;
        }

        private void ComprarBifeARole(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/bife a role.jpg";
            CompraProduto.labelProduto.Text = labelBifeARole.Text;
            CompraProduto.labelValor.Text = labelValor3012.Text;
        }

        private void ComprarAlmondegasSadia(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sadia-almondega_carne-500gr_0.jpg";
            CompraProduto.labelProduto.Text = labelAlmondegasSadia.Text;
            CompraProduto.labelValor.Text = labelValor1899.Text;
        }

        private void ComprarKibeSadia(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/kibe sadia.jpg";
            CompraProduto.labelProduto.Text = labelKibeSadia.Text;
            CompraProduto.labelValor.Text = labelValor2099.Text;
        }

        private void ComprarBifeDeFigado(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/bife de figado.jpg";
            CompraProduto.labelProduto.Text = labelBifeDeFigado.Text;
            CompraProduto.labelValor.Text = labelValor2409.Text;
        }

        private void ComprarCoracaoDeGalinha(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/coração de galinha.jpg";
            CompraProduto.labelProduto.Text = labelCoracaoDeGalinha.Text;
            CompraProduto.labelValor.Text = labelValor4598.Text;
        }

        private void ComprarMassaParaLasanha(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/massa para lasanha santa terezinha 1kg.jpg";
            CompraProduto.labelProduto.Text = labelMassaParaLasanha.Text;
            CompraProduto.labelValor.Text = labelValor1265.Text;
        }

        private void ComprarCarneMoidaDePrimeira(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/carne moida de primeira.jpg";
            CompraProduto.labelProduto.Text = labelCarneMoidaDePrimeira.Text;
            CompraProduto.labelValor.Text = labelValor4471.Text;
        }

        private void ComprarCarneMoidaDeSegunda(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setCongeladosResfriados(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/carne moida de segunda.jpg";
            CompraProduto.labelProduto.Text = labelCarneMoidaDeSegunda.Text;
            CompraProduto.labelValor.Text = labelValor3625.Text;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setCongeladosResfriados(this);
            this.Hide();
        }
    }
}
