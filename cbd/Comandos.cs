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

        public void Procurar(string TProcura, OleDbConnection conexao)
        {
            /*if (conectado == true)
            {
                string Query = "SELECT * FROM Adms WHERE Tipo='" + TLogin + "' AND Senha='" + TSenha + "';";
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
            }*/
        }
    }
}
