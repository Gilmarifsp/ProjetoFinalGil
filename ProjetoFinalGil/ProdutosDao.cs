using ProjetoFinalGil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoGil

{
    internal class ProdutosDao
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ProdutosDao()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Produtos usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO produtos VALUES (@nome, @Descricao, @TipoDeItem, @Unidadde, @Preco, @Vendas, @Marcas, @Modelo,@CodigoBalanca  )";

            Cmd.Parameters.AddWithValue("@nome", usuario.NOME);
            Cmd.Parameters.AddWithValue("@Descricao", usuario.DESCRICAO);
            Cmd.Parameters.AddWithValue("@TipoDeItem", usuario.TIPODEITEM);
            Cmd.Parameters.AddWithValue("@Unidadde", usuario.UNIDADE);
            Cmd.Parameters.AddWithValue("@Preco ", usuario.PRECO);
            Cmd.Parameters.AddWithValue("@Vendas ", usuario.VENDAS);
            Cmd.Parameters.AddWithValue("@Marcas ", usuario.MARCA);
            Cmd.Parameters.AddWithValue("@Modelo ", usuario.MODELO);
            Cmd.Parameters.AddWithValue("@CodigoBalanca ", usuario.CODIGODEBALANCA);


            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir clientes no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        
        public void Excluir(int ID)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Delete from Produtos where ID = @id";
            Cmd.Parameters.AddWithValue("@id", ID);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir Produtos no banco.\n");
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Alterar(Produtos Produtos)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Produtos SET Nome = @nome, Preço = @preco, WHERE ID = @id";
            Cmd.Parameters.AddWithValue("@id", Produtos.Id);
            Cmd.Parameters.AddWithValue("@nome", Produtos.NOME);
            Cmd.Parameters.AddWithValue("@preco", Produtos.PRECO);



            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("\"Erro: Problemas ao alterar usuario no banco.\\n\" + err.Message");


            }
            finally
            {
                Con.CloseConnection();
            }
        }


        public List<Produtos> ListarTodosProdutos()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Produtos";

            List<Produtos> listaDeProdutos = new List<Produtos>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produtos Produtos = new Produtos((int)rd["ID"], (string)rd["NOME"], (string)rd["Descricao"], (string)rd["tipodeitem"], (string)rd["unidade"], (Double)rd["preco"], (Double)rd["vendas"], (string)rd["marca"], (string)rd["modelo"], (string)rd["codigodebalanca"]);
                    listaDeProdutos.Add(Produtos);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de Produtos no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeProdutos;
        }

        public List<Produtos> GerarLista(string selecao)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = selecao;

            List<Produtos> listaDeProdutos = new List<Produtos>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produtos Produtos = new Produtos((int)rd["ID"], (string)rd["NOME"], (string)rd["Descricao"], (string)rd["tipodeitem"], (string)rd["unidade"], (Double)rd["preco"], (Double)rd["vendas"], (string)rd["marca"], (string)rd["modelo"], (string)rd["codigodebalanca"]);

                    listaDeProdutos.Add(Produtos);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de Produtos no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeProdutos;
        }

        /*internal void Inserir(Produtos produtos)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Produtos VALUES (@NOME, @PRECO)";

            Cmd.Parameters.AddWithValue("@NOME", produtos.NOME);
            Cmd.Parameters.AddWithValue("@EMAIL", produtos.PRECO);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir Produtos no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }*/
    }
}


