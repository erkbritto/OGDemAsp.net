using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CadastroComSql
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnviaButton_Click(object sender, EventArgs e)
        {
            EnviaInformacoesLogin();
        }

        protected void EnviaInformacoesLogin()
        {
            string Usuario = TextBoxNome.Text;
            string Email = TextBoxEmail.Text;
            string Senha = TextBoxSenha.Text;

            // Configurar a string de conexão
            string connectionString = "Data Source=DESKTOP-IMURCHB;Initial Catalog=CadastroComSql;Integrated Security=True";

            try
            {
                // Criar e abrir a conexão
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Exemplo: Inserir dados em uma tabela
                    string query = "INSERT INTO Cadastro (Usuario, Email, Senha) VALUES (@Usuario, @Email, @Senha)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adicionar parâmetros para evitar injeção de SQL
                        command.Parameters.AddWithValue("@Usuario", Usuario);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Senha", Senha);

                        // Executar o comando
                        command.ExecuteNonQuery();
                    }
                }

                // Exibir alerta após inserção no banco de dados
                string script = $@"<script>alert('Usuário: {Usuario}\\nSenha: {Senha}\\nDados inseridos no banco de dados.');</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "InformacoesLoginScript", script);
            }
            catch (Exception ex)
            {
                // Tratar exceções, por exemplo, exibir uma mensagem de erro
                string script = $@"<script>alert('Erro ao inserir dados no banco de dados. Detalhes: {ex.Message}');</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "InformacoesLoginScript", script);
            }
        }

        protected void CancelaButton_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            TextBoxNome.Text = "";
            TextBoxEmail.Text = "";
            TextBoxSenha.Text = "";
        }
    }
}
