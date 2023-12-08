using ProjetoGil;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalGil
{
    class ProprietarioDao
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ProprietarioDao()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Excluir(int ID)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Delete from PROPRIETARIO where ID = @id";
            Cmd.Parameters.AddWithValue("@id", ID);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir Proprietario no banco.\n");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Alterar(Clientes usuarios)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE PROPRIETARIO SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone, ENDERECO = @endereco, 
            SEXO = @sexo, CIDADE = @cidade, UF = @uf WHERE ID = @id";
            Cmd.Parameters.AddWithValue("@id", usuarios.Id);
            Cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
            Cmd.Parameters.AddWithValue("@sexo", usuarios.Sexo);
            //Cmd.Parameters.AddWithValue("@cpf", usuarios.CPF);
            Cmd.Parameters.AddWithValue("@email", usuarios.Email);
            Cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);
            Cmd.Parameters.AddWithValue("@endereco", usuarios.Endereco);


            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Proprietario> ListarTodosUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM PROPRIETARIO";

            List<Proprietario> listaDeUsuarios = new List<Proprietario>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Proprietario usuario = new Proprietario((int)rd["ID"], (string)rd["NOME"],
                        (string)rd["SEXO"], (string)rd["CPF"], (string)rd["EMAIL"], (string)rd["TELEFONE"], (string)rd["ENDERECO"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }
        public void Inserir(Proprietario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO PROPRIETARIO VALUES (@nome, @sexo, @cpf, @email, @telefone, @endereco)";

            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@sexo", usuario.SEXO);
            Cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
            Cmd.Parameters.AddWithValue("@email", usuario.EMAIL);
            Cmd.Parameters.AddWithValue("@telefone", usuario.TELEFONE);
            Cmd.Parameters.AddWithValue("@endereco", usuario.ENDERECO);


            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir Proprietario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }




        }
    }
}
