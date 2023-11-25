using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoFinalGil
{
    internal class Produtos
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private string _tipodeitem;
        private string _unidade;
        private string _marca;
        private string _modelo;
        private string _codigodebalanca;
        private Double _preco;
        private Double _vendas;

        public Produtos(string nome, string Descricao, string tipodeitem, string unidade, Double preco,Double vendas, string marca, string modelo, string codigodebalanca)
        {

            NOME = nome;
            DESCRICAO = Descricao;
            TIPODEITEM = tipodeitem;
            UNIDADE = unidade;
            PRECO = preco;
            VENDAS = vendas;
            MARCA = marca;
            MODELO = modelo;
            CODIGODEBALANCA = codigodebalanca;
        }
        public Produtos(int id, string nome, string Descricao,string tipodeitem,string unidade, Double preco, Double vendas, string marca, string modelo, string codigodebalanca)
        {
            _id = id;
            NOME = nome;
            DESCRICAO = Descricao;
            TIPODEITEM = tipodeitem;
            UNIDADE = unidade;
            PRECO = preco;
            VENDAS = vendas;
            MARCA = marca;
            MODELO = modelo;
            CODIGODEBALANCA = codigodebalanca;
        }
        public int Id
        {
            get { return _id; }

        }
        public string NOME
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o nome informado não é um texto valido");
                _nome = value;
            }
        }

        public string DESCRICAO
        {
            get { return _descricao; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o descrição informado não é um texto valido");
                _descricao = value;
            }
        }

        public string TIPODEITEM
        {
            get { return _tipodeitem; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o tipo de item informado não é um texto valido");
                _tipodeitem = value;
            }
        }

        public string UNIDADE
        {
            get { return _unidade; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("a unidade informado não é um texto valido");
                _unidade = value;
            }
        }

        public string MARCA
        {
            get { return _marca; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("a marca informado não é um texto valido");
                _marca = value;
            }
        }

        public string MODELO
        {
            get { return _modelo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o modelo informado não é um texto valido");
                _modelo = value;
            }
        }

        public string CODIGODEBALANCA
        {
            get { return _codigodebalanca; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o codigo de balança informado não é um texto valido");
                _codigodebalanca = value;
            }
        }

        public Double VENDAS
        {
            get { return _vendas; }
            set
            {
                if (value<0)
                    throw new Exception("o valor da vendas é invalido");
                _vendas = value;
            }
        }
        public Double PRECO
        {
            get { return _preco; }
            set
            {
                if (value < 0)
                    throw new Exception("valor invalido");
                _preco = value;
            }

        }
    }
}
