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
    public partial class FormLogin : Form
    {
        private FormMercado Mercado = null;
        public void setMercado(FormMercado Mercado)
        {
            this.Mercado = Mercado;
        }
        MySqlConnection Conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=mercado_cliente;SslMode=none");
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtUserName.ToString().Replace("'", "").Replace("=", "");


            string sql = $"select * from clientes_log where usuario=('{txtUserName.Text}') and senha=('{txtpassword.Text}')";

            MySqlCommand comando = new MySqlCommand(sql, Conexao);


            try
            {
                Conexao.Open();
                MySqlDataReader linhas = comando.ExecuteReader();

                if (linhas.Read())
                {
                    FormMercado FormMercado = new FormMercado();
                    FormMercado.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro " + ex);
            }
            finally
            {
                Conexao.Close();
                comando.Dispose();
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            new FormCadastro().Show();
            this.Hide();
        }

        private void VerSenha(object sender, EventArgs e)
        {
            if (checkBoxVerSenha.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
