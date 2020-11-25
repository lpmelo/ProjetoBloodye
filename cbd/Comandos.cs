using System;
using System.Collections.Generic;
using System.Data;
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
        public bool edicaorealizada = false;
        #region Logar
        public void Logar(string TLogin, string TSenha, OleDbConnection conexao)
        {
            if (conectado == true)
            {
                string Query = "SELECT * FROM Adms WHERE Login='" + TLogin + "' AND Senha='" + TSenha + "';";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                var result = cm.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Logado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void Procurar(string TProcura, string index, OleDbConnection conexao,DataGridView tabela)
        {
            if (conectado == true)
            {
                string Query = "SELECT * FROM Doadores WHERE " + index + " LIKE '%" + TProcura + "%';";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                cm.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                DataTable Doadores = new DataTable();
                da.Fill(Doadores);
                tabela.DataSource = Doadores;
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
                string Query1 = "SELECT * FROM Doadores WHERE Codigo=" + idlnSelecionada + " AND Validado=@value;";
                OleDbCommand cm1 = new OleDbCommand(Query1, conexao);
                cm1.Parameters.AddWithValue("@value", true);
                var possui = cm1.ExecuteScalar();
                if (possui != null)
                {
                    var pergunta = MessageBox.Show("O doador já está validado!\nDeseja remover seu validamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (pergunta == DialogResult.Yes)
                    {
                        string Query3 = "UPDATE Doadores SET Validado=@value WHERE Codigo=" + idlnSelecionada + ";";
                        OleDbCommand cm3 = new OleDbCommand(Query3, conexao);
                        cm3.Parameters.AddWithValue("@value", false);
                        var cancelado = cm3.ExecuteNonQuery();
                        if (cancelado == 1)
                        {
                            MessageBox.Show("Validamento cancelado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    string Query2 = "UPDATE Doadores SET Validado=@value WHERE Codigo=" + idlnSelecionada + ";";
                    OleDbCommand cm2 = new OleDbCommand(Query2, conexao);
                    cm2.Parameters.AddWithValue("@value", true);
                    var validado = cm2.ExecuteNonQuery();
                    if (validado == 1)
                    {
                        MessageBox.Show("Doador validado com sucesso!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro na validação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion Validar
        #region Adicionar
        public void Adicionar(OleDbConnection conexao, string TNome, string TRG, string TCPF, string TTS, string TEndereco, string TTelefone, string TCelular, bool TValidado,int THemocentro)
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
                    MessageBox.Show("Já existe alguém cadastrado este RG ou CPF", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Query2 = "INSERT INTO Doadores(Nome,RG,CPF,TipoSangue,Endereco,Telefone,Celular,Validado,HemocentroCadastrado) VALUES(@nome,@rg,@cpf,@ts,@endereco,@telefone,@celular,@validado,@hemocentro) ";
                    OleDbCommand cm2 = new OleDbCommand(Query2, conexao);
                    cm2.Parameters.AddWithValue("@nome", TNome);
                    cm2.Parameters.AddWithValue("@rg", TRG);
                    cm2.Parameters.AddWithValue("@cpf", TCPF);
                    cm2.Parameters.AddWithValue("@ts", TTS);
                    cm2.Parameters.AddWithValue("@endereco", TEndereco);
                    cm2.Parameters.AddWithValue("@telefone", TTelefone);
                    cm2.Parameters.AddWithValue("@celular", TCelular);
                    cm2.Parameters.AddWithValue("@validado", TValidado);
                    cm2.Parameters.AddWithValue("@hemocentro", THemocentro);

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
        #region Editar
        public void Editar(string idlnSelecionada, string TNome, string TRG, string TCPF, string TTS, string TEndereco, string TTelefone, string TCelular, bool TValidado, int THemocentro, OleDbConnection conexao)
        {
            if (conectado == true)
            {
                string Query = "UPDATE Doadores SET Nome=@nome,RG=@rg,CPF=@cpf,TipoSangue=@ts,Endereco=@endereco,Telefone=@telefone,Celular=@celular,Validado=@validado,HemocentroCadastrado=@hemocentro WHERE Codigo=" + idlnSelecionada + ";";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                cm.Parameters.AddWithValue("@nome", TNome);
                cm.Parameters.AddWithValue("@rg", TRG);
                cm.Parameters.AddWithValue("@cpf", TCPF);
                cm.Parameters.AddWithValue("@ts", TTS);
                cm.Parameters.AddWithValue("@endereco", TEndereco);
                cm.Parameters.AddWithValue("@telefone", TTelefone);
                cm.Parameters.AddWithValue("@celular", TCelular);
                cm.Parameters.AddWithValue("@validado", TValidado);
                cm.Parameters.AddWithValue("@hemocentro", THemocentro);
                var result = cm.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    edicaorealizada = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar os dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Excluir
        public void Excluir(OleDbConnection conexao, string idSelecionado)
        {
            string Query = "DELETE * FROM Doadores WHERE Codigo=@id;";
            OleDbCommand cm = new OleDbCommand(Query, conexao);
            cm.Parameters.AddWithValue("@id", idSelecionado);
            var excluido = cm.ExecuteNonQuery();
            if (excluido == 1)
            {
                MessageBox.Show("O registro do doador foi deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível deletar o registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region ProcurarContato 
        public void ProcurarContato(string TProcura, string index, OleDbConnection conexao, DataGridView tabela)
        {
            if (conectado == true)
            {
                string Query = "SELECT Nome,CPF,TipoSangue,Telefone, Celular FROM Doadores WHERE " + index + " LIKE '%" + TProcura + "%';";
                OleDbCommand cm = new OleDbCommand(Query, conexao);
                cm.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                DataTable Doadores = new DataTable();
                da.Fill(Doadores);
                tabela.DataSource = Doadores;
            }
            else
            {
                MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
