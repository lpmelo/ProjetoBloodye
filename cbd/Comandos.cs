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
        public bool cadastrorealizado = false;
        #region Logar
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
#endregion
        #region Procurar
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
        #endregion
        #region Validar
        public void Validar(string idlnSelecionada, OleDbConnection conexao)
        {
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
        #endregion Validar
        #region Adicionar
        public void Adicionar(OleDbConnection conexao, string TNome, string TRG, string TCPF, string TTS, string TEndereco, string TTelefone, string TCelular, bool TValidado)
        {
            if (conectado == true)
            {
                string Query1 = "SELECT * FROM Doadores WHERE RG=@rg OR CPF=@cpf";
                OleDbCommand cm1 = new OleDbCommand(Query1, conexao);
                cm1.Parameters.AddWithValue("@rg", TRG);
                cm1.Parameters.AddWithValue("@cpf", TCPF);
                var possui = cm1.ExecuteScalar();
                if (possui != null)
                {
                    MessageBox.Show("Já existe alguém cadastrado este RG ou CPF", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { 
                 string Query2 = "INSERT INTO Doadores(Nome,RG,CPF,TipoSangue,Endereco,Telefone,Celular,Validado) VALUES(@nome,@rg,@cpf,@ts,@endereco,@telefone,@celular,@validado) ";
                    OleDbCommand cm2 = new OleDbCommand(Query2, conexao);
                    cm2.Parameters.AddWithValue("@nome", TNome);
                    cm2.Parameters.AddWithValue("@rg", TRG);
                    cm2.Parameters.AddWithValue("@cpf", TCPF);
                    cm2.Parameters.AddWithValue("@ts", TTS);
                    cm2.Parameters.AddWithValue("@endereco", TEndereco);
                    cm2.Parameters.AddWithValue("@telefone", TTelefone);
                    cm2.Parameters.AddWithValue("@celular", TCelular);
                    cm2.Parameters.AddWithValue("@validado", TValidado);

                    var result = cm2.ExecuteNonQuery();
                    if (result == 1)
                    {
                     MessageBox.Show("Doador cadastrado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cadastrorealizado = true;
                    }
                    else
                    {
                     MessageBox.Show("Erro no cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
            else
                {
                    MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        #endregion
    }
}
