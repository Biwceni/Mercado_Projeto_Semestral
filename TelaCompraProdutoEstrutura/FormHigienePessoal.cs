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
    public partial class FormHigienePessoal : Form
    {
        private FormMercado Mercado = null;
        private FormTelaCompra CompraProduto = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        public FormHigienePessoal()
        {
            InitializeComponent();
        }

        private void ComprarAlmaDeFlores(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabonene kit alma de flores.jpg";
            CompraProduto.labelProduto.Text = labelAlmaDeFlores.Text;
            CompraProduto.labelValor.Text = labelValor3190.Text;
        }

        private void ComprarSaboneteLiquidoPhebo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabonete liquido phebo.jpg";
            CompraProduto.labelProduto.Text = labelSaboneteLiquidoPhebo.Text;
            CompraProduto.labelValor.Text = labelValor2190.Text;
        }

        private void ComprarKitPanteneShampoo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/kit shampoo e condicionador pantene 400ml e 200ml.png";
            CompraProduto.labelProduto.Text = labelKitPanteneShampoo.Text;
            CompraProduto.labelValor.Text = labelValor21900.Text;
        }

        private void ComprarShampooECondicionador(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/kit shampoo e condicionador elseve reparação profunda 200ml.jpg";
            CompraProduto.labelProduto.Text = labelShampooECondicionador.Text;
            CompraProduto.labelValor.Text = labelValor2839.Text;
        }

        private void ComprarCremeDePentear(object sender, EventArgs e)
        {

        }

        private void ComprarCremeDePentearPantene(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/creme de pentear pantebe hidro-cauterização 240g.jpg";
            CompraProduto.labelProduto.Text = labelCremeDePentearPantene.Text;
            CompraProduto.labelValor.Text = labelValor990.Text;
        }

        private void ComprarSaboneteLux(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabonetes lux 85 gramas diversas fragancias.jpg";
            CompraProduto.labelProduto.Text = labelSaboneteLux.Text;
            CompraProduto.labelValor.Text = labelValor199.Text;
        }

        private void ComprarSaboneteLiquidoDove(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabonete liquido dove.jpg";
            CompraProduto.labelProduto.Text = labelSaboneteLiquidoDove.Text;
            CompraProduto.labelValor.Text = labelValor999.Text;
        }

        private void ComprarCremeDeTratamentoElseve(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/Creme de Tratamento Elseve Reparação Total 5 300g.jpg";
            CompraProduto.labelProduto.Text = labelCremeDeTratamentoElseve.Text;
            CompraProduto.labelValor.Text = labelValor1485.Text;
        }

        private void ComprarMascaraDeTratamento(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/creme pantene hidro cauterização 300ml.jpg";
            CompraProduto.labelProduto.Text = labelMascaraDeTratamento.Text;
            CompraProduto.labelValor.Text = labelValor2399.Text;
        }

        private void ComprarCremeDePentearElseve(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/elseve-reparacao-total-5-l-oreal-paris-creme-de-pentear-250ml.jpg";
            CompraProduto.labelProduto.Text = labelCremeDePentearElseve.Text;
            CompraProduto.labelValor.Text = labelValor9990.Text;
        }

        private void ComprarSaboneteLiquidoIntimo(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabonete intimo bella mulher 200ml.jpg";
            CompraProduto.labelProduto.Text = labelSaboneteLiquidoIntimo.Text;
            CompraProduto.labelValor.Text = labelValor473.Text;
        }

        private void ComprarSaboneteDermacydFeminina(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/sabonete íntimo dermacyd femina 24h 200ml.jpg";
            CompraProduto.labelProduto.Text = labelSaboneteDermacyd.Text;
            CompraProduto.labelValor.Text = labelValor1174.Text;
        }

        private void ComprarOleoCorporal(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/oleo corporal francis 170ml.jpeg";
            CompraProduto.labelProduto.Text = labelOleoCorporal.Text;
            CompraProduto.labelValor.Text = labelValor1990.Text;
        }

        private void ComprarCremeJohnson(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/creme johnsons lavanda e camomila 200ml.jpg";
            CompraProduto.labelProduto.Text = labelCremeJohnson.Text;
            CompraProduto.labelValor.Text = labelValor1059.Text;
        }

        private void ComprarDesodoranteRoolOn(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/desodorante roll-on nivea 50ml.jpg";
            CompraProduto.labelProduto.Text = labelDesodoranteRoolOn.Text;
            CompraProduto.labelValor.Text = labelValor10590.Text;
        }

        private void ComprarAerosol(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/desodorante above aerosol 150ml.jpg";
            CompraProduto.labelProduto.Text = labelAerosol.Text;
            CompraProduto.labelValor.Text = labelValor475.Text;
        }

        private void ComprarAbsorventeIntimusNoturno(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/absorvente intimus noturno com abas leve 36 pague 30.jpg";
            CompraProduto.labelProduto.Text = labelAbsorventeIntimusNoturno.Text;
            CompraProduto.labelValor.Text = labelValor1950.Text;
        }

        private void ComprarAbsorventeInternoIntimusMini(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/absorvente interno intimus mini,medio,super com 16 unidades.jpg";
            CompraProduto.labelProduto.Text = labelAbsorventeInternoIntimusMini.Text;
            CompraProduto.labelValor.Text = labelValor644.Text;
        }

        private void ComprarAbsorventeIntimusComAbas(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/asorvente intimus leve 32 tripla proteçao com abas.jpg";
            CompraProduto.labelProduto.Text = labelAbsorventeIntimusComAbas.Text;
            CompraProduto.labelValor.Text = labelValor1090.Text;
        }

        private void ComprarAbsorventeIntimusSemAbas(object sender, EventArgs e)
        {
            if (CompraProduto == null)
            {
                CompraProduto = new FormTelaCompra();
            }
            CompraProduto.Show();
            CompraProduto.setHigiene(this);
            this.Hide();
            CompraProduto.pictureBoxProduto.ImageLocation = "img/asorvente intimus leve 9 tripla proteçao sem abas.jpg";
            CompraProduto.labelProduto.Text = labelAbsorventeIntimusSemAbas.Text;
            CompraProduto.labelValor.Text = labelValor950.Text;
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Mercado == null)
            {
                Mercado = new FormMercado();
            }
            Mercado.Show();
            Mercado.setHigiene(this);
            this.Hide();
        }
    }
}
