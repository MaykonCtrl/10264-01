using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {

            var pessoa = new Pessoa();
            Console.WriteLine(Attribute.GetCustomAttribute(pessoa.GetType(), typeof(DataBaseAttribute)));

            Console.WriteLine(Attribute.GetCustomAttribute(pessoa.GetType(), typeof(TableAttribute)));

            


            foreach (var item in pessoa.GetType().GetProperties())
	{
        Console.WriteLine(item.GetCustomAttributes(typeof(CampoAttribute), true)[0]);
	}    

            Console.ReadKey();
        }
    }




    [DataBase("ExemploDataBase")]
    [Table("tbPessoa")]
    class Pessoa
    {
        [Campo("Codigo_Pessoa",true,true)]
        public int Codigo { get; set; }
        [Campo("Nome")]
        public string Nome { get; set; }

    }



    class TableAttribute : Attribute
    {
        public TableAttribute(String nome) { Nome = nome; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }

    class DataBaseAttribute : Attribute
    {
        public DataBaseAttribute(String nome) { Nome = nome; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }

    class CampoAttribute : Attribute
    {
        
        public string Nome { get; set; }
        public bool PK { get; set; }
        public bool Identity { get; set; }

        public CampoAttribute(String nome ,bool pk = false,bool identity = false)  
        { 
            Nome = nome;
            PK = pk;
            Identity = identity;
        }
        
        public override string ToString()
        {
            return string.Format("Nome: {0}, PK: {1},Identity: {2}", Nome, PK, Identity);
        }
    }



}
