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
    public partial class FormDoce : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormDoce()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void ComprarTubesMorangoAzedinho(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/tubes-morando-doce-azedinho-fini-80g.png";
            CompraProduto.labelProduto.Text = labelTubesMorangoAzedinho.Text;
            CompraProduto.labelValor.Text = labelValor836.Text;
        }

        private void ComprarTubesMorango(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/doce_fini_regaliz_tubes_morango_80g.jpg";
            CompraProduto.labelProduto.Text = labelTubesMorango.Text;
            CompraProduto.labelValor.Text = labelValor8360.Text;
        }

        private void ComprarEscovinha(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/ESCOVINHA-90G.jpg";
            CompraProduto.labelProduto.Text = labelEscovinha.Text;
            CompraProduto.labelValor.Text = labelValor1036.Text;
        }

        private void ComprarDentaduras(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Dentaduras-250g.jpg";
            CompraProduto.labelProduto.Text = labelDentaduras.Text;
            CompraProduto.labelValor.Text = labelValor1125.Text;
        }

        private void ComprarBeijoDeMorango(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Beijos-de-morango-500g.jpg";
            CompraProduto.labelProduto.Text = labelBeijoDeMorango.Text;
            CompraProduto.labelValor.Text = labelValor1545.Text;
        }

        private void ComprarFiniAlgodaoDoce(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/fini algodão doce morango 35g.jpg";
            CompraProduto.labelProduto.Text = labelFiniAlgodaoDoce.Text;
            CompraProduto.labelValor.Text = labelValor825.Text;
        }

        private void ComprarFiniTubesTwister(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/finitubestwisterdoce90gfini_195963.jpg";
            CompraProduto.labelProduto.Text = labelFiniTubesTwister.Text;
            CompraProduto.labelValor.Text = labelValor986.Text;
        }

        private void ComprarGomaMinhoca(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/goma-minhoca-brilho-fini 90g.jpg";
            CompraProduto.labelProduto.Text = labelGomaMinhoca.Text;
            CompraProduto.labelValor.Text = labelValor1036.Text;
        }

        private void ComprarMarshmallowTorcaoRosaFino(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/doces-marshmallow-torcao-fini-250g-rosa-balao-metalizado-bh.jpg";
            CompraProduto.labelProduto.Text = labelMarshmallowTorcaoRosaFino.Text;
            CompraProduto.labelValor.Text = labelValor1132.Text;
        }

        private void ComprarMarshmallowTorcaoRecheadinhoAzul(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/1000x1000_M-TORCAOAZULRECHEADINHO_250G.jpg";
            CompraProduto.labelProduto.Text = labelMarshmallowTorcaoRecheadinhoAzul.Text;
            CompraProduto.labelValor.Text = labelValor11320.Text;
        }

        private void ComprarBarraDeChocolateLacta(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/barra de chocolate Lacta 90g.jpg";
            CompraProduto.labelProduto.Text = labelBarraDeChocolateLacta.Text;
            CompraProduto.labelValor.Text = labelValor645.Text;
        }

        private void ComprarBarraDeChocolateNestle(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/barra de chocolate nestle 90g.jpg";
            CompraProduto.labelProduto.Text = labelBarraDeChocolateNestle.Text;
            CompraProduto.labelValor.Text = labelValor785.Text;
        }

        private void ComprarBarraDeChocolateGaroto(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/barra de chocolate garoto.jpg";
            CompraProduto.labelProduto.Text = labelBarraDeChocolateGaroto.Text;
            CompraProduto.labelValor.Text = labelValor895.Text;
        }

        private void ComprarPacoteDeBalaMilk(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/pacote de bala leite milk pocket 100g.jpg";
            CompraProduto.labelProduto.Text = labelPacoteDeBalaMilk.Text;
            CompraProduto.labelValor.Text = labelValor1058.Text;
        }

        private void ComprarCaixaDeChicletePoosh(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/caixa cichlete poosh 200g.jpg";
            CompraProduto.labelProduto.Text = labelCaixaDeChicletePoosh.Text;
            CompraProduto.labelValor.Text = labelValor1502.Text;
        }

        private void ComprarCaixaDeTrident(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/caixa trident 8g 21 uni.jpg";
            CompraProduto.labelProduto.Text = labelCaixaDeTrident.Text;
            CompraProduto.labelValor.Text = labelValor2005.Text;
        }

        private void ComprarPacoteDePirulitoBig(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/pirulito morango big 600g.png";
            CompraProduto.labelProduto.Text = labelPacoteDePirulitoBig.Text;
            CompraProduto.labelValor.Text = labelValor20050.Text;
        }

        private void ComprarPacoteDePirulito7belo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Pirulito7Belo600g_350x.png";
            CompraProduto.labelProduto.Text = labelPacoteDePirulito7belo.Text;
            CompraProduto.labelValor.Text = labelValor1520.Text;
        }

        private void ComprarPacoteDeBalaJuquinha(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/bala juquinha sortida 600g.jpg";
            CompraProduto.labelProduto.Text = labelPacoteDeBalaJuquinha.Text;
            CompraProduto.labelValor.Text = labelValor1024.Text;
        }

        private void ComprarDisqueteDeChocolate(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setDoce(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Mm Disquete de chocolate 500g.jpg";
            CompraProduto.labelProduto.Text = labelDisqueteDeChocolate.Text;
            CompraProduto.labelValor.Text = labelValor1620.Text;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setDoce(this);
            this.Hide();
        }
    }
}
