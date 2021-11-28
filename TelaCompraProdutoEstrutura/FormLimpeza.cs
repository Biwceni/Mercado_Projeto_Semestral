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
    public partial class FormLimpeza : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormLimpeza()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ComprarDetergenteYpeVariasFragancias(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/detergente.jpg";
            CompraProduto.labelProduto.Text = labelDetergenteYpeVariasFragancias.Text;
            CompraProduto.labelValor.Text = labelValor195.Text;
        }

        private void ComprarSabaoEmPoOmo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em po omo.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPoOmo.Text;
            CompraProduto.labelValor.Text = labelValor1880.Text;
        }

        private void ComprarSabaoEmPoUrca(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em po urca.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPoUrca.Text;
            CompraProduto.labelValor.Text = labelValor18800.Text;
        }

        private void ComprarDetergenteYpeNeutro(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/detergente 5L.jpg";
            CompraProduto.labelProduto.Text = labelDetergenteYpeNeutro.Text;
            CompraProduto.labelValor.Text = labelValor1865.Text;
        }

        private void ComprarDetergenteLimpol(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Detergente Limpol 500ml.jpg";
            CompraProduto.labelProduto.Text = labelDetergenteLimpol.Text;
            CompraProduto.labelValor.Text = labelValor195.Text;
        }

        private void ComprarSabaoEmPedraMinuano(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em barra minuano.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPedraMinuano.Text;
            CompraProduto.labelValor.Text = labelValor999.Text;
        }

        private void ComprarSabaoEmPedraYpe(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em barra.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPedraYpe.Text;
            CompraProduto.labelValor.Text = labelValor1099.Text;
        }

        private void ComprarSabaoEmPoBrilhante(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em po brilhante 1,6kg.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPoBrilhante.Text;
            CompraProduto.labelValor.Text = labelValor1699.Text;
        }

        private void ComprarSabaoEmPoTixan(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao em po tixan 1kg.jpg";
            CompraProduto.labelProduto.Text = labelSabaoEmPoTixan.Text;
            CompraProduto.labelValor.Text = labelValor899.Text;
        }

        private void ComprarSabaoLiquido(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabao ariel liquido 2L.jpg";
            CompraProduto.labelProduto.Text = labelSabaoLiquido.Text;
            CompraProduto.labelValor.Text = labelValor2290.Text;
        }

        private void ComprarAmacianteConcentradoConfort(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/amaciante Confort concentrado 1L.jpg";
            CompraProduto.labelProduto.Text = labelAmacianteConcentradoConfort.Text;
            CompraProduto.labelValor.Text = labelValor1590.Text;
        }

        private void ComprarAmacianteConcentradoDowny(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/amaciante downy Concentrado 1,5L.jpg";
            CompraProduto.labelProduto.Text = labelAmacianteConcentradoDowny.Text;
            CompraProduto.labelValor.Text = labelValor2249.Text;
        }

        private void ComprarAmacianteConcentradoFofo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/amaciante fofo concentrado 500ml.jpg";
            CompraProduto.labelProduto.Text = labelAmacianteConcentradoFofo.Text;
            CompraProduto.labelValor.Text = labelValor788.Text;
        }

        private void ComprarAmacianteYpe(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Amaciante ype 2L.png";
            CompraProduto.labelProduto.Text = labelAmacianteYpe.Text;
            CompraProduto.labelValor.Text = labelValor9990.Text;
        }

        private void ComprarAmacianteBabySoft(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/amaciantes baby soft 2L.jpg";
            CompraProduto.labelProduto.Text = labelAmacianteBabySoft.Text;
            CompraProduto.labelValor.Text = labelValor679.Text;
        }

        private void ComprarDesinfetanteBufalo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/desinfetante bufalo 2L.jpg";
            CompraProduto.labelProduto.Text = labelDesinfetanteBufalo.Text;
            CompraProduto.labelValor.Text = labelValor560.Text;
        }

        private void ComprarDesinfetanteCasaEPerfume(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Desinfetante casa e pergume 500Ml.jpg";
            CompraProduto.labelProduto.Text = labelDesinfetanteCasaEPerfume.Text;
            CompraProduto.labelValor.Text = labelValor599.Text;
        }

        private void ComprarDesinfetantePinhoSol(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/pinho-sol desinfetante 500ml.jpg";
            CompraProduto.labelProduto.Text = labelDesinfetantePinhoSol.Text;
            CompraProduto.labelValor.Text = labelValor862.Text;
        }

        private void ComprarKitTiraManchasVanish(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/kit tira manchas vanish Multiuso+Branqueador 450g.jpg";
            CompraProduto.labelProduto.Text = labelKitTiraManchas.Text;
            CompraProduto.labelValor.Text = labelValor4583.Text;
        }

        private void ComprarDoisFardosBombril(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setLimpeza(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/2 fardo de bombril com 14 uni.jpg";
            CompraProduto.labelProduto.Text = labelDoisFardosBombril.Text;
            CompraProduto.labelValor.Text = labelValor4710.Text;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setLimpeza(this);
            this.Hide();
        }
    }
}
