using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBloodye.cbd
{
    public class Comandos
    {
        public bool conectado;
        public bool logado = false;
        public void Logar(string TLogin,string TSenha, OleDbConnection conexao)
        {
            if (conectado==true) {
                string Query = "SELECT * FROM Adms WHERE Login='" + TLogin + "' AND Senha='" + TSenha + "';";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                var result = cm.ExecuteScalar();
                if (result!= null)
                {
                    MessageBox.Show("Logado com sucesso!","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    logado = true;
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Procurar(string TProcura,string index, OleDbConnection conexao)
        {
            if (conectado == true)
            {
                string Query = "SELECT * FROM Doadores WHERE "+index+"='" + TProcura + "';";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                var result = cm.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Encontrou", "Teste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não encontrou", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Validar(string idlnSelecionada, OleDbConnection conexao)
        {
            // string querycampos = @"SELECT * FROM Doadores WHERE Codigo=" + idselecionado + ";";
            if (conectado == true)
            {
                string Query = "UPDATE Doadores SET Validado=@value WHERE Codigo=" + idlnSelecionada + ";";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                cm.Parameters.AddWithValue("@value", true);
                var result=cm.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Doador validado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Erro na validação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Adicionar(OleDbConnection conexao)
        {
            // string querycampos = @"SELECT * FROM Doadores WHERE Codigo=" + idselecionado + ";";
            if (conectado == true)
            {
                string Query = "INSERT INTO Doadores VALUES(Nome=@name,RG=@rg,CPF=@cpf,TipoSangue=@tiposangue,Endereco=@endereco,Telefone=@telefone,Celular=@celular) ";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                cm.Parameters.AddWithValue("@name", true);
                cm.Parameters.AddWithValue("@rg", true);
                cm.Parameters.AddWithValue("@cpf", true);
                cm.Parameters.AddWithValue("@tiposangue", true);
                cm.Parameters.AddWithValue("@endereco", true);
                cm.Parameters.AddWithValue("@telefone", true);
                cm.Parameters.AddWithValue("@celular", true);

                var result = cm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
