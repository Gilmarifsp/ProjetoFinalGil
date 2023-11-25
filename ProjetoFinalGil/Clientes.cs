using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoFinalGil
{
    internal class Clientes
    {
        private int _id;
        private string _Nome;
        private string _Email;
        private string _Telefone;
        private string _Endereco;
        private int _Numero;
        private string _CIDADE;
        private string _UF;
        private string _Sexo;


        public Clientes(string nome, string email, string telefone, string endereco, int numero,string cidade, string uf, string sexo)
        {

            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Numero = numero;
            Cidade = cidade;
            UF = uf; 
            Sexo = sexo;






        }
        public Clientes(int id, string nome, string email, string telefone, string endereco, int numero, string cidade, string uf, string sexo)
        {
            _id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Numero = numero;
            Cidade = cidade;
            UF = uf;
            Sexo = sexo;

        }

        public int Id
        {
            get { return _id; }

        }
        public string Nome
        {
            get { return _Nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o nome informado não é um texto valido");
                _Nome = value;
            }
        }


        public string Email
        {
            get { return _Email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o email informado não é um texto valido");
                _Email = value;
            }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o telefone informado não é um texto valido");
                _Telefone = value;
            }



        }

        public string Endereco
        {
            get { return _Endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o endereço informado não é um texto valido--- O texto vem daqui");
                _Endereco = value;
            }
        }

        public int Numero
        {
            get { return _Numero; }
            set
            {
                _Numero = value;
            }
        }

        public string Cidade
        {
            get { return _CIDADE; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("a cidade informado não é uma cidade valido--- a cidade vem daqui");
                _CIDADE = value;
            }
        }

        public string UF
        {
            get { return _UF; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o estado informado não é um texto valido--- O estado vem daqui");
                _UF = value;
            }
        }


        public string Sexo
        {
            get { return _Sexo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o sexo informado é invalido");
                _Sexo = value;
            }
        }


    }
}