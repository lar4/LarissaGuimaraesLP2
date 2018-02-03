using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{

    public partial class AddFuncionario : Form1
    {
        SqlConnection Conexao;

        public AddFuncionario()
        {
            InitializeComponent();

            textNome.Enabled= false;
            textTelefone.Enabled = false;
            textCPF.Enabled = false;
            textPesquisar.Enabled = false;
            textEmail.Enabled = false;

        }

        private void Conecta()
        {
            string aplicacao = Application.StartupPath; // Caminhos -> (:G), (:H), etc; retorna o caminho da pasta debug 
            string _Arquivo = aplicacao + "\\" + "dbo.Funcionario"; // nome do arquivo, duas \\ é para dizer que é uma \
            SqlConnection conexao = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False;"
            + "Initial Catalog = TesteCrud; Data Source = " + _Arquivo);
            conexao.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textNome.Enabled = true;
            textTelefone.Enabled = true;
            textCPF.Enabled = true;
            textEmail.Enabled = true;

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            Conecta();
            SqlCommand cmd = new SqlCommand();
         cmd.CommandText =@" insert into TesteCrud (Nome,Email,Telefone,CPF) Values (@Nome,@Email,@Telefone,@CPF)";


            cmd.Parameters.AddWithValue("Nome",SqlDbType.VarChar).Value= textNome.Text;
            cmd.Parameters.AddWithValue("Email",SqlDbType.VarChar).Value= textEmail.Text;
            cmd.Parameters.AddWithValue("Telefone",SqlDbType.VarChar).Value= textTelefone.Text;
            cmd.Parameters.AddWithValue("CPF",SqlDbType.VarChar).Value= textCPF.Text;

           try
            {
                Conexao.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Efetuado com Sucesso!");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Conexao.Close();
            }

            textPesquisar.Enabled = true;

            textNome.Clear();
            textEmail.Clear();
            textCPF.Clear();
            textTelefone.Clear();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            Conecta();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from TesteCrud Where Nome= @textPesquisar ";

            cmd.Parameters.AddWithValue("@TextPesquisar", SqlDbType.VarChar).Value = textPesquisar.Text;

            try
            {

                if(textPesquisar.Text== string.Empty)
                {
                    MessageBox.Show("Digite um Nome");
                }

                Conexao.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    throw new Exception("Este nome não está Cadastradado");
                }

                reader.Read();

                textNome.Text = Convert.ToString(reader["Nome"]);
                textEmail.Text = Convert.ToString(reader["Email"]);
                textTelefone.Text = Convert.ToString(reader["Telefone"]);
                textCPF.Text = Convert.ToString(reader["CPF"]);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

            textPesquisar.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            Conecta();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update TesteCrud set Nome=@Nome, Telefone@Telefone, Email@Email, CPF@CPF";

            cmd.Parameters.AddWithValue("Nome", SqlDbType.VarChar).Value = textNome.Text;
            cmd.Parameters.AddWithValue("Email", SqlDbType.VarChar).Value = textEmail.Text;
            cmd.Parameters.AddWithValue("Telefone", SqlDbType.VarChar).Value = textTelefone.Text;
            cmd.Parameters.AddWithValue("CPF", SqlDbType.VarChar).Value = textCPF.Text;

            try
            {
                Conexao.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("cADASTRO Atualizado");
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();

            }

            textNome.Clear();
            textEmail.Clear();
            textCPF.Clear();
            textTelefone.Clear();

        }

        private void btnDelet_Click(object sender, EventArgs e)
        {

            Conecta();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " delete from TesteCrud Where Nome@Nome";

            cmd.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = textNome.Text;

            try
            {
                Conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Deletado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

            textNome.Clear();
            textEmail.Clear();
            textCPF.Clear();
            textTelefone.Clear();
        }
    }
}
