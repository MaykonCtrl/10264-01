using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace _001_TresCamadas_DTO
{
    class Program
    {
        static void Main()
        {
            foreach (var pessoa in BLL.Pessoa.Selecionar())
            {
                Console.WriteLine("{0} -> {1} - {2}", pessoa.Codigo, pessoa.Nome, pessoa.Sexo);
            }

            Console.WriteLine();

            foreach (var pessoa in BLL.Pessoa.Selecionar(new Pessoa(1)))
            {
                Console.WriteLine("{0} -> {1} - {2}", pessoa.Codigo, pessoa.Nome, pessoa.Sexo);
            }

            Console.ReadKey();
        }
    }
}

namespace Model
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public char Sexo { get; set; }

        public Pessoa(int codigo = 0, string nome = null, char sexo = (char)0)
        {
            Codigo = codigo;
            Nome = nome;
            Sexo = sexo;
        }
    }
}

namespace DAL
{
    public class Pessoa
    {
        public static void Inserir(Model.Pessoa obj) { /*implementar sua lógica aqui*/ }
        public static void Alterar(Model.Pessoa obj) { /*implementar sua lógica aqui*/ }
        public static void Excluir(Model.Pessoa obj) { /*implementar sua lógica aqui*/ }

        public static IEnumerable<Model.Pessoa> Selecionar(Model.Pessoa obj = null)
        {
            var retorno = Dados.Pessoa.Obter();

            if (obj != null)
                retorno = retorno.Where(p => p.Codigo == obj.Codigo);

            return retorno;
        }
    }
}

namespace BLL
{
    public class Pessoa
    {
        public static void Inserir(Model.Pessoa obj) { /*implementar sua lógica aqui*/ }
        public static void Alterar(Model.Pessoa obj) { /*implementar sua lógica aqui*/ }
        public static void Excluir(Model.Pessoa obj) { /*implementar sua lógica aqui*/ }

        public static IEnumerable<Model.Pessoa> Selecionar(Model.Pessoa obj = null)
        {
            return DAL.Pessoa.Selecionar(obj);
        }
    }
}

namespace Dados
{
    public class Pessoa
    {
        public static IEnumerable<Model.Pessoa> Obter()
        {
            yield return new Model.Pessoa(1, "ADÃO", 'M');
            yield return new Model.Pessoa(2, "EVA", 'F');
            yield return new Model.Pessoa(3, "CAIM", 'M');
            yield return new Model.Pessoa(4, "ABEL", 'M');
        }
    }
}