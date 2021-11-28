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
    public partial class FormCadastro : Form
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=mercado_cliente;SslMode=none");
        public FormCadastro()
        {
            InitializeComponent();
        }
        private void retornar_Click(object sender, EventArgs e)
        {
            
        }

        private void Cadastrar_Click(object sender, EventArgs e)

        {


            string sql = "";
            string msg = "";
            if (txtID.Text.Equals(""))
            {
                sql = $"insert into clientes_log(usuario,senha,nome,numero,rua,cpf) values('{textBox3.Text}','{textBox4.Text}','{cadNome.Text}','{cadNumero.Text}','{cadRua.Text}','{textBox1.Text}')";
                msg = "Dados inseridos com sucesso!";
            }
            else
            {

            }
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao salvar " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
            txtID.Enabled = false;

        }

        private void retornar_Click_1(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void Cadastrar_Click_1(object sender, EventArgs e)
        {
            string sql = "";
            string msg = "";
            if (txtID.Text.Equals(""))
            {
                sql = $"insert into clientes_log(usuario,senha,nome,numero,rua,cpf) values('{textBox3.Text}','{textBox4.Text}','{cadNome.Text}','{cadNumero.Text}','{cadRua.Text}','{textBox1.Text}')";
                msg = "Dados inseridos com sucesso!";
            }
            else
            {

            }
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao salvar " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
            }
            txtID.Enabled = false;
        }
    }
}
